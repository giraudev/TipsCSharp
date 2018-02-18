using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add(new Livro() { Id = 1, AutorId = 3, Titulo = "Sim e Não", AnoPublicacao = 1999 });
            listaLivro.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Maybe I Want", AnoPublicacao = 1943 });
            listaLivro.Add(new Livro() { Id = 3, AutorId = 1, Titulo = "Saiba Falar Corretamente", AnoPublicacao = 2003 });
            listaLivro.Add(new Livro() { Id = 4, AutorId = 3, Titulo = "Escrevendo com as Estrelas", AnoPublicacao = 2016 });
            listaLivro.Add(new Livro() { Id = 5, AutorId = 2, Titulo = "SIM é SIM", AnoPublicacao = 1986 });

            List<Autor> listaAutor = new List<Autor>();
            listaAutor.Add(new Autor() { Id = 1, Nome = "Russel John" });
            listaAutor.Add(new Autor() { Id = 2, Nome = "Maria Joana" });
            listaAutor.Add(new Autor() { Id = 3, Nome = "John Joseh" });

            var ListaJoin = from livros in listaLivro join autor in listaAutor on livros.AutorId equals autor.Id 
                            select new { livros, autor };

            foreach(var item in ListaJoin)
            {
                Console.WriteLine("Livro: " + item.livros.Titulo + " - Autor: " + item.autor.Nome);
            }
            Console.ReadKey();
        }
    }
}
