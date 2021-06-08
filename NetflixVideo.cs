using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix
{
    class NetflixVideo : Video
    {
        private string kindFilm;
        private string nameFilm;
        private string lengthFilm;
        private string link;

        public NetflixVideo()
        {
            this.kindFilm = "horrible";
            this.nameFilm = "The Witch (2015)";
            this.lengthFilm = "Feature film";
            this.link = "https://www.netflix.com/bg/title/80037280";
        }
        public NetflixVideo(string kin, string nam, string len, string lin)
        {
            this.kindFilm = kin;
            this.nameFilm = nam;
            this.lengthFilm = len;
            this.link = lin;
        }

        public void Playagain(string person)
        {
            Console.WriteLine("You gust " + person + "play again film!");
        }
        public override string ToString()
        {
            return "The first film is " + this.kindFilm + "and the name is " + this.nameFilm + "it is " + this.lengthFilm + "and this is a link for film" + this.link;
        }
    }
}
