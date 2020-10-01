using System;

public class Ex2
{
	 public void Main()
    {
        Console.WriteLine("Gere até 10 apostas (o usuário escolhe quantas apostas quer, com no máximo 10) com 50 números de 00 a 99 em cada bilhete. Use uma matriz para concentrar as apostas. (Pode se definir que cada linha da matriz é uma aposta diferente). Essas apostas podem ser preenchidas pelo usuário ou automaticamente pelo sistema. Lembrando de que não podem ter números repetidos."
   +"\n Após serem criadas as apostas, o sistema deve gerar o RESULTADO DO SORTEIO, um vetor aleatório com 20 números, entre 00 e 99. \n \n");
        Random r = new Random();

        //gerando apostas
        
        Console.WriteLine("Escolha quantas apostas quer (com no máximo 10)");
        int num_apostas = int.Parse(Console.ReadLine());
        if (num_apostas > 10) { num_apostas = 10; }
        int colunas = 50;
        int[,] apostas = new int[num_apostas, colunas];

        int num;

        Console.WriteLine("--- > Apostas <---");
        for (int i = 0; i < num_apostas; i++)
        {
        
            int[] aposta = new int[ colunas];

            Console.WriteLine($"\n\nAposta: {i+1}");
            for (int j = 0; j < colunas; j++)
            {

            //verificando se existe numero antes de inserir

            gera_numero_aleatorio:
                num = r.Next(00, 99);

                foreach (var item in aposta)
                {
                    if (item == num)
                    {
                        goto gera_numero_aleatorio;
                    }
                }

                apostas[i,j] = num;
               
                Console.Write($"{num}, ");
            }

            
        }


        //Gerando sorteio
        Console.WriteLine("\n********************************");
        Console.WriteLine("\n \n--> Sorteio <--");
   
            int[] sorteio = new int[colunas];
            
            
            for (int j = 0; j < 20; j++)
            {

            //verificando se existe numero antes de inserir

            gera_numero_aleatorio:
                num = r.Next(00, 99);

                foreach (var item in sorteio)
                {
                    if (item == num)
                    {
                        goto gera_numero_aleatorio;
                    }
                }

                sorteio[j] = num;

                Console.Write($"{num}, ");
            }


        // conferência das apostas
        Console.WriteLine("\n********************************");
        Console.WriteLine("\n \n-->Acertos <--");
        int[] placar = new int[num_apostas];
        for (int i = 0; i < num_apostas; i++)
        {
            int acertos = 0;
            for (int j = 0; j < 50; j++)
            {

                //sorteado
              
                    for (int l = 0; l < 20; l++)
                    {
                        if (apostas[i, j] == sorteio[l])
                        {
                            acertos++;
                        }
                    }
            }

            placar[i]=acertos;
            Console.WriteLine($"Aposta {i}, acertou {acertos}");
            
        }
        Console.WriteLine("\n********************************");
        Console.WriteLine("\n \n-->Número de acertos <--");
        //int quant_acertos = 20;
       

        for (int i = 20; i >= 12; i--)
        { int quant_aposta = 0;
            foreach (var item in placar)
            {
                if (i == item)
                {
                    quant_aposta++;
                }
            }    
            Console.WriteLine($"Teve {quant_aposta} com {i} de acertos. ");
        }
    }
}
