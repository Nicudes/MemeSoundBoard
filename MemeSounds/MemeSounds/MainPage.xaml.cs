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

        #region ANIME
        //Anime Sound Clicks ------------------------------------------
        private void AnimeSpeedSong_Clicked(object sender, EventArgs e)
        {
            PlaySound("AnimeMemes.AnimeSpeedSong.mp3");
        }
        private void AraAra_Clicked(object sender, EventArgs e)
        {
            PlaySound("AnimeMemes.AraAra.mp3");
        }
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
        #endregion
        #region TROLL

        //-------------------------------------------------------------
        //Troll Sound Clicks ------------------------------------------
        //-------------------------------------------------------------
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
        #endregion

        #region EFFECTS
        //Effects Sound Clicks ------------------------------------------
        private void AirHorn_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.AirHorn.mp3");
        }
        private void BadumTs_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.BadumTs.mp3");
        }
        private void CSEnemySpoted_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.CSEnemySpoted.mp3");
        }
        private void DiscordConnected_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.DiscordConnected.mp3");
        }
        private void DiscordNotification_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.DiscordNotification.mp3");
        }
        private void Error_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.Error.mp3");
        }
        private void Fail_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.Fail.mp3");
        }
        private void FBIOpen_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.FBIOpen.mp3");
        }
        private void GhostAttack_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.GhostAttack.mp3");
        }
        private void GhostGroan_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.GhostGroan.mp3");
        }
        private void GTADeath_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.GTADeath.mp3");
        }
        private void Headshot_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.Headshot.mp3");
        }
        private void HereComesTheMoney_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.HereComesTheMoney.mp3");
        }
        private void MailMotherfucker_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.MailMotherfucker.mp3");
        }
        private void MissionFailed_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.MissionFailed.mp3");
        }
        private void MissionImpossible_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.MissionImpossible.mp3");
        }
        private void Nut_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.Nut.mp3");
        }
        private void ObiHelloThere_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.ObiHelloThere.mp3");
        }
        private void Ouf_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.Ouf.mp3");
        }
        private void Quack_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.Quack.mp3");
        }
        private void SadTrombone_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.SadTrombone.mp3");
        }
        private void WinXP_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.WinXP.mp3");
        }
        private void WowSound_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.WowSound.mp3");
        }
        private void Wrong_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.Wrong.mp3");
        }
        private void Yeet_Clicked(object sender, EventArgs e)
        {
            PlaySound("EffectsMemes.Yeet.mp3");
        }
        #endregion

        #region MUSIC
        //Music Sound Clicks ------------------------------------------
        private void AmongUs_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.AmongUs.mp3");
        }
        private void Celebration_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.Celebration.mp3");
        }
        private void CoffinDance_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.CoffinDance.mp3");
        }
        private void CrabRave_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.CrabRave.mp3");
        }
        private void CykaBlyatSong_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.CykaBlyatSong.mp3");
        }
        private void DanceIt_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.DanceIt.mp3");
        }
        private void Darude_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.Darude.mp3");
        }
        private void EpicSax_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.EpicSax.mp3");
        }
        private void HelloDarknessMyOldFriend_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.HelloDarknessMyOldFriend.mp3");
        }
        private void ItsMyLifeRuski_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.ItsMyLifeRuski.mp3");
        }
        private void MemeEnd_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.MemeEnd.mp3");
        }
        private void OhWhatUSay_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.OhWhatUSay.mp3");
        }
        private void OhYouTouchMy_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.OhYouTouchMy.mp3");
        }
        private void OhYeah_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.OhYeah.mp3");
        }
        private void PeppaPig_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.PeppaPig.mp3");
        }
        private void RickRoll_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.RickRoll.mp3");
        }
        private void RunEffect_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.RunEffect.mp3");
        }
        private void SadFail_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.SadFail.mp3");
        }
        private void SadViolin_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.SadViolin.mp3");
        }
        private void SeinfeldTheme_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.SeinfeldTheme.mp3");
        }
        private void SexySong_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.SexySong.mp3");
        }
        private void ShootingStarsSong_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.ShootingStarsSong.mp3");
        }
        private void Skrah_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.Skrah.mp3");
        }
        private void SmokeWeed_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.SmokeWeed.mp3");
        }
        private void SnoopDog_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.SnoopDog.mp3");
        }
        private void TitanicFlute_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.TitanicFlute.mp3");
        }
        private void Trollolo_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.trollolo.mp3");
        }
        private void UGotThat_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.UGotThat.mp3");
        }
        private void UniversalMusicScream_Clicked(object sender, EventArgs e)
        {
            PlaySound("MusicMemes.UniversalMusicScream.mp3");
        } 
        #endregion
    }
}
