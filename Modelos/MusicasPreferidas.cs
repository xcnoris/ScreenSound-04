namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }

    private List<Musica> ListadeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome) { 
        Nome= nome;
        ListadeMusicasFavoritas = new List<Musica>();
    }
    public void AdicionarMusicaFavoritas(Musica musica)
    {
        ListadeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Musicas Favoritas do(a) >>> {Nome}");
        foreach (var musica in ListadeMusicasFavoritas)
        {
            Console.WriteLine($"-- {musica.Nome} -- {musica.Artista}");
        }
        Console.WriteLine();
    }
}
