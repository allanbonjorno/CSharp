using System.ComponentModel.Design;

namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int busca = 0;



            for (int indice = 0; indice < vetor01.Length; indice++)
            { }
            Console.WriteLine("\nDigite o número que deseja saber a posição no vetor : ");
            
            busca = Convert.ToInt32(Console.ReadLine());


                if (Array.IndexOf(vetor01, busca) == -1)
            {
                Console.WriteLine($"O número {busca} não foi encontrado");
            }
            else
            {
                Console.WriteLine($"A Posição de {busca} é igual a: " + Array.IndexOf(vetor01, busca));
            }







        }
    }
    }
