using System;

namespace Week1.Homework2
{
    public class StudentGrade
    {

    //    static void Main(string[] args)
            void Main2(string[] args)
    
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a grade E, V, G, A, F.");
                return;
            }       

            Char grade = args[0].ToCharArray()[0];
             
      //      Console.WriteLine("Hello World! " + grade);

            switch(grade)
            {
                case 'E':
                    Console.WriteLine("This grade is Excellent");
                break;

                case 'V':
                    Console.WriteLine("This grade is Very Good");
                break;

                case 'G':
                    Console.WriteLine("This grade is Good");
                break;

                case 'A':
                    Console.WriteLine("This grade is Average");
                break;

                case 'F':
                    Console.WriteLine("This grade is Fail");
                break;

                default:
                    Console.WriteLine("This grade is invalid");
                break;
            }

        }
    }
}        
        
