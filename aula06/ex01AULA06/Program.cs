namespace ex01AULA06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            //se liga no Stack, só serve pro tipo PILHA! se liga no string também

            Stack<string?> pilha = new Stack<string?>();
            do
            {
                //aqui é o menu que aparece
                Console.WriteLine("****************");
                Console.WriteLine("**");
                Console.WriteLine("/t1 = Adicionar livros na pilha.");
                Console.WriteLine("/t2 = Listar todos os livros");
                Console.WriteLine("/t3 = Retirar livros da lista");
                Console.WriteLine("/t0 = Sair");
                Console.WriteLine("**");
                Console.WriteLine("****************");

                //aqui o usuário entra com os dados
                opcao = Convert.ToInt32(Console.ReadLine());
                //assim que entrou com os dados, limpa a tela
                Console.Clear();
                //switch case gera essa condição de você digitar um número, e esse número ser correspondente a uma opção em um MENU.

                switch (opcao)
                {
                    //se o usuário digitar 1
                    case 1:
                        Console.WriteLine("Qual seria seu livro:");
                        pilha.Push(Console.ReadLine());
                        Console.Clear();
                        break;
                        //se digita 2
                    case 2:
                        Console.WriteLine("Lista de livros na pilha:");
                        foreach (var livros in pilha)
                        {
                            Console.WriteLine(livros);
                        }

                        break;
                    case 3:
                        //se digitar 3
                        if (pilha.Count > 0)
                        {

                            pilha.Pop();

                            foreach (var livros in pilha) { Console.WriteLine(livros); }
                        }
                        

                        break;
                    case 0:
                        Console.WriteLine("Programa Finalizado.");
                        break;
                }
            } while (opcao != 0);
        }


    }
}









