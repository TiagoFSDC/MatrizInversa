using System;
using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        {
            int[,] mat = new int[5, 5];
            int[,] mat2 = new int[5, 5];

            Random sorteio = new Random();

            //Carregar valores na matriz
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                for (int l = 0; l < mat.GetLength(0); l++)
                {
                    mat[l, c] = sorteio.Next(1000);
                }
            }
            /*
            int ultimalinha = mat.GetLength(0) - 1; // -1 devido iniciar na posição 1
            int ultimacoluna = mat.GetLength(1) - 1; 
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    mat2[ultimalinha -l, ultimacoluna - c] = mat[l,c];
                }
            }*/


            for (int l = 0, l2 = mat.GetLength(0) - 1; l < mat.GetLength(0); l++, l2--)
            {
                for (int c = 0, c2 = mat.GetLength(1) - 1; c < mat.GetLength(1); c++, c2--)
                {
                    mat2[l2,c2] = mat[l,c];
                }
            }

                //Impressao da matriz
                Console.WriteLine("Os valores da matriz são: ");
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(" \tmat[" + l + "][" + c + "] =" + mat[l, c].ToString("d3"));
                }
                Console.WriteLine();
            }

            //Impressao da matriz
            Console.WriteLine("Os valores da matriz inversa são: ");
            for (int l = 0; l < mat2.GetLength(0); l++)
            {
                for (int c = 0; c < mat2.GetLength(1); c++)
                {
                    Console.Write(" \tmat2[" + l + "][" + c + "] =" + mat2[l, c].ToString("d3"));
                }
                Console.WriteLine();
            }
        }
    }
}
