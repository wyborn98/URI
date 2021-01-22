using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace Solution
{
    class Program
    {
        //Função Rafael
        static int FunR (int x, int y)
        {
            x = 3 * x;
            int valor = (x * x) + (y * y);
            return valor;
        }

        //Função Beto
        static int FunB(int x, int y)
        {
            y = 5 * y;
            int valor = (2 * (x * x)) + (y * y);
            return valor;
        }

        //Função Carlos
        static int FunC(int x, int y)
        {
            int valor = -100 * x + (y * y * y);
            return valor;
        }

        static void Impress(int A, int B, int C)
        {
            
            if (A > B && A > C)
            {
                Console.WriteLine("Rafael ganhou");
            }
            else if (B > C)
            {
                Console.WriteLine("Beto ganhou");
            }
            else
            {
                Console.WriteLine("Carlos ganhou");
            }
        }
        static void Main(string[] args)
        {
            int testes = Convert.ToInt32(Console.ReadLine());
            string[] lines = new string[testes];
            for (int j = 0; j < testes; j++)
            {
                lines[j] = Console.ReadLine();
            }            

            for (int i = 0; i < lines.Length; i++)
            {
                //Tratamento da string -> capturar valores com Split() e convertê-los para int.
                string[] values = lines[i].Split(' ');                
                int[] valores = { Convert.ToInt32(values[0]), Convert.ToInt32(values[1]) };               

                //Chamada da função final
                Impress(
                    FunR(valores[0], valores[1]),
                    FunB(valores[0], valores[1]),
                    FunC(valores[0], valores[1])
                );
            }
        }
    }
}
