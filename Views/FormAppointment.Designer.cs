namespace Dentistry_clinic
{
    partial class FormAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppointment));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutTitle = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAppointment = new System.Windows.Forms.Label();
            this.NavButton = new System.Windows.Forms.Button();
            this.tableLayoutFooter = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutAppointment = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutFilter = new System.Windows.Forms.TableLayoutPanel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelDoc = new System.Windows.Forms.Label();
            this.labelServ = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Label();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.dateTimeApp = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.flowLayoutAppointment = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutFooter.SuspendLayout();
            this.tableLayoutAppointment.SuspendLayout();
            this.tableLayoutFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutTitle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutFooter, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutAppointment, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1117, 735);
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
            this.tableLayoutTitle.Controls.Add(this.labelAppointment, 1, 0);
            this.tableLayoutTitle.Controls.Add(this.NavButton, 2, 0);
            this.tableLayoutTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTitle.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutTitle.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutTitle.Name = "tableLayoutTitle";
            this.tableLayoutTitle.RowCount = 1;
            this.tableLayoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTitle.Size = new System.Drawing.Size(1111, 94);
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
            // labelAppointment
            // 
            this.labelAppointment.AutoSize = true;
            this.labelAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.labelAppointment.Location = new System.Drawing.Point(203, 0);
            this.labelAppointment.Name = "labelAppointment";
            this.labelAppointment.Size = new System.Drawing.Size(631, 94);
            this.labelAppointment.TabIndex = 1;
            this.labelAppointment.Text = "Список записей";
            this.labelAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavButton
            // 
            this.NavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.NavButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.NavButton.Location = new System.Drawing.Point(840, 3);
            this.NavButton.Name = "NavButton";
            this.NavButton.Size = new System.Drawing.Size(268, 88);
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
            this.tableLayoutFooter.Location = new System.Drawing.Point(3, 668);
            this.tableLayoutFooter.Name = "tableLayoutFooter";
            this.tableLayoutFooter.RowCount = 1;
            this.tableLayoutFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFooter.Size = new System.Drawing.Size(1111, 64);
            this.tableLayoutFooter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(558, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 64);
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
            this.label1.Size = new System.Drawing.Size(549, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lau_Opi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutAppointment
            // 
            this.tableLayoutAppointment.ColumnCount = 2;
            this.tableLayoutAppointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutAppointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutAppointment.Controls.Add(this.tableLayoutFilter, 1, 0);
            this.tableLayoutAppointment.Controls.Add(this.flowLayoutAppointment, 0, 0);
            this.tableLayoutAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAppointment.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutAppointment.Name = "tableLayoutAppointment";
            this.tableLayoutAppointment.RowCount = 1;
            this.tableLayoutAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAppointment.Size = new System.Drawing.Size(1111, 559);
            this.tableLayoutAppointment.TabIndex = 2;
            // 
            // tableLayoutFilter
            // 
            this.tableLayoutFilter.ColumnCount = 1;
            this.tableLayoutFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFilter.Controls.Add(this.labelDate, 0, 7);
            this.tableLayoutFilter.Controls.Add(this.labelClient, 0, 5);
            this.tableLayoutFilter.Controls.Add(this.labelDoc, 0, 3);
            this.tableLayoutFilter.Controls.Add(this.labelServ, 0, 1);
            this.tableLayoutFilter.Controls.Add(this.comboBoxClient, 0, 6);
            this.tableLayoutFilter.Controls.Add(this.comboBoxDoctor, 0, 4);
            this.tableLayoutFilter.Controls.Add(this.Search, 0, 0);
            this.tableLayoutFilter.Controls.Add(this.comboBoxService, 0, 2);
            this.tableLayoutFilter.Controls.Add(this.dateTimeApp, 0, 8);
            this.tableLayoutFilter.Controls.Add(this.buttonSearch, 0, 9);
            this.tableLayoutFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFilter.Location = new System.Drawing.Point(780, 3);
            this.tableLayoutFilter.Name = "tableLayoutFilter";
            this.tableLayoutFilter.RowCount = 10;
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFilter.Size = new System.Drawing.Size(328, 553);
            this.tableLayoutFilter.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDate.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.labelDate.Location = new System.Drawing.Point(3, 385);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(322, 55);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Дата";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClient.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.labelClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.labelClient.Location = new System.Drawing.Point(3, 275);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(322, 55);
            this.labelClient.TabIndex = 8;
            this.labelClient.Text = "Клиент";
            this.labelClient.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDoc.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.labelDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.labelDoc.Location = new System.Drawing.Point(3, 165);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(322, 55);
            this.labelDoc.TabIndex = 7;
            this.labelDoc.Text = "Доктор";
            this.labelDoc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelServ
            // 
            this.labelServ.AutoSize = true;
            this.labelServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelServ.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.labelServ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.labelServ.Location = new System.Drawing.Point(3, 55);
            this.labelServ.Name = "labelServ";
            this.labelServ.Size = new System.Drawing.Size(322, 55);
            this.labelServ.TabIndex = 6;
            this.labelServ.Text = "Услуга";
            this.labelServ.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.comboBoxClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.comboBoxClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(3, 333);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(322, 50);
            this.comboBoxClient.TabIndex = 3;
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.comboBoxDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.comboBoxDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(3, 223);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(322, 50);
            this.comboBoxDoctor.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.Search.Location = new System.Drawing.Point(3, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(322, 55);
            this.Search.TabIndex = 0;
            this.Search.Text = "Поиск/фильтр";
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxService
            // 
            this.comboBoxService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.comboBoxService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxService.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.comboBoxService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(3, 113);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(322, 50);
            this.comboBoxService.TabIndex = 1;
            // 
            // dateTimeApp
            // 
            this.dateTimeApp.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dateTimeApp.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.dateTimeApp.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.dateTimeApp.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dateTimeApp.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dateTimeApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeApp.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.dateTimeApp.Location = new System.Drawing.Point(3, 443);
            this.dateTimeApp.Name = "dateTimeApp";
            this.dateTimeApp.Size = new System.Drawing.Size(322, 48);
            this.dateTimeApp.TabIndex = 4;
            this.dateTimeApp.ValueChanged += new System.EventHandler(this.dateTimeApp_ValueChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.buttonSearch.Location = new System.Drawing.Point(3, 498);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(322, 52);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // flowLayoutAppointment
            // 
            this.flowLayoutAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutAppointment.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutAppointment.Name = "flowLayoutAppointment";
            this.flowLayoutAppointment.Size = new System.Drawing.Size(771, 553);
            this.flowLayoutAppointment.TabIndex = 1;
            // 
            // FormAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 735);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 420);
            this.Name = "FormAppointment";
            this.Text = "Окно списка записей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutTitle.ResumeLayout(false);
            this.tableLayoutTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutFooter.ResumeLayout(false);
            this.tableLayoutFooter.PerformLayout();
            this.tableLayoutAppointment.ResumeLayout(false);
            this.tableLayoutFilter.ResumeLayout(false);
            this.tableLayoutFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAppointment;
        private System.Windows.Forms.Button NavButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAppointment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAppointment;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.DateTimePicker dateTimeApp;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Label labelServ;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelDate;
    }
}

