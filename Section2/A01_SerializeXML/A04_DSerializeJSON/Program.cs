using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using A01_SerializeXML;
using System.Web.Script.Serialization;

namespace A04_DSerializeJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\admin\source\repos\TipsC#\Section2\Arquivos\02_SerializeJSon.json");
            string linhasDoArquivo = stream.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();

            //sem utilizacao de generics
            //receber em um objeto
            Usuario usuario = (Usuario)serializador.Deserialize(linhasDoArquivo, typeof(Usuario));
            Console.WriteLine("Usuario(nome): {0}, CPF: {1} e Email: {2}", usuario.Nome, usuario.Cpf, usuario.Email);
            Console.ReadKey();
        }
    }
}
