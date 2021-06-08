using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix
{
    class Video : Reactable
    {
        private string kind;
        private int length;

        private string name;
        private string description;
        private int likes;

        public Video()
        {
            this.kind = "Music";
            this.length = 5;
        }
        public Video(string k, int l)
        {
            this.kind = k;
            this.length = l;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void Like(VIDEOuser user)
        {
            this.likes++;
            Console.WriteLine("User " + user.Username + " liked the video " + this.name + ". This video now has " + this.likes + " likes");
        }

        public void Unlike(VIDEOuser user)
        {
            this.likes--;
            Console.WriteLine("User " + user.Username + " disliked our video " + this.name + ". This video now has " + this.likes);
        }
        public void Share(VIDEOuser user)
        {
            Console.WriteLine("User " + user.Username + " share our video " + this.name + ". This video now has " + this.likes);
        }
        public void Play(string person)
        {
            Console.WriteLine("You" + person + "play a video!");
        }
        public void Stop(string person)
        {
            Console.WriteLine("You" + person + "stop a video!");
        }
        public override string ToString()
        {
            return "The first kind is " + this.kind + " and the length is " + this.length;
        }
    }
}
