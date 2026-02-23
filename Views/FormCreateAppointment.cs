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
    public partial class FormCreateAppointment : Form
    {
        public FormCreateAppointment()
        {
            InitializeComponent();
            comboBoxFullname.KeyPress += (sender, e) => e.Handled = true;
            comboBoxDoctor.KeyPress += (sender, e) => e.Handled = true;
            comboBoxService.KeyPress += (sender, e) => e.Handled = true;
            comboBoxAddress.KeyPress += (sender, e) => e.Handled = true;
        }

        /// <summary>
        /// Функция загрузки окна с автоматическим заполнением поле ФИО и номер телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            switch (Helper.role)
            {
                case 4:
                    try
                    {
                        using (var connection = Helper.GetConnection())
                        {
                            Helper.OpenCon(connection);

                            string query = $"SELECT User_fullname, User_Phone from User_tab WHERE User_email = @login;";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Параметры для защиты от SQL-инъекций
                                command.Parameters.AddWithValue("@login", Helper.login);
                                using (var reader = command.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        while (reader.Read())
                                        {
                                            string client = (string)reader["User_fullname"];
                                            string phone = (string)reader["User_Phone"];
                                            comboBoxFullname.Text = client;
                                            textBoxPhone.Text = phone;
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
                    break;
            }
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
        /// Функция для помещения в combobox данных из таблицы Service при открытии элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxService_OnDropDown(object sender, EventArgs e)
        {
            this.comboBoxService.Items.Clear();
            string add = "";
            string doc = "";

            if (comboBoxAddress.Text != "")
            {
                add = comboBoxAddress.Text;
            }
            if (comboBoxDoctor.Text != "")
            {
                doc = comboBoxDoctor.Text;
            }
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = "SELECT DISTINCT s.Service_name FROM Service s LEFT JOIN Arrange_Doctor_Services ads ON s.Service_id = ads.Service_id LEFT JOIN User_tab doctor ON ads.Doctor_id = doctor.User_id LEFT JOIN Arrange_Clinic_Services acs ON s.Service_id = acs.Service_id LEFT JOIN Clinic c ON acs.Clinic_id = c.Clinic_id WHERE (doctor.User_fullname = @DoctorFullname OR @DoctorFullname IS NULL OR @DoctorFullname = '') AND (c.Clinic_Address = @ClinicAddress OR @ClinicAddress IS NULL OR @ClinicAddress = '')AND ((@DoctorFullname IS NULL AND @ClinicAddress IS NULL) OR (@DoctorFullname IS NOT NULL AND doctor.User_id IS NOT NULL) OR (@ClinicAddress IS NOT NULL AND c.Clinic_id IS NOT NULL) OR (@DoctorFullname IS NOT NULL AND @ClinicAddress IS NOT NULL AND doctor.User_id IS NOT NULL AND c.Clinic_id IS NOT NULL));";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@DoctorFullname", doc);
                        command.Parameters.AddWithValue("@ClinicAddress", add);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string serv = (string)reader["Service_name"];
                                    this.comboBoxService.Items.Add(serv);
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
        /// Функция для помещения в combobox данных врачей из таблицы User_tab при открытии элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDoctor_OnDropDown(Object sender, EventArgs e)
        {
            this.comboBoxDoctor.Items.Clear();
            string add = "";
            string ser = "";

            if (comboBoxAddress.Text != "")
            {
                add = comboBoxAddress.Text;
            }
            if (comboBoxService.Text != "")
            {
                ser = comboBoxService.Text;
            }
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = "SELECT DISTINCT doctor.User_fullname FROM User_tab doctor LEFT JOIN Arrange_Doctor_Services ads ON doctor.User_id=ads.Doctor_id LEFT JOIN Service s ON ads.Service_id=s.Service_id LEFT JOIN Clinic c ON doctor.Clinic_id = c.Clinic_id LEFT JOIN Arrange_Clinic_Services acs ON c.Clinic_id = acs.Clinic_id WHERE ((s.Service_name = @ServiceName OR @ServiceName IS NULL OR @ServiceName = '') AND (c.Clinic_Address = @ClinicAddress OR @ClinicAddress IS NULL OR @ClinicAddress = '') AND ((@ServiceName IS NULL AND @ClinicAddress IS NULL) OR (@ServiceName IS NOT NULL AND s.Service_id IS NOT NULL) OR (@ClinicAddress IS NOT NULL AND c.Clinic_id IS NOT NULL) OR (@ServiceName IS NOT NULL AND @ClinicAddress IS NOT NULL AND s.Service_id IS NOT NULL AND c.Clinic_id IS NOT NULL))) and (doctor.Role_title_id=1);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@ServiceName", ser);
                        command.Parameters.AddWithValue("@ClinicAddress", add);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string doc = (string)reader["User_fullname"];
                                    this.comboBoxDoctor.Items.Add(doc);
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
        /// Функция для помещения в combobox данных клиентов из таблицы User_tab при открытии элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFullname_OnDropDown(Object sender, EventArgs e)
        {
            this.comboBoxFullname.Items.Clear();
            using (var connection = Helper.GetConnection())
            {
                Helper.OpenCon(connection);

                string query = "SELECT User_fullname FROM User_tab where Role_title_id=4;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string client = (string)reader["User_fullname"];
                                this.comboBoxFullname.Items.Add(client);
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
        /// Функция для помещения в combobox данных' таблицы Clinic при открытии элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAddress_OnDropDown(Object sender, EventArgs e)
        {
            this.comboBoxAddress.Items.Clear();
            string doc = "";
            string ser = "";

            if (comboBoxDoctor.Text != "")
            {
                doc = comboBoxDoctor.Text;
            }
            if (comboBoxService.Text != "")
            {
                ser = comboBoxService.Text;
            }
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = "SELECT DISTINCT c.Clinic_Address FROM Clinic c LEFT JOIN User_tab doctor on c.Clinic_id=doctor.Clinic_id LEFT JOIN Arrange_Doctor_Services adc on doctor.[User_id]=adc.Doctor_id\r\nLEFT JOIN Service s on adc.Service_id=s.Service_id WHERE (doctor.User_fullname = @DoctorFullname OR @DoctorFullname IS NULL OR @DoctorFullname = '') AND (s.Service_name = @ServiceName OR @ServiceName IS NULL OR @ServiceName = '') AND ((@DoctorFullname IS NULL AND @ServiceName IS NULL) OR (@DoctorFullname IS NOT NULL AND doctor.User_id IS NOT NULL) OR (@ServiceName IS NOT NULL AND s.Service_id IS NOT NULL) OR (@DoctorFullname IS NOT NULL AND @ServiceName IS NOT NULL AND doctor.User_id IS NOT NULL AND s.Service_id IS NOT NULL));";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@ServiceName", ser);
                        command.Parameters.AddWithValue("@DoctorFullname", doc);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string add = (string)reader["Clinic_Address"];
                                    this.comboBoxAddress.Items.Add(add);
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
        /// Функция для создания записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string client;
            string phone;
            string add;
            string doc;
            string serv;
            DateTime date;

            if (this.textBoxPhone.Text is null)
            {
                MessageBox.Show("Заполните поле Номер телефона");
                return;
            }
            else
            {
                phone = textBoxPhone.Text;
            }
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = "UPDATE u SET u.User_Phone = @NewPhoneNumber FROM User_tab u WHERE u.User_email = @UserEmail AND (u.User_Phone != @NewPhoneNumber OR u.User_Phone IS NULL);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@NewPhoneNumber", phone);
                        command.Parameters.AddWithValue("@UserEmail", Helper.login);

                        command.BeginExecuteNonQuery();
                    }
                    Helper.CloseCon(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (this.comboBoxFullname.Text == "")
            {
                MessageBox.Show("Выберите клиента");
                return;
            } 
            else
            {
                client = comboBoxFullname.Text;
            }

            if (this.comboBoxAddress.Text == "")
            {
                MessageBox.Show("Выберите адрес клиники");
                return;
            }
            else
            {
                add = comboBoxAddress.Text;
            }

            if (this.comboBoxDoctor.Text == "")
            {
                MessageBox.Show("Выберите врача");
                return;
            }
            else
            {
                doc = comboBoxDoctor.Text;
            }

            if (this.comboBoxService.Text == "")
            {
                MessageBox.Show("Выберите врача");
                return;
            }
            else
            {
                serv = comboBoxService.Text;
            }

            date = dateTimePicker1.Value;

            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = "INSERT INTO Appointment (Client_id, Clinic_id, Service_id, Doctor_id, Visit_date) SELECT client.User_id, clinic.Clinic_id, service.Service_id, doctor.User_id, @VisitDate FROM (SELECT @ClientFullname AS client_name, @ClinicAddress AS clinic_address, @ServiceName AS service_name, @DoctorName AS doctor_name) AS input LEFT JOIN User_tab client ON client.User_fullname = input.client_name LEFT JOIN Clinic clinic ON clinic.Clinic_Address = input.clinic_address LEFT JOIN Service service ON service.Service_name = input.service_name LEFT JOIN User_tab doctor ON doctor.User_fullname = input.doctor_name WHERE client.User_id IS NOT NULL AND clinic.Clinic_id IS NOT NULL AND service.Service_id IS NOT NULL AND doctor.User_id IS NOT NULL;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@ClientFullname", client);
                        command.Parameters.AddWithValue("@ClinicAddress", add);
                        command.Parameters.AddWithValue("@ServiceName", serv);
                        command.Parameters.AddWithValue("@DoctorName", doc);
                        command.Parameters.AddWithValue("@VisitDate", date);
                        int rows = command.ExecuteNonQuery();
                    }
                    Helper.CloseCon(connection);
                }
                MessageBox.Show("Запись успешно создана.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Функция для автоматического заполнения поля номер телефона при выборе клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPhone.Text = "";
            string name = comboBoxFullname.Text;
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = "select User_Phone from User_tab where User_fullname=@name AND User_Phone IS NOT NULL;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@name", name);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string phone = (string)reader["User_Phone"];
                                    this.textBoxPhone.Text = phone;
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
                return;
            }
        }


    }
}
