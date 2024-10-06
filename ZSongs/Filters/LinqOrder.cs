using System.Linq;
using ZSongs.Models;


namespace ZSongs.Filters
{
    internal class LinqOrder
    {
        public static void DisplaArtistListOrdered(List<Music> musics)
        {
            var orderedArtist = musics.OrderBy(music => music.Artist).Select(music => music.Artist).Distinct().ToList();
            Console.WriteLine("List of artists ordered");
            foreach(var artist in orderedArtist)
            {
                Console.WriteLine($"- {artist}");
            }
        }
    }
}
