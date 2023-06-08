namespace Test01
{
    partial class Analytics
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytics));
            this.pnl_cash = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_maximize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customer_progress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.progress_timer = new System.Windows.Forms.Timer(this.components);
            this.circle_transition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.pnl_cash.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_cash
            // 
            this.pnl_cash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_cash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnl_cash.Controls.Add(this.label7);
            this.pnl_cash.Controls.Add(this.label1);
            this.circle_transition.SetDecoration(this.pnl_cash, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnl_cash.Location = new System.Drawing.Point(430, 141);
            this.pnl_cash.Name = "pnl_cash";
            this.pnl_cash.Size = new System.Drawing.Size(399, 199);
            this.pnl_cash.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.circle_transition.SetDecoration(this.label7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(34, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 41);
            this.label7.TabIndex = 2;
            this.label7.Text = "1 $ = 133.75 KSH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.circle_transition.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Finance";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.btn_maximize);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox1);
            this.circle_transition.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 135);
            this.panel2.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.ActiveImage = null;
            this.btn_close.AllowAnimations = true;
            this.btn_close.AllowBuffering = false;
            this.btn_close.AllowToggling = false;
            this.btn_close.AllowZooming = true;
            this.btn_close.AllowZoomingOnFocus = false;
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.circle_transition.SetDecoration(this.btn_close, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_close.ErrorImage")));
            this.btn_close.FadeWhenInactive = true;
            this.btn_close.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_close.Image = global::Test01.Properties.Resources.cross;
            this.btn_close.ImageActive = null;
            this.btn_close.ImageLocation = null;
            this.btn_close.ImageMargin = 40;
            this.btn_close.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_close.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btn_close.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_close.InitialImage")));
            this.btn_close.Location = new System.Drawing.Point(1220, 30);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rotation = 0;
            this.btn_close.ShowActiveImage = true;
            this.btn_close.ShowCursorChanges = true;
            this.btn_close.ShowImageBorders = false;
            this.btn_close.ShowSizeMarkers = false;
            this.btn_close.Size = new System.Drawing.Size(90, 90);
            this.btn_close.TabIndex = 25;
            this.btn_close.ToolTipText = "";
            this.btn_close.WaitOnLoad = false;
            this.btn_close.Zoom = 40;
            this.btn_close.ZoomSpeed = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.ActiveImage = null;
            this.btn_maximize.AllowAnimations = true;
            this.btn_maximize.AllowBuffering = false;
            this.btn_maximize.AllowToggling = false;
            this.btn_maximize.AllowZooming = true;
            this.btn_maximize.AllowZoomingOnFocus = false;
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.circle_transition.SetDecoration(this.btn_maximize, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_maximize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_maximize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_maximize.ErrorImage")));
            this.btn_maximize.FadeWhenInactive = true;
            this.btn_maximize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_maximize.Image = global::Test01.Properties.Resources.minimize__2_;
            this.btn_maximize.ImageActive = null;
            this.btn_maximize.ImageLocation = null;
            this.btn_maximize.ImageMargin = 40;
            this.btn_maximize.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_maximize.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btn_maximize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_maximize.InitialImage")));
            this.btn_maximize.Location = new System.Drawing.Point(1105, 31);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Rotation = 0;
            this.btn_maximize.ShowActiveImage = true;
            this.btn_maximize.ShowCursorChanges = true;
            this.btn_maximize.ShowImageBorders = false;
            this.btn_maximize.ShowSizeMarkers = false;
            this.btn_maximize.Size = new System.Drawing.Size(90, 90);
            this.btn_maximize.TabIndex = 24;
            this.btn_maximize.ToolTipText = "";
            this.btn_maximize.WaitOnLoad = false;
            this.btn_maximize.Zoom = 40;
            this.btn_maximize.ZoomSpeed = 10;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.circle_transition.SetDecoration(this.label10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(461, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(381, 59);
            this.label10.TabIndex = 23;
            this.label10.Text = "Go Travel Analytics";
            // 
            // pictureBox1
            // 
            this.circle_transition.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = global::Test01.Properties.Resources.GO_TRAVEL_free_file;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // customer_progress
            // 
            this.customer_progress.Animated = true;
            this.customer_progress.AnimationInterval = 1;
            this.customer_progress.AnimationSpeed = 1;
            this.customer_progress.BackColor = System.Drawing.Color.Transparent;
            this.customer_progress.CircleMargin = 10;
            this.circle_transition.SetDecoration(this.customer_progress, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.customer_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_progress.ForeColor = System.Drawing.Color.Gold;
            this.customer_progress.IsPercentage = true;
            this.customer_progress.LineProgressThickness = 10;
            this.customer_progress.LineThickness = 10;
            this.customer_progress.Location = new System.Drawing.Point(194, 71);
            this.customer_progress.Name = "customer_progress";
            this.customer_progress.ProgressAnimationSpeed = 200;
            this.customer_progress.ProgressBackColor = System.Drawing.Color.Red;
            this.customer_progress.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.customer_progress.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.customer_progress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.customer_progress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.customer_progress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.customer_progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.customer_progress.Size = new System.Drawing.Size(203, 203);
            this.customer_progress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.customer_progress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.customer_progress.SubScriptText = ".00";
            this.customer_progress.SuperScriptColor = System.Drawing.Color.Red;
            this.customer_progress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.customer_progress.SuperScriptText = "%";
            this.customer_progress.TabIndex = 16;
            this.customer_progress.Text = "30";
            this.customer_progress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.customer_progress.Value = 30;
            this.customer_progress.ValueByTransition = 30;
            this.customer_progress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.circle_transition.SetDecoration(this.panel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(855, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 199);
            this.panel4.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.circle_transition.SetDecoration(this.label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(20, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(410, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kenya Airways offers the best travelling experience";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.circle_transition.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Flight Company";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label3);
            this.circle_transition.SetDecoration(this.panel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(12, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(498, 228);
            this.panel5.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.circle_transition.SetDecoration(this.label9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(3, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(429, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Local Banks are here to support you in your finances.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.circle_transition.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Local Bank";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label4);
            this.circle_transition.SetDecoration(this.panel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(12, 145);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(387, 190);
            this.panel6.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.circle_transition.SetDecoration(this.label8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(21, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Plan as much as you want.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.circle_transition.SetDecoration(this.label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Journeys";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customer_progress);
            this.circle_transition.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(730, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 296);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.circle_transition.SetDecoration(this.label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(159, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer Care Support";
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = true;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Generate a Report";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.circle_transition.SetDecoration(this.bunifuButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 51;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(508, 702);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.Red;
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(210, 53);
            this.bunifuButton1.TabIndex = 21;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // progress_timer
            // 
            this.progress_timer.Enabled = true;
            this.progress_timer.Interval = 70;
            this.progress_timer.Tick += new System.EventHandler(this.progress_timer_Tick);
            // 
            // circle_transition
            // 
            this.circle_transition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Particles;
            this.circle_transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.circle_transition.DefaultAnimation = animation1;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1333, 785);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_cash);
            this.Controls.Add(this.panel2);
            this.circle_transition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Analytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics";
            this.Load += new System.EventHandler(this.when_starting);
            this.pnl_cash.ResumeLayout(false);
            this.pnl_cash.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_cash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuCircleProgress customer_progress;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_close;
        private Bunifu.UI.WinForms.BunifuImageButton btn_maximize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Timer progress_timer;
        private Bunifu.UI.WinForms.BunifuTransition circle_transition;
    }
}