using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        /*
            Select = seleciona algo dentro da lista 
            Distinct = Nao pode valores iguais
            ToList = retorna como lista        
         */
        var todosOsGenerosMusicais = musicas.Select(musicas => musicas.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($" - {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        /*
            Where() = Filtra class da lista, onde o valor do metodo seja atendido
            Contains() = Retorna class que existe um valor x dentro do metodo, mesmo que dentro do metodo exita dois valores. EXP: x and y
         */
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artista pelo que catam musica do genero{genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}

