namespace Test01
{
    partial class Login_form
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MediaPlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.Login_Shape = new Bunifu.UI.WinForms.BunifuShapes();
            this.btn_Login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.usergif = new System.Windows.Forms.PictureBox();
            this.password_txtbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Username_txtbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_close = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_Minimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_password_check = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Login_Transition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.lbl_Error = new Bunifu.UI.WinForms.BunifuLabel();
            this.Logging_FrmDock = new Bunifu.UI.WinForms.BunifuFormDock();
            ((System.ComponentModel.ISupportInitialize)(this.usergif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MediaPlayerTimer
            // 
            this.MediaPlayerTimer.Tick += new System.EventHandler(this.MediaPlayerTickPlaying);
            // 
            // Login_Shape
            // 
            this.Login_Shape.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Shape.Angle = 0F;
            this.Login_Shape.BackColor = System.Drawing.Color.Transparent;
            this.Login_Shape.BorderColor = System.Drawing.Color.Gold;
            this.Login_Shape.BorderThickness = 5;
            this.Login_Transition.SetDecoration(this.Login_Shape, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Login_Shape.FillColor = System.Drawing.Color.Transparent;
            this.Login_Shape.FillShape = true;
            this.Login_Shape.Location = new System.Drawing.Point(497, 346);
            this.Login_Shape.Name = "Login_Shape";
            this.Login_Shape.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.Login_Shape.Sides = 5;
            this.Login_Shape.Size = new System.Drawing.Size(496, 496);
            this.Login_Shape.TabIndex = 9;
            this.Login_Shape.Text = "bunifuShapes1";
            // 
            // btn_Login
            // 
            this.btn_Login.AllowAnimations = true;
            this.btn_Login.AllowMouseEffects = true;
            this.btn_Login.AllowToggling = false;
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.AnimationSpeed = 200;
            this.btn_Login.AutoGenerateColors = false;
            this.btn_Login.AutoRoundBorders = true;
            this.btn_Login.AutoSizeLeftIcon = true;
            this.btn_Login.AutoSizeRightIcon = true;
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Login.BackgroundImage")));
            this.btn_Login.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.ButtonTextMarginLeft = 0;
            this.btn_Login.ColorContrastOnClick = 45;
            this.btn_Login.ColorContrastOnHover = 45;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Login.CustomizableEdges = borderEdges1;
            this.Login_Transition.SetDecoration(this.btn_Login, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Login.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Login.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Login.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Login.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Login.IconMarginLeft = 11;
            this.btn_Login.IconPadding = 10;
            this.btn_Login.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Login.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Login.IconSize = 25;
            this.btn_Login.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.IdleBorderRadius = 37;
            this.btn_Login.IdleBorderThickness = 1;
            this.btn_Login.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.IdleIconLeftImage = null;
            this.btn_Login.IdleIconRightImage = null;
            this.btn_Login.IndicateFocus = false;
            this.btn_Login.Location = new System.Drawing.Point(652, 680);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Login.OnDisabledState.BorderRadius = 1;
            this.btn_Login.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Login.OnDisabledState.BorderThickness = 1;
            this.btn_Login.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Login.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Login.OnDisabledState.IconLeftImage = null;
            this.btn_Login.OnDisabledState.IconRightImage = null;
            this.btn_Login.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_Login.onHoverState.BorderRadius = 1;
            this.btn_Login.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Login.onHoverState.BorderThickness = 1;
            this.btn_Login.onHoverState.FillColor = System.Drawing.Color.Red;
            this.btn_Login.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Login.onHoverState.IconLeftImage = null;
            this.btn_Login.onHoverState.IconRightImage = null;
            this.btn_Login.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.OnIdleState.BorderRadius = 1;
            this.btn_Login.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Login.OnIdleState.BorderThickness = 1;
            this.btn_Login.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Login.OnIdleState.IconLeftImage = null;
            this.btn_Login.OnIdleState.IconRightImage = null;
            this.btn_Login.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.btn_Login.OnPressedState.BorderRadius = 1;
            this.btn_Login.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Login.OnPressedState.BorderThickness = 1;
            this.btn_Login.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.btn_Login.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Login.OnPressedState.IconLeftImage = null;
            this.btn_Login.OnPressedState.IconRightImage = null;
            this.btn_Login.Size = new System.Drawing.Size(150, 39);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Login.TextMarginLeft = 0;
            this.btn_Login.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Login.UseDefaultRadiusAndThickness = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // usergif
            // 
            this.usergif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Transition.SetDecoration(this.usergif, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.usergif.Image = global::Test01.Properties.Resources.icons8_user;
            this.usergif.Location = new System.Drawing.Point(683, 396);
            this.usergif.Name = "usergif";
            this.usergif.Size = new System.Drawing.Size(93, 88);
            this.usergif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usergif.TabIndex = 3;
            this.usergif.TabStop = false;
            // 
            // password_txtbox
            // 
            this.password_txtbox.AcceptsReturn = false;
            this.password_txtbox.AcceptsTab = false;
            this.password_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_txtbox.AnimationSpeed = 200;
            this.password_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.password_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.password_txtbox.BackColor = System.Drawing.Color.Transparent;
            this.password_txtbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("password_txtbox.BackgroundImage")));
            this.password_txtbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.password_txtbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password_txtbox.BorderColorHover = System.Drawing.Color.Green;
            this.password_txtbox.BorderColorIdle = System.Drawing.Color.Red;
            this.password_txtbox.BorderRadius = 2;
            this.password_txtbox.BorderThickness = 1;
            this.password_txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.password_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login_Transition.SetDecoration(this.password_txtbox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.password_txtbox.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txtbox.DefaultText = "daniel";
            this.password_txtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.password_txtbox.ForeColor = System.Drawing.Color.White;
            this.password_txtbox.HideSelection = true;
            this.password_txtbox.IconLeft = null;
            this.password_txtbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txtbox.IconPadding = 10;
            this.password_txtbox.IconRight = null;
            this.password_txtbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txtbox.Lines = new string[] {
        "daniel"};
            this.password_txtbox.Location = new System.Drawing.Point(612, 592);
            this.password_txtbox.MaxLength = 32767;
            this.password_txtbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.password_txtbox.Modified = false;
            this.password_txtbox.Multiline = false;
            this.password_txtbox.Name = "password_txtbox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.password_txtbox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.password_txtbox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Green;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.password_txtbox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Red;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.password_txtbox.OnIdleState = stateProperties4;
            this.password_txtbox.Padding = new System.Windows.Forms.Padding(3);
            this.password_txtbox.PasswordChar = '\0';
            this.password_txtbox.PlaceholderForeColor = System.Drawing.Color.White;
            this.password_txtbox.PlaceholderText = "Password";
            this.password_txtbox.ReadOnly = false;
            this.password_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_txtbox.SelectedText = "";
            this.password_txtbox.SelectionLength = 0;
            this.password_txtbox.SelectionStart = 6;
            this.password_txtbox.ShortcutsEnabled = true;
            this.password_txtbox.Size = new System.Drawing.Size(260, 44);
            this.password_txtbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.password_txtbox.TabIndex = 7;
            this.password_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_txtbox.TextMarginBottom = 0;
            this.password_txtbox.TextMarginLeft = 3;
            this.password_txtbox.TextMarginTop = 0;
            this.password_txtbox.TextPlaceholder = "Password";
            this.password_txtbox.UseSystemPasswordChar = false;
            this.password_txtbox.WordWrap = true;
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            this.password_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_set);
            this.password_txtbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password_Entry);
            this.password_txtbox.Leave += new System.EventHandler(this.Password_Finish);
            // 
            // Username_txtbox
            // 
            this.Username_txtbox.AcceptsReturn = false;
            this.Username_txtbox.AcceptsTab = false;
            this.Username_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username_txtbox.AnimationSpeed = 200;
            this.Username_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Username_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Username_txtbox.BackColor = System.Drawing.Color.Transparent;
            this.Username_txtbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Username_txtbox.BackgroundImage")));
            this.Username_txtbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Username_txtbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Username_txtbox.BorderColorHover = System.Drawing.Color.Green;
            this.Username_txtbox.BorderColorIdle = System.Drawing.Color.Red;
            this.Username_txtbox.BorderRadius = 2;
            this.Username_txtbox.BorderThickness = 1;
            this.Username_txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Username_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login_Transition.SetDecoration(this.Username_txtbox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Username_txtbox.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txtbox.DefaultText = "daniel";
            this.Username_txtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Username_txtbox.ForeColor = System.Drawing.Color.White;
            this.Username_txtbox.HideSelection = true;
            this.Username_txtbox.IconLeft = null;
            this.Username_txtbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_txtbox.IconPadding = 10;
            this.Username_txtbox.IconRight = null;
            this.Username_txtbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_txtbox.Lines = new string[] {
        "daniel"};
            this.Username_txtbox.Location = new System.Drawing.Point(612, 515);
            this.Username_txtbox.MaxLength = 32767;
            this.Username_txtbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.Username_txtbox.Modified = false;
            this.Username_txtbox.Multiline = false;
            this.Username_txtbox.Name = "Username_txtbox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Username_txtbox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Username_txtbox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Green;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Username_txtbox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Red;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Username_txtbox.OnIdleState = stateProperties8;
            this.Username_txtbox.Padding = new System.Windows.Forms.Padding(3);
            this.Username_txtbox.PasswordChar = '\0';
            this.Username_txtbox.PlaceholderForeColor = System.Drawing.Color.White;
            this.Username_txtbox.PlaceholderText = "Username";
            this.Username_txtbox.ReadOnly = false;
            this.Username_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Username_txtbox.SelectedText = "";
            this.Username_txtbox.SelectionLength = 0;
            this.Username_txtbox.SelectionStart = 6;
            this.Username_txtbox.ShortcutsEnabled = true;
            this.Username_txtbox.Size = new System.Drawing.Size(260, 44);
            this.Username_txtbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Username_txtbox.TabIndex = 6;
            this.Username_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username_txtbox.TextMarginBottom = 0;
            this.Username_txtbox.TextMarginLeft = 3;
            this.Username_txtbox.TextMarginTop = 0;
            this.Username_txtbox.TextPlaceholder = "Username";
            this.Username_txtbox.UseSystemPasswordChar = false;
            this.Username_txtbox.WordWrap = true;
            this.Username_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.details_Entry);
            this.Username_txtbox.Leave += new System.EventHandler(this.details_Complete);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.Login_Transition.SetDecoration(this.pictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox2.Image = global::Test01.Properties.Resources.GO_TRAVEL_free_file;
            this.pictureBox2.Location = new System.Drawing.Point(9, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
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
            this.Login_Transition.SetDecoration(this.btn_close, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_close.ErrorImage")));
            this.btn_close.FadeWhenInactive = true;
            this.btn_close.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_close.Image = global::Test01.Properties.Resources.cross;
            this.btn_close.ImageActive = null;
            this.btn_close.ImageLocation = null;
            this.btn_close.ImageMargin = 40;
            this.btn_close.ImageSize = new System.Drawing.Size(43, 43);
            this.btn_close.ImageZoomSize = new System.Drawing.Size(83, 83);
            this.btn_close.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_close.InitialImage")));
            this.btn_close.Location = new System.Drawing.Point(1371, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rotation = 0;
            this.btn_close.ShowActiveImage = true;
            this.btn_close.ShowCursorChanges = true;
            this.btn_close.ShowImageBorders = false;
            this.btn_close.ShowSizeMarkers = false;
            this.btn_close.Size = new System.Drawing.Size(83, 83);
            this.btn_close.TabIndex = 1;
            this.btn_close.ToolTipText = "";
            this.btn_close.WaitOnLoad = false;
            this.btn_close.Zoom = 40;
            this.btn_close.ZoomSpeed = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.ActiveImage = null;
            this.btn_Minimize.AllowAnimations = true;
            this.btn_Minimize.AllowBuffering = false;
            this.btn_Minimize.AllowToggling = false;
            this.btn_Minimize.AllowZooming = true;
            this.btn_Minimize.AllowZoomingOnFocus = false;
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Login_Transition.SetDecoration(this.btn_Minimize, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_Minimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Minimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.ErrorImage")));
            this.btn_Minimize.FadeWhenInactive = true;
            this.btn_Minimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_Minimize.Image = global::Test01.Properties.Resources.minimize__2_;
            this.btn_Minimize.ImageActive = null;
            this.btn_Minimize.ImageLocation = null;
            this.btn_Minimize.ImageMargin = 40;
            this.btn_Minimize.ImageSize = new System.Drawing.Size(43, 43);
            this.btn_Minimize.ImageZoomSize = new System.Drawing.Size(83, 83);
            this.btn_Minimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.InitialImage")));
            this.btn_Minimize.Location = new System.Drawing.Point(1259, 12);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Rotation = 0;
            this.btn_Minimize.ShowActiveImage = true;
            this.btn_Minimize.ShowCursorChanges = true;
            this.btn_Minimize.ShowImageBorders = false;
            this.btn_Minimize.ShowSizeMarkers = false;
            this.btn_Minimize.Size = new System.Drawing.Size(83, 83);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.ToolTipText = "";
            this.btn_Minimize.WaitOnLoad = false;
            this.btn_Minimize.Zoom = 40;
            this.btn_Minimize.ZoomSpeed = 10;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_password_check
            // 
            this.btn_password_check.ActiveImage = null;
            this.btn_password_check.AllowAnimations = true;
            this.btn_password_check.AllowBuffering = false;
            this.btn_password_check.AllowToggling = false;
            this.btn_password_check.AllowZooming = true;
            this.btn_password_check.AllowZoomingOnFocus = false;
            this.btn_password_check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_password_check.BackColor = System.Drawing.Color.Transparent;
            this.Login_Transition.SetDecoration(this.btn_password_check, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_password_check.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_password_check.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_password_check.ErrorImage")));
            this.btn_password_check.FadeWhenInactive = true;
            this.btn_password_check.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_password_check.Image = global::Test01.Properties.Resources.eye__1_;
            this.btn_password_check.ImageActive = null;
            this.btn_password_check.ImageLocation = null;
            this.btn_password_check.ImageMargin = 40;
            this.btn_password_check.ImageSize = new System.Drawing.Size(27, 25);
            this.btn_password_check.ImageZoomSize = new System.Drawing.Size(67, 65);
            this.btn_password_check.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_password_check.InitialImage")));
            this.btn_password_check.Location = new System.Drawing.Point(890, 585);
            this.btn_password_check.Name = "btn_password_check";
            this.btn_password_check.Rotation = 0;
            this.btn_password_check.ShowActiveImage = true;
            this.btn_password_check.ShowCursorChanges = true;
            this.btn_password_check.ShowImageBorders = false;
            this.btn_password_check.ShowSizeMarkers = false;
            this.btn_password_check.Size = new System.Drawing.Size(67, 65);
            this.btn_password_check.TabIndex = 11;
            this.btn_password_check.ToolTipText = "";
            this.btn_password_check.WaitOnLoad = false;
            this.btn_password_check.Zoom = 40;
            this.btn_password_check.ZoomSpeed = 10;
            this.btn_password_check.Click += new System.EventHandler(this.btn_password_check_Click);
            // 
            // Login_Transition
            // 
            this.Login_Transition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Particles;
            this.Login_Transition.Cursor = null;
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
            this.Login_Transition.DefaultAnimation = animation1;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AllowParentOverrides = false;
            this.lbl_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Error.AutoEllipsis = false;
            this.lbl_Error.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Error.CursorType = System.Windows.Forms.Cursors.Default;
            this.Login_Transition.SetDecoration(this.lbl_Error, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Error.ForeColor = System.Drawing.Color.White;
            this.lbl_Error.Location = new System.Drawing.Point(663, 648);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Error.Size = new System.Drawing.Size(136, 20);
            this.lbl_Error.TabIndex = 12;
            this.lbl_Error.Text = "Incorrect Credentials";
            this.lbl_Error.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Error.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_Error.Visible = false;
            // 
            // Logging_FrmDock
            // 
            this.Logging_FrmDock.AllowFormDragging = true;
            this.Logging_FrmDock.AllowFormDropShadow = true;
            this.Logging_FrmDock.AllowFormResizing = true;
            this.Logging_FrmDock.AllowHidingBottomRegion = true;
            this.Logging_FrmDock.AllowOpacityChangesWhileDragging = false;
            this.Logging_FrmDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.Logging_FrmDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.Logging_FrmDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.Logging_FrmDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.Logging_FrmDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.Logging_FrmDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.Logging_FrmDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.Logging_FrmDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.Logging_FrmDock.BorderOptions.RightBorder.ShowBorder = true;
            this.Logging_FrmDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.Logging_FrmDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.Logging_FrmDock.BorderOptions.TopBorder.ShowBorder = true;
            this.Logging_FrmDock.ContainerControl = this;
            this.Logging_FrmDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.Logging_FrmDock.DockingIndicatorsOpacity = 0.5D;
            this.Logging_FrmDock.DockingOptions.DockAll = true;
            this.Logging_FrmDock.DockingOptions.DockBottomLeft = true;
            this.Logging_FrmDock.DockingOptions.DockBottomRight = true;
            this.Logging_FrmDock.DockingOptions.DockFullScreen = true;
            this.Logging_FrmDock.DockingOptions.DockLeft = true;
            this.Logging_FrmDock.DockingOptions.DockRight = true;
            this.Logging_FrmDock.DockingOptions.DockTopLeft = true;
            this.Logging_FrmDock.DockingOptions.DockTopRight = true;
            this.Logging_FrmDock.FormDraggingOpacity = 0.9D;
            this.Logging_FrmDock.ParentForm = this;
            this.Logging_FrmDock.ShowCursorChanges = true;
            this.Logging_FrmDock.ShowDockingIndicators = true;
            this.Logging_FrmDock.TitleBarOptions.AllowFormDragging = true;
            this.Logging_FrmDock.TitleBarOptions.BunifuFormDock = this.Logging_FrmDock;
            this.Logging_FrmDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.Logging_FrmDock.TitleBarOptions.TitleBarControl = null;
            this.Logging_FrmDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1466, 842);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_password_check);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.usergif);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.Username_txtbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.Login_Shape);
            this.Login_Transition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.Leave += new System.EventHandler(this.Login_form_Leave);
            this.MouseHover += new System.EventHandler(this.Login_form_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.usergif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_close;
        private Bunifu.UI.WinForms.BunifuImageButton btn_Minimize;
        private System.Windows.Forms.PictureBox usergif;
        private Bunifu.UI.WinForms.BunifuTextBox Username_txtbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Login;
        private Bunifu.UI.WinForms.BunifuTextBox password_txtbox;
        private System.Windows.Forms.Timer MediaPlayerTimer;
        private Bunifu.UI.WinForms.BunifuShapes Login_Shape;
        private Bunifu.UI.WinForms.BunifuImageButton btn_password_check;
        private Bunifu.UI.WinForms.BunifuTransition Login_Transition;
        private Bunifu.UI.WinForms.BunifuLabel lbl_Error;
        private Bunifu.UI.WinForms.BunifuFormDock Logging_FrmDock;
    }
}

