using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Warehouse
    {
        private int Item_barcode;
        private int Storage_fee;
        private int Storage_hours;
        private int rate;
        private int storage_type;
        private int sum { get; set; }

        Warehouse(int Item_barcode,int rate, int storage_type, int Storage_fee, int Storage_hours)
        {
            this.Item_barcode = Item_barcode;
            this.rate = rate;
            this.storage_type = storage_type;
            this.Storage_fee = Storage_fee;
            this.Storage_hours = Storage_hours;
        }

        static void Main(string[] args)
        {
            List<Warehouse> items = new List<Warehouse>();
            int Base_Rate;
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Base_Rate = Convert.ToInt32(input_A[0]);
            int j = 1;
            for (int i = 0; i < (input_A.Length-1)/3; i++)
            {
                items.Add(new Warehouse(Convert.ToInt32(input_A[j]),GetDigit(Convert.ToInt32(input_A[j]),1), GetDigit(Convert.ToInt32(input_A[j++]), 2), Convert.ToInt32(input_A[j++]), Convert.ToInt32(input_A[j++])));
            }
            int time_coef = 1;
            int extra_time_coef = 0;
            foreach(Warehouse item in items)
            {
                if(item.storage_type == 1)  //месяц
                {
                    time_coef = item.Storage_hours / (24 * 30);
                    extra_time_coef = item.Storage_hours - time_coef * (24 * 30);
                    extra_time_coef = extra_time_coef > 0 ? extra_time_coef : 0;
                }
                else if(item.storage_type == 2) // день
                {
                    time_coef = item.Storage_hours / 24;
                    extra_time_coef = item.Storage_hours - time_coef * 24;
                    extra_time_coef = extra_time_coef > 0 ? extra_time_coef : 0;
                }
                else if(item.storage_type == 3) // час
                {
                    time_coef = item.Storage_hours;
                    extra_time_coef = 0;
                }
                item.sum = (time_coef * item.Storage_fee + Base_Rate * extra_time_coef) * item.rate;
            }
            int maxSum = items[0].sum;
            int maxBarcode = items[0].Item_barcode;
            int allSum = 0;
            foreach(Warehouse item in items)
            {
                if(item.sum > maxSum)
                {
                    maxSum = item.sum;
                    maxBarcode = item.Item_barcode;
                }
                    
                allSum += item.sum;
            }
            Console.Write(allSum + " " + maxBarcode);
            //Console.ReadKey();
        }


        static int GetDigit(int x, int digitNumber)
        {
            if (digitNumber < 0)
                throw new ArgumentOutOfRangeException("digitNumber");

            int digitCount = (int)Math.Log10(x) + 1;
            if (digitNumber > digitCount)
                return 0;

            var pow = (int)Math.Pow(10, digitCount - digitNumber);
            return (x / pow) % 10;
        }
    }
}
