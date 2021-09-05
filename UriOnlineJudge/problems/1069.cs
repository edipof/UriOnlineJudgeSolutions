using System;

namespace UriOnlineJudge
{
    public class _1069 : IRun
    {
        //https://www.urionlinejudge.com.br/judge/pt/problems/view/1069
        public void Run()
        {
            long n = Convert.ToInt32(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = System.Console.ReadLine();
                int count = 0;
                int lastIndexOf = 0;
                int length = line.Length;
                for (int j = 0; j < length; j++)
                {
                    if (line[j] == '<')
                    {
                        if (lastIndexOf <= j)
                        {
                            lastIndexOf = j + 1;
                        } 

                        for (int k = lastIndexOf; k < length; k++)
                        {
                            if (line[k] == '>')
                            {
                                count++;
                                lastIndexOf = k + 1;
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine($"{count}");
            }
        }
    }
}
