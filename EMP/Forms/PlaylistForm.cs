using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using EMP.Classes;
using System.IO;
using System.Collections.Generic;

namespace EMP.Forms
{
    public partial class PlaylistForm : Form
    {
        public PlaylistForm()
        {
            InitializeComponent();
            if (!Playlist.IsPlaylistEmpty) UpdateDataGrid();
            StylizeDataGrid();
            DoClearPlaylist = false;
        }

        public bool DoClearPlaylist { get; set; }

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

        private void Cross_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Playlist Events

        private void AddFiles_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog
            {
                Multiselect = true,
                //Filter = "Wav(*.wav)|*.wav|Acc(*.aac)|*.aac|Wma(*.wma)|*.wma|Wmv(*.wmv)|*.wmv|Avi(*.avi)|*.avi|Mpg(*.mpg)|*.mpg|Mpeg(*.mpeg)|*.mpeg|M1v(*.m1v)|*.m1v|Mp2(*.mp2)|*.mp2|Mp3(*.mp3)|*.mp3|Mpa(*.mpa)|*.mpa|Mpe(*.mpe)|*.mpe|M3u(*.m3u)|*.m3u|Mp4(*.mp4)|*.mp4|Mov(*.mov)|*.mov|3g2(*.3g2)|*.3g2|3gp2(*.3gp2)|*.3gp2|3gp(*.3gp)|*.3gp|3gpp(*.3gpp)|*.3gpp|M4a(*.m4a)|*.m4a|Cda(*.cda)|*.cda|Aif(*.aif)|*.aif|Aifc(*.aifc)|*.aifc|Aiff(*.aiff)|*.aiff|Mid(*.mid)|*.mid|Midi(*.midi)|*.midi|Rmi(*.rmi)|*.rmi|All files (*.*)|*.*",
                Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV",
                DefaultExt = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV"
            };

            if (od.ShowDialog() == DialogResult.OK)
            {
                Playlist.AddFiles(od.FileNames);
                UpdateDataGrid();
                DoClearPlaylist = false;
            }
        }

        private void AddFolder_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                Playlist.AddFolder(fb.SelectedPath);
                UpdateDataGrid();
                DoClearPlaylist = false;
            }
        }

        private void SavePlaylist_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDi = new SaveFileDialog
            {
                FileName = "Playlist",
                Filter = "Text files (*.txt)|*.txt",
                DefaultExt = "Text files (*.txt)|*.txt"
            };

            if (saveDi.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveDi.FileName, Playlist.GetPlaylist);
            }
        }

        private void NewPlaylist_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Create New Playlist?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DoClearPlaylist = true;
                ClearDataGrid();
            }
        }

        private void LoadPlaylist_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Text Files (*.txt)|*.txt";
            if (od.ShowDialog() == DialogResult.OK)
            {
                Playlist.LoadPlaylist(File.ReadAllLines(od.FileName));
                foreach (string s in File.ReadAllLines(od.FileName)) MessageBox.Show(s);
                DoClearPlaylist = false;
            }
            UpdateDataGrid();
        }

        #endregion

        #region Private Methods

        private void StylizeDataGrid()
        {
            Playlist_datagrid.BorderStyle = BorderStyle.None;
            Playlist_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Playlist_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Playlist_datagrid.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            Playlist_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Playlist_datagrid.BackgroundColor = Color.White;
            Playlist_datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Playlist_datagrid.EnableHeadersVisualStyles = false;
            Playlist_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Playlist_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12, FontStyle.Bold);
            Playlist_datagrid.DefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            Playlist_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 59, 122);
            Playlist_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void UpdateDataGrid()
        {
            Playlist_datagrid.Rows.Clear();

            string[] Names = Playlist.GetListOfNames;

            for (int i = 0; i < Names.Length; i++)
            {
                Playlist_datagrid.Rows.Add((i + 1), Names[i]);
            }

            Repeat_check.Checked = AutoPlaylist.AllowRepitition;
            Shuffle_check.Checked = AutoPlaylist.AllowShuffle;
        }

        public void ClearDataGrid()
        {
            Playlist_datagrid.Rows.Clear();

            Repeat_check.Checked = AutoPlaylist.AllowRepitition;
            Shuffle_check.Checked = AutoPlaylist.AllowShuffle;
        }


        #endregion

        #region PlayLabel Events

        private void Play_lebel_MouseMove(object sender, MouseEventArgs e)
        {
            Play_lebel.ForeColor = Color.DarkMagenta;
        }

        private void Play_lebel_MouseDown(object sender, MouseEventArgs e)
        {
            Play_lebel.ForeColor = Color.Crimson;
        }

        private void Play_lebel_MouseLeave(object sender, EventArgs e)
        {
            Play_lebel.ForeColor = Color.Crimson;
        }

        #endregion

        private void PlaylistForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void Play_lebel_Click(object sender, EventArgs e)
        {
            AutoPlaylist.AllowRepitition = Repeat_check.Checked;
            AutoPlaylist.AllowShuffle = Shuffle_check.Checked;
            if (DoClearPlaylist)
            {
                Playlist.NewPlaylist();
            }
        }

        private void Playlist_datagrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Deletion_cms.Show(MousePosition);
            }
        }

        private void delete_cmsBtn_Click(object sender, EventArgs e)
        {
            List<string> parameters = new List<string>();

            foreach (DataGridViewRow item in Playlist_datagrid.SelectedRows)
            {
                parameters.Add(item.Cells["AudioNames"].Value.ToString());
            }
            Playlist.RemoveItems(parameters.ToArray());
            UpdateDataGrid();
        }

        private void Playlist_datagrid_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Playlist_datagrid_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] filenames = e.Data.GetData(DataFormats.FileDrop) as string[];
                FileAttributes fa = File.GetAttributes(filenames[0]);
                if (fa == FileAttributes.Directory)
                {
                    foreach (string s in filenames)
                        Playlist.AddFolder(s);
                }
                else Playlist.AddFiles(filenames);
            }
            catch { }
            finally { UpdateDataGrid(); }
        }
    }
}