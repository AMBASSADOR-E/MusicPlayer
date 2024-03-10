using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Playlist
    {
        public List<Music> Musics { get; set; }

        public Playlist()
        {
            Musics = new List<Music>();
        }

        public void AddMusic(Music m)
        {
            Musics.Add(m);
            Console.WriteLine("Music added to the playlist");
        }

        public void RemoveMusic(int index)
        {
            if (index >= 0 && index < Musics.Count)
            {
                Musics.RemoveAt(index);
                Console.WriteLine("Music removed from the playlist");
            }
            else
            {
                Console.WriteLine("Invalid music index");
            }
        }

        public void EditMusic(int index, Music m)
        {
            if (index >= 0 && index < Musics.Count)
            {
                Musics[index] = m;
                Console.WriteLine("Music edited successfully");
            }
            else
            {
                Console.WriteLine("Invalid music index");
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            Musics = Musics.OrderBy(x => rnd.Next()).ToList();
            Console.WriteLine("Playlist shuffled successfully");
        }

        public void Sort()
        {
            Musics = Musics.OrderBy(x => x.Title).ToList();
            Console.WriteLine("Playlist sorted successfully");
        }
    }
}
