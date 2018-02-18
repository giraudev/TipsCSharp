using A02_Delegates.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Foto foto = new Foto { Nome = "perfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            //tela - cadastro de usuario: THUMB {foto de perfil}
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processador(foto);

            //tela - cadastro de produtos: colorir + tamanho
            Foto foto2 = new Foto { Nome = "prto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().RedimensionarTamanho;
            FotoProcessador.Processador(foto2);

            //cadastro de albuns do usuario
            Foto foto3 = new Foto { Nome = "album.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processador(foto3);

            Console.ReadKey();
        }
    }
}
