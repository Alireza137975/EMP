using System;
using System.Drawing;
using EMP.Forms;
using EMP.Settings;
using EMP.Classes;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace EMP
{
    public partial class MainForm : Form
    {
        #region Fields And Properties

        public static bool isReady = false;
        public int VolumeProp
        {
            get { return Volume_trackBar.Value; }
            set
            {
                if (value > 100)
                {
                    Volume_trackBar.Value = 100;
                }

                else if (value <= 0)
                {
                    Volume_trackBar.Value = 0;
                }

                else
                {
                    Volume_trackBar.Value = value;
                }
                Player_wmp.settings.volume = Volume_trackBar.Value;
            }
        }

        public int TrackBarProp
        {
            get { return TrackBar.Value; }
            set
            {
                if (value > TrackBar.Maximum)
                {
                    TrackBar.Value = TrackBar.Maximum - 1;
                }

                else if (value <= 0)
                {
                    TrackBar.Value = 0;
                }

                else
                {
                    TrackBar.Value = value;
                }
                Player_wmp.Ctlcontrols.currentPosition = TrackBar.Value;
            }
        }

        #endregion

        #region MainForm 

        public MainForm()
        {
            InitializeComponent();
            Intializer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Settings.Settings.Intitialize(Volume_trackBar, this, PinIcon_btn, FullscreenBtn);
            WinState.SetInitialLoc = this.Location;
        }

        #endregion

        #region TitleBar

        #region fields

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        private void TitleBar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        #region PinBtn
        private void PinIcon_btn_Click(object sender, EventArgs e)
        {
            WinState.TogglePin(this, PinIcon_btn);
        }
        #endregion

        #region CrossBtn

        private void Cross_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region MaximizeBtn

        private void Max_Button_Click(object sender, EventArgs e)
        {
            WinState.Maximize(this, Max_Button);
        }

        #endregion

        #region MinimizeBtn

        private void Min_Button_Click(object sender, EventArgs e)
        {
            WinState.Minimize(this);
        }

        #endregion

        #region FullscreenBtn

        private void FullscreenBtn_Click(object sender, EventArgs e)
        {
            WinState.FullScreen(this, FullscreenBtn);
        }

        #endregion

        #endregion

        #region TitleBar Events

        private void PinIcon_btn_ForeColorChanged(object sender, EventArgs e)
        {
            foCUS.Focus();
        }

        private void Cross_Button_MouseMove(object sender, MouseEventArgs e)
        {
            Cross_Button.ForeColor = Color.FromArgb(222, 82, 70);
        }

        private void Max_Button_MouseMove(object sender, MouseEventArgs e)
        {
            Max_Button.ForeColor = Color.FromArgb(76, 156, 186);
        }

        private void Min_Button_Move(object sender, MouseEventArgs e)
        {
            Min_Button.ForeColor = Color.FromArgb(76, 156, 186);
        }

        private void CMM_Buttons_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = SystemColors.ButtonHighlight;
        }

        #endregion

        #region PlayerEvents

        private void Player_wmp_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            TrackBar.Value = 0;
            TrackBar.Maximum = ConvertToSec(Player_wmp.Ctlcontrols.currentItem.durationString);
        }

        private void Player_wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (Player_wmp.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                UpdateTimer.Start();
                PlayPauseIcon(false);
            }

            else
            {
                UpdateTimer.Stop();
                PlayPauseIcon(true);
            }

            if (Player_wmp.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                if (isReady)
                {
                    AutoPlaylist.PlayNextTrack(Player_wmp);
                    UpdateTimer.Start();
                    PlayPauseIcon(false);
                }
            }

            if (Player_wmp.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                try
                {
                    Player_wmp.Ctlcontrols.play();
                    UpdateTimer.Start();
                    PlayPauseIcon(false);
                }
                catch { }
            }
        }

        private void Volume_trackBar_Scroll(object sender, EventArgs e)
        {
            Player_wmp.settings.volume = Volume_trackBar.Value;
            ControlCentre.lastVolume = Player_wmp.settings.volume;
        }

        private void Volume_btn_Click(object sender, EventArgs e)
        {
            ControlCentre.ToggleMute(Player_wmp, Volume_btn, Volume_trackBar);
        }

        #endregion

        #region Trackbar Events

        private void TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Player_wmp.Ctlcontrols.currentPosition = TrackBar.Value;
            UpdateTimer.Start();
            foCUS.Focus();
        }

        private void TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateTimer.Stop();
        }

        #endregion

        #region Main Control Events (from bottom panel)

        private void PlayPause_btn_Click(object sender, EventArgs e)
        {
            if (Player_wmp.Visible == false)
            {
                ControlCentre.ODialog(Player_wmp);
            }

            else
            {
                if (Player_wmp.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    Player_wmp.Ctlcontrols.pause();
                    PlayPauseIcon(true);
                }

                else
                {
                    Player_wmp.Ctlcontrols.play();
                    PlayPauseIcon(false);
                }
            }
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            Player_wmp.Ctlcontrols.fastForward();
            TrackBar.Value = 0;
        }

        private void Replay_btn_Click(object sender, EventArgs e)
        {
            if (Player_wmp.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Player_wmp.Ctlcontrols.currentPosition = 0;
            }
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            AutoPlaylist.PlayNextTrack(Player_wmp);

            string currName = Path.GetFileName(AutoPlaylist.CurrentTrack);

            foreach (Control cc in Playlist_FlowPanel.Controls)
            {
                if (currName == cc.Text)
                {
                    Button ccbtn = (Button)cc;
                    btnB.BackColor = Color.FromArgb(45, 45, 48);
                    ccbtn.BackColor = Color.FromArgb(0, 122, 204);
                    btnB = ccbtn;
                }
            }
        }

        private void Previous_btn_Click(object sender, EventArgs e)
        {
            AutoPlaylist.PlayPreviousTrack(Player_wmp);

            string currName = Path.GetFileName(AutoPlaylist.CurrentTrack);

            foreach (Control cc in Playlist_FlowPanel.Controls)
            {
                if (currName == cc.Text)
                {
                    Button ccbtn = (Button)cc;
                    btnB.BackColor = Color.FromArgb(45, 45, 48);
                    ccbtn.BackColor = Color.FromArgb(0, 122, 204);
                    btnB = ccbtn;
                }
            }
        }

        #endregion

        #region CMS Events

        private void OpenMedia_option_cms_Click(object sender, EventArgs e)
        {
            ControlCentre.ODialog(Player_wmp);
        }

        private void audioPlayerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Size.Height == 428) this.Size = new Size(641, 102);
            else this.Size = new Size(641, 428);
        }

        private void NewPlaylist_option_cms_Click(object sender, EventArgs e)
        {
            foCUS.Focus();
            PlaylistForm pf = new PlaylistForm();


            if (pf.ShowDialog() == DialogResult.OK)
            {
                if (Playlist.IsPlaylistEmpty == false)
                {
                    UpdateFlowPanel();
                    AutoPlaylist.AutoPlay = true;
                    AutoPlaylist.AutoPlayStarts(Player_wmp);
                    MakeSameSize(Playlist_FlowPanel);
                    SELECTION();
                }

                else
                {
                    AutoPlaylist.AutoPlay = false;
                    UpdateFlowPanel();
                    newBtn();
                }
            }
        }

        private void About_option_cms_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
        }

        private void Exit_option_cms_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Private Methods

        private void SELECTION()
        {
            string currName = Path.GetFileName(AutoPlaylist.CurrentTrack);

            foreach (Control cc in Playlist_FlowPanel.Controls)
            {
                if (currName == cc.Text)
                {
                    Button ccbtn = (Button)cc;
                    btnB.BackColor = Color.FromArgb(45, 45, 48);
                    ccbtn.BackColor = Color.FromArgb(0, 122, 204);
                    btnB = ccbtn;
                    break;
                }
            }
        }

        private void MakeSameSize(Panel pan)
        {
            foreach (Control item in pan.Controls)
            {
                item.Width = (int)Maxsize.Width+15;
            }
        }

        private void Intializer()
        {
            Player_wmp.settings.volume = Volume_trackBar.Value;
            Player_wmp.Ctlenabled = false;
            Player_wmp.windowlessVideo = true;
            Player_wmp.stretchToFit = true;
            Playlist_FlowPanel.AutoScroll = true;
            Playlist_FlowPanel.WrapContents = false;
            btnB = new Button();
        }

        private void UpdateFlowPanel()
        {
            Playlist_FlowPanel.Controls.Clear();

            foreach (string item in Playlist.GetListOfNames)
            {
                Playlist_FlowPanel.Controls.Add(GenerateButton(item));
            }
        }

        private void PlayPauseIcon(bool ChangeToPlay)
        {
            if (ChangeToPlay)
            {
                PlayPause_btn.Font = new Font("MS Reference Sans Serif", 18.00f);
                PlayPause_btn.TextAlign = ContentAlignment.MiddleCenter;
                PlayPause_btn.Text = "▶";
            }

            else
            {
                PlayPause_btn.Font = new Font("MS Reference Sans Serif", 21.75f);
                PlayPause_btn.TextAlign = ContentAlignment.TopCenter;
                PlayPause_btn.Text = "⏸";
            }
        }

        private int ConvertToSec(string dur)
        {
            int timeInSec = 0;
            string[] pieces = dur.Split(':');
            if (pieces.Length == 2)
            {
                timeInSec = int.Parse(pieces[0]) * 60;
                timeInSec += int.Parse(pieces[1]);
            }

            else if (pieces.Length == 3)
            {
                timeInSec = int.Parse(pieces[0]) * 60 * 60;
                timeInSec += int.Parse(pieces[1]) * 60;
                timeInSec += int.Parse(pieces[2]);
            }
            return timeInSec;
        }

        #endregion

        #region Miscellaneous Events

        private void newBtn()
        {
            Button btn22 = new Button();
            btn22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btn22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            btn22.FlatAppearance.BorderSize = 0;
            btn22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            btn22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn22.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn22.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btn22.Location = new System.Drawing.Point(0, 0);
            btn22.Margin = new System.Windows.Forms.Padding(0);
            btn22.Name = "NewPlayLBtn";
            btn22.Size = new System.Drawing.Size(235, 49);
            btn22.TabIndex = 13;
            btn22.TabStop = false;
            btn22.Text = "New Playlist";
            btn22.UseVisualStyleBackColor = false;
            btn22.Click += new System.EventHandler(this.NewPlayLBtn_Click);
            Playlist_FlowPanel.Controls.Add(btn22);
        }

        private void NewPlayLBtn_Click(object sender, EventArgs e)
        {
            NewPlaylist_option_cms_Click(sender, e);
        }

        private void BottomMain_btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.FromArgb(0, 122, 204);
        }

        private void Video_panel_Click(object sender, EventArgs e)
        {
            Playlist_FlowPanel.Visible = false;
            this.Focus();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            foCUS.Focus();
            SettingsForm sf = new SettingsForm();
        }

        private void FoucsToMain_trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Control cc in MainControl_panel.Controls)
            {
                cc.ForeColor = SystemColors.ButtonFace;
            }
            PlaylistShow_Btn.ForeColor = SystemColors.ButtonFace;
            foCUS.Focus();
        }

        private void PlaylistShow_Btn_Click_1(object sender, EventArgs e)
        {
            if (Playlist_FlowPanel.Visible == false) Playlist_FlowPanel.Visible = true;
            else Playlist_FlowPanel.Visible = false;
        }

        static SizeF Maxsize = new SizeF();

        private Button GenerateButton(string btnText)
        {
            Button b = new Button();
            b.AutoSize = true;
            b.Text = btnText;
            b.Font = new Font("Lucida Console", 12, FontStyle.Regular);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Margin = new Padding(0, 0, 0, 0);
            b.ForeColor = SystemColors.ControlLight;
            b.TextAlign = ContentAlignment.MiddleLeft;
            using (Graphics cg = this.CreateGraphics())
            {
                SizeF ss = cg.MeasureString(btnText, b.Font);
                if (ss.Width > Maxsize.Width) Maxsize = ss;
            }
            b.Click += new EventHandler(PlaylistFile_Click);
            return b;
        }

        static Button btnB;
        private void PlaylistFile_Click(object sender, EventArgs e)
        {
            btnB.BackColor = Color.FromArgb(45, 45, 48);
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(0, 122, 204);
            string address = Playlist.SearchByName(btn.Text);
            ControlCentre.OpenMedia(address, Player_wmp);
            btnB = btn;
        }

        private void HidePlaylist_OnClick(object sender, EventArgs e)
        {
            Playlist_FlowPanel.Visible = false;
            this.Focus();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            TrackBar.Value = ConvertToSec(Player_wmp.Ctlcontrols.currentPositionString);
        }

        private void Player_wmp_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            Playlist_FlowPanel.Visible = false;
            this.Focus();

            if (e.nButton == 2)
            {
                Main_cms.Show(MousePosition);
            }
        }

        private void ShowMainCms_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) Main_cms.Show(MousePosition);
        }

        private void MainControl_panel_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        #endregion

        #region ShortKey Event

        private void Appliction_KeyUp(object sender, KeyEventArgs e)
        {
            if (Player_wmp.playState == WMPLib.WMPPlayState.wmppsPlaying || Player_wmp.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                if (e.KeyCode == Keys.Up) VolumeProp += Settings.Settings.VolUp_P;
                else if (e.KeyCode == Keys.Down) VolumeProp -= Settings.Settings.VolDown_P;
                else if (e.KeyCode == Keys.Left)
                {
                    TrackBarProp -= Settings.Settings.Backward_P;
                    UpdateTimer.Start();
                }
                else if (e.KeyCode == Keys.Right)
                {
                    TrackBarProp += Settings.Settings.Forward_P;
                    UpdateTimer.Start();
                }
                else if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter) ControlCentre.TogglePlayPause(Player_wmp);
                else if (e.Alt && e.KeyData != (Keys.RButton | Keys.ShiftKey | Keys.Alt) || e.KeyCode == Keys.F || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6)
                {
                    WinState.FullScreen(this, FullscreenBtn);
                }
            }
        }

        private void Appliction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                UpdateTimer.Stop();
            }
        }

        #endregion

        #region dragNdrop
        private void Video_panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Video_panel_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = e.Data.GetData(DataFormats.FileDrop) as string[];
            ControlCentre.OpenMedia(filenames[0],Player_wmp);

        }
        #endregion
    }
}