using AxWMPLib;
using System;
using System.Collections.Generic;
using Test01;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Test01
{
     
    

    
    public partial class Login_form : Form
    {
        List<Color> Bg_colors = new List<Color>();
        Random rd = new Random();
        SoundPlayer player = new SoundPlayer(Properties.Resources.Go_Travel_Video1);

        public Login_form()
        {

            InitializeComponent();
            //Media_PlayerLogin.URL = "C:\\Users\\DX7\\Pictures\\travel\\Splash_logo\\uuhhuhh\\Go_Travel_Video.mp4";
            //Media_PlayerLogin.settings.autoStart = false;
            //Media_PlayerLogin.uiMode = "none";
            // Media_PlayerLogin.Size = new Size(576, 260);
            Bg_colors.Add(Color.Red);
            Bg_colors.Add(Color.Green);
            Bg_colors.Add(Color.DodgerBlue);
            Bg_colors.Add(Color.Gold);
            Bg_colors.Add(Color.Pink);
            password_txtbox.UseSystemPasswordChar = true;
        }
    
            

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {
            player.PlayLooping();
            if (password_txtbox.Text == string.Empty)
            {
                password_txtbox.UseSystemPasswordChar = false;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                //Media_PlayerLogin.Location = new Point(508, 5);
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MediaPlayerTickPlaying(object sender, EventArgs e)
        {
            //Media_PlayerLogin.Ctlcontrols.play();
            Login_Shape.BorderColor = Bg_colors[rd.Next(Bg_colors.Count)];
        }

        private void Password_Entry(object sender, KeyEventArgs e)
        {
           
        }



        private void details_Entry(object sender, KeyEventArgs e)
        {
            Username_txtbox.BorderThickness = 3;
        }

        private void details_Complete(object sender, EventArgs e)
        {
            Username_txtbox.BorderThickness = 1;
        }

        private void Password_set(object sender, KeyEventArgs e)
        {
            password_txtbox.BorderThickness = 3;
        }

        private void Password_Finish(object sender, EventArgs e)
        {

            password_txtbox.BorderThickness = 1;
        }

        private void btn_password_check_Click(object sender, EventArgs e)
        {
            if(password_txtbox.UseSystemPasswordChar)
            {
                password_txtbox.UseSystemPasswordChar = false;
            }
            else
            {
                password_txtbox.UseSystemPasswordChar = true;

            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(Username_txtbox.Text == "daniel" && password_txtbox.Text == "daniel")
            {
                lbl_Error.Visible = false;
                Login_Transition.HideSync(Login_Shape);
                Login_Transition.HideSync(usergif);
                Login_Transition.HideSync(Username_txtbox);
                Login_Transition.HideSync(password_txtbox);
                Login_Transition.HideSync(btn_password_check);
                Login_Transition.HideSync(btn_Login);
                MediaPlayerTimer.Stop();
                player.Play();

                this.Hide();
                FormSplash SplashScreen = new FormSplash();
                SplashScreen.Show();
                
            }
            else
            {
                lbl_Error.Visible = true;
            }
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            MediaPlayerTimer.Start();
        }

        private void Login_form_Leave(object sender, EventArgs e)
        {
            MediaPlayerTimer.Stop();
        }

        private void Login_form_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
