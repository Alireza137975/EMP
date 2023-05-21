using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EMP.Settings
{
    static class Settings
    {
        public static void Intitialize(TrackBar VolumeBar,Form Main,Button Pinned, Button Fullscr)
        {
            VolumeBar.Value = defVolume_P;
            if (defFullscreen_P == true) WinState.FullScreen(Main, Fullscr);
            if (defPined_P == true) WinState.TogglePin(Main, Pinned);
        }

        public static void DeafaultSettings()
        {
            Update("5", "5", "5", "5", "100", false, false);
        }

        public static void Update(string _Vup, string _Vdown, string _forw, string _back, string _dVol, bool _dFullscr, bool _dPin)
        {
            VolUp_P = int.Parse(_Vup);
            VolDown_P = int.Parse(_Vdown);
            Forward_P = int.Parse(_forw);
            Backward_P= int.Parse(_back);
            defVolume_P= int.Parse(_dVol);
            defPined_P = _dPin;
            defFullscreen_P = _dFullscr;
            Properties.Settings.Default.Save();
        }

        public static int VolUp_P
        {
            get { return Properties.Settings.Default.VolUp; }
            private set { Properties.Settings.Default.VolUp = value; }
        }
        public static int VolDown_P
        {
            get { return Properties.Settings.Default.VolDown; }
            private set { Properties.Settings.Default.VolDown = value; }
        }
        public static int Forward_P
        {
            get { return Properties.Settings.Default.Foward; }
            private set { Properties.Settings.Default.Foward = value; }
        }
        public static int Backward_P
        {
            get { return Properties.Settings.Default.Backward; }
            private set { Properties.Settings.Default.Backward = value; }
        }
        public static int defVolume_P
        {
            get { return Properties.Settings.Default.defVolume; }
            private set { Properties.Settings.Default.defVolume = value; }
        }
        public static bool defPined_P
        {
            get { return Properties.Settings.Default.defPined; }
            private set { Properties.Settings.Default.defPined = value; }
        }
        public static bool defFullscreen_P
        {
            get { return Properties.Settings.Default.defFullscreen; }
            private set { Properties.Settings.Default.defFullscreen = value; }
        }
    }
}
