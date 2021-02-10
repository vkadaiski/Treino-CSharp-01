using System;

namespace exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            int ParouImpar;
            Console.WriteLine("Digite um numero para saber se ele é Par ou impar");
            ParouImpar = Convert.ToInt32(Console.ReadLine());

            if(ParouImpar % 2 == 0){

                Console.WriteLine(ParouImpar +" é par ");

            }
            else{
                
                Console.WriteLine(ParouImpar + " é par ");
            }

        }
    }
}
