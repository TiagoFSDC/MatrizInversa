using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mat = new int[3,3];
        int[,] mat2 = new int[3, 3];

        LerMatriz(mat);

        void LerMatriz(int[,] x)
        {
            for (int i=0; i<3;i++)
            {
                for(int j = 0; j <3;j++)
                {
                    Console.Write($" Matriz[{i},{j}] : ");
                    x[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 2; i >= 0; i--)
            {
                for (int j = 2; j >= 0; j--)
                {
                    Console.Write(x[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}