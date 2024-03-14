using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[0].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "Rock");
        // LinqFilter.FiltrarMusicaDeUmArtista(musicas, "Justin Bieber");

        //var musicasPreferidasDoGabe = new MusicasPreferidas("Gabe");
        //musicasPreferidasDoGabe.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoGabe.AdicionarMusicasFavoritas(musicas[5]);
        //musicasPreferidasDoGabe.AdicionarMusicasFavoritas(musicas[22]);
        //musicasPreferidasDoGabe.AdicionarMusicasFavoritas(musicas[42]);
        //musicasPreferidasDoGabe.AdicionarMusicasFavoritas(musicas[114]);


        //var musicasPreferidasDaJoy = new MusicasPreferidas("Joy");
        //musicasPreferidasDaJoy.AdicionarMusicasFavoritas(musicas[600]);
        //musicasPreferidasDaJoy.AdicionarMusicasFavoritas(musicas[41]);
        //musicasPreferidasDaJoy.AdicionarMusicasFavoritas(musicas[706]);
        //musicasPreferidasDaJoy.AdicionarMusicasFavoritas(musicas[1117]);
        //musicasPreferidasDaJoy.AdicionarMusicasFavoritas(musicas[1744]);
        
        //musicasPreferidasDaJoy.ExibirMusicasFavoritas();
        //Console.WriteLine();
        //musicasPreferidasDaJoy.GerarArquivoJson();
    }   
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

    
}