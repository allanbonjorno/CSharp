namespace ex2AULA05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int somaPrin = 0, somaSec = 0;

            for (int linha = 0; linha < Math.Sqrt(matriz.Length); linha++)
            {
                for (int coluna = 0; coluna < Math.Sqrt(matriz.Length); coluna++)
                {
                    Console.WriteLine($"Informe os números para preencher a matriz :  ");
                    matriz[coluna, linha] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int linha = 0; linha < Math.Sqrt(matriz.Length); linha++)
            {
                for (int coluna = 0; coluna < Math.Sqrt(matriz.Length); coluna++)
                {
                    if (linha == coluna)

                    {
                        Console.WriteLine($"A diagonal Principal é: {matriz[linha, coluna]} ");
                        somaPrin += matriz[linha, coluna];
                    }


                }
            }
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if ((coluna + linha) == (matriz.GetLength(0) - 1))
                    {
                        Console.WriteLine($"A diagonal Secundária é ={matriz[linha, coluna]}");
                        somaSec += matriz[linha, coluna];
                    }
                }
            }
            Console.WriteLine($"Resultado da soma Principal:{somaPrin}\nResultado da soma Secundária: {somaSec} ");



        }




    }
}
