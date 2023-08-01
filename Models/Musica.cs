using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Linq_E_Ordenacao.Models;
    internal class Musica
    {
    private string[] Tonalidades = {"C","C#","D","D#","E","F","F#","G","G#","A","A#","B"};

    [JsonPropertyName("song")]
    public string Nome { get; set; }


    [JsonPropertyName("artist")]
    public string Artista { get; set;}

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set;}

    [JsonPropertyName("year")]
    public string Lancamento { get; set;}

    [JsonPropertyName("genre")]
    public string Genero { get; set;}

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade { 
        get 
        {
            return Tonalidades[Key];
        } 
    }



    public void Detalhes()
    {
        Console.WriteLine($"Artista:{Artista}");
        Console.WriteLine($"Musica:{Nome}");
        Console.WriteLine($"Ano de Lancamento:{Lancamento}");
        Console.WriteLine($"Duracao:{Duracao/1000}");
        Console.WriteLine($"Genero:{Genero}");
        Console.WriteLine($"Tonalidade:{Tonalidade}");
    }

   
}
