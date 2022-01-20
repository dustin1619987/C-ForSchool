using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRates
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run(); 
        }

        void run()
        {
            Console.WriteLine("3-1 Coding Discussion: Four Common Errors with C# Methods - Dustin's Copy"); //OutPut whos copy it is
            double dailyRate = readDouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter the number of days: ");
            writeFee(calculateFee(dailyRate, noOfDays));
        }

        private void writeFee(double p) //int n needs to be remove. There is nothing within this area that it is using int n ISSUE 2
        {
            Console.WriteLine("The consultant's fee is: {0}", p * 1.1);
        }

        private double calculateFee(double dailyRate, int noOfDays) // Shouldn't be a ; here. The ; prevents the area from working correctly ISSUE 1
        {
            return dailyRate * noOfDays;
        }

        private int readInt(string p) // Issue 3 Double needs to be int. You could also change readInt line 19 to (int)readInt. ISSUE 3
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private double readDouble(string p)// (int p) but needed to be (string p) this causes error at line 18 ISSUE 4
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return double.Parse(line);
        }
    }
}
