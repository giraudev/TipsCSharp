using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02_Delegates.Lib
{
    class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;

        public static void Processador(Foto foto)
        {
            filtros(foto);
            /*jeito tradicional
            var filtros = new FotoFiltro();
            filtros.Colorir(foto);
            filtros.GerarThumb(foto);
            filtros.PretoBranco(foto);
            filtros.RedimensionarTamanho(foto);*/

        }
    }
}
