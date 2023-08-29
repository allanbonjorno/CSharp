namespace HashAULA06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> numeros = new HashSet<int>();

            for (int indice = 0; indice < 10; indice++)
            {
                Console.WriteLine("informe o número: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                numeros.Add(valor);
                Console.Clear();
            }
            Console.WriteLine("Lista de números :");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }








        }
    }
    }










