using Dentistry_clinic.Classes;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using Font = System.Drawing.Font;
using Point = System.Drawing.Point;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

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
        DateTime? dat = null;
        //int id;
        Word.Application wordApp;
        Word.Document wordDoc;
        Word.Bookmarks bookmarks;

        /// <summary>
        /// Загрузка формы с отображением всех записей клиента/врача
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        /// <summary>
        /// Функция добавления карточки
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        private void CreateCard(int id, string client, string doctor, string service, decimal service_cost, string clinic, DateTime date)
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

            /// Скрытый номер записи
            Label idApp = new Label();
            idApp.Text = id.ToString();
            idApp.Height = 0;
            cardPanel.Controls.Add(idApp);

            ///Добавление заголовка клиента
            Label clientLabel = new Label();
            clientLabel.Text = "Клиент:";
            clientLabel.Font = new Font("Arial Narrow", 16);
            clientLabel.Location = new Point(10, 10);
            cardPanel.Controls.Add(clientLabel);

            int currentY = clientLabel.Bottom + 10;

            // Добавление строки клиента
            System.Windows.Forms.TextBox clientText = new System.Windows.Forms.TextBox();
            clientText.Text = client;
            clientText.Font = new Font("Arial Narrow", 16);
            clientText.Location = new Point(10, currentY);
            clientText.Width = 220;
            clientText.Multiline = true;
            Size size = TextRenderer.MeasureText(clientText.Text, clientText.Font);
            clientText.Height = size.Height * 2;
            clientText.ReadOnly = true;
            cardPanel.Controls.Add(clientText);

            currentY = clientText.Bottom + 10;

            ///Добавление заголовка врач
            Label doctorLabel = new Label();
            doctorLabel.Text = "Врач:";
            doctorLabel.Font = new Font("Arial Narrow", 16);
            doctorLabel.Location = new Point(10, currentY);
            cardPanel.Controls.Add(doctorLabel);

            currentY = doctorLabel.Bottom + 10;

            // Добавление строки доктора
            System.Windows.Forms.TextBox doctorText = new System.Windows.Forms.TextBox();
            doctorText.Text = doctor;
            doctorText.Font = new Font("Arial Narrow", 16);
            doctorText.Location = new Point(10, currentY);
            doctorText.Width = 220;
            doctorText.Multiline = true;
            doctorText.Height = size.Height * 2;
            doctorText.ReadOnly = true;
            cardPanel.Controls.Add(doctorText);

            currentY = doctorText.Bottom + 10;

            ///Добавление заголовка услуги
            Label serviceLabel = new Label();
            serviceLabel.Text = "Услуга:";
            serviceLabel.Font = new Font("Arial Narrow", 16);
            serviceLabel.Location = new Point(10, currentY);
            cardPanel.Controls.Add(serviceLabel);

            currentY = serviceLabel.Bottom + 10;

            // Добавление строки услуги
            System.Windows.Forms.TextBox serviceText = new System.Windows.Forms.TextBox();
            serviceText.Text = service;
            serviceText.Font = new Font("Arial Narrow", 16);
            serviceText.Location = new Point(10, currentY);
            serviceText.Width = 220;
            serviceText.Multiline = true;
            serviceText.Height = size.Height;
            serviceText.ReadOnly = true;
            cardPanel.Controls.Add(serviceText);

            currentY = serviceText.Bottom + 10;

            ///Добавление заголовка стоимости
            Label costLabel = new Label();
            costLabel.Text = "Стоимость:";
            costLabel.Font = new Font("Arial Narrow", 16);
            costLabel.Location = new Point(10, currentY);
            cardPanel.Controls.Add(costLabel);

            currentY = costLabel.Bottom + 10;

            // Добавление строки стоимости услуги 
            System.Windows.Forms.TextBox serviceCostText = new System.Windows.Forms.TextBox();
            serviceCostText.Text = service_cost.ToString();
            serviceCostText.Font = new Font("Arial Narrow", 16);
            serviceCostText.Location = new Point(10, currentY);
            serviceCostText.Width = 220;
            serviceCostText.Multiline = true;
            serviceCostText.Height = size.Height;
            serviceCostText.ReadOnly = true;
            cardPanel.Controls.Add(serviceCostText);

            currentY = serviceCostText.Bottom + 10;

            ///Добавление заголовка адреса клиники
            Label clinicLabel = new Label();
            clinicLabel.Text = "Адрес:";
            clinicLabel.Font = new Font("Arial Narrow", 16);
            clinicLabel.Location = new Point(10, currentY);
            cardPanel.Controls.Add(clinicLabel);

            currentY = clinicLabel.Bottom + 10;

            // Добавление строки клиники
            System.Windows.Forms.TextBox clinicText = new System.Windows.Forms.TextBox();
            clinicText.Text = clinic;
            clinicText.Font = new Font("Arial Narrow", 16);
            clinicText.Location = new Point(10, currentY);
            clinicText.Width = 220;
            clinicText.Multiline = true;
            clinicText.Height = size.Height * 2;
            clinicText.ReadOnly = true;
            cardPanel.Controls.Add(clinicText);

            currentY = clinicText.Bottom + 10;

            ///Добавление заголовка даты
            Label dateLabel = new Label();
            dateLabel.Text = "Дата:";
            dateLabel.Font = new Font("Arial Narrow", 16);
            dateLabel.Location = new Point(10, currentY);
            cardPanel.Controls.Add(dateLabel);

            currentY = dateLabel.Bottom + 10;

            //Добавление строки даты
            System.Windows.Forms.TextBox dateText = new System.Windows.Forms.TextBox();
            dateText.Text = date.ToString();
            dateText.Font = new Font("Arial Narrow", 16);
            dateText.Location = new Point(10, currentY);
            dateText.Width = 220;
            dateText.Multiline = true;
            dateText.Height = size.Height;
            dateText.ReadOnly = true;
            cardPanel.Controls.Add(dateText);

            currentY = dateText.Bottom + 10;

            if (Helper.role == 2)
            {
                // Кнопка совершения
                System.Windows.Forms.Button completeButton = new System.Windows.Forms.Button();
                completeButton.Tag = id.ToString() + '!' + client + '!' + doctor + '!' + service + '!' + service_cost + '!' + clinic + '!' + date;
                completeButton.Click += new System.EventHandler(this.completeButton_Click);
                completeButton.Width = 40;
                completeButton.Height = 40;
                completeButton.BackColor = Color.FromArgb(26, 206, 26);
                completeButton.Image = Image.FromFile(@"C:\Users\Laudanum\Desktop\jaws desktop\Project\Dentistry clinic\Resources\complete.png");
                completeButton.Location = new Point(40, currentY);
                cardPanel.Controls.Add(completeButton);
            }

            // Кнопка редактирования
            System.Windows.Forms.Button EditButton = new System.Windows.Forms.Button();
            EditButton.Tag = id;
            EditButton.Click += new System.EventHandler(this.EditButton_Click);
            EditButton.Width = 40;
            EditButton.Height = 40;
            EditButton.BackColor = Color.FromArgb(26, 206, 26);
            EditButton.Image = Image.FromFile(@"C:\Users\Laudanum\Desktop\jaws desktop\Project\Dentistry clinic\Resources\edit.png");
            EditButton.Location = new Point(100, currentY);
            cardPanel.Controls.Add(EditButton);

            // Кнопка удаления
            System.Windows.Forms.Button delButton = new System.Windows.Forms.Button();
            delButton.Tag = id;
            delButton.Click += new System.EventHandler(this.delButton_Click);
            delButton.Width = 40;
            delButton.Height = 40;
            delButton.BackColor = Color.FromArgb(206, 26, 26);
            delButton.Image = Image.FromFile(@"C:\Users\Laudanum\Desktop\jaws desktop\Project\Dentistry clinic\Resources\delete.png");
            delButton.Location = new Point(160, currentY);
            cardPanel.Controls.Add(delButton);

            this.flowLayoutAppointment.Controls.Add(cardPanel);
        }

        /// <summary>
        /// Нажатие на кнопку совершения записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void completeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string data = btn.Tag.ToString();
            completeCard(data);
        }

        /// <summary>
        /// Нажатие на кнопку редактирование записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            int data = Convert.ToInt32(btn.Tag);
            updateCard(data);
        }

        /// <summary>
        /// Нажатие на кнопку удаления записи
        /// </summary>
        /// <param name="id"></param>
        private void delButton_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены, что хотите удалить запись?";
            string caption = "Удаление записи";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            // Если нажата кнопка 'нет' - отменяет выполнение функции.
            if (result == DialogResult.No)
            {
                return;
            }

            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            int data = Convert.ToInt32(btn.Tag);
            delCard(data);
        }

        /// <summary>
        /// Возвращение к окну навигации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavButton_Click(object sender, EventArgs e)
        {
            Helper.OpenNavWindow(this);
        }

        /// <summary>
        /// Функция для отображения карточек с применением фильтрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.flowLayoutAppointment.Controls.Clear();
            if (this.comboBoxClient.SelectedItem != null)
                client = this.comboBoxClient.Text;
            
            if (this.comboBoxDoctor.SelectedItem != null)
                doc = this.comboBoxDoctor.Text;
            
            if (this.comboBoxService.SelectedItem != null)
                serv = this.comboBoxService.Text;
            
            //if (this.dateTimeApp.CustomFormat != " ")
                dat = this.dateTimeApp.Value.Date;
            

            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = @"EXEC dbo.Show_App @ClientName=@ClientFullname, @ServiceName=@ServName, @DoctorFullname=@DocName, @Date=@Dat;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@ClientFullname", client);
                        command.Parameters.AddWithValue("@ServName", serv);
                        command.Parameters.AddWithValue("@DocName", doc);
                        //if(!(dat is null))
                        command.Parameters.AddWithValue("@Dat", dat);

                        //MessageBox.Show(command.ToString());

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int id = (int)reader["Appointment_id"];
                                    string client = (string)reader["Client_name"];
                                    string clinic = (string)reader["Clinic_Address"];
                                    string service = (string)reader["Service_name"];
                                    decimal service_cost = (decimal)reader["Service_cost"];
                                    string doctor = (string)reader["Doctor_name"];
                                    DateTime date = (DateTime)reader["Visit_date"];
                                    CreateCard(id, client, doctor, service, service_cost, clinic, date);
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
        /// Загрузка имени пользователя
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Выбор даты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimeApp_ValueChanged(object sender, EventArgs e)
        {
            dateTimeApp.Format = DateTimePickerFormat.Short;
        }

        /// <summary>
        /// Открытие окна редактирования
        /// </summary>
        /// <param name="id"></param>
        private void updateCard(int id)
        {
            FormCreateAppointment formApp = new FormCreateAppointment(2, id);
            this.Hide();
            formApp.Show();
        }

        /// <summary>
        /// Совершение записи
        /// </summary>
        /// <param name="id"></param>
        private void completeCard(string str)
        {
            string message = "Вы уверены, что хотите совершить запись?";
            string caption = "Совершение записи";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            // Если нажата кнопка 'нет' - отменяет выполнение функции.
            if (result == DialogResult.No)
            {
                return;
            }
            //MessageBox.Show(str);
            string[] arr = str.Split('!');
            createAgreement(arr);
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="id"></param>
        private void delCard(int id)
        {
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = "DELETE FROM Appointment where Appointment_id=@id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно удалена");
                        loadData();
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
        /// Составление документа договора
        /// </summary>
        private void createAgreement(string[] arr)
        {
            ///1 Соединение с сервером Word
            try
            {
                wordApp = new Word.Application();
                wordApp.Visible = false;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии приложения");
                return;
            }

            try
            {
                //2 подготовка документа
                string path = Environment.CurrentDirectory;
                string filetemp = path + @"\Templates\templatebookmarks.docx";
                if (File.Exists(filetemp))
                {
                    wordDoc = wordApp.Documents.Add(filetemp);
                    wordDoc.Save();
                    wordDoc.Activate();
                }
                else
                {
                    MessageBox.Show("Шаблон не найден");
                    return;
                }

                //3 добавление закладок
                bookmarks = wordDoc.Bookmarks;
                //0id 1client 2doctor 3service 4service_cost 5clinic 6date
                //foreach(string str in arr)
                //{
                //    MessageBox.Show(str);
                //}
                //4 заполнение закладок
                bookmarks["id"].Range.Text = arr[0];
                bookmarks["date"].Range.Text = DateTime.Now.ToShortDateString();
                bookmarks["address"].Range.Text = arr[5];
                bookmarks["client"].Range.Text = arr[1];
                bookmarks["service"].Range.Text = arr[3];
                bookmarks["cost"].Range.Text = arr[4];
                bookmarks["doctor"].Range.Text = arr[2];
                bookmarks["appdate"].Range.Text = arr[6];
                bookmarks["appaddress"].Range.Text = arr[5];
                bookmarks["admin"].Range.Text = selectUserName();
                bookmarks["appclient"].Range.Text = arr[1];

                ////5 сохранение документа
                string newpath = path + @"\Documents\";
                wordDoc.SaveAs2(newpath + "AgrFrom" + arr[0].ToString() +".docx");
                wordDoc.SaveAs2(newpath + "AgrFrom" + arr[0].ToString() +".pdf", Word.WdExportFormat.wdExportFormatPDF);
                wordDoc.Close(true, null, null);

                //6 закрытие ворда
                wordApp.Quit();
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(wordApp);
                wordApp = null;
                GC.Collect();
                MessageBox.Show("Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Загрузка данных из базы
        /// </summary>
        private void loadData()
        {
            flowLayoutAppointment.Controls.Clear();
            dateTimeApp.Format = DateTimePickerFormat.Custom;
            dateTimeApp.CustomFormat = " ";
            Helper.Load_comboBox(comboBoxClient, "SELECT User_fullname FROM User_tab where Role_title_id=4;", "User_fullname");
            Helper.Load_comboBoxOneDepend(comboBoxService, 
                "SELECT DISTINCT s.Service_name FROM Service s LEFT JOIN Arrange_Doctor_Services ads ON s.Service_id = ads.Service_id LEFT JOIN User_tab doctor ON ads.Doctor_id = doctor.User_id WHERE (doctor.User_fullname = @DoctorFullname OR @DoctorFullname IS NULL OR @DoctorFullname = '') AND ((@DoctorFullname IS NULL) OR (@DoctorFullname IS NOT NULL AND doctor.User_id IS NOT NULL));", 
                "Service_name", 
                comboBoxDoctor, 
                "@DoctorFullname");
            Helper.Load_comboBoxOneDepend(comboBoxDoctor, 
                "SELECT DISTINCT doctor.User_fullname FROM User_tab doctor LEFT JOIN Arrange_Doctor_Services ads ON doctor.User_id=ads.Doctor_id LEFT JOIN Service s ON ads.Service_id=s.Service_id WHERE ((s.Service_name = @ServiceName OR @ServiceName IS NULL OR @ServiceName = '') AND ((@ServiceName IS NULL) OR (@ServiceName IS NOT NULL AND s.Service_id IS NOT NULL) OR (@ServiceName IS NOT NULL AND s.Service_id IS NOT NULL))) and (doctor.Role_title_id=1);", 
                "User_fullname", 
                comboBoxService, 
                "@ServiceName");

            switch (Helper.role)
            {
                case 1:
                    this.comboBoxDoctor.SelectedItem = selectUserName();
                    this.comboBoxDoctor.Hide();
                    this.tableLayoutFilter.RowStyles[3].SizeType = SizeType.Absolute;
                    this.tableLayoutFilter.RowStyles[3].Height = 0;
                    this.tableLayoutFilter.RowStyles[4].SizeType = SizeType.Absolute;
                    this.tableLayoutFilter.RowStyles[4].Height = 0;
                    break;
                case 4:
                    this.comboBoxClient.SelectedItem = selectUserName();
                    this.comboBoxClient.Hide();
                    this.tableLayoutFilter.RowStyles[5].SizeType = SizeType.Absolute;
                    this.tableLayoutFilter.RowStyles[5].Height = 0;
                    this.tableLayoutFilter.RowStyles[6].SizeType = SizeType.Absolute;
                    this.tableLayoutFilter.RowStyles[6].Height = 0;
                    break;
            }
            try
            {
                using (var connection = Helper.GetConnection())
                {
                    Helper.OpenCon(connection);

                    string query = $"EXEC dbo.Show_App";
                    switch (Helper.role)
                    {
                        case (1):
                            query += " @DoctorLogin = @login;";
                            break;
                        case (4):
                            query += " @ClientLogin = @login;";
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
                                    int id = (Int32)reader["Appointment_id"];
                                    string client = (string)reader["Client_name"];
                                    string clinic = (string)reader["Clinic_Address"];
                                    string service = (string)reader["Service_name"];
                                    decimal service_cost = (decimal)reader["Service_cost"];
                                    string doctor = (string)reader["Doctor_name"];
                                    DateTime date = (DateTime)reader["Visit_date"];
                                    CreateCard(id, client, doctor, service, service_cost, clinic, date);
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
        /// Загрузка списка услуг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxService_DropDown(object sender, EventArgs e)
        {
            Helper.Load_comboBoxOneDepend(comboBoxService,
                "SELECT DISTINCT s.Service_name FROM Service s LEFT JOIN Arrange_Doctor_Services ads ON s.Service_id = ads.Service_id LEFT JOIN User_tab doctor ON ads.Doctor_id = doctor.User_id WHERE (doctor.User_fullname = @DoctorFullname OR @DoctorFullname IS NULL OR @DoctorFullname = '') AND ((@DoctorFullname IS NULL) OR (@DoctorFullname IS NOT NULL AND doctor.User_id IS NOT NULL));",
                "Service_name",
                comboBoxDoctor,
                "@DoctorFullname");
        }

        /// <summary>
        /// За
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDoctor_DropDown(object sender, EventArgs e)
        {
            Helper.Load_comboBoxOneDepend(comboBoxDoctor,
                "SELECT DISTINCT doctor.User_fullname FROM User_tab doctor LEFT JOIN Arrange_Doctor_Services ads ON doctor.User_id=ads.Doctor_id LEFT JOIN Service s ON ads.Service_id=s.Service_id WHERE ((s.Service_name = @ServiceName OR @ServiceName IS NULL OR @ServiceName = '') AND ((@ServiceName IS NULL) OR (@ServiceName IS NOT NULL AND s.Service_id IS NOT NULL) OR (@ServiceName IS NOT NULL AND s.Service_id IS NOT NULL))) and (doctor.Role_title_id=1);",
                "User_fullname",
                comboBoxService,
                "@ServiceName");
        }
    }
}
