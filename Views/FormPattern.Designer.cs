namespace Dentistry_clinic
{
    partial class FormPattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPattern));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutTitle = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.NavButton = new System.Windows.Forms.Button();
            this.tableLayoutFooter = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutTitle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutFooter, 0, 2);
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
            this.label.Text = "Заголовок";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 641);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 420);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutTitle.ResumeLayout(false);
            this.tableLayoutTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutFooter.ResumeLayout(false);
            this.tableLayoutFooter.PerformLayout();
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
    }
}

