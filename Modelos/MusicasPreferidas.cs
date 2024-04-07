namespace ScreenSound_04.Modelos;
using System.Text.Json;

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

    // Gerando arquivo Json das musicas favoritas
    public void GerarArquivoJson()
    {
        try
        {

            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListadeMusicasFavoritas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"O arquivo Json foi criado com sucesso :) | {Path.GetFullPath(nomeDoArquivo)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um [ERRO]: {ex.Message}");
        }
    }
}
