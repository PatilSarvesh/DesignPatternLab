using SumOfTwoNumbers.Data;
using SumOfTwoNumbers.Entities;

namespace SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadData();
        }
        static void ReadData()
        {
            DataOfTwoNumbers data = new DataOfTwoNumbers();
            Console.WriteLine("Enter First Number:");
            data.FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            data.SecondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation:");
            data.Operator = char.Parse(Console.ReadLine());
            valid(data);
        }
        static void valid(DataOfTwoNumbers data)
        {
            IMaths maths = null;
            IDataRepo file = new FileRepo();
            IDataRepo database = new DBRepo();
            double res;
            switch (data.Operator)
            {
                case '+':
                    maths = new Addition();
                    data.result = maths.result(data.FirstNumber, data.SecondNumber);
                    Console.WriteLine("The Sum of two Numbers:" + data.result);
                    file.Save(data);
                    database.Save(data);
                    break;
                case '-':
                    maths = new Subtraction();
                    data.result = maths.result(data.FirstNumber, data.SecondNumber);
                    Console.WriteLine("The Sub of two Numbers:" + data.result);
                    file.Save(data);
                    database.Save(data);
                    break;
                default:
                    break;
            }
        }
    }
}