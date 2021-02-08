using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Desenvolva um algoritmo que solicite a entrada de uma frase, 
após isto troque todas as letras A ou a por &, porém não utilize o método Replace().
*/

namespace exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string Frase = "Agora a frase esta sendo manipulada";
            Console.WriteLine(p.Alterar(Frase));
        }

        private string Alterar(string Frase){

            if (Frase.Trim().Length > 0){
                
                int Total = Frase.Length;
                int count = 0;
                var StringBuilder = new StringBuilder(Frase);

                while(count < Total){

                    if (StringBuilder[count]== 'a'){

                        StringBuilder[count] ='&';

                    }
                    count++;


                }
                Frase = StringBuilder.ToString();
                return Frase;
            }
            else{

                return null;

            }




        }
    }
}
