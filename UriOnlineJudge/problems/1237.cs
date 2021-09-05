using System;

namespace UriOnlineJudge
{
    public class _1237 : IRun
    {
        public void Run()
        {
            // https://www.urionlinejudge.com.br/judge/pt/problems/view/2515
            while (true)
            {
                string firstString = System.Console.ReadLine();
                if (firstString == null || string.IsNullOrEmpty(firstString))
                {
                    break;
                }

                string secondString = System.Console.ReadLine();

                int[,] table = new int[firstString.Length, secondString.Length];
                for (int i = 0; i < firstString.Length; i++)
                {
                    for (int j = 0; j < secondString.Length; j++)
                    {
                        if (firstString[i] == secondString[j])
                        {
                            table[i, j] = 1;
                        }
                        else
                        {
                            table[i, j] = 0;
                        }
                    }
                }

                //printTable(table, firstString.Length, secondString.Length);

                int bestValue = 0;
                for (int i = 0; i < firstString.Length; i++)
                {
                    int value = 0;
                    for (int j = 0; j < secondString.Length; j++)
                    {
                        if (table[i, j] == 1)
                        {
                            int col = j;
                            int line = i;
                            while (line < firstString.Length && col < secondString.Length && table[line, col] == 1)
                            {
                                value++;
                                line++;
                                col++;
                            }
                            if (bestValue <= value)
                            {
                                bestValue = value;
                            }
                            value = 0;
                        }
                    }
                }
                Console.WriteLine($"{bestValue}");
            }
        }

        private void printTable(int[,] table, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{table[i, j]}");
                }
                Console.Write($"\n");
            }
        }
    }
}
