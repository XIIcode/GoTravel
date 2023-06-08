namespace Test01
{
    partial class media_playerfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(media_playerfrm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton6 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_RemoveItem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Browse = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_radio = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.volume_bar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btn_mute = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Lbl_CurrentPlaying = new System.Windows.Forms.Label();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_Album = new System.Windows.Forms.Label();
            this.Lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.lbl_Tittle = new System.Windows.Forms.Label();
            this.lbl_songCount = new System.Windows.Forms.Label();
            this.track_end = new System.Windows.Forms.Label();
            this.track_start = new System.Windows.Forms.Label();
            this.p_bar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.album_cover = new System.Windows.Forms.PictureBox();
            this.Tittle_list = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Stop = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Pause = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Next = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Play = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_previous = new Bunifu.Framework.UI.BunifuThinButton2();
            this.timer_Progressbar = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.album_cover)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bunifuImageButton6);
            this.panel1.Controls.Add(this.bunifuImageButton5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1728, 152);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.ActiveImage = null;
            this.bunifuImageButton6.AllowAnimations = true;
            this.bunifuImageButton6.AllowBuffering = false;
            this.bunifuImageButton6.AllowToggling = false;
            this.bunifuImageButton6.AllowZooming = true;
            this.bunifuImageButton6.AllowZoomingOnFocus = false;
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.ErrorImage")));
            this.bunifuImageButton6.FadeWhenInactive = true;
            this.bunifuImageButton6.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton6.Image = global::Test01.Properties.Resources.cross;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.ImageLocation = null;
            this.bunifuImageButton6.ImageMargin = 40;
            this.bunifuImageButton6.ImageSize = new System.Drawing.Size(48, 43);
            this.bunifuImageButton6.ImageZoomSize = new System.Drawing.Size(88, 83);
            this.bunifuImageButton6.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.InitialImage")));
            this.bunifuImageButton6.Location = new System.Drawing.Point(1628, 3);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Rotation = 0;
            this.bunifuImageButton6.ShowActiveImage = true;
            this.bunifuImageButton6.ShowCursorChanges = true;
            this.bunifuImageButton6.ShowImageBorders = false;
            this.bunifuImageButton6.ShowSizeMarkers = false;
            this.bunifuImageButton6.Size = new System.Drawing.Size(88, 83);
            this.bunifuImageButton6.TabIndex = 4;
            this.bunifuImageButton6.ToolTipText = "";
            this.bunifuImageButton6.WaitOnLoad = false;
            this.bunifuImageButton6.Zoom = 40;
            this.bunifuImageButton6.ZoomSpeed = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.ActiveImage = null;
            this.bunifuImageButton5.AllowAnimations = true;
            this.bunifuImageButton5.AllowBuffering = false;
            this.bunifuImageButton5.AllowToggling = false;
            this.bunifuImageButton5.AllowZooming = true;
            this.bunifuImageButton5.AllowZoomingOnFocus = false;
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.ErrorImage")));
            this.bunifuImageButton5.FadeWhenInactive = true;
            this.bunifuImageButton5.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton5.Image = global::Test01.Properties.Resources.minimize__2_;
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.ImageLocation = null;
            this.bunifuImageButton5.ImageMargin = 40;
            this.bunifuImageButton5.ImageSize = new System.Drawing.Size(48, 43);
            this.bunifuImageButton5.ImageZoomSize = new System.Drawing.Size(88, 83);
            this.bunifuImageButton5.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.InitialImage")));
            this.bunifuImageButton5.Location = new System.Drawing.Point(1515, 3);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Rotation = 0;
            this.bunifuImageButton5.ShowActiveImage = true;
            this.bunifuImageButton5.ShowCursorChanges = true;
            this.bunifuImageButton5.ShowImageBorders = false;
            this.bunifuImageButton5.ShowSizeMarkers = false;
            this.bunifuImageButton5.Size = new System.Drawing.Size(88, 83);
            this.bunifuImageButton5.TabIndex = 3;
            this.bunifuImageButton5.ToolTipText = "";
            this.bunifuImageButton5.WaitOnLoad = false;
            this.bunifuImageButton5.Zoom = 40;
            this.bunifuImageButton5.ZoomSpeed = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(581, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "GO TRAVEL MEDIA PLAYER";
            // 
            // txt_search
            // 
            this.txt_search.AcceptsReturn = false;
            this.txt_search.AcceptsTab = false;
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.AnimationSpeed = 200;
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_search.BackColor = System.Drawing.Color.Transparent;
            this.txt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_search.BackgroundImage")));
            this.txt_search.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_search.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_search.BorderRadius = 1;
            this.txt_search.BorderThickness = 1;
            this.txt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_search.DefaultText = "";
            this.txt_search.FillColor = System.Drawing.Color.White;
            this.txt_search.HideSelection = true;
            this.txt_search.IconLeft = null;
            this.txt_search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.IconPadding = 10;
            this.txt_search.IconRight = null;
            this.txt_search.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(1398, 111);
            this.txt_search.MaxLength = 32767;
            this.txt_search.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_search.Modified = false;
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_search.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnIdleState = stateProperties4;
            this.txt_search.Padding = new System.Windows.Forms.Padding(3);
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "Search";
            this.txt_search.ReadOnly = false;
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(327, 41);
            this.txt_search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_search.TabIndex = 1;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginBottom = 0;
            this.txt_search.TextMarginLeft = 3;
            this.txt_search.TextMarginTop = 0;
            this.txt_search.TextPlaceholder = "Search";
            this.txt_search.UseSystemPasswordChar = false;
            this.txt_search.WordWrap = true;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchbarkeyup);
            this.txt_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchbarmouseclick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test01.Properties.Resources.GO_TRAVEL_free_file;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 146);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_RemoveItem);
            this.panel2.Controls.Add(this.btn_Browse);
            this.panel2.Controls.Add(this.btn_radio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 950);
            this.panel2.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.AllowAnimations = true;
            this.btn_clear.AllowMouseEffects = true;
            this.btn_clear.AllowToggling = false;
            this.btn_clear.AnimationSpeed = 200;
            this.btn_clear.AutoGenerateColors = false;
            this.btn_clear.AutoRoundBorders = true;
            this.btn_clear.AutoSizeLeftIcon = true;
            this.btn_clear.AutoSizeRightIcon = true;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_clear.ButtonText = "Clear Playlist";
            this.btn_clear.ButtonTextMarginLeft = 0;
            this.btn_clear.ColorContrastOnClick = 45;
            this.btn_clear.ColorContrastOnHover = 45;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_clear.CustomizableEdges = borderEdges1;
            this.btn_clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_clear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_clear.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_clear.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_clear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_clear.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_clear.IconMarginLeft = 11;
            this.btn_clear.IconPadding = 10;
            this.btn_clear.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_clear.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_clear.IconSize = 25;
            this.btn_clear.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_clear.IdleBorderRadius = 56;
            this.btn_clear.IdleBorderThickness = 1;
            this.btn_clear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_clear.IdleIconLeftImage = null;
            this.btn_clear.IdleIconRightImage = null;
            this.btn_clear.IndicateFocus = false;
            this.btn_clear.Location = new System.Drawing.Point(25, 586);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_clear.OnDisabledState.BorderRadius = 1;
            this.btn_clear.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_clear.OnDisabledState.BorderThickness = 1;
            this.btn_clear.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_clear.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_clear.OnDisabledState.IconLeftImage = null;
            this.btn_clear.OnDisabledState.IconRightImage = null;
            this.btn_clear.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_clear.onHoverState.BorderRadius = 1;
            this.btn_clear.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_clear.onHoverState.BorderThickness = 1;
            this.btn_clear.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_clear.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_clear.onHoverState.IconLeftImage = null;
            this.btn_clear.onHoverState.IconRightImage = null;
            this.btn_clear.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_clear.OnIdleState.BorderRadius = 1;
            this.btn_clear.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_clear.OnIdleState.BorderThickness = 1;
            this.btn_clear.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_clear.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_clear.OnIdleState.IconLeftImage = null;
            this.btn_clear.OnIdleState.IconRightImage = null;
            this.btn_clear.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(89)))), ((int)(((byte)(252)))));
            this.btn_clear.OnPressedState.BorderRadius = 1;
            this.btn_clear.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_clear.OnPressedState.BorderThickness = 1;
            this.btn_clear.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(89)))), ((int)(((byte)(252)))));
            this.btn_clear.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_clear.OnPressedState.IconLeftImage = null;
            this.btn_clear.OnPressedState.IconRightImage = null;
            this.btn_clear.Size = new System.Drawing.Size(239, 58);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_clear.TextMarginLeft = 0;
            this.btn_clear.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_clear.UseDefaultRadiusAndThickness = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.AllowAnimations = true;
            this.btn_RemoveItem.AllowMouseEffects = true;
            this.btn_RemoveItem.AllowToggling = false;
            this.btn_RemoveItem.AnimationSpeed = 200;
            this.btn_RemoveItem.AutoGenerateColors = false;
            this.btn_RemoveItem.AutoRoundBorders = true;
            this.btn_RemoveItem.AutoSizeLeftIcon = true;
            this.btn_RemoveItem.AutoSizeRightIcon = true;
            this.btn_RemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.btn_RemoveItem.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_RemoveItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RemoveItem.BackgroundImage")));
            this.btn_RemoveItem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_RemoveItem.ButtonText = "Remove Item";
            this.btn_RemoveItem.ButtonTextMarginLeft = 0;
            this.btn_RemoveItem.ColorContrastOnClick = 45;
            this.btn_RemoveItem.ColorContrastOnHover = 45;
            this.btn_RemoveItem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_RemoveItem.CustomizableEdges = borderEdges2;
            this.btn_RemoveItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_RemoveItem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_RemoveItem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_RemoveItem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_RemoveItem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_RemoveItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveItem.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveItem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RemoveItem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_RemoveItem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_RemoveItem.IconMarginLeft = 11;
            this.btn_RemoveItem.IconPadding = 10;
            this.btn_RemoveItem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RemoveItem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_RemoveItem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_RemoveItem.IconSize = 25;
            this.btn_RemoveItem.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_RemoveItem.IdleBorderRadius = 56;
            this.btn_RemoveItem.IdleBorderThickness = 1;
            this.btn_RemoveItem.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_RemoveItem.IdleIconLeftImage = null;
            this.btn_RemoveItem.IdleIconRightImage = null;
            this.btn_RemoveItem.IndicateFocus = false;
            this.btn_RemoveItem.Location = new System.Drawing.Point(25, 422);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_RemoveItem.OnDisabledState.BorderRadius = 1;
            this.btn_RemoveItem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_RemoveItem.OnDisabledState.BorderThickness = 1;
            this.btn_RemoveItem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_RemoveItem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_RemoveItem.OnDisabledState.IconLeftImage = null;
            this.btn_RemoveItem.OnDisabledState.IconRightImage = null;
            this.btn_RemoveItem.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_RemoveItem.onHoverState.BorderRadius = 1;
            this.btn_RemoveItem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_RemoveItem.onHoverState.BorderThickness = 1;
            this.btn_RemoveItem.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_RemoveItem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveItem.onHoverState.IconLeftImage = null;
            this.btn_RemoveItem.onHoverState.IconRightImage = null;
            this.btn_RemoveItem.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_RemoveItem.OnIdleState.BorderRadius = 1;
            this.btn_RemoveItem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_RemoveItem.OnIdleState.BorderThickness = 1;
            this.btn_RemoveItem.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_RemoveItem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveItem.OnIdleState.IconLeftImage = null;
            this.btn_RemoveItem.OnIdleState.IconRightImage = null;
            this.btn_RemoveItem.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(89)))), ((int)(((byte)(252)))));
            this.btn_RemoveItem.OnPressedState.BorderRadius = 1;
            this.btn_RemoveItem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_RemoveItem.OnPressedState.BorderThickness = 1;
            this.btn_RemoveItem.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(89)))), ((int)(((byte)(252)))));
            this.btn_RemoveItem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveItem.OnPressedState.IconLeftImage = null;
            this.btn_RemoveItem.OnPressedState.IconRightImage = null;
            this.btn_RemoveItem.Size = new System.Drawing.Size(239, 58);
            this.btn_RemoveItem.TabIndex = 2;
            this.btn_RemoveItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_RemoveItem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_RemoveItem.TextMarginLeft = 0;
            this.btn_RemoveItem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_RemoveItem.UseDefaultRadiusAndThickness = true;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.AllowAnimations = true;
            this.btn_Browse.AllowMouseEffects = true;
            this.btn_Browse.AllowToggling = false;
            this.btn_Browse.AnimationSpeed = 200;
            this.btn_Browse.AutoGenerateColors = false;
            this.btn_Browse.AutoRoundBorders = true;
            this.btn_Browse.AutoSizeLeftIcon = true;
            this.btn_Browse.AutoSizeRightIcon = true;
            this.btn_Browse.BackColor = System.Drawing.Color.Transparent;
            this.btn_Browse.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_Browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Browse.BackgroundImage")));
            this.btn_Browse.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Browse.ButtonText = "Browse Files";
            this.btn_Browse.ButtonTextMarginLeft = 0;
            this.btn_Browse.ColorContrastOnClick = 45;
            this.btn_Browse.ColorContrastOnHover = 45;
            this.btn_Browse.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_Browse.CustomizableEdges = borderEdges3;
            this.btn_Browse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Browse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Browse.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Browse.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Browse.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Browse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Browse.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Browse.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Browse.IconMarginLeft = 11;
            this.btn_Browse.IconPadding = 10;
            this.btn_Browse.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Browse.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Browse.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Browse.IconSize = 25;
            this.btn_Browse.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_Browse.IdleBorderRadius = 56;
            this.btn_Browse.IdleBorderThickness = 1;
            this.btn_Browse.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_Browse.IdleIconLeftImage = null;
            this.btn_Browse.IdleIconRightImage = null;
            this.btn_Browse.IndicateFocus = false;
            this.btn_Browse.Location = new System.Drawing.Point(25, 271);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Browse.OnDisabledState.BorderRadius = 1;
            this.btn_Browse.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Browse.OnDisabledState.BorderThickness = 1;
            this.btn_Browse.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Browse.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Browse.OnDisabledState.IconLeftImage = null;
            this.btn_Browse.OnDisabledState.IconRightImage = null;
            this.btn_Browse.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Browse.onHoverState.BorderRadius = 1;
            this.btn_Browse.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Browse.onHoverState.BorderThickness = 1;
            this.btn_Browse.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Browse.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.onHoverState.IconLeftImage = null;
            this.btn_Browse.onHoverState.IconRightImage = null;
            this.btn_Browse.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_Browse.OnIdleState.BorderRadius = 1;
            this.btn_Browse.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Browse.OnIdleState.BorderThickness = 1;
            this.btn_Browse.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_Browse.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.OnIdleState.IconLeftImage = null;
            this.btn_Browse.OnIdleState.IconRightImage = null;
            this.btn_Browse.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(89)))), ((int)(((byte)(252)))));
            this.btn_Browse.OnPressedState.BorderRadius = 1;
            this.btn_Browse.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Browse.OnPressedState.BorderThickness = 1;
            this.btn_Browse.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(89)))), ((int)(((byte)(252)))));
            this.btn_Browse.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.OnPressedState.IconLeftImage = null;
            this.btn_Browse.OnPressedState.IconRightImage = null;
            this.btn_Browse.Size = new System.Drawing.Size(239, 58);
            this.btn_Browse.TabIndex = 1;
            this.btn_Browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Browse.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Browse.TextMarginLeft = 0;
            this.btn_Browse.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Browse.UseDefaultRadiusAndThickness = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_radio
            // 
            this.btn_radio.AllowAnimations = true;
            this.btn_radio.AllowMouseEffects = true;
            this.btn_radio.AllowToggling = false;
            this.btn_radio.AnimationSpeed = 200;
            this.btn_radio.AutoGenerateColors = false;
            this.btn_radio.AutoRoundBorders = true;
            this.btn_radio.AutoSizeLeftIcon = true;
            this.btn_radio.AutoSizeRightIcon = true;
            this.btn_radio.BackColor = System.Drawing.Color.Transparent;
            this.btn_radio.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_radio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_radio.BackgroundImage")));
            this.btn_radio.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_radio.ButtonText = "Radio";
            this.btn_radio.ButtonTextMarginLeft = 0;
            this.btn_radio.ColorContrastOnClick = 45;
            this.btn_radio.ColorContrastOnHover = 45;
            this.btn_radio.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_radio.CustomizableEdges = borderEdges4;
            this.btn_radio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_radio.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_radio.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_radio.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_radio.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_radio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_radio.ForeColor = System.Drawing.Color.White;
            this.btn_radio.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_radio.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_radio.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_radio.IconMarginLeft = 11;
            this.btn_radio.IconPadding = 10;
            this.btn_radio.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_radio.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_radio.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_radio.IconSize = 25;
            this.btn_radio.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_radio.IdleBorderRadius = 56;
            this.btn_radio.IdleBorderThickness = 1;
            this.btn_radio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_radio.IdleIconLeftImage = null;
            this.btn_radio.IdleIconRightImage = null;
            this.btn_radio.IndicateFocus = false;
            this.btn_radio.Location = new System.Drawing.Point(25, 120);
            this.btn_radio.Name = "btn_radio";
            this.btn_radio.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_radio.OnDisabledState.BorderRadius = 1;
            this.btn_radio.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_radio.OnDisabledState.BorderThickness = 1;
            this.btn_radio.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_radio.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_radio.OnDisabledState.IconLeftImage = null;
            this.btn_radio.OnDisabledState.IconRightImage = null;
            this.btn_radio.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_radio.onHoverState.BorderRadius = 1;
            this.btn_radio.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_radio.onHoverState.BorderThickness = 1;
            this.btn_radio.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_radio.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_radio.onHoverState.IconLeftImage = null;
            this.btn_radio.onHoverState.IconRightImage = null;
            this.btn_radio.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_radio.OnIdleState.BorderRadius = 1;
            this.btn_radio.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_radio.OnIdleState.BorderThickness = 1;
            this.btn_radio.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_radio.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_radio.OnIdleState.IconLeftImage = null;
            this.btn_radio.OnIdleState.IconRightImage = null;
            this.btn_radio.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(89)))), ((int)(((byte)(252)))));
            this.btn_radio.OnPressedState.BorderRadius = 1;
            this.btn_radio.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_radio.OnPressedState.BorderThickness = 1;
            this.btn_radio.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(89)))), ((int)(((byte)(252)))));
            this.btn_radio.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_radio.OnPressedState.IconLeftImage = null;
            this.btn_radio.OnPressedState.IconRightImage = null;
            this.btn_radio.Size = new System.Drawing.Size(239, 58);
            this.btn_radio.TabIndex = 0;
            this.btn_radio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_radio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_radio.TextMarginLeft = 0;
            this.btn_radio.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_radio.UseDefaultRadiusAndThickness = true;
            this.btn_radio.Click += new System.EventHandler(this.btn_radio_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.lbl_Volume);
            this.panel3.Controls.Add(this.volume_bar);
            this.panel3.Controls.Add(this.btn_mute);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Controls.Add(this.bunifuImageButton3);
            this.panel3.Controls.Add(this.bunifuImageButton2);
            this.panel3.Controls.Add(this.Lbl_CurrentPlaying);
            this.panel3.Controls.Add(this.lbl_genre);
            this.panel3.Controls.Add(this.lbl_Album);
            this.panel3.Controls.Add(this.Lbl_Year);
            this.panel3.Controls.Add(this.lbl_Artist);
            this.panel3.Controls.Add(this.lbl_Tittle);
            this.panel3.Controls.Add(this.lbl_songCount);
            this.panel3.Controls.Add(this.track_end);
            this.panel3.Controls.Add(this.track_start);
            this.panel3.Controls.Add(this.p_bar);
            this.panel3.Controls.Add(this.album_cover);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(319, 870);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1409, 232);
            this.panel3.TabIndex = 2;
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Volume.ForeColor = System.Drawing.Color.White;
            this.lbl_Volume.Location = new System.Drawing.Point(1316, 119);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(50, 28);
            this.lbl_Volume.TabIndex = 32;
            this.lbl_Volume.Text = "50%";
            // 
            // volume_bar
            // 
            this.volume_bar.AllowCursorChanges = true;
            this.volume_bar.AllowHomeEndKeysDetection = false;
            this.volume_bar.AllowIncrementalClickMoves = true;
            this.volume_bar.AllowMouseDownEffects = false;
            this.volume_bar.AllowMouseHoverEffects = false;
            this.volume_bar.AllowScrollingAnimations = true;
            this.volume_bar.AllowScrollKeysDetection = true;
            this.volume_bar.AllowScrollOptionsMenu = true;
            this.volume_bar.AllowShrinkingOnFocusLost = false;
            this.volume_bar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volume_bar.BackColor = System.Drawing.Color.Transparent;
            this.volume_bar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volume_bar.BackgroundImage")));
            this.volume_bar.BindingContainer = null;
            this.volume_bar.BorderRadius = 2;
            this.volume_bar.BorderThickness = 1;
            this.volume_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume_bar.DrawThickBorder = false;
            this.volume_bar.DurationBeforeShrink = 2000;
            this.volume_bar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.volume_bar.LargeChange = 10;
            this.volume_bar.Location = new System.Drawing.Point(1166, 119);
            this.volume_bar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volume_bar.Maximum = 100;
            this.volume_bar.Minimum = 0;
            this.volume_bar.MinimumSize = new System.Drawing.Size(0, 31);
            this.volume_bar.MinimumThumbLength = 18;
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.volume_bar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.volume_bar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.volume_bar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.volume_bar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.volume_bar.ShrinkSizeLimit = 3;
            this.volume_bar.Size = new System.Drawing.Size(134, 31);
            this.volume_bar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.volume_bar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.volume_bar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.volume_bar.SmallChange = 1;
            this.volume_bar.TabIndex = 31;
            this.volume_bar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.volume_bar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.volume_bar.ThumbLength = 18;
            this.volume_bar.ThumbMargin = 1;
            this.volume_bar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.volume_bar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.volume_bar.Value = 50;
            this.volume_bar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.volume_barscroll);
            // 
            // btn_mute
            // 
            this.btn_mute.ActiveImage = null;
            this.btn_mute.AllowAnimations = true;
            this.btn_mute.AllowBuffering = false;
            this.btn_mute.AllowToggling = false;
            this.btn_mute.AllowZooming = true;
            this.btn_mute.AllowZoomingOnFocus = false;
            this.btn_mute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mute.BackColor = System.Drawing.Color.Transparent;
            this.btn_mute.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_mute.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_mute.ErrorImage")));
            this.btn_mute.FadeWhenInactive = true;
            this.btn_mute.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_mute.Image = global::Test01.Properties.Resources.volume_up;
            this.btn_mute.ImageActive = null;
            this.btn_mute.ImageLocation = null;
            this.btn_mute.ImageMargin = 40;
            this.btn_mute.ImageSize = new System.Drawing.Size(44, 38);
            this.btn_mute.ImageZoomSize = new System.Drawing.Size(84, 78);
            this.btn_mute.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_mute.InitialImage")));
            this.btn_mute.Location = new System.Drawing.Point(1079, 95);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Rotation = 0;
            this.btn_mute.ShowActiveImage = true;
            this.btn_mute.ShowCursorChanges = true;
            this.btn_mute.ShowImageBorders = false;
            this.btn_mute.ShowSizeMarkers = false;
            this.btn_mute.Size = new System.Drawing.Size(84, 78);
            this.btn_mute.TabIndex = 30;
            this.btn_mute.ToolTipText = "";
            this.btn_mute.WaitOnLoad = false;
            this.btn_mute.Zoom = 40;
            this.btn_mute.ZoomSpeed = 10;
            this.btn_mute.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = true;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::Test01.Properties.Resources.pause;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(44, 38);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(84, 78);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(666, 82);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = false;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(84, 78);
            this.bunifuImageButton1.TabIndex = 29;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = true;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = global::Test01.Properties.Resources.play;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 40;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(44, 38);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(84, 78);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(537, 82);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = false;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(84, 78);
            this.bunifuImageButton3.TabIndex = 28;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 40;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = true;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = global::Test01.Properties.Resources.stop;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 40;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(44, 38);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(84, 78);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(409, 82);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = false;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(84, 78);
            this.bunifuImageButton2.TabIndex = 27;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 40;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // Lbl_CurrentPlaying
            // 
            this.Lbl_CurrentPlaying.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lbl_CurrentPlaying.AutoSize = true;
            this.Lbl_CurrentPlaying.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Lbl_CurrentPlaying.ForeColor = System.Drawing.Color.White;
            this.Lbl_CurrentPlaying.Location = new System.Drawing.Point(489, 179);
            this.Lbl_CurrentPlaying.Name = "Lbl_CurrentPlaying";
            this.Lbl_CurrentPlaying.Size = new System.Drawing.Size(95, 28);
            this.Lbl_CurrentPlaying.TabIndex = 19;
            this.Lbl_CurrentPlaying.Text = "No Music";
            // 
            // lbl_genre
            // 
            this.lbl_genre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_genre.ForeColor = System.Drawing.Color.White;
            this.lbl_genre.Location = new System.Drawing.Point(156, 167);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(81, 28);
            this.lbl_genre.TabIndex = 25;
            this.lbl_genre.Text = "Genre : ";
            // 
            // lbl_Album
            // 
            this.lbl_Album.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Album.AutoSize = true;
            this.lbl_Album.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Album.ForeColor = System.Drawing.Color.White;
            this.lbl_Album.Location = new System.Drawing.Point(157, 132);
            this.lbl_Album.Name = "lbl_Album";
            this.lbl_Album.Size = new System.Drawing.Size(87, 28);
            this.lbl_Album.TabIndex = 24;
            this.lbl_Album.Text = "Album : ";
            // 
            // Lbl_Year
            // 
            this.Lbl_Year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Year.AutoSize = true;
            this.Lbl_Year.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Lbl_Year.ForeColor = System.Drawing.Color.White;
            this.Lbl_Year.Location = new System.Drawing.Point(157, 201);
            this.Lbl_Year.Name = "Lbl_Year";
            this.Lbl_Year.Size = new System.Drawing.Size(68, 28);
            this.Lbl_Year.TabIndex = 23;
            this.Lbl_Year.Text = "Year : ";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Artist.ForeColor = System.Drawing.Color.White;
            this.lbl_Artist.Location = new System.Drawing.Point(158, 95);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(76, 28);
            this.lbl_Artist.TabIndex = 22;
            this.lbl_Artist.Text = "Artist : ";
            // 
            // lbl_Tittle
            // 
            this.lbl_Tittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tittle.AutoSize = true;
            this.lbl_Tittle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Tittle.ForeColor = System.Drawing.Color.White;
            this.lbl_Tittle.Location = new System.Drawing.Point(163, 59);
            this.lbl_Tittle.Name = "lbl_Tittle";
            this.lbl_Tittle.Size = new System.Drawing.Size(74, 28);
            this.lbl_Tittle.TabIndex = 21;
            this.lbl_Tittle.Text = "Tittle : ";
            // 
            // lbl_songCount
            // 
            this.lbl_songCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_songCount.AutoSize = true;
            this.lbl_songCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_songCount.ForeColor = System.Drawing.Color.White;
            this.lbl_songCount.Location = new System.Drawing.Point(1114, 41);
            this.lbl_songCount.Name = "lbl_songCount";
            this.lbl_songCount.Size = new System.Drawing.Size(214, 28);
            this.lbl_songCount.TabIndex = 20;
            this.lbl_songCount.Text = "TRACK NUMBER : 0 / 0";
            // 
            // track_end
            // 
            this.track_end.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.track_end.AutoSize = true;
            this.track_end.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.track_end.ForeColor = System.Drawing.Color.White;
            this.track_end.Location = new System.Drawing.Point(808, 41);
            this.track_end.Name = "track_end";
            this.track_end.Size = new System.Drawing.Size(61, 28);
            this.track_end.TabIndex = 9;
            this.track_end.Text = "00:00";
            // 
            // track_start
            // 
            this.track_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.track_start.AutoSize = true;
            this.track_start.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.track_start.ForeColor = System.Drawing.Color.White;
            this.track_start.Location = new System.Drawing.Point(364, 38);
            this.track_start.Name = "track_start";
            this.track_start.Size = new System.Drawing.Size(61, 28);
            this.track_start.TabIndex = 8;
            this.track_start.Text = "00:00";
            // 
            // p_bar
            // 
            this.p_bar.AllowCursorChanges = true;
            this.p_bar.AllowHomeEndKeysDetection = false;
            this.p_bar.AllowIncrementalClickMoves = true;
            this.p_bar.AllowMouseDownEffects = false;
            this.p_bar.AllowMouseHoverEffects = false;
            this.p_bar.AllowScrollingAnimations = true;
            this.p_bar.AllowScrollKeysDetection = true;
            this.p_bar.AllowScrollOptionsMenu = true;
            this.p_bar.AllowShrinkingOnFocusLost = false;
            this.p_bar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p_bar.BackColor = System.Drawing.Color.Transparent;
            this.p_bar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_bar.BackgroundImage")));
            this.p_bar.BindingContainer = null;
            this.p_bar.BorderRadius = 2;
            this.p_bar.BorderThickness = 1;
            this.p_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_bar.DrawThickBorder = false;
            this.p_bar.DurationBeforeShrink = 2000;
            this.p_bar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.p_bar.LargeChange = 10;
            this.p_bar.Location = new System.Drawing.Point(455, 38);
            this.p_bar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_bar.Maximum = 100;
            this.p_bar.Minimum = 0;
            this.p_bar.MinimumSize = new System.Drawing.Size(0, 31);
            this.p_bar.MinimumThumbLength = 18;
            this.p_bar.Name = "p_bar";
            this.p_bar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.p_bar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.p_bar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.p_bar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.p_bar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.p_bar.ShrinkSizeLimit = 3;
            this.p_bar.Size = new System.Drawing.Size(324, 31);
            this.p_bar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.p_bar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.p_bar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.p_bar.SmallChange = 1;
            this.p_bar.TabIndex = 1;
            this.p_bar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.p_bar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.p_bar.ThumbLength = 32;
            this.p_bar.ThumbMargin = 1;
            this.p_bar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.p_bar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.p_bar.Value = 0;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_barMouseDown);
            // 
            // album_cover
            // 
            this.album_cover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.album_cover.Image = global::Test01.Properties.Resources.tesr;
            this.album_cover.Location = new System.Drawing.Point(2, 76);
            this.album_cover.Name = "album_cover";
            this.album_cover.Size = new System.Drawing.Size(149, 144);
            this.album_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.album_cover.TabIndex = 0;
            this.album_cover.TabStop = false;
            // 
            // Tittle_list
            // 
            this.Tittle_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.Tittle_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tittle_list.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle_list.ForeColor = System.Drawing.Color.White;
            this.Tittle_list.FormattingEnabled = true;
            this.Tittle_list.ItemHeight = 28;
            this.Tittle_list.Location = new System.Drawing.Point(319, 416);
            this.Tittle_list.Name = "Tittle_list";
            this.Tittle_list.Size = new System.Drawing.Size(1409, 454);
            this.Tittle_list.TabIndex = 3;
            this.Tittle_list.SelectedIndexChanged += new System.EventHandler(this.selecteditem);
            this.Tittle_list.DoubleClick += new System.EventHandler(this.doubleclick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.panel4.Controls.Add(this.btn_Stop);
            this.panel4.Controls.Add(this.btn_Pause);
            this.panel4.Controls.Add(this.btn_Next);
            this.panel4.Controls.Add(this.btn_Play);
            this.panel4.Controls.Add(this.btn_previous);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(319, 345);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1409, 71);
            this.panel4.TabIndex = 4;
            // 
            // btn_Stop
            // 
            this.btn_Stop.ActiveBorderThickness = 1;
            this.btn_Stop.ActiveCornerRadius = 20;
            this.btn_Stop.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Stop.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Stop.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.btn_Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Stop.BackgroundImage")));
            this.btn_Stop.ButtonText = "Stop";
            this.btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Stop.IdleBorderThickness = 1;
            this.btn_Stop.IdleCornerRadius = 20;
            this.btn_Stop.IdleFillColor = System.Drawing.Color.White;
            this.btn_Stop.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Stop.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Stop.Location = new System.Drawing.Point(1025, 17);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(197, 41);
            this.btn_Stop.TabIndex = 4;
            this.btn_Stop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.ActiveBorderThickness = 1;
            this.btn_Pause.ActiveCornerRadius = 20;
            this.btn_Pause.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Pause.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Pause.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Pause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.btn_Pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Pause.BackgroundImage")));
            this.btn_Pause.ButtonText = "Pause";
            this.btn_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pause.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Pause.IdleBorderThickness = 1;
            this.btn_Pause.IdleCornerRadius = 20;
            this.btn_Pause.IdleFillColor = System.Drawing.Color.White;
            this.btn_Pause.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Pause.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Pause.Location = new System.Drawing.Point(801, 17);
            this.btn_Pause.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(197, 41);
            this.btn_Pause.TabIndex = 3;
            this.btn_Pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.ActiveBorderThickness = 1;
            this.btn_Next.ActiveCornerRadius = 20;
            this.btn_Next.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Next.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Next.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Next.BackgroundImage")));
            this.btn_Next.ButtonText = "Next";
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Next.IdleBorderThickness = 1;
            this.btn_Next.IdleCornerRadius = 20;
            this.btn_Next.IdleFillColor = System.Drawing.Color.White;
            this.btn_Next.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Next.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Next.Location = new System.Drawing.Point(564, 17);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(197, 41);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.ActiveBorderThickness = 1;
            this.btn_Play.ActiveCornerRadius = 20;
            this.btn_Play.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Play.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Play.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Play.BackgroundImage")));
            this.btn_Play.ButtonText = "Play";
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Play.IdleBorderThickness = 1;
            this.btn_Play.IdleCornerRadius = 20;
            this.btn_Play.IdleFillColor = System.Drawing.Color.White;
            this.btn_Play.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Play.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Play.Location = new System.Drawing.Point(333, 17);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(197, 41);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.ActiveBorderThickness = 1;
            this.btn_previous.ActiveCornerRadius = 20;
            this.btn_previous.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_previous.ActiveForecolor = System.Drawing.Color.White;
            this.btn_previous.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_previous.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.btn_previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_previous.BackgroundImage")));
            this.btn_previous.ButtonText = "Previous";
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_previous.IdleBorderThickness = 1;
            this.btn_previous.IdleCornerRadius = 20;
            this.btn_previous.IdleFillColor = System.Drawing.Color.White;
            this.btn_previous.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_previous.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_previous.Location = new System.Drawing.Point(126, 17);
            this.btn_previous.Margin = new System.Windows.Forms.Padding(5);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(197, 41);
            this.btn_previous.TabIndex = 0;
            this.btn_previous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // timer_Progressbar
            // 
            this.timer_Progressbar.Enabled = true;
            this.timer_Progressbar.Tick += new System.EventHandler(this.timer_Progressbar_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Player
            // 
            this.Player.Dock = System.Windows.Forms.DockStyle.Top;
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(319, 152);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(1409, 193);
            this.Player.TabIndex = 3;
            // 
            // media_playerfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 1102);
            this.Controls.Add(this.Tittle_list);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "media_playerfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "media_playerfrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.album_cover)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox album_cover;
        private System.Windows.Forms.ListBox Tittle_list;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuTextBox txt_search;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_clear;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_RemoveItem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Browse;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_radio;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Stop;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Pause;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Next;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Play;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_previous;
        private Bunifu.UI.WinForms.BunifuHSlider p_bar;
        private System.Windows.Forms.Timer timer_Progressbar;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_Album;
        private System.Windows.Forms.Label Lbl_Year;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Label lbl_Tittle;
        private System.Windows.Forms.Label lbl_songCount;
        private System.Windows.Forms.Label track_end;
        private System.Windows.Forms.Label track_start;
        private System.Windows.Forms.Label Lbl_CurrentPlaying;
        private Bunifu.UI.WinForms.BunifuImageButton btn_mute;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbl_Volume;
        private Bunifu.UI.WinForms.BunifuHSlider volume_bar;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton6;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton5;
        private System.Windows.Forms.Label label1;
    }
}