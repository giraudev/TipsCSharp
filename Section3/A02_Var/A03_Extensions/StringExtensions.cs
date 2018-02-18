using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03_Extensions
// se colocar no namespace System, e esse tipo de classe estiver em outra pasta, vc nao esqce de importar
{
    /*String é classe selada, nao permite ser herdada, porém, eu posso adicionar a classe
     String um método que será escrito fora da classe, mas poderá ser visto por ela*/
    public static class StringExtensions
    {
        /*método vai pertencer a classe String e ser extensions methods, então precisa colocar como
         primeiro parametro o seguinte:
         outra regra, a classe precisa ser estatica*/
        public static string FirstToUpper(this String str)
        {
            //começa do indice 0 até o 1
            string Primeira = str.Substring(0, 1);
           
            string Segunda = str.Substring(1);
            return Primeira.ToUpper() + Segunda;
            
        }
    }
}
