using Linq_E_Ordenacao.Filters;
using Linq_E_Ordenacao.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string reponse = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(reponse);

        // musicas[0].Detalhes();
        
        //usando Linq
        GenderFilter.FiltrarGenerosMusicais(musicas); 
        ArtistFilter.FiltrarArtistas(musicas);
        ArtistFilter.FiltrarArtistasPorGenero(musicas, "pop");
        ArtistFilter.FiltrarMusicasPorArtista(musicas,"Michel Teló");
        MusicFilter.FiltrarMusicaPorAno(musicas, "2014");
        MusicFilter.FiltrarMusicaPorNota(musicas, "C#");


        //Gerando arquivos
        var musicasPreferidas = new MusicasPreferidas("Daniel");
        musicasPreferidas.AddMusicasFavoritas(musicas[500]);
        musicasPreferidas.AddMusicasFavoritas(musicas[637]);
        musicasPreferidas.AddMusicasFavoritas(musicas[428]);
        musicasPreferidas.AddMusicasFavoritas(musicas[13]);
        musicasPreferidas.AddMusicasFavoritas(musicas[1771]);
        musicasPreferidas.ExibirMusicasFavoritas();

        musicasPreferidas.GerarArquivoJson();
        musicasPreferidas.GerarArquivoTXT();
    }
    catch(Exception e)
    {
        Console.WriteLine($"O erro é: {e.Message}");
    }






}/*
  Desafio:

    Exibir todos os gêneros musicais da lista; (feito)

    Ordenar os artistas por nome;(feito)

    Filtrar artistas por gênero musical;(feito)

    Filtrar as músicas de um artista.(feito)

    DESAFIO 2
    apresentar o campo key de acordo a com a tabela
    0-C
    1-C#
    2-D
    3-D#
    4-E
    5-F
    6-F#
    7-G
    8-G#
    9-A
    10-A#
    11-B

  */