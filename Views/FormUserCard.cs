using Dentistry_clinic.Classes;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentistry_clinic
{
    public partial class FormUserCard : Form
    {
        /// <summary>
        /// Режим работы окна. Всего их 3: 
        /// 1 - Просмотр карты пользователя
        /// 2 - Редактирование пользователя
        /// 3 - Создание нового пользователя (регистрация)
        /// </summary>
        int mode, userId, newRoleId, newSpecId, newClinicId;
        string login, newLogin, newFullname, newPhone, newRole, newSpec, newClinic;
        SqlDateTime? newDate;
        string query;
        public static string password;

        /// <summary>
        /// Добавление в запрос обновления нового логина пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            newLogin = textBoxLogin.Text;
            //MessageBox.Show(newLogin);
        }

        /// <summary>
        /// Добавление в запрос обновления нового ФИО
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFullname_TextChanged(object sender, EventArgs e)
        {
            newFullname = textBoxFullname.Text;
            //MessageBox.Show(newFullname);
        }

        /// <summary>
        /// Добавление в запрос обновления нового номера телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            newPhone = textBoxPhone.Text;
            //MessageBox.Show(newPhone);
        }

        /// <summary>
        /// Добавление в запрос обновления новой даты рождения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimeBirth_ValueChanged(object sender, EventArgs e)
        {
            dateTimeBirth.Format = DateTimePickerFormat.Short;
            newDate = dateTimeBirth.Value;
            //MessageBox.Show(newDate.ToString());
        }

        /// <summary>
        /// Добавление в запрос обновления номера роли пользователя на основе выбранной в списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            newRole = comboBoxRole.Text;
            using (var connection = Helper.GetConnection())
            {
                Helper.OpenCon(connection);

                string queryL = "SELECT Role_title_id FROM Role_tab where Role_title = " + "N'" + newRole + "'" + ";";
                using (SqlCommand command = new SqlCommand(queryL, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                newRoleId = (Int32)reader["Role_title_id"];
                                ChangeRole(newRoleId);
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
            MessageBox.Show(newRole);
        }

        /// <summary>
        /// Добавление в запрос обновления номера специализации на основе выбранной в списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSpec = comboBoxSpecialization.Text;
            using (var connection = Helper.GetConnection())
            {
                Helper.OpenCon(connection);

                string queryL = "SELECT Specialization_id FROM Specialization where Specialization_name= N'" + newSpec + "';";
                using (SqlCommand command = new SqlCommand(queryL, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                newSpecId = (Int32)reader["Specialization_id"];
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
            //MessageBox.Show(newSpec);
        }

        private void comboBoxSpecialization_DropDown(object sender, EventArgs e)
        {
            this.comboBoxSpecialization.Items.Clear();
            using (var connection = Helper.GetConnection())
            {
                Helper.OpenCon(connection);

                string query = "SELECT Specialization_name FROM Specialization;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string spec = (string)reader["Specialization_name"];
                                this.comboBoxSpecialization.Items.Add(spec);
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

        private void comboBoxClinic_DropDown(object sender, EventArgs e)
        {
            this.comboBoxClinic.Items.Clear();
            using (var connection = Helper.GetConnection())
            {
                Helper.OpenCon(connection);

                string query = "SELECT Clinic_Address FROM Clinic;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string clinic = (string)reader["Clinic_Address"];
                                this.comboBoxClinic.Items.Add(clinic);
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
        /// Открытие окна управления паролем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            FormManagePassword PasswordForm = new FormManagePassword(mode);
            PasswordForm.Show();
        }

        /// <summary>
        /// Добавление в запрос обновления номера клиники на основе выбранного адреса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxClinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            newClinic = comboBoxClinic.Text;
            using (var connection = Helper.GetConnection())
            {
                Helper.OpenCon(connection);

                string queryL = "SELECT Clinic_id FROM Clinic where Clinic_Address = N'" + newClinic + "';";
                using (SqlCommand command = new SqlCommand(queryL, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                newClinicId = (Int32)reader["Clinic_id"];
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
            //MessageBox.Show(newClinic);
        }

        /// <summary>
        /// Загрузка названий ролей в системе в список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxRole_DropDown(object sender, EventArgs e)
        {
            this.comboBoxRole.Items.Clear();
            using (var connection = Helper.GetConnection())
            {
                Helper.OpenCon(connection);

                string query = "SELECT Role_title FROM Role_tab;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string role = (string)reader["Role_title"];
                                this.comboBoxRole.Items.Add(role);
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

        public FormUserCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор с передаваемыми режимом и логином пользователя
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="login"></param>
        public FormUserCard(int mode, string login = "")
        {
            InitializeComponent();
            this.mode = mode;
            this.login = login;
        }

        /// <summary>
        /// Загрузка формы в соответствующем режиме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimeBirth.Format = DateTimePickerFormat.Custom;
            dateTimeBirth.CustomFormat = " ";

            switch (mode)
            {
                case 1:
                    labelWindow.Text = "Просмотр пользователя";
                    textBoxLogin.ReadOnly = true;
                    buttonChangePassword.Enabled = false;
                    buttonAct.Enabled = false;
                    textBoxFullname.ReadOnly = true;
                    textBoxPhone.ReadOnly = true;
                    dateTimeBirth.Enabled = false;
                    comboBoxRole.Enabled = false;
                    comboBoxSpecialization.Enabled = false;
                    comboBoxClinic.Enabled = false;
                    UpdateData();
                    break;
                case 2:
                    labelWindow.Text = "Редактирование пользователя";
                    buttonAct.Text = "Обновить";
                    query = @"EXEC Update_User ";
                    UpdateData();
                    break;
                case 3:
                    labelWindow.Text = "Регистрация пользователя";
                    buttonAct.Text = "Добавить";
                    buttonChangePassword.Text = "Создать пароль";
                    query = "EXEC Insert_User ";
                    break;
            }
        }

        /// <summary>
        /// Функция для отображения данных пользователя
        /// </summary>
        private void UpdateData()
        {
            tableLayoutSpecialization.Visible = false;
            tableLayoutClinic.Visible = false;
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = $"SELECT u.User_id, u.User_email, u.User_password, u.User_fullname, u.User_Phone, u.User_birth_date, u.Role_title_id, r.Role_title, s.Specialization_name, c.Clinic_Address " +
                        $"from User_tab u " +
                        $"LEFT JOIN Role_tab r on u.Role_title_id = r.Role_title_id "+
                        $"LEFT JOIN Specialization s on u.Specialization_id = s.Specialization_id " +
                        $"LEFT JOIN Clinic c on u.Clinic_id = c.Clinic_id " +
                        $"where u.User_email = @login;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    userId = (int)reader["User_id"];
                                    textBoxLogin.Text = (string)reader["User_email"];
                                    textBoxFullname.Text = (string)reader["User_fullname"];
                                    if (!(reader["User_Phone"] is DBNull))
                                    {
                                        textBoxPhone.Text = (string)reader["User_Phone"];
                                    }
                                    if (!(reader["User_birth_date"] is DBNull))
                                    {
                                        dateTimeBirth.Format = DateTimePickerFormat.Short;
                                        dateTimeBirth.Value = (DateTime)reader["User_birth_date"];
                                    }
                                    comboBoxRole.Text = (string)reader["Role_title"];
                                    int role = (Int32)reader["Role_title_id"];
                                    ChangeRole(role);

                                    if (!(reader["Specialization_name"] is DBNull))
                                    {
                                        comboBoxSpecialization.Text = (string)reader["Specialization_name"];
                                    }
                                    if (!(reader["Clinic_Address"] is DBNull))
                                    {
                                        comboBoxClinic.Text = (string)reader["Clinic_Address"];
                                    }
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
        }

        /// <summary>
        /// Закрытие текущего окна
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
        /// Функция, для отображение полей в соответствии с выбранной ролью
        /// </summary>
        /// <param name="role"></param>
        private void ChangeRole(int role)
        {
            switch (role)
            {
                case 1:
                    tableLayoutClinic.Visible = true;
                    tableLayoutSpecialization.Visible = true;
                    break;
                case 2:
                    tableLayoutClinic.Visible = true;
                    tableLayoutSpecialization.Visible = false;
                    break;
                case 3:
                    tableLayoutClinic.Visible = true;
                    tableLayoutSpecialization.Visible = false;
                    break;
                case 4:
                    tableLayoutClinic.Visible = false;
                    tableLayoutSpecialization.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Обновление или добавление пользователя в систему
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAct_Click(object sender, EventArgs e)
        {
            if (newFullname != "") query += "@User_fullname = N'" + newFullname + "', ";
            if (newPhone!="") query+= "@User_Phone = '" + newPhone + "', ";
            if(!(newDate is null)) query+= "@User_birth_date = @newDate, ";
            if (newRoleId !=0) query += "@Role_title_id = " + newRoleId + ", ";
            if (newSpecId !=0) query += "@Specialization_id = " + newSpecId + ", ";
            if(newClinicId !=0) query+= "@Clinic_id = " + newClinicId + ", ";
            if (!(password is null)) query+="@InputPassword = N'" + password + "', ";
            query += "@Login = N'" + newLogin + "';";

            switch (mode)
            {
                case 2:
                    query = query.Insert(query.IndexOf(";"), ", @User_id = " + userId);
                    try
                    {
                        using (var connection = Helper.GetConnection())
                        {
                            Helper.OpenCon(connection);

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                if (!(newDate is null)) command.Parameters.AddWithValue("@newDate", newDate);
                                MessageBox.Show(query);
                                command.ExecuteNonQuery();
                            }
                            Helper.CloseCon(connection);
                            MessageBox.Show("Изменения внесены успешно");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        using (var connection = Helper.GetConnection())
                        {
                            Helper.OpenCon(connection);

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                if (!(newDate is null)) command.Parameters.AddWithValue("@newDate", newDate);
                                MessageBox.Show(query);
                                command.ExecuteNonQuery();
                            }
                            Helper.CloseCon(connection);
                            MessageBox.Show("Аккаунт успешно создан");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
    }
}