using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqOrder
{
    public static void ExbirListaDeArtistaOrdenados(List<Musica> musicas)
    {
        /*
            OrderBy() = Ordena de forma cendente. EXP: ABC
            OrderByDecending() = Ordena de forma decendente. EXP: CBA

            Select() = Seleciona apenas a propriedade artistas
            Distinct() = Não deixa retorna mais de uma vez o mesmo nome de artista
            ToList() = Retorna como lista(nao é necessario nesse caso)
        */
        var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musicas => musicas.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados\n");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
        
    }
}
