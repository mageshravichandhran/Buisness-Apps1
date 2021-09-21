using System;
using System.Collections.Generic;
using System.Collections;
using Mp3Player;
namespace Mp3Player
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the Name of the Song");
            //String title1 = Console.ReadLine();

            //Console.WriteLine("Enter the Name of the Artist");
            //string Name1 = Console.ReadLine();

            //Console.WriteLine("Enter the minutes of the song");
            //int minutes = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the seconds of the song");
            //int Seconds =Convert.ToInt32( Console.ReadLine());

            Song Song1 = new Song("h","e",1,2);


            Dictionary<string, Song> Songs = new Dictionary<string, Song>();

            Songs.Add(Song1.Title, Song1);


            Player firsttry = new Player(Songs);
            
          
            bool quit = false;
            while (quit==false)
            {

                Console.WriteLine("Enter A to Add song");

                Console.WriteLine("Enter G to get song");

                Console.WriteLine("Enter R to Remove a song");

                Console.WriteLine("Enter P TO PRINT ALL Songs");


                Console.WriteLine("enter B to Print songs by Artists");

                Console.WriteLine("Enter S to get the size of the playlist");

                Console.WriteLine("Enter Q to quit");


                string option = Console.ReadLine();

                if (option == "A")
                {
                    firsttry.Add();
                }
                if (option == "G")
                {
                    Console.WriteLine("enter song to get");
                    string songtitle = Console.ReadLine();
                    firsttry.Getsong(songtitle);
                }

                if (option =="R")
                {
                    Console.WriteLine("Enter song to remove");
                    string songtitle = Console.ReadLine();
                    firsttry.Removesong(songtitle);
                }

                if (option == "P")
                {
                    firsttry.printAllsongs();
                }

                if (option == "B")
                {
                    Console.WriteLine("Enter artist name to print");
                    string Artist = Console.ReadLine();
                    firsttry.printSongbyArtist(Artist);
                }

                if (option == "S")
                {
                    firsttry.GetSize();
                }

                if (option == "Q")
                {
                    quit = true;
                    break;
                }

            }
          

            

           
        }
    }
}
