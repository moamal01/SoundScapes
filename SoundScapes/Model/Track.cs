using System;
using System.Collections.Generic;
using System.Text;

namespace SoundScapes.Model
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Locator { get; set; }

        Random Random = new Random();

        public Track(string Locator)
        {
            Id = Random.Next(100);
            this.Locator = Locator;
        }
    }
}
