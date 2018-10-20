using System;
using Android.Media;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExemploDependecy.Droid.Media))]

namespace ExemploDependecy.Droid
{

    public class Media : IMedia
    {
        MediaPlayer mp;

        public void Play()
        {
              mp = MediaPlayer.Create(Android.App.Application.Context, Resource.Raw.teste);

            mp.Start();
             
        }
    }
}
