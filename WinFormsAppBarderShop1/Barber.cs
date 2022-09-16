using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppBarderShop1
{
    internal class Barber
    {
        public static void FillTheOriginalArrays(out DateTime[] input, out int n, out int[] waiting)
        {
            StreamReader sr = new StreamReader("In.txt");
            n = Convert.ToInt32(sr.ReadLine());
            waiting = new int[n];
            input = new DateTime[n];
            for (int i = 0; i < n; i++)
            {
                string[] client = sr.ReadLine().Split(" ");
                input[i] = new DateTime(1, 1, 1, Convert.ToInt32(client[0]), Convert.ToInt32(client[1]), 0);
                waiting[i] = Convert.ToInt32(client[2]);
            }
            sr.Close();
        }
        public static void FillTheFinallAray(out DateTime[] output, DateTime[] input, int n, int[] waiting)
        {

            output = new DateTime[n];
            for (int i = 0; i < n; i++)
            {
                int diffrence = 0;
                int countClient = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (output[j] > input[i])
                    {
                        countClient++;
                        diffrence = i - j;
                    }
                }
                if (waiting[i] < countClient)
                {
                    output[i] = input[i];
                }
                else
                {
                    output[i] = input[i].AddMinutes(20);
                    for (int j = i - 1; j >= i - diffrence; j--)
                    {
                        if (output[j] > input[i])
                        {
                            output[i] = output[j].AddMinutes(20);
                        }
                    }
                }
            }
        }
        public static void SaveData(DateTime[] output)
        {
            StreamWriter sw = new StreamWriter("output.txt");
            for (int i = 0; i < output.Length; i++)
            {
                sw.WriteLine(output[i].Hour + " " + output[i].Minute);
            }
            sw.Close();
        }
    }
}
