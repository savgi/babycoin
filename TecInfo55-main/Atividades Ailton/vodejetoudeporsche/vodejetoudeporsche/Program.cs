using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vodejetoudeporsche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            int i ;
            
            Console.WriteLine("Digite um número: ");
            numeros[0]=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            0numeros[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            numeros[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            numeros[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            numeros[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            numeros[5] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            numeros[6] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            numeros[7] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            numeros[8] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            numeros[9] = int.Parse(Console.ReadLine());



            Console.WriteLine("Os números digitados foram: ");
            for (i = numeros[0]; i <= numeros[9]; i++)

            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }


    }
}