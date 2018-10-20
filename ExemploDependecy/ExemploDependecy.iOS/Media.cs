using System;
using AVFoundation;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExemploDependecy.iOS.Media))]

namespace ExemploDependecy.iOS
{
    public class Media : IMedia
    {
        AVAudioPlayer player;
        public void Play()
        {
            NSUrl url =new NSUrl("Sons/teste.mp3");
            NSError error;

            player = new AVAudioPlayer(url, "mp3", out error);
            player.Volume = 1.0f;
            player.NumberOfLoops = -1;
            player.Play();
         }
    }
}
