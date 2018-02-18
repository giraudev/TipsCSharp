using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Delegates
{
    class Program
    {
        //criando delegate:
        delegate int Calcula(int a, int b);

        static void Main(string[] args)
        {
            /*modo tradicional:
             var so = Soma(10, 20);
             var su = Subtrair(20, 10);*/

            Calcula calc = new Calcula(Soma);
            int So = calc(10, 20);

            Calcula calc1 = new Calcula(Subtrair);
            int Su = calc(10, 20);

        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
