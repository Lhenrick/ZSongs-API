using System.Text.Encodings;
using System.Text.Json;
namespace ZSongs.Models
{
    internal class FavoriteMusics
    {
        public string? Name { get; set; }
        public List<Music> FavoriteMusicsList { get; }

        public FavoriteMusics(string name)
        {
            Name = name;
            FavoriteMusicsList = new List<Music>();
        }

        public void AddFavoriteMusics(Music music)
        {
            FavoriteMusicsList.Add(music);
        }

        public void DisplayFavoriteMusics()
        {
            Console.WriteLine($"Here are the favorite musics -> {Name}");
            foreach(var music in FavoriteMusicsList)
            {
                Console.WriteLine($"{music.Name} from {music.Artist}");
            }
            Console.WriteLine();
        }

        public void GenerateJsonFile()
        {
            string json = JsonSerializer.Serialize(new { 
                name = Name,
                music = FavoriteMusicsList
            });
            string fileName = $"favorites-musics-{Name}.json";

            File.WriteAllText(fileName, json);
            Console.WriteLine($"Json file created! {Path.GetFullPath(fileName)}");
        }
    }
}
