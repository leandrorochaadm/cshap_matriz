using System;

public class test2
{
	static public void Ex1()
    {
        Console.WriteLine("**Matrizes**");
        Console.WriteLine("Quantas linhas deseja?");
        int linhas = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantas linhas deseja?");
        int colunas = int.Parse(Console.ReadLine());

        int[,] Matriz1 = new int[linhas, colunas];
        //int[,] Matriz2 = new int[linhas, colunas];

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
                Console.WriteLine($"Matriz1 [{i + 1}, {j + 1}] = {Matriz1[i, j]}");
                
            }
        }

        Console.WriteLine("---> Verificando maior e menor valor <---");
        int maior = int.MinValue;
        int menor = int.MaxValue;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                //Console.WriteLine($"Matriz2 [{i + 1}, {j + 1}] = {Matriz1[i, j]}");
             if(maior < Matriz1[i, j]) { maior = Matriz1[i, j]; }
             if (menor > Matriz1[i, j]) { menor = Matriz1[i, j]; }
            }
        }

        Console.WriteLine($"Menor: {menor}");
        Console.WriteLine($"Maior: {maior}");
    }
}
