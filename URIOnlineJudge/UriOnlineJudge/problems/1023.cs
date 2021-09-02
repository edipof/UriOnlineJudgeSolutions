using System;
using System.Linq;

namespace URIOnlineJudge
{
    class _1023 : IRun
    {
        public void Run()
        {
            // https://www.urionlinejudge.com.br/judge/pt/problems/view/1023
            int countCity = 0;
            while (true)
            {
                int N = Convert.ToInt32(System.Console.ReadLine());
                if (N == 0)
                {
                    break;
                }
                int sumResidents = 0;
                int sumConsumption = 0;
                System.Collections.Generic.Dictionary<int, int> dictionary = new System.Collections.Generic.Dictionary<int, int>();
                for (int i = 0; i < N; i++)
                {
                    string line = System.Console.ReadLine();
                    string[] arraySplited = line.Split(' ');
                    int residents = Convert.ToInt32(arraySplited[0]);
                    int consumption = Convert.ToInt32(arraySplited[1]) / residents;

                    sumResidents += Convert.ToInt32(arraySplited[0]);
                    sumConsumption += Convert.ToInt32(arraySplited[1]);

                    if (!dictionary.ContainsKey(consumption))
                    {
                        dictionary.Add(consumption, residents);
                    }
                    else
                    {
                        dictionary[consumption] += residents;
                    }
                }
                double average = Convert.ToDouble(sumConsumption) / Convert.ToDouble(sumResidents);
                double formatedAverage = Math.Truncate(average * 100) / 100;
                System.Collections.Generic.List<string> formatedValues = new System.Collections.Generic.List<string>();
                foreach (System.Collections.Generic.KeyValuePair<int, int> keyValue in dictionary.OrderBy(s => s.Key))
                {
                    formatedValues.Add($"{keyValue.Value}-{keyValue.Key}");
                }

                Console.WriteLine($"Cidade# {++countCity}:");
                Console.WriteLine(string.Join(" ", formatedValues));
                Console.WriteLine($"Consumo medio: {formatedAverage:F} m3.");
                if (countCity != N)
                {
                    Console.Write('\n');
                }
            }
        }
    }
}
