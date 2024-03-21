using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Ailtom_do_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            string escolha;
            string calculadora;
            int n1, n2, soma, multiplicacao, subtracao, divisao;
            double imc, peso, altura, altura2;
            int PI;
            float m1, m2, m3, m4, m5, media;




            Console.WriteLine("Você acessou a Shavasca.com");
            Console.WriteLine("aperte 'enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Nossas opções são:");
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_");
            Console.WriteLine("C- Calculadora");
            Console.WriteLine("I- Calcular IMC");
            Console.WriteLine("PI- Par ou ímpar");
            Console.WriteLine("M- Calcular Média");
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_");
            Console.WriteLine("Digite a opção que deseja:");
            Console.WriteLine("_______________________");


            escolha = Console.ReadLine().ToUpper();

            Console.Clear();

            switch (escolha)
            {
                case "C":
                    {

                        Console.WriteLine("Calculadora aberta :)");
                        Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_");
                        Console.WriteLine("opções");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("S- Soma");
                        Console.WriteLine("T- Subtração");
                        Console.WriteLine("M- Multiplicação");
                        Console.WriteLine("D- Divisão");
                        Console.WriteLine("_-_-_-_-_-_-_-_-_-_");
                        Console.WriteLine("Qual opção deseja?");
                        
                        calculadora = Console.ReadLine().ToUpper();
                        Console.Clear();
                        //break;

                        switch (calculadora)
                        {

                            case "S":
                                {
                                    calculadora = ("Soma");
                                    Console.WriteLine("Escreva o 1° algoritmo= ");
                                    Console.WriteLine("_______________________");
                                    n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Escreva o 2° algoritimo= ");
                                    Console.WriteLine("_______________________");
                                    n2 = int.Parse(Console.ReadLine());
                                    soma = n1 + n2;
                                    Console.WriteLine("_______________________");
                                    Console.Clear();
                                    Console.WriteLine($"{n1} + {n2} é= {soma}");
                                    Console.ReadLine();
                                    break;
                                }

                            case "T":
                                {
                                    calculadora = ("subtração");
                                    Console.WriteLine("Escreva o 1° algoritmo= ");
                                    Console.WriteLine("_______________________");
                                    n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Escreva o 2° algoritimo= ");
                                    Console.WriteLine("_______________________");
                                    n2 = int.Parse(Console.ReadLine());
                                    subtracao = n1 - n2;
                                    Console.WriteLine("_______________________");
                                    Console.Clear();
                                    Console.WriteLine($"{n1} - {n2} é= {subtracao}");
                                    Console.ReadLine();
                                    break;
                                }
                            case "M":
                                {
                                    Console.WriteLine("Escreva o 1° algoritmo= ");
                                    Console.WriteLine("_______________________");
                                    n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Escreva o 2° algoritimo= ");
                                    Console.WriteLine("_______________________");
                                    n2 = int.Parse(Console.ReadLine());
                                    multiplicacao = n1 * n2;
                                    Console.WriteLine("_______________________");
                                    Console.Clear();
                                    Console.WriteLine($"{n1} * {n2} é= {multiplicacao}");
                                    Console.ReadLine();
                                    break;
                                }
                            case "D":
                                {
                                    Console.WriteLine("Escreva o 1° algoritmo= ");
                                    Console.WriteLine("_______________________");
                                    n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Escreva o 2° algoritimo= ");
                                    Console.WriteLine("_______________________");
                                    n2 = int.Parse(Console.ReadLine());
                                    divisao = n1 / n2;
                                    Console.WriteLine("_______________________");
                                    Console.Clear();
                                    Console.WriteLine($"{n1} / {n2} é= {divisao}");
                                    Console.ReadLine();
                                    break;
                                }

                        }

                        break;
                    }

                case "I":
                    {
                        Console.WriteLine("Escreva o seu peso= ");
                        Console.WriteLine("_______________________");
                        peso = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escreva a sua altura= ");
                        Console.WriteLine("_______________________");

                        altura = Double.Parse(Console.ReadLine());
                        altura2 = altura * altura;
                        imc = peso / altura2;
                        Console.WriteLine("_______________________");
                        Console.Clear();
                        Console.WriteLine($"Seu IMC é = {imc}");
                        Console.ReadLine();
                        break;
                    }

                case "PI":
                    {
                        Console.WriteLine("Escreva o número que deseja saber se é par ou ímpar ");
                        Console.WriteLine("_______________________");
                        PI = int.Parse(Console.ReadLine());
                        if (PI % 2 == 0)
                        {
                            Console.WriteLine($"O número {PI} é par. ");
                        }
                        else
                        {
                            Console.WriteLine($"O número {PI} é ímpar.");
                            Console.ReadLine();
                        }
                        break;
                    }

                case "M": 
                    {
                    
                     Console.WriteLine("Cálculo de média");
                        Console.WriteLine("Digite o 1° número:");
                        m1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 2° número:");
                        m2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 3° número:");
                        m3 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 4° número:");
                        m4 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 5° número:");
                        m5 = float.Parse(Console.ReadLine());
                        media = (m1 + m2 + m3 + m4 + m5) / 5;
                        Console.Clear();
                        Console.WriteLine($"A média  é= {media}");
                        Console.ReadLine();

                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Essa opção é inexistente :(");
                        Console.ReadLine();
                    }

                    break;

            }   
        }
    }  }



