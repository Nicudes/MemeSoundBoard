using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemeSounds
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            player.Stop();
            base.OnDisappearing();
        }

        ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;


        void PlaySound(string soundName)
        {
            player.Stop();
            player.Load(GetStreamFromFile(soundName));
            player.Play();
        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("MemeSounds.MemeSounds." + filename);

            return stream;
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }

        private void One_Clicked(object sender, EventArgs e)
        {
            PlaySound("Bruh.mp3");
        }

        private void Two_Clicked(object sender, EventArgs e)
        {
            PlaySound("OhNo.mp3");
        }

        private void Three_Clicked(object sender, EventArgs e)
        {
            PlaySound("Nani.mp3");
        }

        private void Four_Clicked(object sender, EventArgs e)
        {
            PlaySound("WinXP.mp3");
        }

    }
}
