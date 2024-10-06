using System.Linq;
using ZSongs.Models;


namespace ZSongs.Filters
{
    internal class LinqFilter
    {
        public static void FilterAllGenres(List<Music> musics)
        {
            var allMusicGenres = musics.Select(genres => genres.Genre).Distinct().ToList();
            foreach (var genre in allMusicGenres)
            {
                Console.WriteLine($"- {genre}");
            }
        }

        public static void FilterArtistByMusicalGenre(List<Music> musics, string genre)
        {
            var artistByMusicalGenre = musics.Where(music => music.Genre!.Contains(genre)).Select(music => music.Artist).Distinct().ToList();
            Console.WriteLine($"displaying artis by musical genre >>> {genre}");
            foreach(var artist in artistByMusicalGenre)
            {
                Console.WriteLine($"-{artist}");
            }
        }

        public static void FilterArtistMusics(List<Music> musics, string artistName)
        {
            var artistMusic = musics.Where(music => music.Artist!.Equals(artistName)).ToList();
            Console.WriteLine(artistName);
            foreach(var music in artistMusic)
            {
                Console.WriteLine($"- {music.Name}");
            }
        }

        internal static void FilterMusicsinCSharp(List<Music> musics)
        {
            var CsharpMusics = musics.Where(Music => Music.Tones.Equals("C#")).Select(music => music.Name).ToList();
            Console.WriteLine("Musics in C#: ");
            foreach(var music in CsharpMusics)
            {
                Console.WriteLine($" - {music}");
            }
        }
    }
}
