using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => 
            generos.Genero).Distinct().ToList();

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorgeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero.ToLower()))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine($"Exibindo artistas por genero musical - Genero: {genero}");
        foreach (var artista in artistasPorgeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicaDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);

        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
        
    }

    public static void FiltrarMusicaPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicaPorTonalidade = musicas.Where(musica => musica
            .Tonalidade
            .Equals(tonalidade))
            .Select(musica => musica.Nome)
            .ToList();

        Console.WriteLine();
        foreach(var musica in musicaPorTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
