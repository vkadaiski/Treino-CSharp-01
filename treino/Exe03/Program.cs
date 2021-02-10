using System;
 /* Exercício 03 – Desenvolva uma calculadora, onde será necessário entrar com a operação,
 primeiro e segundo valor, exiba o resultado na tela.*/

namespace Exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1, Num2, Resultado = 0; 
            char Operador;
            
            Console.WriteLine("Escolha um Operador");
            Console.WriteLine("(+) Soma ");
            Console.WriteLine("(-) Subtração ");
            Console.WriteLine("(*) Multiplicação ");
            Console.WriteLine("(/) Divisão ");

            Console.WriteLine();

            char.TryParse(Console.ReadLine(),out Operador);

            
            
            Console.WriteLine("Escolha o primeiro numero");

            double.TryParse(Console.ReadLine(), out Num1);

            Console.WriteLine("Escolha o segundo numero");

            double.TryParse(Console.ReadLine(), out Num2);

            Console.WriteLine();

            switch(Operador){
                case '+':
                    Resultado = Soma (Num1,Num2);

                    break;

                 case '-':
                    Resultado = Subtracao (Num1,Num2);

                    break;
                 case '*':
                    Resultado = Multiplicacao (Num1,Num2);

                    break;
                 case '/':
                    Resultado = Divisao (Num1,Num2);

                    break;
            }

            Console.WriteLine(string.Format("Seu resulyado é {0}", Resultado));

        }

        static double Soma (double Num1, double Num2){

            return(Num1+Num2);

        }
        
        static double Subtracao (double Num1, double Num2){

            return(Num1-Num2);

        }
        
        static double Multiplicacao (double Num1, double Num2){

            return(Num1*Num2);

        }
        
        static double Divisao (double Num1, double Num2){

            return(Num1/Num2);

        }
        
    }
}
