using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace A01_Generics
{

    public class Serializador
    {
        //metodo static, com um objeto como parametro
        public static void Serializar(object obj)
        {
            //o nome do objeto será colocado genericamente
            StreamWriter sw = new StreamWriter(@"C:\Users\admin\source\repos\TipsC#\Section3\Arquivos\03_" + obj.GetType().Name + ".txt");
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);

            sw.Write(objSerializado);
            sw.Close();
        }

        /*metodo static, com uma classe como parametro
        sintaxe do generics <T>, e no lugar de (Classe) colocar somente T
        antes: public static (Classe) Deserializar()
        depois:*/
        public static T Deserializar<T>() /*Isso quer dizer que no program, temos que especificar <> tbm*/
        {
            /*especificando o typeof(T).Name, ele verifica qual o arquivo q tem o nome da classe que substitui o nome T, e 
             pega o nome*/
            StreamReader sr = new StreamReader(@"C:\Users\admin\source\repos\TipsC#\Section3\Arquivos\03_"+typeof(T).Name+".txt");
            string Conteudo = sr.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            T obj = (T)serializador.Deserialize(Conteudo, typeof(T));

            return obj;
        }
    }
}
