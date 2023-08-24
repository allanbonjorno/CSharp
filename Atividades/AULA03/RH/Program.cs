namespace RH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int cargo;
            float salario, reajuste;

            Console.WriteLine("Digite seu primeiro nome : ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Supervisor ");
            Console.WriteLine("2 - Diretor ");
            Console.WriteLine("3 - Gerente ");
            Console.WriteLine("4 - Outros ");



            Console.WriteLine($"Agora {nome}, qual seu cargo na empresa: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Agora {nome}, qual seu salario: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 7) / 100;
                    break;
                case 2:
                    reajuste = (salario * 9) / 100;
                    break;
                case 3:
                    reajuste = (salario * 5) / 100;
                    break;
                default:
                    reajuste = (salario * 12) / 100;
                    break;
            }
            Console.WriteLine($"{nome}, o reajuste do seu salário é no valor de : {reajuste} ");
            Console.WriteLine($"Seu novo salário é : {reajuste + salario}");









        }
    }
    }