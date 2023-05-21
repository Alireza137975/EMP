using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EMP.Settings
{
    public partial class SettingsForm : Form
    {
        private bool DefPinned { get { return PinnedOn_chk.Checked; } }
        private bool DefFullscreen { get { return FullScrOn_chk.Checked; } }

        public SettingsForm()
        {
            InitializeComponent();
            IntializeFromSetting();
            this.ShowDialog();
        }


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

        private void Cross_Button_Click(object sender, EventArgs e)
        {
            Settings.Update(VolUp_cbox.Text, VolDown_cbox.Text, Forward_cbox.Text, Backward_cbox.Text, Volume_cbox.Text, DefFullscreen, DefPinned);
            this.Close();
        }

        private void IntializeFromSetting()
        {
            VolUp_cbox.Text = Settings.VolUp_P.ToString();
            VolDown_cbox.Text = Settings.VolDown_P.ToString();
            Forward_cbox.Text = Settings.Forward_P.ToString();
            Backward_cbox.Text = Settings.Backward_P.ToString();
            Volume_cbox.Text = Settings.defVolume_P.ToString();
            if (Settings.defPined_P) PinnedOn_chk.Checked = true;
            if (Settings.defFullscreen_P) FullScrOn_chk.Checked = true;
        }

        private void Default_btn_Click(object sender, EventArgs e)
        {
            foCUS.Focus();
            if (MessageBox.Show("Are You Sure You Want The Setting ToBe Set To Default?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Settings.DeafaultSettings();
            }
        }
    }
}
