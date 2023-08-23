namespace Exercicio23AGOSTO2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, NovoSalario;
       
            Console.WriteLine("Digite o valor do salário :");
            salario = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Agora, digite o valor do abono :");
            abono = Convert.ToSingle(Console.ReadLine());

            NovoSalario = salario + abono;
            Console.WriteLine("Seu novo salário é: ");
            Console.WriteLine(NovoSalario);

        }
    }
}