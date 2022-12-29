using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using Area;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input values of sides: ");
            string s = "";
            s = Console.ReadLine();
            string[] subs = s.Split();
            if (subs.Length == 1)
            {
                try
                {
                    CalcArea.OneParameter(Convert.ToDouble(subs[0]));
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
            if (subs.Length == 2)
            {
                try
                {
                    CalcArea.TwoParameter(Convert.ToDouble(subs[0]), Convert.ToDouble(subs[1]));
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
            if (subs.Length == 3)
            {
                try
                {
                    CalcArea.ThreeParameter(Convert.ToDouble(subs[0]), Convert.ToDouble(subs[1]), Convert.ToDouble(subs[2]));
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
        }
    }
}
