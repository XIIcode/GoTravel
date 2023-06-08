using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01
{
    public partial class location_finderfrm : Form
    {
        List<Color> txt_colors = new List<Color>();
        Random rd = new Random();
        public location_finderfrm()
        {
            InitializeComponent();
            txt_colors.Add(Color.DeepPink);
            txt_colors.Add(Color.Green);
            txt_colors.Add(Color.Orange);
            txt_colors.Add(Color.RoyalBlue);
            txt_colors.Add(Color.Yellow);
            txt_colors.Add(Color.Magenta);
            txt_colors.Add(Color.MediumPurple);
            txt_colors.Add(Color.OliveDrab);
            //To suppress errors from the google maps
            gmapsWeb.ScriptErrorsSuppressed = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to Leave", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
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

        private void street_enter(object sender, KeyEventArgs e)
        {
            txt_street.BorderThickness = 3;
        }

        private void street_leave(object sender, EventArgs e)
        {
            txt_street.BorderThickness = 1;
        }

        private void when_starting(object sender, EventArgs e)
        {
            location_Timer.Start();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to clear all fields", "Delete text", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                txt_street.Text = string.Empty;
                txt_City.Text = string.Empty;
                txt_Country.Text = string.Empty;
                txt_Zip.Text = string.Empty;
            }

        }

        private void location_Timer_Tick(object sender, EventArgs e)
        {
            txt_street.BorderColorIdle = txt_colors[rd.Next(txt_colors.Count)];
            txt_City.BorderColorIdle = txt_colors[rd.Next(txt_colors.Count)];
            txt_Country.BorderColorIdle = txt_colors[rd.Next(txt_colors.Count)];
            txt_street.BorderColorIdle = txt_colors[rd.Next(txt_colors.Count)];
            txt_Zip.BorderColorIdle = txt_colors[rd.Next(txt_colors.Count)];

        }

        private void btn_getlocation_Click(object sender, EventArgs e)
        {
            StringBuilder urlquerry = new StringBuilder();
            urlquerry.Append("https://google.com/maps?q=");
            if (txt_street.Text != string.Empty)
            {
                urlquerry.Append(txt_street.Text + "," + "+");
            }
            if (txt_City.Text != string.Empty)
            {
                urlquerry.Append(txt_City.Text);
            }
            if (txt_Country.Text != string.Empty)
            {
                urlquerry.Append(txt_Country.Text);
            }
            if (txt_Zip.Text != string.Empty)
            {
                urlquerry.Append(txt_Zip.Text);
            }
            gmapsWeb.Navigate(urlquerry.ToString());

        }

        private void city_enter(object sender, KeyEventArgs e)
        {
            txt_City.BorderThickness = 3;
        }

        private void city_leave(object sender, EventArgs e)
        {
            txt_City.BorderThickness = 1;
        }

        private void country_enter(object sender, KeyEventArgs e)
        {
            txt_Country.BorderThickness = 3;
        }

        private void country_leave(object sender, EventArgs e)
        {
            txt_Country.BorderThickness=1;
        }

        private void zip_enter(object sender, KeyEventArgs e)
        {
            txt_Zip.BorderThickness = 3;
        }

        private void zip_leave(object sender, EventArgs e)
        {
            txt_Zip.BorderThickness=1;
        }
    }
}
