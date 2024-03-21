using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Ailton_segunda29._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int início, fim , intervalo;
            
            
            
            Console.WriteLine("Olá seja bem-vindo!!");
            Console.WriteLine("-----------------------------");
            

           
            Console.WriteLine("Você deseja contar até qual número?");
            fim = int.Parse(Console.ReadLine());


            Console.WriteLine("Deseja iniciar em qual valor?");
            início = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Qual intervalo de contagem?");
            intervalo = int.Parse(Console.ReadLine());

           Console.ForegroundColor = ConsoleColor.Green;
            for (int i = início; i <= fim; i +=intervalo)

            {
                Console.WriteLine(i);
            }
            
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = início; i >= fim; i -= intervalo)

            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            Console.ResetColor();


        }



    }
}
