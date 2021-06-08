using System;
using System.Collections.Generic;

namespace Netflix
{
    class Program
    {
        private static string onemounth;
        private static string youtubeVideo;
        private static string netflixVideo;

        static void Main(string[] args)
        {
            Console.WriteLine("Hi! This is program for video!");
            Console.WriteLine("First pleas enter your username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Your username is: " + userName);
            Console.WriteLine("Now can you write what style of music you listen:");
            string music = Console.ReadLine();
            Console.WriteLine("So your favourite style of music is: " + music);
            Console.WriteLine("Now can you write what kind of films you watch:");
            string films = Console.ReadLine();
            Console.WriteLine("So your favourite kind of films is: " + films);

            List<string> firstList = new List<string>();
            firstList.Add("Sucker ");
            firstList.Add("Pak li ");
            firstList.Add("Sex ");
            
            Console.WriteLine();
            Console.WriteLine();
            List<string> secondList = new List<string>();
            secondList.Add("The matrix ");
            secondList.Add("The Lord of the Rings: The two towers ");
            secondList.Add("Die Hard ");
            Console.WriteLine("The films are: ");
            
            while (true)
            {
                Console.WriteLine("Choose what you want to wach youtube or netflix or stop to exit");
                string videoSelected = Console.ReadLine();
                if (videoSelected == "stop")
                {
                    break;
                }
                else if (videoSelected == "youtube")
                {
                    Console.WriteLine("Ok. So we have some options for you: ");
                    Console.WriteLine("The songs are: ");
                    for (int i = 0; i < firstList.Count; i++)
                    {
                        Console.Write(firstList[i] + " ,");
                    }
                }
                Console.WriteLine("Choose what you want to wach: ");
                string youtubeVideos = Console.ReadLine();
                foreach (youtubeVideos as youtubeVideo)
                {
                    if (youtubeVideos == videoSelected)
                    {
                        Console.WriteLine("Choose action with this video - " + youtubeVideo);
                        Console.WriteLine("Like / Dislike/ Share ");
                        string action = Console.ReadLine();
                        if (action == "Like")
                        {
                            youtubeVideo.Like(userName);
                        }
                        else if (action == "Dislike")
                        {
                            youtubeVideo.Unlike(userName);
                        }
                        else if (action == "Share")
                        {
                            youtubeVideo.Share(userName);
                        }
                    }
                }
                 if (videoSelected == "netflix")
                {
                    Console.WriteLine("No problem. So we have some options for you: ");
                    Console.WriteLine("The films are: ");
                    for (int q = 0; q < secondList.Count; q++)
                    {
                        Console.Write(secondList[q] + " ,");
                    }
                }
                Console.WriteLine("Choose what you want to wach: ");
                string netflixVideos = Console.ReadLine();
                foreach (netflixVideos as netflixVideo)
                {
                    if (netflixVideo == videoSelected)
                    {
                        Console.WriteLine("Choose action with this film - " + netflixVideo);
                        Console.WriteLine("Like / Dislike/ Share ");
                        string action = Console.ReadLine();
                        if (action == "Like")
                        {
                            netflixVideo.Like(userName);
                        }
                        else if (action == "Dislike")
                        {
                            netflixVideo.Unlike(userName);
                        }
                        else if (action == "Share")
                        {
                            netflixVideo.Share(userName);
                        }
                    }
                }
            }
            Console.WriteLine();

            YoutubeVideo myYoutube = new YoutubeVideo();
            Console.WriteLine(myYoutube);
            Console.WriteLine();

            NetflixVideo Netflix = new NetflixVideo();
            Console.WriteLine(Netflix);
            Console.WriteLine();

            Video Video1 = new Video();
            Console.WriteLine(Video1);
            Console.WriteLine();

            VIDEOuser mariya = new VIDEOuser();
            VIDEOuser aleks = new VIDEOuser();
            VIDEOuser vladi = new VIDEOuser();
            vladi.Username = "vladi";
            mariya.Username = "marcheto";
            aleks.Username = "aleks";
            Video Sucker = new Video();
            Sucker.Name = "Sucker";
            Video TheWitch = new Video();
            TheWitch.Name = "TheWitch";

            Sucker.Like(aleks);
            Sucker.Like(mariya);
            Sucker.Like(vladi);
            TheWitch.Like(aleks);
            TheWitch.Unlike(mariya);
            TheWitch.Like(vladi);
           
            Console.ReadLine();
        }
    }
}
