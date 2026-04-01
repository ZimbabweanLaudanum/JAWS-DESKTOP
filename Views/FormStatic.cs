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
    public partial class FormStatic : Form
    {
        string[] months = { "Янв", "Фев", "Мар", "Апр", "Май", "Июн", "Июл", "Авг", "Сен", "Окт", "Ноя", "Дек" };

        public FormStatic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlStatClinic = "SELECT c.Clinic_Address, COUNT(a.Clinic_id) FROM Appointment a JOIN Clinic c on a.Clinic_id = c.Clinic_id GROUP BY c.Clinic_Address;";
            SqlDataAdapter adapClinic = new SqlDataAdapter(sqlStatClinic, Classes.Helper.conString);
            DataTable dtStaticClinic = new DataTable();
            adapClinic.Fill(dtStaticClinic);
            chartClinic.Series[0].Points.Clear();

            for (int i = 0; i < dtStaticClinic.Rows.Count; i++)
            {
                DataRow drStatic = dtStaticClinic.Rows[i];
                chartClinic.Series[0].Points.AddY(drStatic[1]);
                chartClinic.Series[0].Points[i].LegendText = drStatic[0].ToString();
            }

            string sqlStatMon = "SELECT MONTH(a.Visit_date) as Months, COUNT(a.Appointment_id) \r\nFROM Appointment a \r\nGROUP BY MONTH(a.Visit_date);";
            SqlDataAdapter adapMon = new SqlDataAdapter(sqlStatMon, Classes.Helper.conString);
            DataTable dtStaticMon = new DataTable();
            adapMon.Fill(dtStaticMon);
            chartMon.Series[0].Points.Clear();
            chartMon.ChartAreas["ChartArea1"].AxisX.Interval = 1;


            for (int i = 1; i <= 12; i++)
            {
                DataRow[] r;
                int n = 0;
                //MessageBox.Show(dtStaticMon.Select("Months = " + i)[0].ToString());
                if (dtStaticMon.Select("Months = " + i) != null)
                {
                    r = dtStaticMon.Select("Months = " + i);
                    foreach (DataRow dr in r)
                    {
                        //MessageBox.Show(dr[0].ToString());
                        n = Convert.ToInt32(dr[1]);
                    }
                }
                chartMon.Series[0].Points.AddXY(months[i-1], n);
                //chartClinic.Series[0].Points[i].LegendText = drStatic[0].ToString();
            }
        }

        /// <summary>
        /// Закрытие текущего окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
