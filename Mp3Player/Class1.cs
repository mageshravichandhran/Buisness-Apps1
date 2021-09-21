using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Mp3Player
{
  public class Song
    {
       public String Title;
       public String Artist;
      public  int minutes;
       public int seconds;


        public Song(String Title, String Artist,int minutes,int seconds)
        {

            this.Title = Title;
            this.Artist = Artist;
            this.minutes = minutes;
            this.seconds = seconds;

        }


        public void Display()
        {
            Console.WriteLine("Title of the Song : {0}",this.Title);
            Console.WriteLine("Artist of the Song : {0}", this.Artist);
            Console.WriteLine("Number of Minutes : {0}", this.minutes);
            Console.WriteLine("Number of Seconds : {0}", this.seconds);
        }




    }


    public class Player
    {
        Dictionary<String, Song> songs;
        public Player(Dictionary<string, Song> songs) {

            this.songs = songs;


          }


        public void Add()
        {
            bool start = true;
            while (start)
            {
                Console.WriteLine("Enter the Name of the Song");
                String title1 = Console.ReadLine();

                Console.WriteLine("Enter the Name of the Artist");
                string name1 = Console.ReadLine();

                Console.WriteLine("Enter the minutes of the song");
                int minutes = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the seconds of the song");
                int seconds = Convert.ToInt32(Console.ReadLine());


               

                Song newsong = new Song(title1, name1, minutes, seconds);
                this.songs.Add(newsong.Title, newsong);

                Console.WriteLine("AddedSuccessfully");

                Console.WriteLine("Add more? Y or N");

                string decision = Console.ReadLine();

                start = decision == "Y" ? true : false;
               


            }
           



        }

        public void Getsong(string title)
        {
           foreach(KeyValuePair <string,Song> keyValuePair in this.songs)
            {
                if (keyValuePair.Key == title)
                {
                    keyValuePair.Value.Display();
                    break;
                }
                else
                {
                    Console.WriteLine("not found");
                }
               
            }
        }


        public void Removesong(string title)
        {
            foreach (KeyValuePair<string, Song> keyValuePair in this.songs)
            {
                if (keyValuePair.Key == title)
                {
                    this.songs.Remove(title);
                }
                else
                {
                    Console.WriteLine("not found");
                }

            }
        }


        public void printAllsongs()
        {
            foreach (KeyValuePair<string, Song> keyValuePair in this.songs)
            {
                keyValuePair.Value.Display();

            }

        }
        

        public void printSongbyArtist(string artist)
        {
            foreach (KeyValuePair<string, Song> keyValuePair in this.songs)
            {
                if (keyValuePair.Key == artist)
                {
                    keyValuePair.Value.Display();
                }
                else
                {
                    Console.WriteLine("not found");
                }

            }
        }


        public void GetSize()
        {
            Console.WriteLine( this.songs.Count);
        }




    }


      
}
