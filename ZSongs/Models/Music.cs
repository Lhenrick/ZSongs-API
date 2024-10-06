
using System.Text.Json.Serialization;

namespace ZSongs.Models
{
    internal class Music
    {
        private string[] tones = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"
 };
        [JsonPropertyName("song")]
        public string? Name { get; set; }


        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duration { get; set; }

        [JsonPropertyName("genre")]
        public string? Genre { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string Tones { 
            get
            {
                return tones[Key];
            }
        }

        public void DisplayMusicDetails()
        {
            Console.WriteLine($"Artist:{Artist}");
            Console.WriteLine($"Music:{Name}");
            Console.WriteLine($"Genre:{Genre}");
            Console.WriteLine($"Duration:{Duration}");
            Console.WriteLine($"Tone:{Tones}");


        }
    }
}
