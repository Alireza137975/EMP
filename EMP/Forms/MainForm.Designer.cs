namespace EMP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleBar_panel = new System.Windows.Forms.Panel();
            this.foCUS = new System.Windows.Forms.Panel();
            this.PinIcon_btn = new System.Windows.Forms.Button();
            this.Logo_pbox = new System.Windows.Forms.PictureBox();
            this.EliteMediaPlayer_label = new System.Windows.Forms.Label();
            this.Min_Button = new System.Windows.Forms.Button();
            this.Max_Button = new System.Windows.Forms.Button();
            this.Cross_Button = new System.Windows.Forms.Button();
            this.MainControl_panel = new System.Windows.Forms.Panel();
            this.Previous_btn = new System.Windows.Forms.Button();
            this.Replay_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.PlayPause_btn = new System.Windows.Forms.Button();
            this.BelowPanel = new System.Windows.Forms.Panel();
            this.PlaylistShow_Btn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.Volume_trackBar = new System.Windows.Forms.TrackBar();
            this.Volume_btn = new System.Windows.Forms.Button();
            this.FullscreenBtn = new System.Windows.Forms.Button();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.Main_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenMedia_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPlaylist_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.audioPlayerModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.Video_panel = new System.Windows.Forms.Panel();
            this.Playlist_FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewPlayLBtn = new System.Windows.Forms.Button();
            this.TrackBar = new ColorSlider.ColorSlider();
            this.Player_wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.TitleBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pbox)).BeginInit();
            this.MainControl_panel.SuspendLayout();
            this.BelowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_trackBar)).BeginInit();
            this.Main_cms.SuspendLayout();
            this.Video_panel.SuspendLayout();
            this.Playlist_FlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar_panel
            // 
            this.TitleBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(19)))));
            this.TitleBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar_panel.Controls.Add(this.foCUS);
            this.TitleBar_panel.Controls.Add(this.PinIcon_btn);
            this.TitleBar_panel.Controls.Add(this.Logo_pbox);
            this.TitleBar_panel.Controls.Add(this.EliteMediaPlayer_label);
            this.TitleBar_panel.Controls.Add(this.Min_Button);
            this.TitleBar_panel.Controls.Add(this.Max_Button);
            this.TitleBar_panel.Controls.Add(this.Cross_Button);
            this.TitleBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar_panel.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_panel.Name = "TitleBar_panel";
            this.TitleBar_panel.Size = new System.Drawing.Size(641, 34);
            this.TitleBar_panel.TabIndex = 1;
            this.TitleBar_panel.Click += new System.EventHandler(this.HidePlaylist_OnClick);
            this.TitleBar_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowMainCms_MouseClick);
            this.TitleBar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // foCUS
            // 
            this.foCUS.Location = new System.Drawing.Point(402, 5);
            this.foCUS.Name = "foCUS";
            this.foCUS.Size = new System.Drawing.Size(18, 20);
            this.foCUS.TabIndex = 9;
            this.foCUS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // PinIcon_btn
            // 
            this.PinIcon_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PinIcon_btn.FlatAppearance.BorderSize = 0;
            this.PinIcon_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PinIcon_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PinIcon_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinIcon_btn.ForeColor = System.Drawing.Color.Beige;
            this.PinIcon_btn.Location = new System.Drawing.Point(455, 0);
            this.PinIcon_btn.Name = "PinIcon_btn";
            this.PinIcon_btn.Size = new System.Drawing.Size(45, 29);
            this.PinIcon_btn.TabIndex = 7;
            this.PinIcon_btn.Text = "📌";
            this.PinIcon_btn.UseVisualStyleBackColor = true;
            this.PinIcon_btn.ForeColorChanged += new System.EventHandler(this.PinIcon_btn_ForeColorChanged);
            this.PinIcon_btn.Click += new System.EventHandler(this.PinIcon_btn_Click);
            this.PinIcon_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Logo_pbox
            // 
            this.Logo_pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo_pbox.Image = global::EMP.Properties.Resources.Untitled_2_01;
            this.Logo_pbox.Location = new System.Drawing.Point(-2, -4);
            this.Logo_pbox.Name = "Logo_pbox";
            this.Logo_pbox.Size = new System.Drawing.Size(79, 37);
            this.Logo_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_pbox.TabIndex = 0;
            this.Logo_pbox.TabStop = false;
            this.Logo_pbox.Click += new System.EventHandler(this.MainControl_panel_Click);
            this.Logo_pbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // EliteMediaPlayer_label
            // 
            this.EliteMediaPlayer_label.AutoSize = true;
            this.EliteMediaPlayer_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(19)))));
            this.EliteMediaPlayer_label.Font = new System.Drawing.Font("Chaparral Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliteMediaPlayer_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.EliteMediaPlayer_label.Location = new System.Drawing.Point(81, 5);
            this.EliteMediaPlayer_label.Name = "EliteMediaPlayer_label";
            this.EliteMediaPlayer_label.Size = new System.Drawing.Size(151, 23);
            this.EliteMediaPlayer_label.TabIndex = 6;
            this.EliteMediaPlayer_label.Text = "Elite Media Player";
            this.EliteMediaPlayer_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // Min_Button
            // 
            this.Min_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min_Button.FlatAppearance.BorderSize = 0;
            this.Min_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Min_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Min_Button.Location = new System.Drawing.Point(501, 1);
            this.Min_Button.Name = "Min_Button";
            this.Min_Button.Size = new System.Drawing.Size(45, 31);
            this.Min_Button.TabIndex = 4;
            this.Min_Button.TabStop = false;
            this.Min_Button.Text = "_";
            this.Min_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Min_Button.UseVisualStyleBackColor = true;
            this.Min_Button.Click += new System.EventHandler(this.Min_Button_Click);
            this.Min_Button.MouseLeave += new System.EventHandler(this.CMM_Buttons_Leave);
            this.Min_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Min_Button_Move);
            this.Min_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Max_Button
            // 
            this.Max_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max_Button.FlatAppearance.BorderSize = 0;
            this.Max_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Max_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Max_Button.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Max_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Max_Button.Location = new System.Drawing.Point(547, 1);
            this.Max_Button.Name = "Max_Button";
            this.Max_Button.Size = new System.Drawing.Size(45, 30);
            this.Max_Button.TabIndex = 3;
            this.Max_Button.TabStop = false;
            this.Max_Button.Text = "1";
            this.Max_Button.UseVisualStyleBackColor = true;
            this.Max_Button.Click += new System.EventHandler(this.Max_Button_Click);
            this.Max_Button.MouseLeave += new System.EventHandler(this.CMM_Buttons_Leave);
            this.Max_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Max_Button_MouseMove);
            this.Max_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Cross_Button
            // 
            this.Cross_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cross_Button.FlatAppearance.BorderSize = 0;
            this.Cross_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Cross_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cross_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cross_Button.Location = new System.Drawing.Point(593, 1);
            this.Cross_Button.Name = "Cross_Button";
            this.Cross_Button.Size = new System.Drawing.Size(45, 30);
            this.Cross_Button.TabIndex = 2;
            this.Cross_Button.TabStop = false;
            this.Cross_Button.Text = "X";
            this.Cross_Button.UseVisualStyleBackColor = true;
            this.Cross_Button.Click += new System.EventHandler(this.Cross_Button_Click);
            this.Cross_Button.MouseLeave += new System.EventHandler(this.CMM_Buttons_Leave);
            this.Cross_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cross_Button_MouseMove);
            this.Cross_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // MainControl_panel
            // 
            this.MainControl_panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MainControl_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.MainControl_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainControl_panel.Controls.Add(this.Previous_btn);
            this.MainControl_panel.Controls.Add(this.Replay_btn);
            this.MainControl_panel.Controls.Add(this.Next_btn);
            this.MainControl_panel.Controls.Add(this.Stop_btn);
            this.MainControl_panel.Controls.Add(this.PlayPause_btn);
            this.MainControl_panel.Location = new System.Drawing.Point(221, -3);
            this.MainControl_panel.Margin = new System.Windows.Forms.Padding(0);
            this.MainControl_panel.Name = "MainControl_panel";
            this.MainControl_panel.Size = new System.Drawing.Size(200, 38);
            this.MainControl_panel.TabIndex = 0;
            this.MainControl_panel.Click += new System.EventHandler(this.MainControl_panel_Click);
            // 
            // Previous_btn
            // 
            this.Previous_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Previous_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Previous_btn.FlatAppearance.BorderSize = 0;
            this.Previous_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Previous_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Previous_btn.Location = new System.Drawing.Point(15, -7);
            this.Previous_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Previous_btn.Name = "Previous_btn";
            this.Previous_btn.Size = new System.Drawing.Size(35, 49);
            this.Previous_btn.TabIndex = 12;
            this.Previous_btn.TabStop = false;
            this.Previous_btn.Text = "⏮";
            this.Previous_btn.UseVisualStyleBackColor = false;
            this.Previous_btn.Click += new System.EventHandler(this.Previous_btn_Click);
            this.Previous_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Previous_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Replay_btn
            // 
            this.Replay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Replay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Replay_btn.FlatAppearance.BorderSize = 0;
            this.Replay_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Replay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Replay_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F);
            this.Replay_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Replay_btn.Location = new System.Drawing.Point(49, -7);
            this.Replay_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Replay_btn.Name = "Replay_btn";
            this.Replay_btn.Size = new System.Drawing.Size(35, 49);
            this.Replay_btn.TabIndex = 11;
            this.Replay_btn.TabStop = false;
            this.Replay_btn.Text = "⟲";
            this.Replay_btn.UseVisualStyleBackColor = false;
            this.Replay_btn.Click += new System.EventHandler(this.Replay_btn_Click);
            this.Replay_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Replay_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Next_btn
            // 
            this.Next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Next_btn.FlatAppearance.BorderSize = 0;
            this.Next_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Next_btn.Location = new System.Drawing.Point(152, -7);
            this.Next_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(35, 49);
            this.Next_btn.TabIndex = 10;
            this.Next_btn.TabStop = false;
            this.Next_btn.Text = "⏭ ";
            this.Next_btn.UseVisualStyleBackColor = false;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            this.Next_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Next_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Stop_btn.FlatAppearance.BorderSize = 0;
            this.Stop_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F);
            this.Stop_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Stop_btn.Location = new System.Drawing.Point(117, -7);
            this.Stop_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(35, 49);
            this.Stop_btn.TabIndex = 9;
            this.Stop_btn.TabStop = false;
            this.Stop_btn.Text = "⏹";
            this.Stop_btn.UseVisualStyleBackColor = false;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            this.Stop_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Stop_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // PlayPause_btn
            // 
            this.PlayPause_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlayPause_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.PlayPause_btn.FlatAppearance.BorderSize = 0;
            this.PlayPause_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.PlayPause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayPause_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayPause_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayPause_btn.Location = new System.Drawing.Point(83, -7);
            this.PlayPause_btn.Margin = new System.Windows.Forms.Padding(0);
            this.PlayPause_btn.Name = "PlayPause_btn";
            this.PlayPause_btn.Size = new System.Drawing.Size(35, 49);
            this.PlayPause_btn.TabIndex = 8;
            this.PlayPause_btn.TabStop = false;
            this.PlayPause_btn.Text = "▶ ";
            this.PlayPause_btn.UseVisualStyleBackColor = false;
            this.PlayPause_btn.Click += new System.EventHandler(this.PlayPause_btn_Click);
            this.PlayPause_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.PlayPause_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // BelowPanel
            // 
            this.BelowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BelowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.BelowPanel.Controls.Add(this.PlaylistShow_Btn);
            this.BelowPanel.Controls.Add(this.SettingsBtn);
            this.BelowPanel.Controls.Add(this.Volume_trackBar);
            this.BelowPanel.Controls.Add(this.Volume_btn);
            this.BelowPanel.Controls.Add(this.FullscreenBtn);
            this.BelowPanel.Controls.Add(this.MainControl_panel);
            this.BelowPanel.Location = new System.Drawing.Point(0, 390);
            this.BelowPanel.Name = "BelowPanel";
            this.BelowPanel.Size = new System.Drawing.Size(641, 38);
            this.BelowPanel.TabIndex = 3;
            this.BelowPanel.Click += new System.EventHandler(this.HidePlaylist_OnClick);
            this.BelowPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowMainCms_MouseClick);
            // 
            // PlaylistShow_Btn
            // 
            this.PlaylistShow_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaylistShow_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.PlaylistShow_Btn.FlatAppearance.BorderSize = 0;
            this.PlaylistShow_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.PlaylistShow_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaylistShow_Btn.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistShow_Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlaylistShow_Btn.Location = new System.Drawing.Point(556, 3);
            this.PlaylistShow_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.PlaylistShow_Btn.Name = "PlaylistShow_Btn";
            this.PlaylistShow_Btn.Size = new System.Drawing.Size(42, 32);
            this.PlaylistShow_Btn.TabIndex = 13;
            this.PlaylistShow_Btn.TabStop = false;
            this.PlaylistShow_Btn.Text = "P";
            this.PlaylistShow_Btn.UseVisualStyleBackColor = false;
            this.PlaylistShow_Btn.Click += new System.EventHandler(this.PlaylistShow_Btn_Click_1);
            this.PlaylistShow_Btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.PlaylistShow_Btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingsBtn.Location = new System.Drawing.Point(0, -3);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(42, 41);
            this.SettingsBtn.TabIndex = 8;
            this.SettingsBtn.TabStop = false;
            this.SettingsBtn.Text = "⚙";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            this.SettingsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Volume_trackBar
            // 
            this.Volume_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Volume_trackBar.AutoSize = false;
            this.Volume_trackBar.LargeChange = 10;
            this.Volume_trackBar.Location = new System.Drawing.Point(90, 7);
            this.Volume_trackBar.Maximum = 100;
            this.Volume_trackBar.Name = "Volume_trackBar";
            this.Volume_trackBar.Size = new System.Drawing.Size(100, 27);
            this.Volume_trackBar.TabIndex = 8;
            this.Volume_trackBar.TabStop = false;
            this.Volume_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Volume_trackBar.Value = 100;
            this.Volume_trackBar.Scroll += new System.EventHandler(this.Volume_trackBar_Scroll);
            this.Volume_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Volume_btn
            // 
            this.Volume_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Volume_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Volume_btn.FlatAppearance.BorderSize = 0;
            this.Volume_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Volume_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volume_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Volume_btn.Location = new System.Drawing.Point(57, -45);
            this.Volume_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Volume_btn.Name = "Volume_btn";
            this.Volume_btn.Size = new System.Drawing.Size(31, 82);
            this.Volume_btn.TabIndex = 13;
            this.Volume_btn.TabStop = false;
            this.Volume_btn.Text = " 🔊";
            this.Volume_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Volume_btn.UseVisualStyleBackColor = false;
            this.Volume_btn.Click += new System.EventHandler(this.Volume_btn_Click);
            this.Volume_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // FullscreenBtn
            // 
            this.FullscreenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FullscreenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FullscreenBtn.BackgroundImage")));
            this.FullscreenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FullscreenBtn.FlatAppearance.BorderSize = 0;
            this.FullscreenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.FullscreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullscreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullscreenBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FullscreenBtn.Location = new System.Drawing.Point(608, 9);
            this.FullscreenBtn.Name = "FullscreenBtn";
            this.FullscreenBtn.Size = new System.Drawing.Size(20, 20);
            this.FullscreenBtn.TabIndex = 5;
            this.FullscreenBtn.TabStop = false;
            this.FullscreenBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FullscreenBtn.UseVisualStyleBackColor = true;
            this.FullscreenBtn.Click += new System.EventHandler(this.FullscreenBtn_Click);
            this.FullscreenBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 700;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Main_cms
            // 
            this.Main_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Main_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMedia_option_cms,
            this.NewPlaylist_option_cms,
            this.audioPlayerModeToolStripMenuItem,
            this.About_option_cms,
            this.Exit_option_cms});
            this.Main_cms.Name = "Main_cms";
            this.Main_cms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Main_cms.Size = new System.Drawing.Size(176, 114);
            // 
            // OpenMedia_option_cms
            // 
            this.OpenMedia_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.OpenMedia_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenMedia_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OpenMedia_option_cms.ImageTransparentColor = System.Drawing.Color.Silver;
            this.OpenMedia_option_cms.Name = "OpenMedia_option_cms";
            this.OpenMedia_option_cms.Size = new System.Drawing.Size(175, 22);
            this.OpenMedia_option_cms.Text = "Open Media";
            this.OpenMedia_option_cms.Click += new System.EventHandler(this.OpenMedia_option_cms_Click);
            // 
            // NewPlaylist_option_cms
            // 
            this.NewPlaylist_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.NewPlaylist_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewPlaylist_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NewPlaylist_option_cms.Name = "NewPlaylist_option_cms";
            this.NewPlaylist_option_cms.Size = new System.Drawing.Size(175, 22);
            this.NewPlaylist_option_cms.Text = "Playlist Menu";
            this.NewPlaylist_option_cms.Click += new System.EventHandler(this.NewPlaylist_option_cms_Click);
            // 
            // audioPlayerModeToolStripMenuItem
            // 
            this.audioPlayerModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.audioPlayerModeToolStripMenuItem.Name = "audioPlayerModeToolStripMenuItem";
            this.audioPlayerModeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.audioPlayerModeToolStripMenuItem.Text = "Audio/Video Mode";
            this.audioPlayerModeToolStripMenuItem.Click += new System.EventHandler(this.audioPlayerModeToolStripMenuItem_Click);
            // 
            // About_option_cms
            // 
            this.About_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.About_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.About_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.About_option_cms.Name = "About_option_cms";
            this.About_option_cms.Size = new System.Drawing.Size(175, 22);
            this.About_option_cms.Text = "About";
            this.About_option_cms.Click += new System.EventHandler(this.About_option_cms_Click);
            // 
            // Exit_option_cms
            // 
            this.Exit_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Exit_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Exit_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Exit_option_cms.Name = "Exit_option_cms";
            this.Exit_option_cms.Size = new System.Drawing.Size(175, 22);
            this.Exit_option_cms.Text = "Exit";
            this.Exit_option_cms.Click += new System.EventHandler(this.Exit_option_cms_Click);
            // 
            // Video_panel
            // 
            this.Video_panel.AllowDrop = true;
            this.Video_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Video_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.Video_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Video_panel.BackgroundImage")));
            this.Video_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Video_panel.Controls.Add(this.Playlist_FlowPanel);
            this.Video_panel.Controls.Add(this.TrackBar);
            this.Video_panel.Controls.Add(this.Player_wmp);
            this.Video_panel.Location = new System.Drawing.Point(0, 32);
            this.Video_panel.Name = "Video_panel";
            this.Video_panel.Size = new System.Drawing.Size(641, 361);
            this.Video_panel.TabIndex = 2;
            this.Video_panel.Click += new System.EventHandler(this.Video_panel_Click);
            this.Video_panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.Video_panel_DragDrop);
            this.Video_panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Video_panel_DragEnter);
            this.Video_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowMainCms_MouseClick);
            // 
            // Playlist_FlowPanel
            // 
            this.Playlist_FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Playlist_FlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Playlist_FlowPanel.Controls.Add(this.NewPlayLBtn);
            this.Playlist_FlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Playlist_FlowPanel.Location = new System.Drawing.Point(403, 8);
            this.Playlist_FlowPanel.Name = "Playlist_FlowPanel";
            this.Playlist_FlowPanel.Size = new System.Drawing.Size(235, 318);
            this.Playlist_FlowPanel.TabIndex = 10;
            this.Playlist_FlowPanel.Visible = false;
            // 
            // NewPlayLBtn
            // 
            this.NewPlayLBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewPlayLBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.NewPlayLBtn.FlatAppearance.BorderSize = 0;
            this.NewPlayLBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.NewPlayLBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.NewPlayLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPlayLBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPlayLBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewPlayLBtn.Location = new System.Drawing.Point(0, 0);
            this.NewPlayLBtn.Margin = new System.Windows.Forms.Padding(0);
            this.NewPlayLBtn.Name = "NewPlayLBtn";
            this.NewPlayLBtn.Size = new System.Drawing.Size(235, 49);
            this.NewPlayLBtn.TabIndex = 13;
            this.NewPlayLBtn.TabStop = false;
            this.NewPlayLBtn.Text = "New Playlist";
            this.NewPlayLBtn.UseVisualStyleBackColor = false;
            this.NewPlayLBtn.Click += new System.EventHandler(this.NewPlayLBtn_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TrackBar.BarInnerColor = System.Drawing.Color.DimGray;
            this.TrackBar.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.TrackBar.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.TrackBar.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TrackBar.ElapsedInnerColor = System.Drawing.Color.Silver;
            this.TrackBar.ElapsedPenColorBottom = System.Drawing.Color.DimGray;
            this.TrackBar.ElapsedPenColorTop = System.Drawing.Color.Silver;
            this.TrackBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.TrackBar.ForeColor = System.Drawing.Color.White;
            this.TrackBar.LargeChange = ((uint)(5u));
            this.TrackBar.Location = new System.Drawing.Point(5, 331);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.ScaleDivisions = 10;
            this.TrackBar.ScaleSubDivisions = 5;
            this.TrackBar.ShowDivisionsText = true;
            this.TrackBar.ShowSmallScale = false;
            this.TrackBar.Size = new System.Drawing.Size(631, 27);
            this.TrackBar.SmallChange = ((uint)(1u));
            this.TrackBar.TabIndex = 8;
            this.TrackBar.Text = "colorSlider1";
            this.TrackBar.ThumbInnerColor = System.Drawing.Color.DimGray;
            this.TrackBar.ThumbOuterColor = System.Drawing.Color.LightCyan;
            this.TrackBar.ThumbPenColor = System.Drawing.Color.Black;
            this.TrackBar.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.TrackBar.ThumbSize = new System.Drawing.Size(16, 16);
            this.TrackBar.TickAdd = 0F;
            this.TrackBar.TickColor = System.Drawing.Color.Maroon;
            this.TrackBar.TickDivide = 0F;
            this.TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar.Value = 0;
            this.TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseDown);
            this.TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseUp);
            // 
            // Player_wmp
            // 
            this.Player_wmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_wmp.Enabled = true;
            this.Player_wmp.Location = new System.Drawing.Point(6, 4);
            this.Player_wmp.Name = "Player_wmp";
            this.Player_wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player_wmp.OcxState")));
            this.Player_wmp.Size = new System.Drawing.Size(630, 373);
            this.Player_wmp.TabIndex = 9;
            this.Player_wmp.Visible = false;
            this.Player_wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_wmp_PlayStateChange);
            this.Player_wmp.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.Player_wmp_MediaChange);
            this.Player_wmp.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.Player_wmp_ClickEvent);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 428);
            this.Controls.Add(this.TitleBar_panel);
            this.Controls.Add(this.BelowPanel);
            this.Controls.Add(this.Video_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Appliction_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Appliction_KeyUp);
            this.TitleBar_panel.ResumeLayout(false);
            this.TitleBar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pbox)).EndInit();
            this.MainControl_panel.ResumeLayout(false);
            this.BelowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Volume_trackBar)).EndInit();
            this.Main_cms.ResumeLayout(false);
            this.Video_panel.ResumeLayout(false);
            this.Playlist_FlowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player_wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar_panel;
        private System.Windows.Forms.Button FullscreenBtn;
        private System.Windows.Forms.Button Min_Button;
        private System.Windows.Forms.Button Max_Button;
        private System.Windows.Forms.Button Cross_Button;
        private System.Windows.Forms.Label EliteMediaPlayer_label;
        private System.Windows.Forms.PictureBox Logo_pbox;
        private System.Windows.Forms.Panel MainControl_panel;
        private System.Windows.Forms.Button PlayPause_btn;
        private System.Windows.Forms.Panel BelowPanel;
        private System.Windows.Forms.Button Previous_btn;
        private System.Windows.Forms.Button Replay_btn;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button Volume_btn;
        private System.Windows.Forms.TrackBar Volume_trackBar;
        private System.Windows.Forms.Button PinIcon_btn;
        private System.Windows.Forms.Panel foCUS;
        private ColorSlider.ColorSlider TrackBar;
        private System.Windows.Forms.Panel Video_panel;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.ContextMenuStrip Main_cms;
        private System.Windows.Forms.ToolStripMenuItem OpenMedia_option_cms;
        private System.Windows.Forms.ToolStripMenuItem NewPlaylist_option_cms;
        private System.Windows.Forms.ToolStripMenuItem About_option_cms;
        private System.Windows.Forms.ToolStripMenuItem Exit_option_cms;
        private AxWMPLib.AxWindowsMediaPlayer Player_wmp;
        private System.Windows.Forms.Button PlaylistShow_Btn;
        private System.Windows.Forms.FlowLayoutPanel Playlist_FlowPanel;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.ToolStripMenuItem audioPlayerModeToolStripMenuItem;
        private System.Windows.Forms.Button NewPlayLBtn;
    }
}