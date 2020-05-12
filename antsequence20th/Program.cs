using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ant = new int[1000];
            int[] ant2 = new int[1000];
            int j = 0;
            int k = 0;
            int count = 1;
            ant[0] = 1;

            Console.WriteLine("1번째 수열: " + ant[0]);

            for(int i = 0; i < 20-1; i++)
            {
                while (ant[j] != 0)
                {
                    if (ant[j] == ant[j + 1])
                        count++;
                    else
                    {
                        ant2[k++] = ant[j];
                        ant2[k++] = count;
                        count = 1;
                    }
                    j++;
                }
                ant = (int[])ant2.Clone();
                j = 0;
                k = 0;
                Console.Write((i + 2) + "번째 수열: ");
                while (ant2[j] != 0)
                {
                    Console.Write(ant2[j]);
                    j++;
                }
                j = 0;
                Console.WriteLine();
            }
        }
    }
}
