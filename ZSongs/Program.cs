using System.Text.Json;
using ZSongs.Models;
using ZSongs.Filters;

using (HttpClient client = new HttpClient())
{
    try 
    {   string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;

        LinqFilter.FilterMusicsinCSharp(musics);
        //musics[0].DisplayMusicDetails();
        //LinqFilter.FilterAllGenres(musics);
        //LinqOrder.DisplaArtistListOrdered(musics);
        //LinqFilter.FilterArtistByMusicalGenre(musics, "pop");
        //LinqFilter.FilterArtistMusics(musics, "Michel Teló");

        //var jhonFavoriteMusics = new FavoriteMusics("Jhon");
        //jhonFavoriteMusics.AddFavoriteMusics(musics[1]);
        //jhonFavoriteMusics.AddFavoriteMusics(musics[377]);
        //jhonFavoriteMusics.AddFavoriteMusics(musics[4]);
        //jhonFavoriteMusics.AddFavoriteMusics(musics[6]);
        //jhonFavoriteMusics.AddFavoriteMusics(musics[1467]);

        //jhonFavoriteMusics.DisplayFavoriteMusics();

        //var annaFavoriteMusics = new FavoriteMusics("Anna");
        //annaFavoriteMusics.AddFavoriteMusics(musics[600]);
        //annaFavoriteMusics.AddFavoriteMusics(musics[177]);
        //annaFavoriteMusics.AddFavoriteMusics(musics[40]);
        //annaFavoriteMusics.AddFavoriteMusics(musics[76]);
        //annaFavoriteMusics.AddFavoriteMusics(musics[17]);

        //annaFavoriteMusics.DisplayFavoriteMusics();

        //annaFavoriteMusics.GenerateJsonFile();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"We have a problem: {ex.Message}");
    }
}