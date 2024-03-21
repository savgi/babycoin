using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ailton_aula_07._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[3];

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"Entre com o {i+1}* Nome : ");
                nome[i]= (Console.ReadLine());
            }
            Console.Clear();

            Array.Reverse(nome);

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"O {i + 1} nome digitado foi : {nome[i]}");
                
            }
            Console.ReadKey();


















        }
    }
}
