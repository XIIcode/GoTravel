using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test01
{
    public partial class Events_Planning : Form
    {
        public Events_Planning()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized )
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_transportcomm_Click(object sender, EventArgs e)
        {
            Eventspages.SetPage(1);
        }

        private void btn_journeydetails_Click(object sender, EventArgs e)
        {
            Eventspages.SetPage(0);
        }

        private void btn_foodAccomodation_Click(object sender, EventArgs e)
        {
            Eventspages.SetPage(2);
        }

        private void btn_moneybanking_Click(object sender, EventArgs e)
        {
            Eventspages.SetPage(3);
        }

        private void btn_healthfitness_Click(object sender, EventArgs e)
        {
            Eventspages.SetPage(4);
        }

        private void btn_submitDetails_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you wish to submit Record you can not change anymore","Form submission",MessageBoxButtons.OKCancel , MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True;Pooling=False");
                SqlConnection con_transport = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True;Pooling=False");
                SqlConnection con_foodAccomodation = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True;Pooling=False");
                SqlConnection con_moneyBanking = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True;Pooling=False");
                SqlConnection con_healthfitness = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=GoTravelDashboard;Integrated Security=True;Pooling=False");
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into travel_details values(@journey_name,@departure_day,@arrival_day,@description,@count_companions)", con);
                if (txt_journeyname.Text == string.Empty)
                {
                    txt_journeyname.Text = "none";
                    cmd.Parameters.AddWithValue("@journey_name", txt_journeyname.Text);
                }
                else

                {
                    cmd.Parameters.AddWithValue("@journey_name", txt_journeyname.Text);
                }
                cmd.Parameters.AddWithValue("@departure_day", datepick_departure.Value.ToString());
                cmd.Parameters.AddWithValue("@arrival_day", datepick_arrival.Value.ToString());
                if (txt_description.Text == string.Empty)
                {
                    txt_description.Text = "none";
                    cmd.Parameters.AddWithValue("@description", txt_description.Text.ToString());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@description", txt_description.Text.ToString());
                }
                if (txt_companions.Text == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@count_companions", Convert.ToInt32(txt_companions.Text = "0"));
                }
                else
                { 
                        cmd.Parameters.AddWithValue("@count_companions", Convert.ToInt32(txt_companions.Text = "0"));
                }
                cmd.ExecuteNonQuery();
                con.Close();
                con_transport.Open();
                SqlCommand cmd_transport = new SqlCommand("Insert into transport_communication values(@flight_company,@taxi_company,@translation_company,@journey_name)", con_transport);
                if (txt_drp_airline.Text == string.Empty)
                {
                    cmd_transport.Parameters.AddWithValue("@flight_company", txt_drp_airline.Text = "none");
                }
                else
                {
                    cmd_transport.Parameters.AddWithValue("@flight_company", txt_drp_airline.Text);
                }
                if (txt_drp_taxiCompany.Text == string.Empty)
                {
                    cmd_transport.Parameters.AddWithValue("@taxi_company", txt_drp_taxiCompany.Text = "none");
                }
                else
                {
                    cmd_transport.Parameters.AddWithValue("@taxi_company", txt_drp_taxiCompany.Text);
                }
                if (txt_drp_translationCompany.Text == string.Empty)
                {
                    cmd_transport.Parameters.AddWithValue("@translation_company", txt_drp_translationCompany.Text = "none");
                }
                else
                {
                    cmd_transport.Parameters.AddWithValue("@translation_company", txt_drp_translationCompany.Text);
                }
                if (txt_journeyname.Text == string.Empty)
                {
                    txt_journeyname.Text = "none";
                    cmd_transport.Parameters.AddWithValue("@journey_name", txt_journeyname.Text);
                }
                else

                {
                    cmd_transport.Parameters.AddWithValue("@journey_name", txt_journeyname.Text);
                }
                cmd_transport.ExecuteNonQuery();
                con_transport.Close();
                con_foodAccomodation.Open();
                SqlCommand cmd_foodaccomodation = new SqlCommand("insert into food_accomodation values(@accomodation_hotel,@special_foods,@special_requirements,@journey_name)", con_foodAccomodation);
                if (txt_drp_hotel.Text == string.Empty)
                {
                    cmd_foodaccomodation.Parameters.AddWithValue("@accomodation_hotel", txt_drp_hotel.Text = "none");
                }
                else
                {
                    cmd_foodaccomodation.Parameters.AddWithValue("@accomodation_hotel", txt_drp_hotel.Text);
                }
                if (txt_specialfoods.Text == string.Empty)
                {
                    cmd_foodaccomodation.Parameters.AddWithValue("@special_foods", txt_specialfoods.Text = "none");
                }
                else
                {
                    cmd_foodaccomodation.Parameters.AddWithValue("@special_foods", txt_specialfoods.Text);
                }
                if (txt_specialrequirements.Text == string.Empty)
                {
                    cmd_foodaccomodation.Parameters.AddWithValue("@special_requirements", txt_specialrequirements.Text = "none");
                }
                else
                {
                    cmd_foodaccomodation.Parameters.AddWithValue("@special_requirements", txt_specialrequirements.Text);
                }
                if (txt_journeyname.Text == string.Empty)
                {
                    txt_journeyname.Text = "none";
                    cmd_foodaccomodation.Parameters.AddWithValue("@journey_name", txt_journeyname.Text);
                }
                else

                {
                    cmd_foodaccomodation.Parameters.AddWithValue("@journey_name", txt_journeyname.Text);
                }
                cmd_foodaccomodation.ExecuteNonQuery();
                con_foodAccomodation.Close();
                con_moneyBanking.Open();
                SqlCommand cmd_moneybanking = new SqlCommand("insert into money_banking values(@local_bank,@vacation_money,@financial_advisor,@journey_name)",con_moneyBanking);
                if (txt_drp_localBank.Text == string.Empty)
                {
                    cmd_moneybanking.Parameters.AddWithValue("@local_bank", txt_drp_localBank.Text = "none");
                }
                else
                {
                    cmd_moneybanking.Parameters.AddWithValue("@local_bank", txt_drp_localBank.Text);
                }
                if (txt_vacationCash.Text == string.Empty)
                {
                    cmd_moneybanking.Parameters.AddWithValue("@vacation_money", Convert.ToInt32(txt_vacationCash.Text = "0"));
                }
                else
                {
                    try
                    {
                        cmd_moneybanking.Parameters.AddWithValue("@vacation_money", Convert.ToInt32(txt_vacationCash.Text));

                    }
                    catch(Exception ex) {
                        cmd_moneybanking.Parameters.AddWithValue("@vacation_money", Convert.ToInt32(txt_vacationCash.Text="0"));

                    }
                }
                if (txt_drp_financialadvisor.Text == string.Empty)
                {
                    cmd_moneybanking.Parameters.AddWithValue("@financial_advisor", txt_drp_financialadvisor.Text = "none");
                }
                else
                {
                    cmd_moneybanking.Parameters.AddWithValue("@financial_advisor", txt_drp_financialadvisor.Text);
                }
                if (txt_journeyname.Text == string.Empty)
                {
                    txt_journeyname.Text = "none";
                    cmd_moneybanking.Parameters.AddWithValue("@journey_name", txt_journeyname.Text);
                }
                else

                {
                    cmd_moneybanking.Parameters.AddWithValue("@journey_name", txt_journeyname.Text);
                }
                cmd_moneybanking.ExecuteNonQuery();
                con_moneyBanking.Close();
                con_healthfitness.Open();
                SqlCommand cmd_healthfitness = new SqlCommand("insert into health_fitness(@emergency_details,@fitness_company,@fitness_products,@journey_name)",con_healthfitness);
                if (txt_emergencydetails.Text == string.Empty)
                {
                    cmd_healthfitness.Parameters.AddWithValue("@emergency_details", txt_emergencydetails.Text = "none");
                }
                else
                {
                    cmd_healthfitness.Parameters.AddWithValue("@emergency_detailsl", txt_emergencydetails.Text);
                }
                if (txt_drp_fitnesscompany.Text == string.Empty)
                {
                    cmd_healthfitness.Parameters.AddWithValue("@fitness_company", txt_drp_fitnesscompany.Text = "none");
                }
                else
                {
                    cmd_healthfitness.Parameters.AddWithValue("@fitness_company", txt_drp_fitnesscompany.Text);
                }
                if (txt_fitnessproducts.Text == string.Empty)
                {
                    cmd_healthfitness.Parameters.AddWithValue("@fitness_products", txt_fitnessproducts.Text = "none");
                }
                else
                {
                    cmd_healthfitness.Parameters.AddWithValue("@fitness_products", txt_fitnessproducts.Text);
                }
                if (txt_journeyname.Text == string.Empty)
                {
                    txt_journeyname.Text = "none";
                    cmd_healthfitness.Parameters.AddWithValue("@journey_name", txt_journeyname.Text);
                }
                else

                {
                    cmd_healthfitness.Parameters.AddWithValue("@journey_name", txt_journeyname.Text);
                }

                MessageBox.Show("Successfully added Records","success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_journeyname.Text = string.Empty;
                txt_companions.Text = string.Empty;
                txt_description.Text = string.Empty;
                txt_destination.Text = string.Empty;
                txt_drp_airline.Text = string.Empty;
                txt_drp_financialadvisor.Text = string.Empty;
                txt_drp_fitnesscompany.Text = string.Empty;
                txt_drp_hotel.Text = string.Empty;
                txt_drp_localBank.Text = string.Empty;
                txt_drp_taxiCompany.Text = string.Empty;
                txt_drp_translationCompany.Text = string.Empty;
                txt_emergencydetails.Text = string.Empty;
                txt_fitnessproducts.Text = string.Empty;
                txt_specialfoods.Text = string.Empty;
                txt_specialrequirements.Text = string.Empty;
                txt_vacationCash.Text = string.Empty;
                
            }
            
        }
    }
}
