namespace Test01
{
    partial class FormSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplash));
            this.SplashElipse = new Bunifu.Framework.UI.BunifuElipse();
            this.lbl_Welcome = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_WelcomeName = new Bunifu.UI.WinForms.BunifuLabel();
            this.Circle_ProgressBar = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.fade_in = new System.Windows.Forms.Timer();
            this.fade_out = new System.Windows.Forms.Timer();
            this.SplashDragControl = new Bunifu.Framework.UI.BunifuDragControl();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashElipse
            // 
            this.SplashElipse.ElipseRadius = 5;
            this.SplashElipse.TargetControl = this;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AllowParentOverrides = false;
            this.lbl_Welcome.AutoEllipsis = false;
            this.lbl_Welcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Welcome.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_Welcome.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_Welcome.Location = new System.Drawing.Point(737, 55);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Welcome.Size = new System.Drawing.Size(280, 81);
            this.lbl_Welcome.TabIndex = 2;
            this.lbl_Welcome.Text = "WELCOME";
            this.lbl_Welcome.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Welcome.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_WelcomeName
            // 
            this.lbl_WelcomeName.AllowParentOverrides = false;
            this.lbl_WelcomeName.AutoEllipsis = false;
            this.lbl_WelcomeName.CursorType = null;
            this.lbl_WelcomeName.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lbl_WelcomeName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_WelcomeName.Location = new System.Drawing.Point(1052, 55);
            this.lbl_WelcomeName.Name = "lbl_WelcomeName";
            this.lbl_WelcomeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_WelcomeName.Size = new System.Drawing.Size(168, 81);
            this.lbl_WelcomeName.TabIndex = 3;
            this.lbl_WelcomeName.Text = "Daniel";
            this.lbl_WelcomeName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_WelcomeName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Circle_ProgressBar
            // 
            this.Circle_ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Circle_ProgressBar.Animated = true;
            this.Circle_ProgressBar.AnimationInterval = 1;
            this.Circle_ProgressBar.AnimationSpeed = 1;
            this.Circle_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.Circle_ProgressBar.CircleMargin = 10;
            this.Circle_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.Circle_ProgressBar.ForeColor = System.Drawing.Color.Gold;
            this.Circle_ProgressBar.IsPercentage = true;
            this.Circle_ProgressBar.LineProgressThickness = 12;
            this.Circle_ProgressBar.LineThickness = 12;
            this.Circle_ProgressBar.Location = new System.Drawing.Point(893, 268);
            this.Circle_ProgressBar.Name = "Circle_ProgressBar";
            this.Circle_ProgressBar.ProgressAnimationSpeed = 200;
            this.Circle_ProgressBar.ProgressBackColor = System.Drawing.Color.Red;
            this.Circle_ProgressBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.Circle_ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Circle_ProgressBar.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.Circle_ProgressBar.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.Circle_ProgressBar.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.Circle_ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Circle_ProgressBar.Size = new System.Drawing.Size(184, 184);
            this.Circle_ProgressBar.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Circle_ProgressBar.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.Circle_ProgressBar.SubScriptText = "";
            this.Circle_ProgressBar.SuperScriptColor = System.Drawing.Color.Gold;
            this.Circle_ProgressBar.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.Circle_ProgressBar.SuperScriptText = "%";
            this.Circle_ProgressBar.TabIndex = 16;
            this.Circle_ProgressBar.Text = "30";
            this.Circle_ProgressBar.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Circle_ProgressBar.Value = 30;
            this.Circle_ProgressBar.ValueByTransition = 30;
            this.Circle_ProgressBar.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // fade_in
            // 
            this.fade_in.Interval = 70;
            this.fade_in.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fade_out
            // 
            this.fade_out.Interval = 70;
            this.fade_out.Tick += new System.EventHandler(this.fade_out_Tick);
            // 
            // SplashDragControl
            // 
            this.SplashDragControl.Fixed = true;
            this.SplashDragControl.Horizontal = true;
            this.SplashDragControl.TargetControl = this;
            this.SplashDragControl.Vertical = true;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(814, 505);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(300, 81);
            this.bunifuLabel1.TabIndex = 17;
            this.bunifuLabel1.Text = "Loading . . .";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Test01.Properties.Resources.GO_TRAVEL_free_file;
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test01.Properties.Resources.login_Image;
            this.pictureBox1.Location = new System.Drawing.Point(2, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(737, 55);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(280, 81);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "WELCOME";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1294, 632);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.Circle_ProgressBar);
            this.Controls.Add(this.lbl_WelcomeName);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse SplashElipse;
        private Bunifu.UI.WinForms.BunifuLabel lbl_Welcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuCircleProgress Circle_ProgressBar;
        private Bunifu.UI.WinForms.BunifuLabel lbl_WelcomeName;
        private System.Windows.Forms.Timer fade_in;
        private System.Windows.Forms.Timer fade_out;
        private Bunifu.Framework.UI.BunifuDragControl SplashDragControl;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}