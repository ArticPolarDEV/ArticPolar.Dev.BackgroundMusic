using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using WMPLib;

namespace ArticPolar.Dev.BackgroundMusic
{
    public class Player
    {
        public static void WavPlayer(string WavPath, bool PlayLooping, int LoadTimeout)
        {
            SoundPlayer Wavplayer = new SoundPlayer();
            Wavplayer.SoundLocation = WavPath;
            if (PlayLooping == true) { Wavplayer.PlayLooping(); }
            Wavplayer.LoadTimeout = LoadTimeout;
            Wavplayer.Play();
        }

        public static void Mp3Player(string Mp3Path)
        {
            WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            wplayer.URL = Mp3Path;
            wplayer.controls.play();
        }
    }
}
