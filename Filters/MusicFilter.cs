using Linq_E_Ordenacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_E_Ordenacao.Filters;
internal class MusicFilter
{
    public static void FiltrarMusicaPorAno(List<Musica> musicas, string ano)
    {
        /*
        var musicasDoAno = 
        musicas.Where(musica => musica.Ano == ano)//seleciona as musicas de acordo com o ano
        .OrderBy(musicas => musicas.Nome) // ordena as músicas pelo nome
            .Select(musicas => musicas.Nome) // seleciona apenas o nome das músicas
        .Distinct() // remove as duplicidades
        .ToList(); // converte o resultado em uma lista
        */
        var musicasPorAno = musicas.Where(musica=>musica.Lancamento==ano).OrderBy(musica=>musica.Nome).Select(m=>m.Nome).Distinct().ToList();

        Console.WriteLine($"Musicas do ano:{ano}");
        foreach (var item in musicasPorAno)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public static void FiltrarMusicaPorNota(List<Musica> musica, string nota)
    {
        var musicasporNota = musica.Where(musica => musica.Tonalidade == nota).OrderBy(Musicas => Musicas.Lancamento).Distinct().ToList();
        Console.WriteLine($"Musicas em {nota}");
        foreach (var item in musicasporNota)
        {
            Console.WriteLine($"- {item.Nome} : {item.Artista} - {item.Lancamento}");
        }
    }


}

