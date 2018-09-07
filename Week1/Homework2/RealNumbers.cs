using System;
using Week1.Homework3;

namespace Week1.Homework2
{
    public class RealNumbers
    {
        static void Main(string[] args)
        {

            Bicycle bi = new Bicycle(50);
          //  bi._iSize = 29;
            int size = bi._iSize;
            string s = bi._sColor;
            bi._sColor ="brown";
            bi.getTheBicycle();

            System.Console.Write("The first 10 natural numbers are: ");
            for(int ii=0; ii < 10; ii++)
            {
                System.Console.Write((ii + 1) + " ");
            }
            System.Console.WriteLine("");

            int number = 1;
            refsameple(ref number);
            refsameple(number);
        }

        public static void refsameple(ref int value)
        {
            System.Console.WriteLine("ref" + value);
        }
        
        public static void refsameple(int value)
        {
            
            System.Console.WriteLine(value);
        }
    }
}