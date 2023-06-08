namespace Test01
{
    partial class menu_frm
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_frm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.img_background = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btn_dashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_analysis = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_background)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 117);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Test01.Properties.Resources.Go_Travel_Display;
            this.pictureBox1.Location = new System.Drawing.Point(407, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = true;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::Test01.Properties.Resources.minimize__2_;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(44, 41);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(84, 81);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(937, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = false;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(84, 81);
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = true;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = global::Test01.Properties.Resources.cross;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 40;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(44, 41);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(84, 81);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(1051, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = false;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(84, 81);
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 40;
            this.bunifuImageButton2.ZoomSpeed = 10;
            // 
            // img_background
            // 
            this.img_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_background.Location = new System.Drawing.Point(0, 117);
            this.img_background.Name = "img_background";
            this.img_background.Size = new System.Drawing.Size(1178, 528);
            this.img_background.TabIndex = 1;
            this.img_background.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_analysis);
            this.panel2.Controls.Add(this.btn_dashboard);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 528);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test01.Properties.Resources.GO_TRAVEL_free_file;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 148);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btn_menu
            // 
            this.btn_menu.Image = global::Test01.Properties.Resources.Menu;
            this.btn_menu.Location = new System.Drawing.Point(1, 66);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(52, 53);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome User";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Gold;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(24, 206);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(241, 17);
            this.bunifuSeparator1.TabIndex = 3;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.AllowAnimations = true;
            this.btn_dashboard.AllowMouseEffects = true;
            this.btn_dashboard.AllowToggling = false;
            this.btn_dashboard.AnimationSpeed = 200;
            this.btn_dashboard.AutoGenerateColors = false;
            this.btn_dashboard.AutoRoundBorders = false;
            this.btn_dashboard.AutoSizeLeftIcon = true;
            this.btn_dashboard.AutoSizeRightIcon = true;
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_dashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.BackgroundImage")));
            this.btn_dashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dashboard.ButtonText = "Dashboard";
            this.btn_dashboard.ButtonTextMarginLeft = 0;
            this.btn_dashboard.ColorContrastOnClick = 45;
            this.btn_dashboard.ColorContrastOnHover = 45;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_dashboard.CustomizableEdges = borderEdges2;
            this.btn_dashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dashboard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_dashboard.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_dashboard.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_dashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_dashboard.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_dashboard.IconMarginLeft = 11;
            this.btn_dashboard.IconPadding = 10;
            this.btn_dashboard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dashboard.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_dashboard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_dashboard.IconSize = 25;
            this.btn_dashboard.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_dashboard.IdleBorderRadius = 1;
            this.btn_dashboard.IdleBorderThickness = 1;
            this.btn_dashboard.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_dashboard.IdleIconLeftImage = global::Test01.Properties.Resources.Dashboard;
            this.btn_dashboard.IdleIconRightImage = null;
            this.btn_dashboard.IndicateFocus = false;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 243);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_dashboard.OnDisabledState.BorderRadius = 1;
            this.btn_dashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dashboard.OnDisabledState.BorderThickness = 1;
            this.btn_dashboard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_dashboard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_dashboard.OnDisabledState.IconLeftImage = null;
            this.btn_dashboard.OnDisabledState.IconRightImage = null;
            this.btn_dashboard.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.btn_dashboard.onHoverState.BorderRadius = 1;
            this.btn_dashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dashboard.onHoverState.BorderThickness = 1;
            this.btn_dashboard.onHoverState.FillColor = System.Drawing.Color.Green;
            this.btn_dashboard.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.onHoverState.IconLeftImage = null;
            this.btn_dashboard.onHoverState.IconRightImage = null;
            this.btn_dashboard.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_dashboard.OnIdleState.BorderRadius = 1;
            this.btn_dashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dashboard.OnIdleState.BorderThickness = 1;
            this.btn_dashboard.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_dashboard.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.OnIdleState.IconLeftImage = global::Test01.Properties.Resources.Dashboard;
            this.btn_dashboard.OnIdleState.IconRightImage = null;
            this.btn_dashboard.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.btn_dashboard.OnPressedState.BorderRadius = 1;
            this.btn_dashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dashboard.OnPressedState.BorderThickness = 1;
            this.btn_dashboard.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.btn_dashboard.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.OnPressedState.IconLeftImage = null;
            this.btn_dashboard.OnPressedState.IconRightImage = null;
            this.btn_dashboard.Size = new System.Drawing.Size(314, 61);
            this.btn_dashboard.TabIndex = 3;
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_dashboard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dashboard.TextMarginLeft = 0;
            this.btn_dashboard.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_dashboard.UseDefaultRadiusAndThickness = true;
            // 
            // btn_analysis
            // 
            this.btn_analysis.AllowAnimations = true;
            this.btn_analysis.AllowMouseEffects = true;
            this.btn_analysis.AllowToggling = false;
            this.btn_analysis.AnimationSpeed = 200;
            this.btn_analysis.AutoGenerateColors = false;
            this.btn_analysis.AutoRoundBorders = false;
            this.btn_analysis.AutoSizeLeftIcon = true;
            this.btn_analysis.AutoSizeRightIcon = true;
            this.btn_analysis.BackColor = System.Drawing.Color.Transparent;
            this.btn_analysis.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_analysis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_analysis.BackgroundImage")));
            this.btn_analysis.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_analysis.ButtonText = "Dashboard";
            this.btn_analysis.ButtonTextMarginLeft = 0;
            this.btn_analysis.ColorContrastOnClick = 45;
            this.btn_analysis.ColorContrastOnHover = 45;
            this.btn_analysis.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_analysis.CustomizableEdges = borderEdges1;
            this.btn_analysis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_analysis.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_analysis.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_analysis.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_analysis.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_analysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analysis.ForeColor = System.Drawing.Color.White;
            this.btn_analysis.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_analysis.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_analysis.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_analysis.IconMarginLeft = 11;
            this.btn_analysis.IconPadding = 10;
            this.btn_analysis.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_analysis.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_analysis.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_analysis.IconSize = 25;
            this.btn_analysis.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_analysis.IdleBorderRadius = 1;
            this.btn_analysis.IdleBorderThickness = 1;
            this.btn_analysis.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_analysis.IdleIconLeftImage = global::Test01.Properties.Resources.Dashboard;
            this.btn_analysis.IdleIconRightImage = null;
            this.btn_analysis.IndicateFocus = false;
            this.btn_analysis.Location = new System.Drawing.Point(1, 326);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_analysis.OnDisabledState.BorderRadius = 1;
            this.btn_analysis.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_analysis.OnDisabledState.BorderThickness = 1;
            this.btn_analysis.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_analysis.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_analysis.OnDisabledState.IconLeftImage = null;
            this.btn_analysis.OnDisabledState.IconRightImage = null;
            this.btn_analysis.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.btn_analysis.onHoverState.BorderRadius = 1;
            this.btn_analysis.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_analysis.onHoverState.BorderThickness = 1;
            this.btn_analysis.onHoverState.FillColor = System.Drawing.Color.Green;
            this.btn_analysis.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_analysis.onHoverState.IconLeftImage = null;
            this.btn_analysis.onHoverState.IconRightImage = null;
            this.btn_analysis.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_analysis.OnIdleState.BorderRadius = 1;
            this.btn_analysis.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_analysis.OnIdleState.BorderThickness = 1;
            this.btn_analysis.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_analysis.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_analysis.OnIdleState.IconLeftImage = global::Test01.Properties.Resources.Dashboard;
            this.btn_analysis.OnIdleState.IconRightImage = null;
            this.btn_analysis.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.btn_analysis.OnPressedState.BorderRadius = 1;
            this.btn_analysis.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_analysis.OnPressedState.BorderThickness = 1;
            this.btn_analysis.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.btn_analysis.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_analysis.OnPressedState.IconLeftImage = null;
            this.btn_analysis.OnPressedState.IconRightImage = null;
            this.btn_analysis.Size = new System.Drawing.Size(314, 61);
            this.btn_analysis.TabIndex = 4;
            this.btn_analysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_analysis.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_analysis.TextMarginLeft = 0;
            this.btn_analysis.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_analysis.UseDefaultRadiusAndThickness = true;
            // 
            // menu_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.img_background);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu_frm";
            this.Text = "menu_frm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_background)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_analysis;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_dashboard;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox img_background;
        private System.Windows.Forms.PictureBox btn_menu;
    }
}