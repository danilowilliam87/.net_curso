using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTreino
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] valor = Console.ReadLine().Split(' ');
            int linhas = int.Parse(valor[0]);
            int colunas = int.Parse(valor[1]);
            int[,] numeros = new int[linhas, colunas];

            for(int i = 0; i < linhas; i++)
            {
                string[] nums = Console.ReadLine().Split(' ');

                for (int j = 0; j < colunas; j++)
                {
                    numeros[i, j] = int.Parse(nums[j]);
                }
            }

            int procurado = int.Parse(Console.ReadLine());
            for(int i = 0; i < linhas; i++)
            {
                for(int j = 0; j < colunas; j++)
                {
                    if(numeros[i,j] == procurado)
                    {
                       
                        
                    }                   
                }
            }
        }
    }
}
