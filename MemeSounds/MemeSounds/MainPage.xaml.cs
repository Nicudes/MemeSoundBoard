using MemeSounds.Services;
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

        public string ChosenCategory;

        public MainPage()
        {
            InitializeComponent();
            CategoryPicker.Items.Add("All");
            CategoryPicker.Items.Add("Anime");
            CategoryPicker.Items.Add("Troll");
            CategoryPicker.Items.Add("Effects");
            CategoryPicker.Items.Add("Music");

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



        private void CategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ChosenCategory = CategoryPicker.Items[CategoryPicker.SelectedIndex];
           
            
            if (ChosenCategory == "All")
            {
                AnimeMemes.IsVisible = true;
                TrollMemes.IsVisible = true;
                EffectsMemes.IsVisible = true;
                MusicMemes.IsVisible = true;
            }
            if (ChosenCategory == "Anime")
            {
                AnimeMemes.IsVisible = true;
                TrollMemes.IsVisible = false;
                EffectsMemes.IsVisible = false;
                MusicMemes.IsVisible = false;
            }
            if (ChosenCategory == "Troll")
            {
                AnimeMemes.IsVisible = false;
                TrollMemes.IsVisible = true;
                EffectsMemes.IsVisible = false;
                MusicMemes.IsVisible = false;
            }
            if (ChosenCategory == "Effects")
            {
                AnimeMemes.IsVisible = false;
                TrollMemes.IsVisible = false;
                EffectsMemes.IsVisible = true;
                MusicMemes.IsVisible = false;
            }
            if (ChosenCategory == "Music")
            {
                AnimeMemes.IsVisible = false;
                TrollMemes.IsVisible = false;
                EffectsMemes.IsVisible = false;
                MusicMemes.IsVisible = true;
            }

        }

        //Anime Sound Clicks ------------------------------------------
        private void DeJaVuAnime_Clicked(object sender, EventArgs e)
        {
            PlaySound("AnimeMemes.DejaVuAnime.mp3");
        }

        private void Nani_Clicked(object sender, EventArgs e)
        {
            PlaySound("AnimeMemes.Nani.mp3");
        }

        private void OraOra_Clicked(object sender, EventArgs e)
        {
            PlaySound("AnimeMemes.OraOra.mp3");
        }


        //Troll Sound Clicks ------------------------------------------
        private void Bruh_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.Bruh.mp3");
        }

        private void EndCareer_Clicked(object sender, EventArgs e)
        {
            PlaySound("EndCareer.mp3");
        }

        //Effects Sound Clicks ------------------------------------------
        private void AirHorn_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.AirHorn.mp3");
        }

        //Music Sound Clicks ------------------------------------------

        private void CoffinDance_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.CoffinDance.mp3");
        }
    }
}
