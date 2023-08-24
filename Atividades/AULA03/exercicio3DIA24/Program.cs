using System.Xml.Linq;

namespace exercicio3DIA24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int produto;
            float unidades, valor = 0;

            Console.WriteLine("Digite seu primeiro nome : ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Cachorro-Quente R$10,00 ");
            Console.WriteLine("2 - X-Salada R$15,00 ");
            Console.WriteLine("3 - X-Bacon R$18,00 ");
            Console.WriteLine("4 - Bauru R$12,00 ");
            Console.WriteLine("5 - Refrigerante R$8,00");
            Console.WriteLine("6 - Suco de Laranja R$13,00");



            Console.WriteLine($"Agora {nome}, qual produto você deseja: ");
            produto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Agora {nome}, quantas unidades: ");
            unidades = Convert.ToSingle(Console.ReadLine());

            switch (produto)
            {
                case 1:
                    valor = (unidades * 10);
                    break;
                case 2:
                    valor = (unidades * 15);
                    break;
                case 3:
                    valor = (unidades * 18);
                    break;
                case 4:
                    valor = (unidades * 12);
                    break;
                case 5:
                    valor = (unidades * 8);
                    break;
                case 6:
                    valor = (unidades * 13);
                    break;

                default:
                    Console.WriteLine("Pedido inválido. ");
                    break;
            }
            Console.WriteLine($"Valor a ser PAGO : R${valor}");












        }
    }
}
