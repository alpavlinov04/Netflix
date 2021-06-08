using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix
{
    class YoutubeVideo :  Video
    {
        private string style;
        private string name;
        private double lengthMusic;
        private string Speed;
        private string Link;

        public YoutubeVideo(string st, string n, double len, string s, string Lin)
        {
            this.style = st;
            this.name = n;
            this.lengthMusic = len;
            this.Speed = s;
            this.Link = Lin;
        }
        public YoutubeVideo()
        {
            this.style = "Pop";
            this.name = "Sucker";
            this.lengthMusic = 4.50;
            this.Speed = "normal";
            this.Link = "https://www.youtube.com/watch?v=YysWbPzkgpo";
        }
        
        public void Return(string person)
        {
            Console.WriteLine("You" + person + "return a small part of video!");
        }
        public override string ToString()
        {
            return "The first film is " + this.style + "and the name is " + this.name + "it is " + this.lengthMusic + "the speed of music is " + this.Speed + "and this is a link for film " + this.Link;
        }
    }
}
