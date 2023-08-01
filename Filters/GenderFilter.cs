using Linq_E_Ordenacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_E_Ordenacao.Filters;
internal class GenderFilter
{
    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var Generos = musicas.Select(Generos => Generos.Genero).Distinct().ToList();
        foreach (var genero in Generos)
        {
            Console.WriteLine($"- {genero}");
        }
        Console.WriteLine($"São {Generos.Count} generos");
    }
}


