using System;
/*Exercício 02: Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na
tela.*/
namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine(string.Format("Bem vido! {0}", nome));

        }
    }
}
