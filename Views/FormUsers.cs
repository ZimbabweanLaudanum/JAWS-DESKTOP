using Dentistry_clinic;
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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        bool blocked;

        /// <summary>
        /// При загрузке формы делается запрос в базу для заполнения таблицы в окне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            updateWindow();
        }

        /// <summary>
        /// Возвращение к окну навигации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavButton_Click(object sender, EventArgs e)
        {
            FormNavigation NavForm = new FormNavigation();
            this.Hide();
            NavForm.Show();
        }

        /// <summary>
        /// Двойной клик по строке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Индексы кликнутой ячейки
            int row = (int)e.RowIndex;
            int col = (int)e.ColumnIndex;

            //Клик по кнопке меняет значение в столбце блокировки в БД
            if ((string)dataGridViewUsers.Rows[row].Cells[3].Value == "Разблокировать")
            {
                blocked = true;
            }
            else if ((string)dataGridViewUsers.Rows[row].Cells[3].Value == "Заблокировать")
            {
                blocked = false;
            }
            else
            {
                return;
            }

            if (col == 3)
            {
                try
                {
                    using (var connection = Helper.GetConnection())
                    {
                        Helper.OpenCon(connection);

                        string query = @"Update User_tab set Is_blocked = @block where User_email=@login;";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@login", (string)dataGridViewUsers.CurrentRow.Cells[1].Value);
                            command.Parameters.AddWithValue("@block", !blocked);
                            command.ExecuteNonQuery();
                        }
                        Helper.CloseCon(connection);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                updateWindow();
            }
            else
            {
                FormUserCard UserForm = new FormUserCard(1, (string)dataGridViewUsers.Rows[row].Cells[1].Value);
                this.Hide();
                UserForm.Show();
            }
        }

        /// <summary>
        /// Функция для обновления таблицы
        /// </summary>
        private void updateWindow()
        {
            dataGridViewUsers.Rows.Clear();

            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = $"SELECT User_id, User_email, User_fullname, Is_blocked from User_tab;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                int row = 0;
                                while (reader.Read())
                                {
                                    int id = (Int32)reader["User_id"];
                                    string login = (string)reader["User_email"];
                                    string name = (string)reader["User_fullname"];

                                    dataGridViewUsers.Rows.Add(id, login, name);
                                    if ((bool)reader["Is_blocked"] == true)
                                    {
                                        dataGridViewUsers.Rows[row].Cells[3].Value = "Разблокировать";
                                    }
                                    else if ((bool)reader["Is_blocked"] == false)
                                    {
                                        dataGridViewUsers.Rows[row].Cells[3].Value = "Заблокировать";
                                    }
                                    //name=name.Split(,'.');
                                    row++;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int c = dataGridViewUsers.RowCount;
            labelNum.Text = c.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int row = dataGridViewUsers.CurrentRow.Index;
            FormUserCard UserForm = new FormUserCard(2, (string)dataGridViewUsers.Rows[row].Cells[1].Value);
            this.Hide();
            UserForm.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormUserCard UserForm = new FormUserCard(3);
            this.Hide();
            UserForm.Show();
        }
    }
}
