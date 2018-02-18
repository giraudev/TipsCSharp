using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Explicacoes
            /*porém, desde que vc set um valor a 'var', ela passa a ser o tipo setado:
             exemplo v1 passa a ser string e v2 passa a ser int32
             
             dynamic: todo erro de compilação é ignorado, e vc tem acesso a qualquer tipo de info.

             Diferença de var e object:
             object: você pode setar qualquer tipo, exemplo: o t2 virou int32, mas pode virar int ou double depois.
             var: a apartir do momento que vc seta um tipo, ele não recebe outro, exemplo: o v1 é string e nao pode virar
             int ou qualquer outro tipo.
             ERRO: var v3 - PQ obrigatoriamente precisa atribuir um valor a ela.
             */
            #endregion

            //object
            object t = "";
            object t2 = 123456;

            //var
            var v1 = "";
            var v2 = 123456;
            
            //dynamic
            dynamic d1 = new Usuario { Nome = "Maria" };
            Console.WriteLine(d1.Nome);
            //neste caso dará erro, pois nao temos a "senha" de Maria, mas só aparecerá erro na execução e não na compilação
            //Console.WriteLine(d1.Senha);

        }
        //classe criada para explicar dynamic
        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}
