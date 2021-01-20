using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemeSounds.Services
{
    public static class DataService
    {
        public static List<string> Memes { get; } = new List<string>
        {
            "Oh No",
            "Oh nani",
            "bruh",
            "windows logout",
            "horn",
            "goat",
        };

        public static List<string> GetSearchResults(string queryString)
        {
            var normalizedQuery = queryString?.ToLower() ?? "";
            return Memes.Where(f => f.ToLowerInvariant().Contains(normalizedQuery)).ToList();
        }
    }
}
