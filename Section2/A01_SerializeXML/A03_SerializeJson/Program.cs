using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//estes usings foram add como referencia antes de iniciar o projeto
using System.Web.Script.Serialization;
using A01_SerializeXML;

namespace A03_SerializeJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Arlindo Cruz", Cpf = "333.222.333-22", Email = "arlindo@gmail.com" };

            JavaScriptSerializer serializador = new JavaScriptSerializer();

            //o serialize retorna uma string
            string stringObjSerializado = serializador.Serialize(usuario);

            //criar stream com parametro do path + nome do novo arquivo
            StreamWriter stream = new StreamWriter(@"C:\Users\admin\source\repos\TipsC#\Section2\Arquivos\02_SerializeJSon.json");
            
            stream.WriteLine(stringObjSerializado);
            stream.Close();
        }
    }
}
