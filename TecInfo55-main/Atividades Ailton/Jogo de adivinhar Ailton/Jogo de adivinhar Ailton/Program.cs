using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_adivinhar_Ailton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random random = new Random();
                int numeroAdivinhado = random.Next(0, 101);
                int tentativa = 0;
                int chute = -1;

                Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
                Console.WriteLine("Tente adivinhar o número de 0 a 100.");

                while (chute != numeroAdivinhado)
                {
                    Console.Write("Digite seu chute: ");
                    chute = Convert.ToInt32(Console.ReadLine());
                    tentativa++;

                    if (chute < numeroAdivinhado)
                    {
                        Console.WriteLine("Tente um número maior.");
                    }
                    else if (chute > numeroAdivinhado)
                    {
                        Console.WriteLine("Tente um número menor.");
                    }
                }

                Console.WriteLine("Parabéns! Você acertou o número em " + tentativa + " tentativas.");
            }
        }

