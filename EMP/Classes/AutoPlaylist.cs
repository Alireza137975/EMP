using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.Classes
{
    static class AutoPlaylist
    {
        public static bool AutoPlay = false;
        public static bool AllowRepitition = false;
        public static bool AllowShuffle = false;
        public static string CurrentTrack { get; set; }

        public static void AutoPlayStarts(AxWMPLib.AxWindowsMediaPlayer player)
        {
            if (AutoPlay)
            {
                if (AllowShuffle == false)
                {
                    ControlCentre.OpenMedia(Playlist.GetFirstTrack, player);
                    CurrentTrack = Playlist.GetFirstTrack;
                }

                else
                {
                    CurrentTrack = Playlist.GetRandomTrack;
                    ControlCentre.OpenMedia(CurrentTrack, player);
                }
            }
        }

        public static void PlayNextTrack(AxWMPLib.AxWindowsMediaPlayer player)
        {
            if (AutoPlay)
            {
                CurrentTrack = Playlist.SelectTrack('N', CurrentTrack, AllowRepitition, AllowShuffle);
                ControlCentre.OpenMedia(CurrentTrack, player);
            }
        }

        public static void PlayPreviousTrack(AxWMPLib.AxWindowsMediaPlayer player)
        {
            if (AutoPlay)
            {
                CurrentTrack = Playlist.SelectTrack('P', CurrentTrack, AllowRepitition, AllowShuffle);
                ControlCentre.OpenMedia(CurrentTrack, player);
            }
        }

        //maybe not needed
        public static void ReInstantiate()
        {
            AutoPlay = true;
            AllowRepitition = false;
            AllowShuffle = false;
        }
    }
}