using System;
using Design_Principles_Library;

namespace Design_Principles
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("\n\n Start : Liskov Substitution Principle Demo ");
            Console.WriteLine("\n\n==========Rectangle=========== ");
            bool isRectangle = true;
            LiskovSubstitutionPrincipleDemo.LSPDemo(isRectangle);
            //Console.ReadKey();
            Console.WriteLine("\n\n==========Square=========== ");
            isRectangle = false;
            LiskovSubstitutionPrincipleDemo.LSPDemo(isRectangle);
            Console.WriteLine("\n\nEnd : Liskov Substitution Principle Demo ");
            Console.ReadKey();
        }
    }
}