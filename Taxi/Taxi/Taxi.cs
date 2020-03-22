using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        private int Tariff;
        private int Unique_ID;
        private int discount;
        private int Total;
        private static int All_profit = 0;

        Taxi(int Tariff, int Unique_ID)
        {
            this.Tariff = Tariff;
            this.Unique_ID = Unique_ID;
            this.discount = 0;
            this.Total = 0;
        }
        private static List<Taxi> persons = new List<Taxi>();
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            String[] inputStr = s.Split(new String[] { "-1" }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_A = inputStr[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_B = inputStr[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int j = 0;
            for (int i = 0; i < input_A.Length/2; i++)
            {
                persons.Add(new Taxi(Convert.ToInt32(input_A[j++]), Convert.ToInt32(input_A[j++])));
            }
            int k = 0;
            for (int i = 0; i < input_B.Length / 2; i++)
            {
                All_profit += getProfit(Convert.ToInt32(input_B[k++]), Convert.ToInt32(input_B[k++]));
                //Console.WriteLine(getProfit(Convert.ToInt32(input_B[k++]), Convert.ToInt32(input_B[k++])));
                //getProfit(Convert.ToInt32(input_B[k++]), Convert.ToInt32(input_B[k++]));
            }
            Console.Write(All_profit);
            Console.ReadLine();

        }
        static int getProfit(int Customer_ID, int km)
        {
            int profit = 0;
            foreach(Taxi t in persons)
            {
                if(t.Unique_ID == Customer_ID)
                {
                   if(t.Tariff == 1)
                    {
                        profit = 8 * km;
                    }
                   else if (t.Tariff == 2)
                    {
                        profit = 6 * km - t.discount;
                        
                        
                        t.discount = profit / 2;
                        t.discount = t.discount > 0 ? t.discount : 0;
        

                    }
                   else if (t.Tariff == 3)
                    {
                            for(int i = 0; i < km; i++)
                            {
                                if(t.Total < 100)
                                    profit += 6;
                                else if (t.Total >= 100)
                                    profit += 4;
                                t.Total ++;
                            }
                    }
                }
            }
            return (profit > 0) ? profit : 0;
        }
    }
}
