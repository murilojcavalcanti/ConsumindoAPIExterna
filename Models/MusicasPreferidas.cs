using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Linq_E_Ordenacao.Models;
internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListadeMusicasFavoritas { get; set; }

    public MusicasPreferidas(string _Nome)
    {
        Nome = _Nome;
        ListadeMusicasFavoritas = new List<Musica>();
    }

    public void AddMusicasFavoritas(Musica musica)
    {
        ListadeMusicasFavoritas.Add(musica);

    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Musicas Favoritas -> {Nome}");
        foreach (var item in ListadeMusicasFavoritas)
        {
            Console.WriteLine($"- {item.Nome} : {item.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            Nome= Nome,
            musicas= ListadeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Arquivo.json criado com sucesso {Path.GetFullPath(nomeDoArquivo)}");
    }

    public void GerarArquivoTXT()
    {
        string nomeDoArquivo = $"Musicas-Favoritas-de-{Nome}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
        {
            arquivo.WriteLine($"Musicas favoritas de {Nome}\n");
            foreach (var item in ListadeMusicasFavoritas)
            {
                arquivo.WriteLine($"- {item.Nome} : {item.Artista}");
            }
        }
        Console.WriteLine($"Arquivo gerado em {Path.GetFileName(nomeDoArquivo)}");
    }
}

