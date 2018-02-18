using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A04_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Explicações
            /*alguns tipos não possuem valor null, e sim um range.
             O que chamamos de Struct - por valor.
             Porém, se tiver um object, ele pode ser setado como null
             object (classe) - por referência
             problema com banco de dados:
             exemplo a idade de uma pessoa, que pode ser representada por int, nao nasceu, tem menos de 
             1 ano. Colocamos como informações opcionais.
             Por isso utilizamos nullable
             */
            #endregion
            //ERRO: int i = null;

            object o = null;

            Nullable<int> Idade = null;
            //ou
            int? idade2 = null;

        }
    }
}
