using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Salary
    {
        static void Main(string[] args)
        {
            List<int> sequence_A = new List<int>();
            int workDays;
            List<int> sequence_B = new List<int>();
            List<int> sequence_C = new List<int>();
            String s = Console.ReadLine();
            String[] _sequences = s.Split(new String[] { "-1" }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_A = _sequences[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            String[] wD = _sequences[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_B = _sequences[2].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_C = _sequences[3].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToInt32(input_A[i]));
                
            }

            workDays = Convert.ToInt32(wD[0]);
            for (int i = 0; i < input_B.Length; i++)
            {
                sequence_B.Add(Convert.ToInt32(input_B[i]));
                
            }
            
            for (int i = 0; i < input_C.Length; i++)
            {
                sequence_C.Add(Convert.ToInt32(input_C[i]));
                
            }

            Employee[] employees = new Employee[sequence_A.Count / 3];
            int d = 0;
            for(int i = 0; i < sequence_A.Count / 3;i++)
            {
                employees[i] = new Employee(sequence_A[d++], sequence_A[d++], sequence_A[d++]);
            }
           

            for(int i = 0; i < sequence_B.Count; i+=2)
            {
                for (int j = 0; j < sequence_A.Count / 3; j++)
                {

                    if (sequence_B[i] == employees[j].Employee_ID)
                    {
                        employees[j].Emp_hours += sequence_B[i + 1];
                    }
                }
            }
            //foreach(Employee e in employees)
            //{
            //    Console.WriteLine(e.Emp_hours);
            //}
            for (int j = 0; j < sequence_A.Count / 3; j++)
            {
                if ((employees[j].Emp_hours > workDays * 8) && employees[j].Salary_type == 1)
                {

                    employees[j].Emp_Salary = (workDays * 8) * employees[j].Salary_rate + (employees[j].Emp_hours - (workDays * 8)) * employees[j].Salary_rate * 2;
                }
                else if ((employees[j].Emp_hours <= workDays * 8) && employees[j].Salary_type == 1)
                {
                    employees[j].Emp_Salary = employees[j].Salary_rate * employees[j].Emp_hours;
                }
                
                else if (employees[j].Salary_type == 2)
                {
                    employees[j].Emp_Salary = (employees[j].Emp_hours / 8) * employees[j].Salary_rate;
                }
                
            }
            //Console.WriteLine("_______");
            //foreach (Employee e in employees)
            //{
            //    Console.WriteLine(e.Emp_Salary);
            //}
            for (int i = 0; i < sequence_C.Count; i ++)
            {
                for (int j = 0; j < sequence_A.Count / 3; j++)
                {
                    if (sequence_C[i] == employees[j].Employee_ID)
                    {
                        employees[j].Fired = true;
                    }
                }
            }
            for (int j = 0; j < sequence_A.Count / 3; j++)
            {
                if (employees[j].Fired)
                {
                    employees[j].Emp_Salary = employees[j].Emp_Salary + employees[j].Emp_Salary / 2;
                }
            }
            Double money = 0;
            for (int j = 0; j < sequence_A.Count / 3; j++)
            {
                money += employees[j].Emp_Salary;
            }
            Console.Write(money);
        }


    }
    class Employee
    {
        public int Emp_hours = 0;
        public int Employee_ID;
        public Double Emp_Salary;
        public int Salary_type;
        public int Salary_rate;
        public bool Fired = false;
        public Employee(int Employee_ID, int Salary_type, int Salary_rate)
        {
            this.Employee_ID = Employee_ID;
            this.Salary_type = Salary_type;
            this.Salary_rate = Salary_rate;
        }
    }
}
