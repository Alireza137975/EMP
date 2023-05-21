using System.Windows.Forms;
using System.Drawing;

namespace EMP
{
    static class WinState
    {
        static public string resultText = "";
        static public string tboxText = "0";
        static private string _currentWinState = "Normal";
        static private bool FullscreenBool = false;
        static internal bool FullscreenOrNot { get { return FullscreenBool; }  set { FullscreenBool = value; } }
        static private Point LastLocation;
        public static Point SetInitialLoc { set { LastLocation = value; } }
        static private int Dx = 641; //default size(x,y) 
        static private int Dy = 428;

        static public string CurrentWinState { get { return _currentWinState; } }

        internal static void TogglePin(Form form, Button pinBtn)
        {
            if (form.TopMost == false)
            {
                form.TopMost = true;
                pinBtn.ForeColor = Color.CadetBlue;
            }

            else
            {
                form.TopMost = false;
                pinBtn.ForeColor = Color.Beige;
            }
        }

        internal static void Maximize(Form form, Button MaximizeBtn)
        {
            if (CurrentWinState == "Normal")
            {
                FullscreenBool = false;
                LastLocation = form.Location;
                form.WindowState = FormWindowState.Normal;
                form.Location = new Point(0, 0);
                form.Size = SystemInformation.WorkingArea.Size;
                _currentWinState = "Maximized";
                MaximizeBtn.Text = "2";
            }

            else
            {
                Normal(form, MaximizeBtn);
            }
        }

        internal static void Minimize(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        internal static void FullScreen(Form form, Button FullscreenBtn)
        {
            //enable fullscreen
            if (!FullscreenBool)
            {
                form.WindowState = FormWindowState.Maximized;
                FullscreenBool = true;
            }

            //disable fuullscreen
            else
            {
                //before fullscreen if screen was normal
                if (CurrentWinState == "Normal")
                {
                    FullscreenBool = false;
                    form.WindowState = FormWindowState.Normal;
                    form.Location = LastLocation;
                    form.Size = new Size(Dx, Dy);
                }

                //before fullscreen if screen was maximized
                else
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Location = new Point((Size)LastLocation);
                    form.Size = SystemInformation.WorkingArea.Size;
                }
                FullscreenBool = false;
            }
        }

        private static void Normal(Form form, Button MaximizeBtn)
        {
            FullscreenBool = false;
            form.WindowState = FormWindowState.Normal;
            form.Location = LastLocation;
            form.Size = new Size(Dx, Dy);
            _currentWinState = "Normal";
            MaximizeBtn.Text = "1";
        }

        public static void SetDefaultFormSize(Size SizeOfMainForm)
        {
            Dx = SizeOfMainForm.Width;
            Dy = SizeOfMainForm.Height;
        }

        public static Size GetDefaultFormSize()
        {
            return new Size(Dx, Dy);
        }
    }
}
