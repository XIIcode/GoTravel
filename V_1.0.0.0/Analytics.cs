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

namespace Test01
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState= FormWindowState.Maximized;
            }
        }

        private void when_starting(object sender, EventArgs e)
        {
            customer_progress.Value = 0;
        }

        private void progress_timer_Tick(object sender, EventArgs e)
        {
            if (customer_progress.Value == 100)
            {
                customer_progress.Value = 0;
                circle_transition.HideSync(customer_progress);
                circle_transition.ShowSync(customer_progress);
            }
            customer_progress.Value += 1;
            customer_progress.Text= customer_progress.Value.ToString();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            reporting_frm reporting_Frm = new reporting_frm();
            reporting_Frm.Show();
            SqlConnection con = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select journey_name,departure_day,arrival_day,description from travel_details",con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet,"travel_details");
            con.Close();    
            CrystalReport1 crystalReport1 = new CrystalReport1();
            crystalReport1.SetDataSource(dataSet);
            reporting_Frm.crystalReportViewer1.ReportSource = crystalReport1;
            reporting_Frm.crystalReportViewer1.Refresh();
            

        }
    }
}
