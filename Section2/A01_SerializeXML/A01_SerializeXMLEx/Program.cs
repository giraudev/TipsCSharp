using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using A01_SerializeXML;
using System.Xml.Serialization;

namespace A01_SerializeXMLEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /*serializando objetos
             * 1.importar alguns usings */

            Usuario usuario = new Usuario() { Nome = "Maria Rita", Cpf = "222.222.222-22", Email = "rita@gmail.com" };

            /*estanciar objeto de serialização, com o parametro do tipo do objeto q será serializado:
            XmlSerializer serializador = new XmlSerializer(typeof(usuario.GetType()), ou*/
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            /*criar um stream e como parametro o path do diretorio do arquivo + nome do arquivo que vou criar*/
            StreamWriter stream = new StreamWriter(@"C:\Users\admin\source\repos\TipsC#\Section2\Arquivos\01_SerializarXml.xml");

            //serializando o objeto:
            serializador.Serialize(stream,usuario)


;
        }
    }
}
