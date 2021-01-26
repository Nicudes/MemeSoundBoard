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
        private void Damn_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.Damn.mp3");
        }
        private void DarthVaderNo_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.DarthVaderNo.mp3");
        }
        private void DoorKnock_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.DoorKnock.mp3");
        }
        private void DryFart_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.DryFart.mp3");
        }
        private void EndCareer_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.EndCareer.mp3");
        }
        private void FakeLaugh_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.FakeLaugh.mp3");
        }
        private void FartNormal_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.FartNormal.mp3");
        }
        private void FuckThisShitImOut_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.FuckThisShitImOut.mp3");
        }
        private void HeFuckedUp_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.HeFuckedUp.mp3");
        }
        private void IGotU_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.IGotU.mp3");
        }
        private void InsideTheirHead_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.InsideTheirHead.mp3");
        }
        private void ItIsWhatItIs_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.ItIsWhatItIs.mp3");
        }
        private void MyNameIsJeff_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.MyNameIsJeff.mp3");
        }
        private void NelsonHaha_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.NelsonHaha.mp3");
        }
        private void Nope_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.Nope.mp3");
        }
        private void OhNo_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.OhNo.mp3");
        }
        private void PHDrums_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.PHDrums.mp3");
        }
        private void Shrek_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.Shrek.mp3");
        }
        private void ShutUp_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.ShutUp.mp3");
        }
        private void SupriseMotherFucker_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.SupriseMotherfucker.mp3");
        }
        private void TheyAskYou_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.TheyAskYou.mp3");
        }
        private void ToBeContinue_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.ToBeContinue.mp3");
        }
        private void WhatAreUDoingStepBro_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.WhatAreUDoingStepBro.mp3");
        }
        private void WhyAreYouRunning_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.WhyAreURunning.mp3");
        }
        private void WhyUBullyMe_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.WhyUBullyMe.mp3");
        }
        private void WhyUhaffToBeSad_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.WhyUhaffToBeSad.mp3");
        }
        private void YouWhat_Clicked(object sender, EventArgs e)
        {
            PlaySound("TrollMemes.YouWhat.mp3");
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
