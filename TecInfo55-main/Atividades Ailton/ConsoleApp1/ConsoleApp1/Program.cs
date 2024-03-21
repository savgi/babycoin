using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string escolha;
            int n1, n2, soma, multiplicação, subtração, adição, divisão;
            
            
            
            
            Console.WriteLine("Bem vindo ao Shati calc");
            Console.WriteLine("Qual operação deseja?");
            Console.ReadLine();
            Console.WriteLine("C- Calculadora");
            Console.WriteLine("I- Cálculo do IMC");
            Console.WriteLine("PI- informar se é par ou ímpar");
            Console.WriteLine("M- Calcular média");
            Console.WriteLine("__________________");
            Console.WriteLine("Escolha a opção que deseja.");
            Console.WriteLine("__________________");
           
            escolha = Console.ReadLine().ToUpper();

            switch (escolha)
            {
                case "C":
                    {

                        Console.WriteLine("S- Soma");
                        Console.WriteLine("T- Subtração");
                        Console.WriteLine("M- Multiplicação");
                        Console.WriteLine("D- Divisão");
                        Console.WriteLine("_____________________");
                        Console.WriteLine("Qual operação deseja?");
                        Console.WriteLine("_____________________");
                        Console.ReadKey();
                        escolha = Console.ReadLine().ToUpper();

                        switch (escolha)
                        {

                            case "S":
                                {


                                    Console.WriteLine("Bem vindo a soma");
                                    Console.ReadKey();
                                    break;








                            }  }









                        break;







                        }
                    }





        }
    }
}
