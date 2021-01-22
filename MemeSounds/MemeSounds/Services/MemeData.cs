using MemeSounds.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemeSounds.Services
{
    public class MemeData
    {
        public static List<Meme> MemeList = new List<Meme>();



        public void GetMemeList()
        {
            MemeList.Add(new Meme() { 
            
                MemeName = "",
                MemeCategory = "",
                SearchWords = ""
            });

            MemeList.Add(new Meme()
            {

                MemeName = "",
                MemeCategory = "",
                SearchWords = ""
            });
        }

    }
}
