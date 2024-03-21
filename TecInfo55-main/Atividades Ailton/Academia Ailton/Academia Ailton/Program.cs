using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alunos;
            float peso, media;
            float i = 1;
            float j = 0;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Você entrou no Savg.information");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Academia joga y joga");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
            Console.Write("Quantidade de Alunos cadastrados na academia: ");
            alunos =int.Parse(Console.ReadLine());
            

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{i}- ");
                i++;
                Console.ResetColor();
                Console.Write($"Digite o Peso do Aluno: ");
                peso = float.Parse(Console.ReadLine());
                j = j + peso;
            }
            while (i <= alunos);
            {
                media = j / alunos;
                Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"A Média de Peso dos Alunos é: {media}");
                Console.ReadKey();
                Console.ResetColor();
            }
        }
    }
}


