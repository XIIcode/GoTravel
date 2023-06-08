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
    public partial class final_menu : Form
    {
        List<Bitmap> back_groundImages = new List<Bitmap>();
        public final_menu()
        {
            back_groundImages.Add(Properties.Resources.mammal_3218712_1920);
            back_groundImages.Add(Properties.Resources.loveourplanet_4851331_1920);
            back_groundImages.Add(Properties.Resources.castelmezzano_1979546_1920);
            back_groundImages.Add(Properties.Resources.compass_5261062_1920);
            back_groundImages.Add(Properties.Resources.hd_wallpaper_1758197_1920);
            back_groundImages.Add(Properties.Resources.tree_3072431_1920);
            back_groundImages.Add(Properties.Resources.toronto_3112508_1920);
            back_groundImages.Add(Properties.Resources.rice_terraces_2389023_1920);
            InitializeComponent();
            pnl_submenu.Visible = false;
        }
        #region quotes text
        string[] quotes = { "Jobs fill your pockets, adventures fill your soul.",
        "Remember that happiness is a way of travel, not a destination.","The world is a book and those who do not travel read only one page.",
        "Travel is the only thing you buy that makes you richer.",
        "The journey of a thousand miles begins with a single step",
        "Adventures are the best way to learn.",
        "I haven’t been everywhere, but it’s on my list.",
        "Have stories to tell not stuff to show.",
        "Leave nothing but footprints, take nothing but photos, kill nothing but time.",
        "Always take the scenic road.",
        "Live your life by a compass, not a clock.",
        "Go where you feel most alive.",
        "Travel is the healthiest addiction",
        "The biggest adventure you can take is to live the life of your dreams",
        "The world is a book and those who do not travel read only one page.",
        "Travel is  fatal to prejudice, bigotry, and narrow mindedness, and many of our people need it sorely on these accounts.",
        "The real voyage of discovery consists not in seeking new landscapes, but in having new eyes.",
        "Never go on trips with anyone you do not love.",
        "Like all great travellers, I have seen more than I remember and remember more than I have seen.",
        "Traveling – it leaves you speechless, then turns you into a storyteller."};
        #endregion

        Random rd = new Random();
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Go_travelDashboard dashboard = new Go_travelDashboard();
            dashboard.Show();
        }

        private void btn_eventsplanner_Click(object sender, EventArgs e)
        {
            Events_Planning events_Planning = new Events_Planning();
            events_Planning.Show();
        }

        private void btn_analytics_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            analytics.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if(pnl_sidepanel.Visible)
            {
                panel_transition.HideSync(pnl_sidepanel);
            }
            else
            {
                panel_transition.ShowSync(pnl_sidepanel);
            }
        }

        private void image_timer_Tick(object sender, EventArgs e)
        {
            img_background.Image = back_groundImages[rd.Next(back_groundImages.Count)];
            lbl_quotes.Text = quotes[rd.Next(quotes.Length)];
        }

        private void btn_Extra_Click(object sender, EventArgs e)
        {
            if(pnl_submenu.Visible == false)
            {
                panel_transition.ShowSync(pnl_submenu);
            }
        }

        private void btn_mediaplayer_Click(object sender, EventArgs e)
        {
            panel_transition.HideSync(pnl_submenu);
            media_playerfrm media_Playerfrm = new media_playerfrm();
            media_Playerfrm.Show();
        }

        private void btn_junglebird_Click(object sender, EventArgs e)
        {
            panel_transition.HideSync(pnl_submenu);
            jungle_birdfrm jungleBirdfrm = new jungle_birdfrm();
            jungleBirdfrm.Show();
        }

        private void btn_locationfinder_Click(object sender, EventArgs e)
        {
            panel_transition.HideSync(pnl_submenu);
            location_finderfrm _Finderfrm = new location_finderfrm();
            _Finderfrm.Show();
        }

        private void btn_medemergency_Click(object sender, EventArgs e)
        {
            medical_frm medical_Frm = new medical_frm();
            medical_Frm.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();
        }
    }
}
