using System;
 /*
  Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário,
   se for menor que 18 anos exiba na cor vermelha “Sem permissão”, 
   caso seja maior ou  igual a 18 anos exiba na cor verde “Permissão concedida”
 */
namespace exe04
{
    class Program
    {
        static void Main(string[] args)
        {
           Verificar();
        }

        static void Verificar(){

            int idade;

            Console.WriteLine("Digite sua idade");

            int.TryParse(Console.ReadLine(),out idade);

            if(idade >= 18 ){

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso Permitido");
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Acesso Negado");
            }

            


        }
    }
}
