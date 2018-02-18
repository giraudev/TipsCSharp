using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A01_SerializeXML;
using System.IO;
using System.Xml.Serialization;

namespace A02_DSerializeXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader leitor = new StreamReader(@"C:\Users\admin\source\repos\TipsC#\Section2\Arquivos\01_SerializarXml.xml");

            //como não temos objeto, iremos utilizar o typeof
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            /*ele ira retornar o xml em um objeto, mas precisa fazer cast, dizer que este objeto
             é do tipo usuario*/
            Usuario usuario = (Usuario)serializador.Deserialize(leitor);

            //lendo os dados
            Console.WriteLine("Usuario (Nome): {0}, CPF: {1} e Email: {2}", usuario.Nome, usuario.Cpf, usuario.Email);

            //para encerrar o programa
            Console.ReadKey();

        }
    }
}
