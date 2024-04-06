using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        //                                  - seleciona algo dentro da lista - Nao pode valores iguais e retorna como lista
        var todosOsGenerosMusicais = musicas.Select(musicas => musicas.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($" - {genero}");
        }
    }
}
