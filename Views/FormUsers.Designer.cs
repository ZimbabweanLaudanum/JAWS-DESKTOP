namespace Dentistry_clinic
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutTitle = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelReg = new System.Windows.Forms.Label();
            this.NavButton = new System.Windows.Forms.Button();
            this.tableLayoutFooter = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelList = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.block = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutFooter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutTitle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutFooter, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
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
            this.tableLayoutTitle.Controls.Add(this.labelReg, 1, 0);
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
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.labelReg.Location = new System.Drawing.Point(203, 0);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(572, 94);
            this.labelReg.TabIndex = 1;
            this.labelReg.Text = "Аккаунты системы";
            this.labelReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 538F));
            this.tableLayoutPanel1.Controls.Add(this.labelList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewUsers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonRegister, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonEdit, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.78295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.21706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1027, 465);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelList.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.labelList.Location = new System.Drawing.Point(3, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(483, 123);
            this.labelList.TabIndex = 0;
            this.labelList.Text = "Список пользователей:";
            this.labelList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNum.Location = new System.Drawing.Point(492, 0);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(532, 123);
            this.labelNum.TabIndex = 1;
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.login,
            this.fullname,
            this.block});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewUsers, 2);
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 126);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1021, 258);
            this.dataGridViewUsers.TabIndex = 2;
            this.dataGridViewUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.FillWeight = 101.5228F;
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // login
            // 
            this.login.FillWeight = 99.49239F;
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.FillWeight = 99.49239F;
            this.fullname.HeaderText = "ФИО";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // block
            // 
            this.block.FillWeight = 99.49239F;
            this.block.HeaderText = "Блокировка";
            this.block.Name = "block";
            this.block.ReadOnly = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.buttonRegister.Location = new System.Drawing.Point(3, 390);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(483, 72);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "ДОБАВИТЬ АККАУНТ";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.buttonEdit.Location = new System.Drawing.Point(492, 390);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(532, 72);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "РЕДАКТИРОВАТЬ АККАУНТ";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 641);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 420);
            this.Name = "FormUsers";
            this.Text = "Окно регистрации";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutTitle.ResumeLayout(false);
            this.tableLayoutTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutFooter.ResumeLayout(false);
            this.tableLayoutFooter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Button NavButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewButtonColumn block;
    }
}

