using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsOffice
{
    class CustomsOffice
    {
        int PersonID;
        int Citizenship;
        int Document;
        int RightOfEntry;
        int Worker_mark;
        int Work_permit;

        CustomsOffice(int PersonID, int Citizenship, int Document, int RightOfEntry, int Worker_mark, int Work_permit)
        {
            this.PersonID = PersonID;
            this.Citizenship = Citizenship;
            this.Document = Document;
            this.RightOfEntry = RightOfEntry;
            this.Worker_mark = Worker_mark;
            this.Work_permit = Work_permit;
        }
        static void Main(string[] args)
        {
            List<CustomsOffice> persons = new List<CustomsOffice>();

            
            
            String s = Console.ReadLine();
            String[] inputStr = s.Split(new String[] { "-1" }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_A = inputStr[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_B = inputStr[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] output = new int[input_B.Length];
            int j = 0;
            for(int i=0; i < input_B.Length; i++ )
            {
                persons.Add(new CustomsOffice(Convert.ToInt32(input_A[j++]), Convert.ToInt32(input_A[j++]), Convert.ToInt32(input_A[j++]), Convert.ToInt32(input_A[j++]), Convert.ToInt32(input_A[j++]), Convert.ToInt32(input_A[j++])));
            }
            



            for (int i = 0; i < input_B.Length; i++)
            {
                if(persons[i].Citizenship == 1)
                {
                    if (persons[i].Document == 1)
                    {
                        output[i] = 1;
                    }
                    else output[i] = 0;
                }
                else if (persons[i].Citizenship == 2)
                {
                    if (persons[i].Document == 1)
                    {
                        if(persons[i].RightOfEntry == 1)
                        {
                            if (persons[i].Worker_mark == 1)
                            {
                                if(persons[i].Work_permit == 1)
                                {
                                    output[i] = 1;
                                }
                                else output[i] = 0;
                            }
                            else output[i] = 1;
                        }
                        else output[i] = 0;
                    }
                    else output[i] = 0;
                }
            }

            for(int i = 0; i < input_B.Length; i++)
            {
                Console.Write(output[Convert.ToInt32(input_B[i])-1] + " ");
            }
            Console.Write("-1");
            //Console.ReadLine();
        }
    }
    
}
