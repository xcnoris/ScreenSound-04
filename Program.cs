﻿using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;


using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExbirListaDeArtistaOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "set()");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}

