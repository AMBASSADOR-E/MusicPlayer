using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("1. Add Music to Playlist");
                Console.WriteLine("2. Remove Music from Playlist");
                Console.WriteLine("3. Edit Music in Playlist");
                Console.WriteLine("4. Shuffle the Playlist");
                Console.WriteLine("5. Sort the Playlist");
                Console.WriteLine("6. Play Music from Playlist");
                Console.WriteLine("0. Exit");

                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Music details:");
                        Music m = new Music();
                        Console.Write("Title: ");
                        m.Title = Console.ReadLine();
                        Console.Write("Artist: ");
                        m.Artist = Console.ReadLine();
                        Console.Write("Album: ");
                        m.Album = Console.ReadLine();
                        Console.Write("Genre: ");
                        m.Genre = Console.ReadLine();
                        Console.Write("FilePath: ");
                        m.FilePath = Console.ReadLine();
                        playlist.AddMusic(m);
                        break;

                    case 2:
                        Console.WriteLine("Enter the index of the Music to remove:");
                        int index = Int32.Parse(Console.ReadLine());
                        playlist.RemoveMusic(index);
                        break;

                    case 3:
                        Console.WriteLine("Enter the index of the Music to edit:");
                        index = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Music details to update:");
                        m = new Music();
                        Console.Write("Title: ");
                        m.Title = Console.ReadLine();
                        Console.Write("Artist: ");
                        m.Artist = Console.ReadLine();
                        Console.Write("Album: ");
                        m.Album = Console.ReadLine();
                        Console.Write("Genre: ");
                        m.Genre = Console.ReadLine();
                        Console.Write("FilePath: ");
                        m.FilePath = Console.ReadLine();
                        playlist.EditMusic(index, m);
                        break;

                    case 4:
                        playlist.Shuffle();
                        break;

                    case 5:
                        playlist.Sort();
                        break;



                };
            }
        }
    }
}
