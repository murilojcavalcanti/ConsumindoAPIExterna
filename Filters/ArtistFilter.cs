using Linq_E_Ordenacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_E_Ordenacao.Filters;

    internal class ArtistFilter
{

    public static void FiltrarArtistas(List<Musica> musicas)
    {
        //forma 1
        //var artistas = musicas.OrderBy(musica => musica.Artista).Select(musica=>musica.Artista).Distinct().ToList();
        var artistas = musicas.Select(a => a.Artista).Distinct().ToList().Order();
        Console.WriteLine("Lista de artistas");
        foreach (var artista in artistas)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas,string genero)
    {                                               
        var artistasPorGenero = musicas.Where(musica=>musica.Genero.Contains(genero)).Select(musica=>musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os artistas do genero {genero}");

        foreach (var item in artistasPorGenero)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica>musicas,string artistas)
    {
        var musicasPorArtista= musicas.Where(musica=>musica.Artista.Equals(artistas)).ToList();
        Console.WriteLine($"Exibindo as musicas do artista: {artistas}");
        foreach (var item in musicasPorArtista)
        {
            Console.WriteLine($"- {item.Nome}");
        }
    }
}