namespace Dentistry_clinic
{
    partial class FormManagePassword
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagePassword));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutTitle = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.NavButton = new System.Windows.Forms.Button();
            this.tableLayoutFooter = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPasswordMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelCurrPassword = new System.Windows.Forms.Label();
            this.textBoxCurrPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutFooter.SuspendLayout();
            this.tableLayoutPasswordMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutTitle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutFooter, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPasswordMain, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1033, 641);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutTitle
            // 
            this.tableLayoutTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tableLayoutTitle.ColumnCount = 3;
            this.tableLayoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutTitle.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutTitle.Controls.Add(this.label, 1, 0);
            this.tableLayoutTitle.Controls.Add(this.NavButton, 2, 0);
            this.tableLayoutTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTitle.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutTitle.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutTitle.Name = "tableLayoutTitle";
            this.tableLayoutTitle.RowCount = 1;
            this.tableLayoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTitle.Size = new System.Drawing.Size(1027, 94);
            this.tableLayoutTitle.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.label.Location = new System.Drawing.Point(203, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(572, 94);
            this.label.TabIndex = 1;
            this.label.Text = "Управление паролем";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavButton
            // 
            this.NavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.NavButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.NavButton.Location = new System.Drawing.Point(781, 3);
            this.NavButton.Name = "NavButton";
            this.NavButton.Size = new System.Drawing.Size(243, 88);
            this.NavButton.TabIndex = 2;
            this.NavButton.Text = "Навигация";
            this.NavButton.UseVisualStyleBackColor = false;
            this.NavButton.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // tableLayoutFooter
            // 
            this.tableLayoutFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.tableLayoutFooter.ColumnCount = 2;
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFooter.Controls.Add(this.label2, 1, 0);
            this.tableLayoutFooter.Controls.Add(this.label1, 0, 0);
            this.tableLayoutFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFooter.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tableLayoutFooter.Location = new System.Drawing.Point(3, 574);
            this.tableLayoutFooter.Name = "tableLayoutFooter";
            this.tableLayoutFooter.RowCount = 1;
            this.tableLayoutFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFooter.Size = new System.Drawing.Size(1027, 64);
            this.tableLayoutFooter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(516, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "LauOpi@gmail.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lau_Opi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPasswordMain
            // 
            this.tableLayoutPasswordMain.ColumnCount = 3;
            this.tableLayoutPasswordMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPasswordMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPasswordMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPasswordMain.Controls.Add(this.textBoxRepeatPassword, 1, 5);
            this.tableLayoutPasswordMain.Controls.Add(this.labelRepeatPassword, 1, 4);
            this.tableLayoutPasswordMain.Controls.Add(this.textBoxNewPassword, 1, 3);
            this.tableLayoutPasswordMain.Controls.Add(this.labelNewPassword, 1, 2);
            this.tableLayoutPasswordMain.Controls.Add(this.labelCurrPassword, 1, 0);
            this.tableLayoutPasswordMain.Controls.Add(this.textBoxCurrPassword, 1, 1);
            this.tableLayoutPasswordMain.Controls.Add(this.buttonConfirm, 1, 6);
            this.tableLayoutPasswordMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPasswordMain.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.tableLayoutPasswordMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.tableLayoutPasswordMain.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPasswordMain.Name = "tableLayoutPasswordMain";
            this.tableLayoutPasswordMain.RowCount = 7;
            this.tableLayoutPasswordMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.32353F));
            this.tableLayoutPasswordMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.67647F));
            this.tableLayoutPasswordMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPasswordMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPasswordMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPasswordMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPasswordMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPasswordMain.Size = new System.Drawing.Size(1027, 465);
            this.tableLayoutPasswordMain.TabIndex = 2;
            // 
            // labelCurrPassword
            // 
            this.labelCurrPassword.AutoSize = true;
            this.labelCurrPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrPassword.Location = new System.Drawing.Point(208, 0);
            this.labelCurrPassword.Name = "labelCurrPassword";
            this.labelCurrPassword.Size = new System.Drawing.Size(610, 67);
            this.labelCurrPassword.TabIndex = 0;
            this.labelCurrPassword.Text = "Введите текущий пароль";
            this.labelCurrPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCurrPassword
            // 
            this.textBoxCurrPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCurrPassword.Location = new System.Drawing.Point(208, 70);
            this.textBoxCurrPassword.Name = "textBoxCurrPassword";
            this.textBoxCurrPassword.PasswordChar = '*';
            this.textBoxCurrPassword.Size = new System.Drawing.Size(610, 48);
            this.textBoxCurrPassword.TabIndex = 1;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNewPassword.Location = new System.Drawing.Point(208, 145);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(610, 75);
            this.labelNewPassword.TabIndex = 2;
            this.labelNewPassword.Text = "Введите новый пароль";
            this.labelNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNewPassword.Location = new System.Drawing.Point(208, 223);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(610, 48);
            this.textBoxNewPassword.TabIndex = 3;
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.AutoSize = true;
            this.labelRepeatPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRepeatPassword.Location = new System.Drawing.Point(208, 277);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Size = new System.Drawing.Size(610, 56);
            this.labelRepeatPassword.TabIndex = 4;
            this.labelRepeatPassword.Text = "Повторите новый пароль";
            this.labelRepeatPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(208, 336);
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.PasswordChar = '*';
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(610, 48);
            this.textBoxRepeatPassword.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.buttonConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(208, 401);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(610, 61);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Задать пароль";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormManagePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 641);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 420);
            this.Name = "FormManagePassword";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutTitle.ResumeLayout(false);
            this.tableLayoutTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutFooter.ResumeLayout(false);
            this.tableLayoutFooter.PerformLayout();
            this.tableLayoutPasswordMain.ResumeLayout(false);
            this.tableLayoutPasswordMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button NavButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPasswordMain;
        private System.Windows.Forms.Label labelCurrPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxCurrPassword;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Label labelRepeatPassword;
        private System.Windows.Forms.Button buttonConfirm;
    }
}

