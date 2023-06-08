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
    public partial class Go_travelDashboard : Form
    {
        public Go_travelDashboard()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState= FormWindowState.Maximized;
            }
        }

        private void dahboard_starting(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from travel_details;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dashboard_datagrid.DataSource = dt;
            con.Close();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from travel_details where journey_name=@journey_name;;", con);
            cmd.Parameters.AddWithValue("@journey_name", txt_search.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dashboard_datagrid.DataSource = dt;
            con.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from travel_details;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dashboard_datagrid.DataSource = dt;
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {   
            SqlConnection con = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete travel_details where journey_name = @journey_name", con);
            cmd.Parameters.AddWithValue("@journey_name", txt_search.Text.ToString());
            cmd.ExecuteNonQuery();
            con.Close();

            SqlConnection con_transportcommunication = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True");
            con_transportcommunication.Open();
            SqlCommand cmd_transport_communication = new SqlCommand("Delete transport_communication where journey_name=@journey_name", con_transportcommunication);
            cmd_transport_communication.Parameters.AddWithValue("@journey_name", txt_search.Text);
            cmd_transport_communication.ExecuteNonQuery();
            con_transportcommunication.Close();

            SqlConnection con_healthfitness = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True");
            con_healthfitness.Open();
            SqlCommand cmd_healthfitness = new SqlCommand("Delete health_fitness where journey_name=@journey_name", con_healthfitness);
            cmd_healthfitness.Parameters.AddWithValue("@journey_name", txt_search.Text);
            cmd_healthfitness.ExecuteNonQuery();
            con_healthfitness.Close();

            SqlConnection con_moneybanking = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True");
            con_moneybanking.Open();
            SqlCommand cmd_money_banking = new SqlCommand("Delete money_banking where journey_name=@journey_name", con_moneybanking);
            cmd_money_banking.Parameters.AddWithValue("@journey_name", txt_search.Text);
            cmd_money_banking.ExecuteNonQuery();
            con_moneybanking.Close();

            SqlConnection con_foodaccomodation = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True");
            con_foodaccomodation.Open();
            SqlCommand cmd_food_accomodation = new SqlCommand("Delete food_accomodation where journey_name=@journey_name", con_foodaccomodation);
            cmd_food_accomodation.Parameters.AddWithValue("@journey_name", txt_search.Text);
            cmd_food_accomodation.ExecuteNonQuery();
            con_foodaccomodation.Close();

            MessageBox.Show("Successfully deleted refresh to view again", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void hover_over(object sender, EventArgs e)
        {
            lbl_deleteinfo.Visible = true;
        }

        private void hover_finish(object sender, EventArgs e)
        {
            lbl_deleteinfo.Visible = false;
        }
    }
}
