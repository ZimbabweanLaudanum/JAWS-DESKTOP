using Dentistry_clinic.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentistry_clinic
{
    public partial class FormNavigation : Form
    {
        public FormNavigation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка окна в соответствии с ролью пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            switch (Helper.role)
            {
                case 1:
                    hideButtonUserList();
                    hideButtonReport();
                    hideButtonLoginHistory();
                    break;
                case 2:
                    hideButtonLoginHistory();
                    break;
                case 3:
                    hideButtonAppointment();
                    hideButtonOpenAppointments();
                    hideButtonOpenHistory();
                    hideButtonReport();
                    break;
                case 4:
                    hideButtonUserList();
                    hideButtonLoginHistory();
                    hideButtonReport();
                    break;
            }
        }

        /// <summary>
        /// Закрытие текущего окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Открытие окна списка записей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenAppointments_Click(object sender, EventArgs e)
        {
            FormAppointment AppForm = new FormAppointment();
            this.Hide();
            AppForm.Show();
        }

        /// <summary>
        /// Открытие окна записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            FormCreateAppointment createAppointment = new FormCreateAppointment(1, 0);
            this.Hide();
            createAppointment.Show();
        }

        /// <summary>
        /// Открытие списка пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUserList_Click(object sender, EventArgs e)
        {
            FormUsers users = new FormUsers();
            this.Hide();
            users.Show();
        }

        /// <summary>
        /// Открытия окна редактирования аккаунта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            FormUserCard UserForm = new FormUserCard(4, Helper.login);
            this.Hide();
            UserForm.Show();
        }

        /// <summary>
        /// Функция для скрытия кнопки открытия окна записи
        /// </summary>
        private void hideButtonAppointment()
        {
            this.buttonAppointment.Enabled = false;
            this.buttonAppointment.Hide();
            this.tableLayoutFunctions.RowStyles[1].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[1].Height = 0;
            this.tableLayoutFunctions.RowStyles[2].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[2].Height = 0;
        }

        /// <summary>
        /// Функция для скрытия кнопки открытия окна списка записей
        /// </summary>
        private void hideButtonOpenAppointments()
        {
            this.buttonOpenAppointments.Enabled = false;
            this.buttonOpenAppointments.Hide();
            this.tableLayoutFunctions.RowStyles[5].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[5].Height = 0;
            this.tableLayoutFunctions.RowStyles[6].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[6].Height = 0;
        }

        /// <summary>
        /// Функция для скрытия кнопки открытия окна истории посещений
        /// </summary>
        private void hideButtonOpenHistory()
        {
            this.buttonOpenHistory.Enabled = false;
            this.buttonOpenHistory.Hide();
            this.tableLayoutFunctions.RowStyles[7].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[7].Height = 0;
            this.tableLayoutFunctions.RowStyles[8].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[8].Height = 0;
        }

        /// <summary>
        /// Функция для скрытия кнопки открытия окна списка пользователей
        /// </summary>
        private void hideButtonUserList()
        {
            this.buttonUserList.Enabled = false;
            this.buttonUserList.Hide();
            this.tableLayoutFunctions.RowStyles[9].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[9].Height = 0;
            this.tableLayoutFunctions.RowStyles[10].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[10].Height = 0;
        }

        /// <summary>
        /// Функция для скрытия кнопки открытия окна отчётов
        /// </summary>
        private void hideButtonReport()
        {
            this.buttonReport.Enabled = false;
            this.buttonReport.Hide();
            this.tableLayoutFunctions.RowStyles[11].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[11].Height = 0;
            this.tableLayoutFunctions.RowStyles[12].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[12].Height = 0;
        }

        /// <summary>
        /// Функция для скрытия кнопки открытия окна истории входов
        /// </summary>
        private void hideButtonLoginHistory()
        {
            this.buttonLoginHistory.Enabled = false;
            this.buttonLoginHistory.Hide();
            this.tableLayoutFunctions.RowStyles[13].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[13].Height = 0;
            this.tableLayoutFunctions.RowStyles[14].SizeType = SizeType.Absolute;
            this.tableLayoutFunctions.RowStyles[14].Height = 0;
        }

        /// <summary>
        /// Открытие формы статистики
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport_Click(object sender, EventArgs e)
        {
            FormStatic form = new FormStatic();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
