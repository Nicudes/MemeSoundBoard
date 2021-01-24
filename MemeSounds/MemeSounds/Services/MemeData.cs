using MemeSounds.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemeSounds.Services
{
    public class MemeData
    {
        public static List<Meme> AnimeMemeList = new List<Meme>();



        public void GetAnimeMemeList()
        {
            AnimeMemeList.Add(new Meme() { 
            
                MemeName = "Nani",
                MemeCategory = "Anime",
                FileName = "Nani.mp3"
            });
        }

    }
}
