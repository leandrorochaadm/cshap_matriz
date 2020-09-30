using System;

public class Ex1
{
	 public void Main()
    {
        Console.WriteLine("1. Gere uma matriz 25 x 25 com números aleatórios de -350 a 350, que não podem, em hipótese alguma, ser repetidos. Leia um valor X que o usuário irá informar.");
        Random r = new Random();

        int linhas = 25;
        int colunas = linhas;

        int[,] Matriz1 = new int[linhas, colunas];
        int num;
     

        for (int i = 0; i < linhas; i++)
        {

            for (int j = 0; j < colunas; j++)
            {

            //verificando se existe numero antes de inserir

            gera_numero_aleatorio:
                num = r.Next(-350, 350);

                foreach (var item in Matriz1)
                {
                    if (item == num)
                    {
                        goto gera_numero_aleatorio;
                    }
                }

                Matriz1[i, j] = num;
                Console.WriteLine($"Matriz[{i + 1}, {j + 1}]: {Matriz1[i, j]}");
            }

        }

        Console.WriteLine("-------------------------------");
        bool encontrou = false;
        String posicao="";
        Console.Write("Qual numero deseja pesquisar? ");
        int pesq = int.Parse(Console.ReadLine());
        

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (Matriz1[i, j] == pesq)
                {
                    encontrou = true;
                    posicao = $"posição: linha {i + 1}, coluna {j + 1}";
                }
            }
        }

        if (encontrou) {
            Console.WriteLine($"Esse numero está na {posicao}");
        }
        else
        {
            Console.WriteLine("Número não encontrado");
        }
    }
}
