namespace exercicio4DIA24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int cargo;
            float salario, reajuste = 0;
            

            Console.WriteLine("Digite seu primeiro nome : ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Gerente ");
            Console.WriteLine("2 - Vendedor ");
            Console.WriteLine("3 - Supervisor ");
            Console.WriteLine("5 - Motorista ");
            Console.WriteLine("6 - Estoquista ");
            Console.WriteLine("7 - Tec T.I ");



            Console.WriteLine($"Agora {nome}, qual seu cargo na empresa: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Agora {nome}, qual seu salario: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:

                    reajuste = (salario * 10) / 100;
                    break;

                case 2:
                    reajuste = (salario * 7) / 100;
                    break;

                case 3:
                    reajuste = (salario * 9) / 100;
                    break;

                case 4:
                    reajuste = (salario * 6) / 100;
                    break;

                case 5:
                    reajuste = (salario * 5) / 100;
                    break;

                case 6:
                    reajuste = (salario * 8) / 100;
                    break;

                default:
                    Console.WriteLine("Não há informações.");
                    break;

            }
            Console.WriteLine($"O Valor do seu salário é: {salario + reajuste}");

        }

    }
    






        }
  