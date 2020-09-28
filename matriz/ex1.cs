using System;

public class ex1
{
	static public void Ex1()
    {
        Console.WriteLine("**Matrizes**");
        Console.WriteLine("Quantas linhas deseja?");
        int linhas = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantas linhas deseja?");
        int colunas = int.Parse(Console.ReadLine());

        int[,] Matriz1 = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {

            for (int j = 0; j < colunas; j++)
            {
                Console.WriteLine($"Informe o valor a ser inserido na matriz [{i + 1},{j + 1}]");
                Matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
            }

        }

        Console.WriteLine("---> Imprimindo elementos  <---");


        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.WriteLine($"Matriz [{i + 1}, {j + 1}] = {Matriz1[i, j]}");
            }
        }
    }
}
