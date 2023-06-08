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
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }
        int cont = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            Circle_ProgressBar.Value += 1;
            Circle_ProgressBar.Text = Circle_ProgressBar.Value.ToString();
            if(Circle_ProgressBar.Value == 100)
            {
                fade_in.Stop();
                fade_out.Start();
            }
        }

        private void fade_out_Tick(object sender, EventArgs e)
        {
            Login_form lgnFrm = new Login_form();
            this.Opacity -= 1.0;
            if(this.Opacity == 0)
            {
                fade_out.Stop();
                final_menu final_Menu = new final_menu();
                final_Menu.Show();
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            fade_in.Start();
            Circle_ProgressBar.Value = 0;
            Circle_ProgressBar.Minimum = 0;
            Circle_ProgressBar.Maximum = 100;
        }
    }
}
