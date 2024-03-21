using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_While___do_while_31._01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //atribuir valor ao (i) que é a variável
            int i=20;
            string opcao = "sim";


            while (opcao == "sim")
            {
                while (i>=1) 
                {
                  Console.WriteLine(i);
                    i -= 2;
                }
                Console.WriteLine("Deseja refazer? Sim/Não? ");
                opcao = Console.ReadLine().ToLower();
                //pq o i está valendo 0, então tivemos dar o valor 20 a variável i novamente 
                i = 20;
                //Console.Clear();
            }

           

            
              
        }
    }
}
