namespace Test01
{
    partial class location_finderfrm
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(location_finderfrm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lbl_LocationFinder = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_street = new Bunifu.UI.WinForms.BunifuTextBox();
            this.gmapsWeb = new System.Windows.Forms.WebBrowser();
            this.location_Timer = new System.Windows.Forms.Timer(this.components);
            this.txt_City = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_Country = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_Zip = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_getlocation = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_clear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(53)))), ((int)(((byte)(130)))));
            this.splitContainer1.Panel1.Controls.Add(this.btn_clear);
            this.splitContainer1.Panel1.Controls.Add(this.btn_getlocation);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Zip);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Country);
            this.splitContainer1.Panel1.Controls.Add(this.txt_City);
            this.splitContainer1.Panel1.Controls.Add(this.txt_street);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_LocationFinder);
            this.splitContainer1.Panel1.Controls.Add(this.bunifuImageButton2);
            this.splitContainer1.Panel1.Controls.Add(this.bunifuImageButton1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gmapsWeb);
            this.splitContainer1.Size = new System.Drawing.Size(1086, 906);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Test01.Properties.Resources.GO_TRAVEL_free_file;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 161);
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
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = true;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::Test01.Properties.Resources.cross;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(40, 37);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(80, 77);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 167);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = false;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(80, 77);
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = true;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = global::Test01.Properties.Resources.minimize__2_;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 40;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(38, 37);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(78, 77);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(89, 167);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = false;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(78, 77);
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 40;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // lbl_LocationFinder
            // 
            this.lbl_LocationFinder.AllowParentOverrides = false;
            this.lbl_LocationFinder.AutoEllipsis = false;
            this.lbl_LocationFinder.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_LocationFinder.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_LocationFinder.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.lbl_LocationFinder.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_LocationFinder.Location = new System.Drawing.Point(42, 264);
            this.lbl_LocationFinder.Name = "lbl_LocationFinder";
            this.lbl_LocationFinder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_LocationFinder.Size = new System.Drawing.Size(183, 37);
            this.lbl_LocationFinder.TabIndex = 11;
            this.lbl_LocationFinder.Text = "Location Finder";
            this.lbl_LocationFinder.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_LocationFinder.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_street
            // 
            this.txt_street.AcceptsReturn = false;
            this.txt_street.AcceptsTab = false;
            this.txt_street.AnimationSpeed = 200;
            this.txt_street.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_street.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_street.BackColor = System.Drawing.Color.Transparent;
            this.txt_street.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_street.BackgroundImage")));
            this.txt_street.BorderColorActive = System.Drawing.Color.Green;
            this.txt_street.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_street.BorderColorHover = System.Drawing.Color.DeepPink;
            this.txt_street.BorderColorIdle = System.Drawing.Color.Orange;
            this.txt_street.BorderRadius = 1;
            this.txt_street.BorderThickness = 1;
            this.txt_street.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_street.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_street.DefaultText = "";
            this.txt_street.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(53)))), ((int)(((byte)(130)))));
            this.txt_street.ForeColor = System.Drawing.Color.White;
            this.txt_street.HideSelection = true;
            this.txt_street.IconLeft = null;
            this.txt_street.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_street.IconPadding = 10;
            this.txt_street.IconRight = null;
            this.txt_street.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_street.Lines = new string[0];
            this.txt_street.Location = new System.Drawing.Point(25, 330);
            this.txt_street.MaxLength = 32767;
            this.txt_street.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_street.Modified = false;
            this.txt_street.Multiline = false;
            this.txt_street.Name = "txt_street";
            stateProperties13.BorderColor = System.Drawing.Color.Green;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_street.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_street.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.DeepPink;
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_street.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Orange;
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(53)))), ((int)(((byte)(130)))));
            stateProperties16.ForeColor = System.Drawing.Color.White;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_street.OnIdleState = stateProperties16;
            this.txt_street.Padding = new System.Windows.Forms.Padding(3);
            this.txt_street.PasswordChar = '\0';
            this.txt_street.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_street.PlaceholderText = "Street";
            this.txt_street.ReadOnly = false;
            this.txt_street.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_street.SelectedText = "";
            this.txt_street.SelectionLength = 0;
            this.txt_street.SelectionStart = 0;
            this.txt_street.ShortcutsEnabled = true;
            this.txt_street.Size = new System.Drawing.Size(260, 44);
            this.txt_street.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_street.TabIndex = 12;
            this.txt_street.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_street.TextMarginBottom = 0;
            this.txt_street.TextMarginLeft = 3;
            this.txt_street.TextMarginTop = 0;
            this.txt_street.TextPlaceholder = "Street";
            this.txt_street.UseSystemPasswordChar = false;
            this.txt_street.WordWrap = true;
            this.txt_street.KeyDown += new System.Windows.Forms.KeyEventHandler(this.street_enter);
            this.txt_street.Leave += new System.EventHandler(this.street_leave);
            // 
            // gmapsWeb
            // 
            this.gmapsWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmapsWeb.Location = new System.Drawing.Point(0, 0);
            this.gmapsWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.gmapsWeb.Name = "gmapsWeb";
            this.gmapsWeb.Size = new System.Drawing.Size(750, 906);
            this.gmapsWeb.TabIndex = 0;
            // 
            // location_Timer
            // 
            this.location_Timer.Tick += new System.EventHandler(this.location_Timer_Tick);
            // 
            // txt_City
            // 
            this.txt_City.AcceptsReturn = false;
            this.txt_City.AcceptsTab = false;
            this.txt_City.AnimationSpeed = 200;
            this.txt_City.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_City.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_City.BackColor = System.Drawing.Color.Transparent;
            this.txt_City.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_City.BackgroundImage")));
            this.txt_City.BorderColorActive = System.Drawing.Color.Green;
            this.txt_City.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_City.BorderColorHover = System.Drawing.Color.DeepPink;
            this.txt_City.BorderColorIdle = System.Drawing.Color.Orange;
            this.txt_City.BorderRadius = 1;
            this.txt_City.BorderThickness = 1;
            this.txt_City.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_City.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_City.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_City.DefaultText = "";
            this.txt_City.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(53)))), ((int)(((byte)(130)))));
            this.txt_City.ForeColor = System.Drawing.Color.White;
            this.txt_City.HideSelection = true;
            this.txt_City.IconLeft = null;
            this.txt_City.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_City.IconPadding = 10;
            this.txt_City.IconRight = null;
            this.txt_City.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_City.Lines = new string[0];
            this.txt_City.Location = new System.Drawing.Point(25, 421);
            this.txt_City.MaxLength = 32767;
            this.txt_City.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_City.Modified = false;
            this.txt_City.Multiline = false;
            this.txt_City.Name = "txt_City";
            stateProperties9.BorderColor = System.Drawing.Color.Green;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_City.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_City.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.DeepPink;
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_City.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Orange;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(53)))), ((int)(((byte)(130)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_City.OnIdleState = stateProperties12;
            this.txt_City.Padding = new System.Windows.Forms.Padding(3);
            this.txt_City.PasswordChar = '\0';
            this.txt_City.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_City.PlaceholderText = "City";
            this.txt_City.ReadOnly = false;
            this.txt_City.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_City.SelectedText = "";
            this.txt_City.SelectionLength = 0;
            this.txt_City.SelectionStart = 0;
            this.txt_City.ShortcutsEnabled = true;
            this.txt_City.Size = new System.Drawing.Size(260, 44);
            this.txt_City.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_City.TabIndex = 13;
            this.txt_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_City.TextMarginBottom = 0;
            this.txt_City.TextMarginLeft = 3;
            this.txt_City.TextMarginTop = 0;
            this.txt_City.TextPlaceholder = "City";
            this.txt_City.UseSystemPasswordChar = false;
            this.txt_City.WordWrap = true;
            this.txt_City.KeyUp += new System.Windows.Forms.KeyEventHandler(this.city_enter);
            this.txt_City.Leave += new System.EventHandler(this.city_leave);
            // 
            // txt_Country
            // 
            this.txt_Country.AcceptsReturn = false;
            this.txt_Country.AcceptsTab = false;
            this.txt_Country.AnimationSpeed = 200;
            this.txt_Country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Country.BackColor = System.Drawing.Color.Transparent;
            this.txt_Country.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Country.BackgroundImage")));
            this.txt_Country.BorderColorActive = System.Drawing.Color.Green;
            this.txt_Country.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Country.BorderColorHover = System.Drawing.Color.DeepPink;
            this.txt_Country.BorderColorIdle = System.Drawing.Color.Orange;
            this.txt_Country.BorderRadius = 1;
            this.txt_Country.BorderThickness = 1;
            this.txt_Country.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Country.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Country.DefaultText = "";
            this.txt_Country.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(53)))), ((int)(((byte)(130)))));
            this.txt_Country.ForeColor = System.Drawing.Color.White;
            this.txt_Country.HideSelection = true;
            this.txt_Country.IconLeft = null;
            this.txt_Country.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Country.IconPadding = 10;
            this.txt_Country.IconRight = null;
            this.txt_Country.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Country.Lines = new string[0];
            this.txt_Country.Location = new System.Drawing.Point(25, 515);
            this.txt_Country.MaxLength = 32767;
            this.txt_Country.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Country.Modified = false;
            this.txt_Country.Multiline = false;
            this.txt_Country.Name = "txt_Country";
            stateProperties5.BorderColor = System.Drawing.Color.Green;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Country.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Country.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.DeepPink;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Country.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Orange;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(53)))), ((int)(((byte)(130)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Country.OnIdleState = stateProperties8;
            this.txt_Country.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Country.PasswordChar = '\0';
            this.txt_Country.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_Country.PlaceholderText = "Country";
            this.txt_Country.ReadOnly = false;
            this.txt_Country.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Country.SelectedText = "";
            this.txt_Country.SelectionLength = 0;
            this.txt_Country.SelectionStart = 0;
            this.txt_Country.ShortcutsEnabled = true;
            this.txt_Country.Size = new System.Drawing.Size(260, 44);
            this.txt_Country.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_Country.TabIndex = 14;
            this.txt_Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Country.TextMarginBottom = 0;
            this.txt_Country.TextMarginLeft = 3;
            this.txt_Country.TextMarginTop = 0;
            this.txt_Country.TextPlaceholder = "Country";
            this.txt_Country.UseSystemPasswordChar = false;
            this.txt_Country.WordWrap = true;
            this.txt_Country.KeyUp += new System.Windows.Forms.KeyEventHandler(this.country_enter);
            this.txt_Country.Leave += new System.EventHandler(this.country_leave);
            // 
            // txt_Zip
            // 
            this.txt_Zip.AcceptsReturn = false;
            this.txt_Zip.AcceptsTab = false;
            this.txt_Zip.AnimationSpeed = 200;
            this.txt_Zip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Zip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Zip.BackColor = System.Drawing.Color.Transparent;
            this.txt_Zip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Zip.BackgroundImage")));
            this.txt_Zip.BorderColorActive = System.Drawing.Color.Green;
            this.txt_Zip.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Zip.BorderColorHover = System.Drawing.Color.DeepPink;
            this.txt_Zip.BorderColorIdle = System.Drawing.Color.Orange;
            this.txt_Zip.BorderRadius = 1;
            this.txt_Zip.BorderThickness = 1;
            this.txt_Zip.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Zip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Zip.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Zip.DefaultText = "";
            this.txt_Zip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(53)))), ((int)(((byte)(130)))));
            this.txt_Zip.ForeColor = System.Drawing.Color.White;
            this.txt_Zip.HideSelection = true;
            this.txt_Zip.IconLeft = null;
            this.txt_Zip.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Zip.IconPadding = 10;
            this.txt_Zip.IconRight = null;
            this.txt_Zip.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Zip.Lines = new string[0];
            this.txt_Zip.Location = new System.Drawing.Point(25, 621);
            this.txt_Zip.MaxLength = 32767;
            this.txt_Zip.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Zip.Modified = false;
            this.txt_Zip.Multiline = false;
            this.txt_Zip.Name = "txt_Zip";
            stateProperties1.BorderColor = System.Drawing.Color.Green;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Zip.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Zip.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.DeepPink;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Zip.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Orange;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(53)))), ((int)(((byte)(130)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Zip.OnIdleState = stateProperties4;
            this.txt_Zip.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Zip.PasswordChar = '\0';
            this.txt_Zip.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_Zip.PlaceholderText = "Zip";
            this.txt_Zip.ReadOnly = false;
            this.txt_Zip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Zip.SelectedText = "";
            this.txt_Zip.SelectionLength = 0;
            this.txt_Zip.SelectionStart = 0;
            this.txt_Zip.ShortcutsEnabled = true;
            this.txt_Zip.Size = new System.Drawing.Size(260, 44);
            this.txt_Zip.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_Zip.TabIndex = 15;
            this.txt_Zip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Zip.TextMarginBottom = 0;
            this.txt_Zip.TextMarginLeft = 3;
            this.txt_Zip.TextMarginTop = 0;
            this.txt_Zip.TextPlaceholder = "Zip";
            this.txt_Zip.UseSystemPasswordChar = false;
            this.txt_Zip.WordWrap = true;
            this.txt_Zip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.zip_enter);
            this.txt_Zip.Leave += new System.EventHandler(this.zip_leave);
            // 
            // btn_getlocation
            // 
            this.btn_getlocation.AllowAnimations = true;
            this.btn_getlocation.AllowMouseEffects = true;
            this.btn_getlocation.AllowToggling = false;
            this.btn_getlocation.AnimationSpeed = 200;
            this.btn_getlocation.AutoGenerateColors = false;
            this.btn_getlocation.AutoRoundBorders = true;
            this.btn_getlocation.AutoSizeLeftIcon = true;
            this.btn_getlocation.AutoSizeRightIcon = true;
            this.btn_getlocation.BackColor = System.Drawing.Color.Transparent;
            this.btn_getlocation.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_getlocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_getlocation.BackgroundImage")));
            this.btn_getlocation.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_getlocation.ButtonText = "Get Location";
            this.btn_getlocation.ButtonTextMarginLeft = 0;
            this.btn_getlocation.ColorContrastOnClick = 45;
            this.btn_getlocation.ColorContrastOnHover = 45;
            this.btn_getlocation.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_getlocation.CustomizableEdges = borderEdges2;
            this.btn_getlocation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_getlocation.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_getlocation.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_getlocation.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_getlocation.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_getlocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getlocation.ForeColor = System.Drawing.Color.White;
            this.btn_getlocation.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_getlocation.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_getlocation.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_getlocation.IconMarginLeft = 11;
            this.btn_getlocation.IconPadding = 10;
            this.btn_getlocation.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_getlocation.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_getlocation.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_getlocation.IconSize = 25;
            this.btn_getlocation.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_getlocation.IdleBorderRadius = 37;
            this.btn_getlocation.IdleBorderThickness = 1;
            this.btn_getlocation.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_getlocation.IdleIconLeftImage = null;
            this.btn_getlocation.IdleIconRightImage = null;
            this.btn_getlocation.IndicateFocus = false;
            this.btn_getlocation.Location = new System.Drawing.Point(3, 781);
            this.btn_getlocation.Name = "btn_getlocation";
            this.btn_getlocation.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_getlocation.OnDisabledState.BorderRadius = 1;
            this.btn_getlocation.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_getlocation.OnDisabledState.BorderThickness = 1;
            this.btn_getlocation.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_getlocation.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_getlocation.OnDisabledState.IconLeftImage = null;
            this.btn_getlocation.OnDisabledState.IconRightImage = null;
            this.btn_getlocation.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_getlocation.onHoverState.BorderRadius = 1;
            this.btn_getlocation.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_getlocation.onHoverState.BorderThickness = 1;
            this.btn_getlocation.onHoverState.FillColor = System.Drawing.Color.Red;
            this.btn_getlocation.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_getlocation.onHoverState.IconLeftImage = null;
            this.btn_getlocation.onHoverState.IconRightImage = null;
            this.btn_getlocation.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_getlocation.OnIdleState.BorderRadius = 1;
            this.btn_getlocation.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_getlocation.OnIdleState.BorderThickness = 1;
            this.btn_getlocation.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_getlocation.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_getlocation.OnIdleState.IconLeftImage = null;
            this.btn_getlocation.OnIdleState.IconRightImage = null;
            this.btn_getlocation.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_getlocation.OnPressedState.BorderRadius = 1;
            this.btn_getlocation.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_getlocation.OnPressedState.BorderThickness = 1;
            this.btn_getlocation.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_getlocation.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_getlocation.OnPressedState.IconLeftImage = null;
            this.btn_getlocation.OnPressedState.IconRightImage = null;
            this.btn_getlocation.Size = new System.Drawing.Size(147, 39);
            this.btn_getlocation.TabIndex = 16;
            this.btn_getlocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_getlocation.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_getlocation.TextMarginLeft = 0;
            this.btn_getlocation.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_getlocation.UseDefaultRadiusAndThickness = true;
            this.btn_getlocation.Click += new System.EventHandler(this.btn_getlocation_Click);
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
            this.btn_clear.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_clear.ButtonText = "Clear";
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
            this.btn_clear.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_clear.IdleBorderRadius = 37;
            this.btn_clear.IdleBorderThickness = 1;
            this.btn_clear.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_clear.IdleIconLeftImage = null;
            this.btn_clear.IdleIconRightImage = null;
            this.btn_clear.IndicateFocus = false;
            this.btn_clear.Location = new System.Drawing.Point(168, 781);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_clear.OnDisabledState.BorderRadius = 1;
            this.btn_clear.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_clear.OnDisabledState.BorderThickness = 1;
            this.btn_clear.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_clear.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_clear.OnDisabledState.IconLeftImage = null;
            this.btn_clear.OnDisabledState.IconRightImage = null;
            this.btn_clear.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_clear.onHoverState.BorderRadius = 1;
            this.btn_clear.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_clear.onHoverState.BorderThickness = 1;
            this.btn_clear.onHoverState.FillColor = System.Drawing.Color.Red;
            this.btn_clear.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_clear.onHoverState.IconLeftImage = null;
            this.btn_clear.onHoverState.IconRightImage = null;
            this.btn_clear.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_clear.OnIdleState.BorderRadius = 1;
            this.btn_clear.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_clear.OnIdleState.BorderThickness = 1;
            this.btn_clear.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_clear.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_clear.OnIdleState.IconLeftImage = null;
            this.btn_clear.OnIdleState.IconRightImage = null;
            this.btn_clear.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_clear.OnPressedState.BorderRadius = 1;
            this.btn_clear.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_clear.OnPressedState.BorderThickness = 1;
            this.btn_clear.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_clear.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_clear.OnPressedState.IconLeftImage = null;
            this.btn_clear.OnPressedState.IconRightImage = null;
            this.btn_clear.Size = new System.Drawing.Size(147, 39);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_clear.TextMarginLeft = 0;
            this.btn_clear.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_clear.UseDefaultRadiusAndThickness = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // location_finderfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 906);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "location_finderfrm";
            this.Text = "location_finderfrm";
            this.Load += new System.EventHandler(this.when_starting);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_LocationFinder;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txt_street;
        private System.Windows.Forms.WebBrowser gmapsWeb;
        private System.Windows.Forms.Timer location_Timer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_clear;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_getlocation;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Zip;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Country;
        private Bunifu.UI.WinForms.BunifuTextBox txt_City;
    }
}