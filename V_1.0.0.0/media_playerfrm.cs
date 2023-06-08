using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Test01
{
    public partial class media_playerfrm : Form
    {
        public media_playerfrm()
        {
            InitializeComponent();
            lbl_songCount.Text = String.Empty;
            Player.uiMode = "none";
           // Player.URL = "X:\\Programming\\Projects\\School_Project\\Project parts\\Login_Page\\Test01\\TIMELAPSE OF ARTIFICIAL INTELLIGENCE (2028 – 3000+).mp4";
            Player.Ctlcontrols.play();
        }
        string[] files, paths;

        private void selecteditem(object sender, EventArgs e)
        {
            if (Tittle_list.SelectedIndex > 0)
            {
                lbl_songCount.Text = "TRACK NUMBER : " + (Tittle_list.SelectedIndex + 1).ToString() + " / " + Tittle_list.Items.Count.ToString();
            }
            else
            {
                lbl_songCount.Text = "TRACK NUMBER : 1 " + " / " + Tittle_list.Items.Count.ToString();
            }
            try
            {
                TagLib.File file = TagLib.File.Create(paths[Tittle_list.SelectedIndex]);
                lbl_Tittle.Text = "Tittle : " + file.Tag.Title;
                lbl_Artist.Text = "Artist : " + file.Tag.FirstAlbumArtist;
                lbl_genre.Text = "Genre : " + file.Tag.FirstGenre;
                Lbl_Year.Text = "Year : " + file.Tag.Year;
                var tt = TagLib.File.Create(paths[Tittle_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                album_cover.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch { }
        }

        private void searchbarkeyup(object sender, KeyEventArgs e)
        {
            int index = Tittle_list.FindString(txt_search.Text);
            if (0 <= index)
            {
                Tittle_list.SelectedIndex = index;
            }
        }

        private void searchbarmouseclick(object sender, MouseEventArgs e)
        {
            txt_search.Text = string.Empty;
        }

        private void btn_radio_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bbc.co.uk/sounds/play/live:bbc_world_service");
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                foreach (var x in files)
                {
                    Tittle_list.Items.Add(x);

                }

            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tittle_list.SelectedIndex > 0)
                {
                    Tittle_list.SelectedIndex -= 1;
                }
            }
            catch { }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tittle_list.SelectedIndex < Tittle_list.Items.Count + 1)
                {
                    Tittle_list.SelectedIndex += 1;
                }
            }
            catch { }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                Player.Ctlcontrols.play();
            }
            else
            {
                if (Tittle_list.Items.Count > 0)
                {
                    if (Tittle_list.SelectedIndex < 0)
                    {
                        Tittle_list.SelectedIndex = 0;
                    }
                    Player.URL = paths[Tittle_list.SelectedIndex];
                    Player.Ctlcontrols.play();
                    Lbl_CurrentPlaying.Text = Player.currentMedia.name.ToString();
                }

            }

        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();

        }

        private void timer_Progressbar_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    p_bar.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                    p_bar.Value = (int)Player.Ctlcontrols.currentPosition;
                    track_end.Text = Player.Ctlcontrols.currentItem.durationString;
                }
            }
            catch { }
            try
            {
                track_start.Text = Player.Ctlcontrols.currentPositionString;
            }
            catch { }

        }

        private void p_barMouseDown(object sender, MouseEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / p_bar.Width;

        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Tittle_list.Items.RemoveAt(Tittle_list.SelectedIndex);
            }
            catch { }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                Player.Ctlcontrols.play();
            }
            else
            {
                if (Tittle_list.Items.Count > 0)
                {
                    if (Tittle_list.SelectedIndex < 0)
                    {
                        Tittle_list.SelectedIndex = 0;
                    }
                    Player.URL = paths[Tittle_list.SelectedIndex];
                    Player.Ctlcontrols.play();
                    Lbl_CurrentPlaying.Text = Player.currentMedia.name.ToString();
                }

            }

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
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

        private void volume_barscroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if(Player.settings.volume == 0)
            {
                btn_mute.Image = Properties.Resources.mute_rounded;
            }
            else
            {
                btn_mute.Image = Properties.Resources.volume_up;
            }
            Player.settings.volume = volume_bar.Value;
            lbl_Volume.Text = volume_bar.Value.ToString() + "%";
        }

        private void doubleclick(object sender, EventArgs e)
        {
            try
            {
                Player.URL = paths[Tittle_list.SelectedIndex];
                Player.Ctlcontrols.play();
                Lbl_CurrentPlaying.Text = Player.currentMedia.name.ToString();
            }
            catch { }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (Player.settings.volume == 0)
            {
                btn_mute.Image = Properties.Resources.mute_rounded;
            }
            else
            {
                btn_mute.Image = Properties.Resources.volume_up;
            }
            Player.settings.volume = 0;
            volume_bar.Value = 0;
            lbl_Volume.Text = "0%";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            Tittle_list.Items.Clear();
            lbl_songCount.Text = string.Empty;

        }
    }
}
