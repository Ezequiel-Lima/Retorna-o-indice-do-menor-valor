using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 7, 5, 6, 7, 8, 9, 10, 2 };
            
            Console.WriteLine($"O Índice do menor numero é: {BuscarMenorIndice(vetor)}");
            Console.ReadKey();
        }

        static int BuscarMenorIndice(int[] vetor)
        {
            //Armazena o menor valor
            int menor = vetor[0];
            //Armazena o indice do menor valor
            int menorIndice = 0;

            //Percorre todo o array
            for (int i = 0; i < vetor.Length; i++)
            {
                //Verifica o menor valor
                if (vetor[i] < menor)
                {
                    //Armazena o menor valor
                    menor = vetor[i];
                    //Armazena o indice do menor valor
                    menorIndice = i;
                }
            }

            return menorIndice;
        }
    }
}
