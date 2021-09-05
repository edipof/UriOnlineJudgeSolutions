using System;

namespace UriOnlineJudge
{
    public class _2515 : IRun
    {
        public void Run()
        {
            // https://www.urionlinejudge.com.br/judge/pt/problems/view/2515
            while (true)
            {
                string N = System.Console.ReadLine();
                if (N == null || N == "EOF")
                {
                    break;
                }

                string line = System.Console.ReadLine();
                string[] packetOfBiscuits = line.Split(' ');
                int size = Convert.ToInt32(N);
                int[,] table = new int[2, size];
                int total = 0;
                int[] bestSlice = new int[2];

                for (int i = 0; i < size; i++)
                {
                    total += Convert.ToInt32(packetOfBiscuits[i]);
                    table[0, i] = total;
                }

                for (int i = 0; i < size; i++)
                {
                    table[1, i] = total - table[0, i];
                }

                int difference = -1;
                for (int i = 0; i < size; i++)
                {
                    int aux = table[0, i] - table[1, i];
                    if (aux < 0)
                    {
                        aux = aux * (-1);
                    }

                    if (difference < 0 || aux <= difference)
                    {
                        difference = aux;
                        bestSlice[0] = table[0, i] < table[1, i] ? table[0, i] : table[1, i];
                        bestSlice[1] = table[0, i] > table[1, i] ? table[0, i] : table[1, i];
                    }
                }

                Console.WriteLine($"{bestSlice[0]} {bestSlice[1]}");
            }
        }
    }
}
