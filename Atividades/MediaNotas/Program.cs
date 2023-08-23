namespace MediaNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float P1, P2, P3, P4, somatotal, mediafinal;

            Console.WriteLine("Digite sua nota na P1: ");
            P1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite sua nota na P2: ");
            P2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite sua nota na P3: ");
            P3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite sua nota na P4: ");
            P4 = Convert.ToSingle(Console.ReadLine());
            somatotal = P1 + P2 + P3 + P4;
            mediafinal = somatotal / 4;
            Console.WriteLine(mediafinal);
        }
    }
}