namespace ex02AULA06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
           Queue<string?> fila = new Queue<string?>();
            do
            {
                Console.WriteLine("****************");
                Console.WriteLine("**");
                Console.WriteLine("1 = Adicionar cliente na fila.");
                Console.WriteLine("2 = Listar todos os clientes");
                Console.WriteLine("3 = Retirar clientes da lista");
                Console.WriteLine("0 = Sair");
                Console.WriteLine("**");
                Console.WriteLine("****************");

               


                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Adicionar Cliente na fila.");
                        fila.Enqueue(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Lista de todos os clientes:");
                        foreach (var cliente in fila)
                        {
                            Console.WriteLine(cliente);
                            Console.WriteLine("Aqui estão os livros da lista");
                        }

                        break;
                    case 3:
                        if (fila.Count > 0)
                        {
                            Console.WriteLine("Retirar Cliente da Fila.");
                            fila.Dequeue();
                            foreach (var cliente in fila) { Console.WriteLine(cliente); }
                        }


                        break;
                   
                        


                    case 0:
                        Console.WriteLine("Programa Finalizado.");
                        break;
                    default:
                        Console.WriteLine("Opção inexistente");
                        break;
                }
            } while (opcao != 0);
        }


    }
}
