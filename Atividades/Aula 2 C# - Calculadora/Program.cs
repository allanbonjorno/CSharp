namespace Aula_2_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;
            Console.WriteLine("\nDigite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo número:\n ");
            numero2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(numero1 + " " + numero2);
            Console.WriteLine($"\n{numero1} + {numero2} = " + (numero1 + numero2));
            Console.WriteLine($"\n{numero1} - {numero2} = " + (numero1 - numero2).ToString("F2"));
            if (numero2 > 0)
            {
                Console.WriteLine($"\n{numero1} / {numero2} = " + (numero1 / numero2).ToString("F2"));
            }
            else
            {
                Console.WriteLine("Não existe divisão por ZERO!");
            }
            Console.WriteLine($"\n{numero1} * {numero2} = " + (numero1 * numero2));
            Console.WriteLine(Math.Round(numero1 / numero1 * numero2));
            Console.WriteLine($"{numero1} ^ {numero2} = " + Math.Pow(numero1,numero2));
            Console.WriteLine($"Raiz Quadrada de: = " + Math.Sqrt(numero1));







        }
    }
}