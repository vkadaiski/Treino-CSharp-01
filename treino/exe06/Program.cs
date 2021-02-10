using System;

/*
 Desenvolva um algoritmo que calcule o reajuste salarial. 
 Se o salário for abaixo de 1.700 o ajuste é de R$300.00, se maior de R$ 200.00. 
 Para finalizar, 
 exiba o novo salário na tela.
*/

namespace exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            double Salario;
            Console.WriteLine("Por favor digite seu salario atual usando ponto para separa os valores");
            double.TryParse(Console.ReadLine(), out Salario);
            Console.WriteLine("Novo salario");
            Console.WriteLine(p.CalculaSalario(Salario));

            



        }

        private double CalculaSalario(double Salario){

            double NovoSalario;

            if(Salario <=1700){

                NovoSalario = (Salario+300);

            }
            else{
                NovoSalario = (Salario+200);
            }

            return NovoSalario;

        }
    }
}
