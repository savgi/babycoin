using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Adivinhar_Ailton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int NumeroEscolhido = rand.Next(0, 100);
            int palpite;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Estou pensando em um número de 0 a 100 (enter para continuar)");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Dê seu palpite: ");
            palpite = Convert.ToInt32(Console.ReadLine());

            while (NumeroEscolhido > palpite)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("mais alto");
                Console.ResetColor();
                Console.WriteLine("Tente dnv");
                palpite = Convert.ToInt32(Console.ReadLine());
            }
            while (NumeroEscolhido < palpite)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("mais baixo");
                Console.ResetColor();
                Console.WriteLine("Tente dnv");
                palpite = Convert.ToInt32(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Parabéns você é um ótimo palpiteiro!!!!!");
            Console.ReadLine();
            Console.ResetColor();



        }
    }
}
