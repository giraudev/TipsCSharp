using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05_LINQ_GROUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNum = { 1, 3, 4, 4, 4, 3, 3, 5, 5, 6, 6, 6, 6, 6, 7, 8, 9, 11 };

            //Distinct
            var listafiltrada = listaNum.Distinct().OrderBy(a=>a).Select(a => a);

            foreach(var item in listafiltrada)
            {
                Console.WriteLine("Distinct: "+item);
            }

            //primeiro ordenamos, depois agrupamos
            var listaGroup = listaNum.OrderBy(a=>a).GroupBy(a => a).Select(a => a);
            foreach (var item in listaGroup)
            {
                Console.WriteLine("GroupBy: "+ item.Key);
                //sem o key, ele não mostra o valor.
            }

            Console.ReadKey();
        }
    }
}
