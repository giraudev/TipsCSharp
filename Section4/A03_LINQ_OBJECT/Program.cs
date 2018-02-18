using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03_LINQ_OBJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa() { Nome = "Beatriz", Cidade = "Santos" });
            lista.Add(new Pessoa() { Nome = "Paula", Cidade = "Mongagua" });
            lista.Add(new Pessoa() { Nome = "Ellen", Cidade = "Guararema" });
            lista.Add(new Pessoa() { Nome = "Camila", Cidade = "Bertioga" });
            lista.Add(new Pessoa() { Nome = "Andreia", Cidade = "Guarujá" });
            lista.Add(new Pessoa() { Nome = "Suellen", Cidade = "Ubatuba" });

            //filtrando todas as cidades que contenham u
            var ListaFiltrada = lista.Where(a => a.Cidade.Contains("u")).OrderBy(a=>a.Cidade).Select(a=>a);

            foreach(var item in ListaFiltrada)
            {
                Console.WriteLine(item.Nome + " - "+item.Cidade);
            }

            Console.ReadKey();

        }
    }
}
