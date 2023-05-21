namespace EMP.Settings
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.TitleBar_panel = new System.Windows.Forms.Panel();
            this.foCUS = new System.Windows.Forms.Panel();
            this.EliteMediaPlayer_label = new System.Windows.Forms.Label();
            this.Cross_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Backward_cbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Forward_cbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VolDown_cbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VolUp_cbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PinPanel = new System.Windows.Forms.Panel();
            this.PinnedOn_chk = new System.Windows.Forms.RadioButton();
            this.PinnedOff_chk = new System.Windows.Forms.RadioButton();
            this.FullScrOn_chk = new System.Windows.Forms.RadioButton();
            this.FullScrOff_chk = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.Volume_cbox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Default_btn = new System.Windows.Forms.Button();
            this.TitleBar_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar_panel
            // 
            this.TitleBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TitleBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar_panel.Controls.Add(this.Default_btn);
            this.TitleBar_panel.Controls.Add(this.foCUS);
            this.TitleBar_panel.Controls.Add(this.EliteMediaPlayer_label);
            this.TitleBar_panel.Controls.Add(this.Cross_Button);
            this.TitleBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar_panel.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_panel.Name = "TitleBar_panel";
            this.TitleBar_panel.Size = new System.Drawing.Size(600, 34);
            this.TitleBar_panel.TabIndex = 3;
            this.TitleBar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // foCUS
            // 
            this.foCUS.Location = new System.Drawing.Point(244, 6);
            this.foCUS.Name = "foCUS";
            this.foCUS.Size = new System.Drawing.Size(18, 20);
            this.foCUS.TabIndex = 9;
            this.foCUS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // EliteMediaPlayer_label
            // 
            this.EliteMediaPlayer_label.AutoSize = true;
            this.EliteMediaPlayer_label.BackColor = System.Drawing.Color.Transparent;
            this.EliteMediaPlayer_label.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliteMediaPlayer_label.ForeColor = System.Drawing.Color.White;
            this.EliteMediaPlayer_label.Location = new System.Drawing.Point(6, 4);
            this.EliteMediaPlayer_label.Name = "EliteMediaPlayer_label";
            this.EliteMediaPlayer_label.Size = new System.Drawing.Size(77, 23);
            this.EliteMediaPlayer_label.TabIndex = 6;
            this.EliteMediaPlayer_label.Text = "Settings";
            this.EliteMediaPlayer_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // Cross_Button
            // 
            this.Cross_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cross_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cross_Button.FlatAppearance.BorderSize = 0;
            this.Cross_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Cross_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cross_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cross_Button.Location = new System.Drawing.Point(552, 1);
            this.Cross_Button.Name = "Cross_Button";
            this.Cross_Button.Size = new System.Drawing.Size(45, 30);
            this.Cross_Button.TabIndex = 2;
            this.Cross_Button.Text = "X";
            this.Cross_Button.UseVisualStyleBackColor = true;
            this.Cross_Button.Click += new System.EventHandler(this.Cross_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Backward_cbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Forward_cbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.VolDown_cbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.VolUp_cbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 185);
            this.panel1.TabIndex = 10;
            // 
            // Backward_cbox
            // 
            this.Backward_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Backward_cbox.FormattingEnabled = true;
            this.Backward_cbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.Backward_cbox.Location = new System.Drawing.Point(179, 145);
            this.Backward_cbox.Name = "Backward_cbox";
            this.Backward_cbox.Size = new System.Drawing.Size(57, 21);
            this.Backward_cbox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Go Backward (sec.)";
            // 
            // Forward_cbox
            // 
            this.Forward_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Forward_cbox.FormattingEnabled = true;
            this.Forward_cbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.Forward_cbox.Location = new System.Drawing.Point(179, 108);
            this.Forward_cbox.Name = "Forward_cbox";
            this.Forward_cbox.Size = new System.Drawing.Size(57, 21);
            this.Forward_cbox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Go Forward (sec.)";
            // 
            // VolDown_cbox
            // 
            this.VolDown_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VolDown_cbox.FormattingEnabled = true;
            this.VolDown_cbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.VolDown_cbox.Location = new System.Drawing.Point(179, 69);
            this.VolDown_cbox.Name = "VolDown_cbox";
            this.VolDown_cbox.Size = new System.Drawing.Size(57, 21);
            this.VolDown_cbox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Volume Down";
            // 
            // VolUp_cbox
            // 
            this.VolUp_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VolUp_cbox.FormattingEnabled = true;
            this.VolUp_cbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.VolUp_cbox.Location = new System.Drawing.Point(179, 32);
            this.VolUp_cbox.Name = "VolUp_cbox";
            this.VolUp_cbox.Size = new System.Drawing.Size(57, 21);
            this.VolUp_cbox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Volume Up";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ShortKeys Controls";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Location = new System.Drawing.Point(17, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(257, 331);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(312, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 370);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(70, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Default Controls";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.PinPanel);
            this.panel3.Controls.Add(this.FullScrOn_chk);
            this.panel3.Controls.Add(this.FullScrOff_chk);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.Volume_cbox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(15, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 136);
            this.panel3.TabIndex = 12;
            // 
            // PinPanel
            // 
            this.PinPanel.Controls.Add(this.PinnedOn_chk);
            this.PinPanel.Controls.Add(this.PinnedOff_chk);
            this.PinPanel.Location = new System.Drawing.Point(136, 14);
            this.PinPanel.Name = "PinPanel";
            this.PinPanel.Size = new System.Drawing.Size(111, 33);
            this.PinPanel.TabIndex = 10;
            // 
            // PinnedOn_chk
            // 
            this.PinnedOn_chk.AutoSize = true;
            this.PinnedOn_chk.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PinnedOn_chk.Location = new System.Drawing.Point(59, 10);
            this.PinnedOn_chk.Name = "PinnedOn_chk";
            this.PinnedOn_chk.Size = new System.Drawing.Size(41, 17);
            this.PinnedOn_chk.TabIndex = 21;
            this.PinnedOn_chk.Text = "ON";
            this.PinnedOn_chk.UseVisualStyleBackColor = true;
            // 
            // PinnedOff_chk
            // 
            this.PinnedOff_chk.AutoSize = true;
            this.PinnedOff_chk.Checked = true;
            this.PinnedOff_chk.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PinnedOff_chk.Location = new System.Drawing.Point(8, 10);
            this.PinnedOff_chk.Name = "PinnedOff_chk";
            this.PinnedOff_chk.Size = new System.Drawing.Size(45, 17);
            this.PinnedOff_chk.TabIndex = 20;
            this.PinnedOff_chk.TabStop = true;
            this.PinnedOff_chk.Text = "OFF";
            this.PinnedOff_chk.UseVisualStyleBackColor = true;
            // 
            // FullScrOn_chk
            // 
            this.FullScrOn_chk.AutoSize = true;
            this.FullScrOn_chk.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FullScrOn_chk.Location = new System.Drawing.Point(195, 90);
            this.FullScrOn_chk.Name = "FullScrOn_chk";
            this.FullScrOn_chk.Size = new System.Drawing.Size(41, 17);
            this.FullScrOn_chk.TabIndex = 25;
            this.FullScrOn_chk.Text = "ON";
            this.FullScrOn_chk.UseVisualStyleBackColor = true;
            // 
            // FullScrOff_chk
            // 
            this.FullScrOff_chk.AutoSize = true;
            this.FullScrOff_chk.Checked = true;
            this.FullScrOff_chk.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FullScrOff_chk.Location = new System.Drawing.Point(144, 90);
            this.FullScrOff_chk.Name = "FullScrOff_chk";
            this.FullScrOff_chk.Size = new System.Drawing.Size(45, 17);
            this.FullScrOff_chk.TabIndex = 24;
            this.FullScrOff_chk.TabStop = true;
            this.FullScrOff_chk.Text = "OFF";
            this.FullScrOff_chk.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(12, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Fullscreen";
            // 
            // Volume_cbox
            // 
            this.Volume_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Volume_cbox.FormattingEnabled = true;
            this.Volume_cbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.Volume_cbox.Location = new System.Drawing.Point(144, 56);
            this.Volume_cbox.Name = "Volume_cbox";
            this.Volume_cbox.Size = new System.Drawing.Size(87, 21);
            this.Volume_cbox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(12, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Volume";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pined";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Khaki;
            this.label10.Location = new System.Drawing.Point(21, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 26);
            this.label10.TabIndex = 13;
            this.label10.Text = "ShortKeys:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(67, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Applied After Restart";
            // 
            // Default_btn
            // 
            this.Default_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Default_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Default_btn.FlatAppearance.BorderSize = 0;
            this.Default_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Default_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Default_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Default_btn.ForeColor = System.Drawing.Color.IndianRed;
            this.Default_btn.Location = new System.Drawing.Point(491, 1);
            this.Default_btn.Name = "Default_btn";
            this.Default_btn.Size = new System.Drawing.Size(60, 30);
            this.Default_btn.TabIndex = 10;
            this.Default_btn.Text = "Default";
            this.Default_btn.UseVisualStyleBackColor = true;
            this.Default_btn.Click += new System.EventHandler(this.Default_btn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(600, 427);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.TopMost = true;
            this.TitleBar_panel.ResumeLayout(false);
            this.TitleBar_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PinPanel.ResumeLayout(false);
            this.PinPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar_panel;
        private System.Windows.Forms.Panel foCUS;
        private System.Windows.Forms.Label EliteMediaPlayer_label;
        private System.Windows.Forms.Button Cross_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VolUp_cbox;
        private System.Windows.Forms.ComboBox VolDown_cbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Backward_cbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Forward_cbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton PinnedOn_chk;
        private System.Windows.Forms.RadioButton PinnedOff_chk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Volume_cbox;
        private System.Windows.Forms.RadioButton FullScrOn_chk;
        private System.Windows.Forms.RadioButton FullScrOff_chk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PinPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Default_btn;
    }
}