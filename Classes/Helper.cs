using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentistry_clinic.Classes
{
    /// <summary>
    /// Глобальные величины проекта
    /// </summary>
    public class Helper
    {
        //Строка подключения к БД
        public static string conString = "Server=localhost;database=Midnight_Queen_DB;user=sa;password=Kr0svoun;MultipleActiveResultSets=True";

        public static string login;
        public static int role;

        /// <summary>
        /// Функция для создания подключения
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(conString);
        }

        /// <summary>
        /// Функция для открытия подключения
        /// </summary>
        /// <param name="connection"></param>
        public static void OpenCon(SqlConnection connection)
        {
            //Проверка корректного подключения
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    //MessageBox.Show("Подключение открыто", "Подключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "Подключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Функция для закрытия подключения
        /// </summary>
        /// <param name="connection"></param>
        public static void CloseCon(SqlConnection connection)
        {
            //Проверка состояния подключения
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
                //MessageBox.Show("Отключение от БД успешно", "Отключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Функция для сравнения введённых данных с данными в таблице
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool VerifyPassword(string login, string password)
        {
            using (var connection = GetConnection())
            {
                OpenCon(connection);
                string query = $"SELECT dbo.Check_User_Password('{login}', '{password}') as IsValid;";
                using (var com = new SqlCommand(query, connection))
                {
                    using (var reader = com.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool res = reader.GetBoolean(0);
                            CloseCon(connection);
                            return res;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Функция, открывающая окно навигации
        /// </summary>
        /// <param name="form"></param>
        public static void OpenNavWindow(Form form)
        {
            FormNavigation NavForm = new FormNavigation();
            form.Hide();
            NavForm.Show();
        }

        /// <summary>
        /// Загрузка значений в список
        /// </summary>
        public static void Load_comboBox(ComboBox comb, string query, string field)
        {
            comb.Items.Clear();
            using (var connection = Helper.GetConnection())
            {
                Helper.OpenCon(connection);

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                comb.Items.Add((string)reader[field]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No rows found.");
                        }
                        reader.Close();
                    }
                }
                Helper.CloseCon(connection);
            }
        }

        /// <summary>
        /// Загрузка значений в список с 1 зависимостью
        /// </summary>
        public static void Load_comboBoxOneDepend(ComboBox comb, string query, string field, ComboBox combDep, string param)
        {
            comb.Items.Clear();

            string el="";

            if (!(combDep.SelectedItem is null))
            {
                el = combDep.SelectedItem.ToString();
            }

            using (var connection = Helper.GetConnection())
            {
                Helper.OpenCon(connection);

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Параметры для защиты от SQL-инъекций
                    command.Parameters.AddWithValue(param, el);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                comb.Items.Add((string)reader[field]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No rows found.");
                        }
                        reader.Close();
                    }
                }
                Helper.CloseCon(connection);
            }
        }

        /// <summary>
        /// Загрузка значений в список с 2 зависимостями
        /// </summary>
        public static void Load_comboBoxTwoDepend(ComboBox comb, string query, string field, ComboBox combFirstDep, string firstParam, ComboBox combSecondDep, string secondParam)
        {
            comb.Items.Clear();

            string fEl = "";
            string sEl = "";

            if (!(combFirstDep.SelectedItem is null))
            {
                fEl = combFirstDep.SelectedItem.ToString();
            }
            if (!(combSecondDep.SelectedItem is null))
            {
                sEl = combSecondDep.SelectedItem.ToString();
            }

            using (var connection = Helper.GetConnection())
            {
                Helper.OpenCon(connection);

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Параметры для защиты от SQL-инъекций
                    command.Parameters.AddWithValue(firstParam, fEl);
                    command.Parameters.AddWithValue(secondParam, sEl);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                comb.Items.Add((string)reader[field]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No rows found.");
                        }
                        reader.Close();
                    }
                }
                Helper.CloseCon(connection);
            }
        }

        ///string sql = "select ..."
        ///sqldataadapter ad=new sqldataadapter(sql, helper.connection);
        ///datatable dt = new datatable();
        ///ad.fill(dt);
        ///datarow client =dt.newrow();
        ///client["fullanme"]=textbox.text;
        ///dt.rows.add(client);
        ///sqlcommandbuilder commandBuilder=new sqlcommandbuiledr
        ///commandBuilder.dataadapter=ad;
        ///ad.update(dt);
    }
}
