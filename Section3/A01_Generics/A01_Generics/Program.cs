using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A01_Generics.Models;

namespace A01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //estanciar os objetos das outras classes
            Carro carro = new Carro() { Marca = "Honda", Modelo = "Civic" };
            Casa casa = new Casa() { Cidade = "Pindamonhangaba", Endereco = "Rua da Rosa, 23" };
            Usuario usuario = new Usuario() { Nome = "Reginaldo Rossi", Email = "rossi@hotmail.com", Senha = "123456" };

            //criar um arquivo para salvar os dados dos objetos
            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            //especificando o generics com <>, ver em serializador
            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro2: " + carro2.Marca + " - " + carro2.Modelo);
            Console.WriteLine("Casa2: " + casa2.Cidade + " - " + casa2.Endereco);
            Console.WriteLine("Usuario2: " + usuario2.Nome + " - " + usuario2.Email + " - " + usuario2.Senha);

            Console.ReadKey();
        }
    }
}
