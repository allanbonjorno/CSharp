namespace PlanodeSaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? Nome;
            int idade;

            Console.WriteLine("Digite seu primeiro nome : ");
            Nome = Console.ReadLine();
            Console.WriteLine($"\nOlá {Nome}, seja vem vinde!");
            Console.WriteLine("\nAgora, Digite sua idade : ");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade > 0 && idade <= 10)
            {
                Console.WriteLine($"{Nome}, seu plano de saúde é no valor de 100 reais.");
            }
            else if (idade >= 11 && idade <= 29)
            {
                Console.WriteLine($"{Nome}, seu plano de saúde é no valor de 200 reais.");
            }
            else if (idade >= 30 && idade <= 45)
            {
                Console.WriteLine($"{Nome}, seu plano de saúde é no valor de 300 reais.");
            }
            else if (idade >= 46 && idade <= 59)
            {
                Console.WriteLine($"{Nome}, seu plano de saúde é no valor de 500 reais.");
            }
         
            else if (idade >= 60 && idade <= 65)
            {
                Console.WriteLine($"{Nome}, seu plano de saúde é no valor de 600 reais.");
            }
            else
            {
                Console.WriteLine($"{Nome}, seu plano de saúde é no valor de 1000 reais.");
            }
        }
    }
}
