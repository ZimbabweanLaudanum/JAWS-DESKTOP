using Dentistry_clinic.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentistry_clinic
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        private int tryCount = 3;

        /// <summary>
        /// Закрытие текущего окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Проведение авторизации пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            try
            {
                string login = textBoxLogin.Text;
                string Password = textBoxPassword.Text;

                if (Helper.VerifyPassword(login, Password) is false && tryCount > 0)
                {
                    tryCount -= 1;
                    MessageBox.Show($"Неправильно введён логин или пароль. Осталось попыток: {tryCount}. Повторите попытку.");
                    return;
                }
                else if (tryCount == 0)
                {
                    using (var connection = Helper.GetConnection())
                    {
                        Helper.OpenCon(connection);

                        string query = "update User_tab set Is_blocked=1 where User_email=@login;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Параметры для защиты от SQL-инъекций
                            command.Parameters.AddWithValue("@login", login);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Аккаунт заблокирован. Обратитесь к администратору для разблокировки.");
                    return;
                }

                // Отдельное соединение для получения данных пользователя
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = "SELECT User_fullname, Role_title_id, Is_blocked FROM User_tab where User_email=@login;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@login", login);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader.GetString(0);
                                int role = reader.GetInt32(1);
                                Helper.login = login;
                                Helper.role = role;
                                bool Is_blocked=reader.GetBoolean(2);
                                if (Is_blocked is true)
                                {
                                    MessageBox.Show("Аккаунт заблокирован. Обратитесь к администратору для разблокировки.");
                                    return;
                                }
                                MessageBox.Show("Добро пожаловать! " + name);
                                OpenWindow(role);
                            }
                        }
                    }
                    Helper.CloseCon(connection);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg);
            }
        }

        /// <summary>
        /// Функция, открывающая окно навигации
        /// </summary>
        /// <param name="role"></param>
        private void OpenWindow(int role)
        {
            FormNavigation NavForm = new FormNavigation();
            this.Hide();
            NavForm.Show();
        }
    }
}
