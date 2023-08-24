namespace exercicio2DIA24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o primeiro número(A) : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número(B) : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número(C) : ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c)
            {
                Console.WriteLine("A Soma de A+B é maior que C");
            }
            if (a + b < c)
            {
                Console.WriteLine("A Soma de A+B é menor que C");
            }
            if (a + b == c)
            {
                Console.WriteLine("A Soma de A+B é igual a C");
            }

        }
    }
}