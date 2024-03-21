using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcao_Ailton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2;

            Console.WriteLine("Insira o primeiro nº: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo n°: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            //////////////////////////////////////////////////////////

            Console.WriteLine($"A soma dos numeros é :{Soma(n1, n2)}");

            Console.WriteLine($"A subtração dos numeros é :{Subtracao(n1, n2)}");

            Console.WriteLine($"A subtração dos numeros é :{Multiplicacao(n1, n2)}");

            Console.WriteLine($"A subtração dos numeros é :{Divisao(n1, n2)}");
            Console.ReadKey();
        }

        static int Soma(int n1, int n2)
        {
            return (n1 + n2);
        }

        static int Subtracao(int n1, int n2)
        {
            return (n1 - n2);
        }

        static int Multiplicacao(int n1, int n2)
        {
            return (n1 * n2);
        }
        static int Divisao(int n1, int n2)
        {
            return (n1 / n2);
        }

    }


}


