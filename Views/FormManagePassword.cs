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
    public partial class FormManagePassword : Form
    {
        /// <summary>
        /// Режим работы окна. Всего их 2: 
        /// 3 - Создание пароля при регистрации
        /// 2 - Изменение пароля у существующего пользователя
        /// </summary>
        int mode;

        public FormManagePassword()
        {
            InitializeComponent();
        }

        public FormManagePassword(int mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 3:
                    tableLayoutPasswordMain.RowStyles[0] = new RowStyle(SizeType.Absolute, 0);
                    labelCurrPassword.Visible = false;
                    tableLayoutPasswordMain.RowStyles[1] = new RowStyle(SizeType.Absolute, 0);
                    textBoxCurrPassword.Visible = false;
                    textBoxCurrPassword.Enabled = false;
                    break;
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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 2:
                    string currPassword=textBoxCurrPassword.Text;
                    if (Helper.VerifyPassword(Helper.login, currPassword) is false)
                    {
                        MessageBox.Show("Неправильно введён текущий пароль. Повторите попытку.");
                        return;
                    }
                    break;
            }
            if (textBoxNewPassword.Text == textBoxRepeatPassword.Text)
            {
                FormUserCard.password=textBoxNewPassword.Text;
                MessageBox.Show("Пароль задан успешно.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают. Повторите попытку.");
            }
        }
    }
}
