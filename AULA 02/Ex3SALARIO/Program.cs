namespace Ex3SALARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBRT, adcNOT, horaEXT, desc, salarioLQD;


            Console.WriteLine("Digite o valor do salário Bruto : ");
            salarioBRT = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor do adicional Noturno : ");
            adcNOT = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora extra(Caso tenha feito) : ");
            horaEXT = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor dos descontos : ");
            desc = Convert.ToSingle(Console.ReadLine());
            salarioLQD = salarioBRT + adcNOT + (horaEXT * 5) - desc;
            Console.WriteLine(salarioLQD);
        }
    }
}