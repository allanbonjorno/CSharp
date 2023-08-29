namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };

            //atribuir um valor a variável "busca" mesmo que seja zero.

            int busca = 0;

            Console.WriteLine("Digite o número que deseja saber a posição no vetor : ");

            //convert to int32 porque a variavel busca é int, tem um valor numérico.

            busca = Convert.ToInt32(Console.ReadLine());

            //o array.indexof busca dentro do vetor o número digitado pelo usuário(busca), se NÃO existir esse número, o retorno é -1.
            if (Array.IndexOf(vetor01, busca) == -1)
            {
                Console.WriteLine($"O número {busca} não foi encontrado");
            }
            //se o número digitado pelo usuário(busca) for encontrado pelo arrayindexof, o console vai exibir a mensagem.
            else
            {
                Console.WriteLine($"A Posição de {busca} é igual a: " + Array.IndexOf(vetor01, busca));
            }
        }
    }
}