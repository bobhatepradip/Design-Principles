using System;

namespace Design_Principles_Library.OOPS_Basics
{
    /// <summary>
    /// Interfaces are used to define the peripheral abilities of a class.
    /// </summary>

    //An interface cannot have access modifiers for the subs, functions, properties etc
    //everything is assumed as public
    internal class InterfaceExample1
    {
        private interface ISampleInterface
        {
            void SampleMethod();
        }

        private class ImplementationClass : ISampleInterface
        {
            // Explicit interface member implementation:
            void ISampleInterface.SampleMethod()
            {
                // Method implementation.
            }

            private static void Main()
            {
                // Declare an interface instance.
                ISampleInterface obj = new ImplementationClass();

                // Call the member.
                obj.SampleMethod();
            }
        }
    }

    internal class InterfaceExample2
    {
        //Interface contains the property declaration and the class contains the implementation.

        private interface IPoint
        {
            // Property signatures:
            int x
            {
                get;
                set;
            }

            int y
            {
                get;
                set;
            }
        }

        private class Point : IPoint
        {
            // Fields:
            private int _x;

            private int _y;

            // Constructor:
            public Point(int x, int y)
            {
                _x = x;
                _y = y;
            }

            // Property implementation:
            public int x
            {
                get
                {
                    return _x;
                }

                set
                {
                    _x = value;
                }
            }

            public int y
            {
                get
                {
                    return _y;
                }
                set
                {
                    _y = value;
                }
            }
        }

        private class MainClass
        {
            private static void PrintPoint(IPoint p)
            {
                Console.WriteLine("x={0}, y={1}", p.x, p.y);
            }

            private static void Main()
            {
                Point p = new Point(2, 3);
                Console.Write("My Point: ");
                PrintPoint(p);
            }
        }

        // Output: My Point: x=2, y=3
    }
}