using Plugin.SimpleAudioPlayer;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemeSounds
{
    public partial class App : Application
    {

        ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            player.Stop();
        }

        protected override void OnResume()
        {
        }
    }
}
