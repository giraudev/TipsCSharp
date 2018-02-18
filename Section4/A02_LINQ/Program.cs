using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambda: (entrada) => (expressao)
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            /*listar onde a é maior que 10 e selecionar o elemento da lista
             usando a forma literal*/
            var listafiltrada = from a in lista where a > 10 orderby a select a;
                                ;

            // se acrescentar .OrderBy(a=>a)
            foreach (var item in listafiltrada)
            {
                Console.WriteLine("__ " + item);
            }
            Console.ReadKey();
        }
    }
}
