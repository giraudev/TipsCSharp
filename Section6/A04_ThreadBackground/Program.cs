using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A03_ThreadBackground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateIni: " + DateTime.Now);
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);

                //executar enquanto executa a atividade principal
                t1.IsBackground = true;
                t1.Start();
            }

           Console.ReadKey();

            //as threads neste caso só são uteis enquanto o main for executado
        }

        //IO
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Num: " + i);
            }
            Console.WriteLine("Date: " + DateTime.Now);
        }
    }
}
