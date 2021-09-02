using System;

namespace URIOnlineJudge
{
    public class _3299 : IRun
    {
        //https://www.urionlinejudge.com.br/judge/pt/problems/view/3299
        public void Run()
        {
            long N = Convert.ToInt64(System.Console.ReadLine());
            if (N.ToString().Contains("13"))
            {
                Console.Write("{0} es de Mala Suerte\n", N);
            }
            else
            {
                Console.Write("{0} NO es de Mala Suerte\n", N);
            }
        }
    }
}
