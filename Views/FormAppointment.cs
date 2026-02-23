using Dentistry_clinic.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentistry_clinic
{
    public partial class FormAppointment : Form
    {
        public FormAppointment()
        {
            InitializeComponent();
            comboBoxClient.KeyPress += (sender, e) => e.Handled = true;
            comboBoxDoctor.KeyPress += (sender, e) => e.Handled = true;
            comboBoxService.KeyPress += (sender, e) => e.Handled = true;
        }

        string client = "";
        string doc = "";
        string serv = "";

        /// <summary>
        /// Загрузка формы с отображением всех записей клиента/врача
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimeApp.Format = DateTimePickerFormat.Custom;
            dateTimeApp.CustomFormat = " ";
            switch (Helper.role)
            {
                case 1:
                    this.comboBoxDoctor.Text = selectUserName();
                    this.comboBoxDoctor.Hide();
                    this.tableLayoutfilter.RowStyles[3].SizeType = SizeType.Absolute;
                    this.tableLayoutfilter.RowStyles[3].Height = 0;
                    this.tableLayoutfilter.RowStyles[4].SizeType = SizeType.Absolute;
                    this.tableLayoutfilter.RowStyles[4].Height = 0;
                    break;
                case 4:

                    this.comboBoxClient.Text = selectUserName();
                    this.comboBoxClient.Hide();
                    this.tableLayoutfilter.RowStyles[5].SizeType = SizeType.Absolute;
                    this.tableLayoutfilter.RowStyles[5].Height = 0;
                    this.tableLayoutfilter.RowStyles[6].SizeType = SizeType.Absolute;
                    this.tableLayoutfilter.RowStyles[6].Height = 0;
                    break;
            } 
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = $"SELECT client.User_fullname AS Client_name, c.Clinic_Address, s.Service_name, s.Service_cost, doctor.User_fullname AS Doctor_name, a.Visit_date FROM Appointment a INNER JOIN User_tab client ON a.Client_id = client.User_id INNER JOIN Clinic c ON a.Clinic_id = c.Clinic_id INNER JOIN Service s ON a.Service_id = s.Service_id INNER JOIN User_tab doctor ON a.Doctor_id = doctor.User_id";
                    switch (Helper.role)
                    {
                        case(1):
                            query += " WHERE doctor.User_email = @login;";
                            break;
                        case (4):
                            query += " WHERE client.User_email = @login;";
                            break;
                    }
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
                                    string client = (string)reader["Client_name"];
                                    string clinic = (string)reader["Clinic_Address"];
                                    string service = (string)reader["Service_name"];
                                    decimal service_cost = (decimal)reader["Service_cost"];
                                    string doctor = (string)reader["Doctor_name"];
                                    DateTime date = (DateTime)reader["Visit_date"];
                                    CreateCard(client, doctor, service, service_cost, clinic, date);
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
        /// Функция добавления карточки
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        private void CreateCard(string client, string doctor, string service, decimal service_cost, string clinic, DateTime date)
        {
            this.flowLayoutAppointment.AutoScroll = false;
            this.flowLayoutAppointment.HorizontalScroll.Enabled = false;
            this.flowLayoutAppointment.HorizontalScroll.Visible = false;
            this.flowLayoutAppointment.HorizontalScroll.Maximum = 0;
            this.flowLayoutAppointment.AutoScroll = true;

            // Создание новой карточки (Panel)
            Panel cardPanel = new Panel();
            cardPanel.AutoSize = true;
            cardPanel.Width = 240;
            cardPanel.BorderStyle = BorderStyle.FixedSingle;
            cardPanel.BackColor = Color.White;
            cardPanel.Margin = new Padding(5);
            


            // Добавление Label для строки клиента
            Label clientLabel = new Label();
            clientLabel.Text = client;
            clientLabel.Font= new Font("Arial Narrow", 16);
            clientLabel.Location = new Point(10, 10);
            clientLabel.Width= 220;
            clientLabel.MaximumSize = new Size(220, 100);
            
            cardPanel.Controls.Add(clientLabel);

            int currentY = clientLabel.Bottom + 10;

            // Добавление Label для строки доктора
            Label doctorLabel = new Label();
            doctorLabel.Text = doctor;
            doctorLabel.Font = new Font("Arial Narrow", 16);
            doctorLabel.Location = new Point(10, currentY);
            doctorLabel.Width = 220;
            doctorLabel.MaximumSize = new Size(220, 100);
            cardPanel.Controls.Add(doctorLabel);

            currentY = doctorLabel.Bottom + 10;

            // Добавление Label для строки услуги
            Label serviceLabel = new Label();
            serviceLabel.Text = service;
            serviceLabel.Font = new Font("Arial Narrow", 16);
            serviceLabel.Location = new Point(10, currentY);
            serviceLabel.Width = 220;
            serviceLabel.MaximumSize = new Size(220, 100);
            cardPanel.Controls.Add(serviceLabel);

            currentY = serviceLabel.Bottom + 10;

            // Добавление Label для строки стоимости услуги 
            Label serviceCostLabel = new Label();
            serviceCostLabel.Text = service_cost.ToString();
            serviceCostLabel.Font = new Font("Arial Narrow", 16);
            serviceCostLabel.Location = new Point(10, currentY);
            serviceCostLabel.Width = 220;
            serviceCostLabel.MaximumSize = new Size(220, 100);
            cardPanel.Controls.Add(serviceCostLabel);

            currentY = serviceCostLabel.Bottom + 10;
            //MessageBox.Show(serviceCostLabel.Bottom.ToString());

            // Добавление Label для строки клиники
            Label clinicLabel = new Label();
            clinicLabel.Text = clinic;
            clinicLabel.Font = new Font("Arial Narrow", 16);
            clinicLabel.Location = new Point(10, currentY);
            clinicLabel.Width = 220;
            clinicLabel.MaximumSize = new Size(220, 100);
            cardPanel.Controls.Add(clinicLabel);

            currentY = clinicLabel.Bottom + 10;

            // Добавление Label для строки услуги
            Label dateLabel = new Label();
            dateLabel.Text = date.ToString();
            dateLabel.Font = new Font("Arial Narrow", 16);
            dateLabel.Location = new Point(10, currentY);
            dateLabel.Width = 220;
            dateLabel.MaximumSize = new Size(220, 100);
            cardPanel.Controls.Add(dateLabel);

            currentY = dateLabel.Bottom + 10;

            // Добавление Button
            Button delButton = new Button();
            delButton.BackColor = Color.FromArgb(206, 26, 26);
            delButton.Text = "Удалить";
            delButton.Font = new Font("Arial Narrow", 16);
            delButton.Location = new Point(160, currentY);
            cardPanel.Controls.Add(delButton);
            this.flowLayoutAppointment.Controls.Add(cardPanel);
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

            if (comboBoxDoctor.Text != "")
            {
                doc = comboBoxDoctor.Text;
            }
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = "SELECT DISTINCT s.Service_name FROM Service s LEFT JOIN Arrange_Doctor_Services ads ON s.Service_id = ads.Service_id LEFT JOIN User_tab doctor ON ads.Doctor_id = doctor.User_id WHERE (doctor.User_fullname = @DoctorFullname OR @DoctorFullname IS NULL OR @DoctorFullname = '') AND ((@DoctorFullname IS NULL) OR (@DoctorFullname IS NOT NULL AND doctor.User_id IS NOT NULL));";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@DoctorFullname", doc);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string ser = (string)reader["Service_name"];
                                    this.comboBoxService.Items.Add(ser);
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

            if (comboBoxService.Text != "")
            {
                serv = comboBoxService.Text;
            }
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = "SELECT DISTINCT doctor.User_fullname FROM User_tab doctor LEFT JOIN Arrange_Doctor_Services ads ON doctor.User_id=ads.Doctor_id LEFT JOIN Service s ON ads.Service_id=s.Service_id WHERE ((s.Service_name = @ServiceName OR @ServiceName IS NULL OR @ServiceName = '') AND ((@ServiceName IS NULL) OR (@ServiceName IS NOT NULL AND s.Service_id IS NOT NULL) OR (@ServiceName IS NOT NULL AND s.Service_id IS NOT NULL))) and (doctor.Role_title_id=1);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@ServiceName", serv);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string doct = (string)reader["User_fullname"];
                                    this.comboBoxDoctor.Items.Add(doct);
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
        private void comboBoxClient_OnDropDown(Object sender, EventArgs e)
        {
            this.comboBoxClient.Items.Clear();
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
                                string cli = (string)reader["User_fullname"];
                                this.comboBoxClient.Items.Add(cli);
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
        /// Функция для отображения карточек с применением фильтрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.flowLayoutAppointment.Controls.Clear();
            if (this.comboBoxClient.Text != "")
            {
                client = this.comboBoxClient.Text;
            }
            if (this.comboBoxDoctor.Text != "")
            {
                doc = this.comboBoxDoctor.Text;
            }
            if (this.comboBoxService.Text != "")
            {
                serv= this.comboBoxService.Text;
            }
            DateTime dat = dateTimeApp.Value.Date;

            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = @"SELECT 
                        client.User_fullname AS Client_name, 
                        c.Clinic_Address, 
                        s.Service_name, 
                        s.Service_cost, 
                        doctor.User_fullname AS Doctor_name, 
                        a.Visit_date 
                    FROM Appointment a 
                        INNER JOIN User_tab client ON a.Client_id = client.User_id 
                        INNER JOIN Clinic c ON a.Clinic_id = c.Clinic_id 
                        INNER JOIN Service s ON a.Service_id = s.Service_id 
                        INNER JOIN User_tab doctor ON a.Doctor_id = doctor.User_id 
                    WHERE (doctor.User_fullname = @DoctorFullname OR @DoctorFullname IS NULL OR @DoctorFullname = '') 
                        AND (s.Service_name = @ServiceName OR @ServiceName IS NULL OR @ServiceName = '') 
                        AND (client.User_fullname = @ClientName OR @ClientName IS NULL OR @ClientName = '') 
                        AND (a.Visit_date = @Date OR @Date IS NULL OR @Date = '') 
                        AND ((@DoctorFullname IS NULL AND @ServiceName IS NULL AND @ClientName is null and @Date is null) 
                            OR (@DoctorFullname IS NOT NULL AND doctor.User_id IS NOT NULL) 
                            OR (@ServiceName IS NOT NULL AND s.Service_id IS NOT NULL) 
                            OR (@ClientName IS NOT NULL AND client.User_fullname IS NOT NULL) 
                            OR (@Date IS NOT NULL AND a.Visit_date IS NOT NULL) 
                            OR (@DoctorFullname IS NOT NULL AND @ServiceName IS NOT NULL and @ClientName is not null and @Date is not null AND doctor.User_id IS NOT NULL AND s.Service_id IS NOT NULL and client.User_fullname is not null and a.Visit_date is not null) 
                            or (@DoctorFullname IS NULL AND @ServiceName IS NOT NULL and @ClientName is not null and @Date is not null AND doctor.User_id IS NULL AND s.Service_id IS NOT NULL and client.User_fullname is not null and a.Visit_date is not null) 
                            or (@DoctorFullname IS NOT NULL AND @ServiceName IS NULL and @ClientName is not null and @Date is not null AND doctor.User_id IS NOT NULL AND s.Service_id IS NULL and client.User_fullname is not null and a.Visit_date is not null) 
                            or (@DoctorFullname IS NOT NULL AND @ServiceName IS NOT NULL and @ClientName is null and @Date is not null AND doctor.User_id IS NOT NULL AND s.Service_id IS NOT NULL and client.User_fullname is null and a.Visit_date is not null) 
                            OR (@DoctorFullname IS NULL AND @ServiceName IS NOT NULL and @ClientName is null and @Date is not null AND doctor.User_id IS NULL AND s.Service_id IS NOT NULL and client.User_fullname is null and a.Visit_date is not null) 
                            OR (@DoctorFullname IS NOT NULL AND @ServiceName IS NULL and @ClientName is not null and @Date is null AND doctor.User_id IS NOT NULL AND s.Service_id IS NULL and client.User_fullname is not null and a.Visit_date is null) 
                            OR (@DoctorFullname IS NULL AND @ServiceName IS NOT NULL and @ClientName is not null and @Date is null AND doctor.User_id IS NULL AND s.Service_id IS NOT NULL and client.User_fullname is not null and a.Visit_date is null) 
                            OR (@DoctorFullname IS NOT NULL AND @ServiceName IS NULL and @ClientName is null and @Date is not null AND doctor.User_id IS NOT NULL AND s.Service_id IS NULL and client.User_fullname is null and a.Visit_date is not null));";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@ClientName", client);
                        command.Parameters.AddWithValue("@ServiceName", serv);
                        command.Parameters.AddWithValue("@DoctorFullname", doc);
                        command.Parameters.AddWithValue("@Date", dat);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string client = (string)reader["Client_name"];
                                    string clinic = (string)reader["Clinic_Address"];
                                    string service = (string)reader["Service_name"];
                                    decimal service_cost = (decimal)reader["Service_cost"];
                                    string doctor = (string)reader["Doctor_name"];
                                    DateTime date = (DateTime)reader["Visit_date"];
                                    CreateCard(client, doctor, service, service_cost, clinic, date);
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

        private string selectUserName()
        {
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);
                    string name = "";

                    string query = "SELECT User_fullname from User_tab where User_email=@login";
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
                                    name = (string)reader["User_fullname"];
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
                    return name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void dateTimeApp_ValueChanged(object sender, EventArgs e)
        {
            dateTimeApp.Format = DateTimePickerFormat.Short;
        }
    }
}
