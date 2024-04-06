
using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
    // A ? significa que o campo pode ser nulo
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set;}
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        try
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Musica: {Nome}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Duração: {Duracao / 1000}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um [ERRO]: {ex.Message}");
                
        }
        
    }
}
