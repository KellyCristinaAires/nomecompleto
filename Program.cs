using System;

namespace nomecompeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            Console.Write("\n");
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            sobrenome =Console.ReadLine();
            Console.Write("\n");
            Console.Write($"nome completo: {nome} {sobrenome}");
            Console.Write("\n");
            Console.WriteLine($"nome de catalogo: {sobrenome.ToUpper()}, {nome}");
            Console.Write("\n");
            Console.WriteLine("pressione enter para sair");
            Console.ReadKey();
        }
    }
}

