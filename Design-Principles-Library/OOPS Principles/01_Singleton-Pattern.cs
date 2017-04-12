using System;

namespace Design_Principles_Library.OOPS_Principles
{
    internal class _01_Singleton_Pattern
    {
        // Example 1:  Method initalization
        private class Emp
        {
            public int No { get; set; }
            public string Name { get; set; }
            public string Sal { get; set; }

            // Private static object can access only inside the Emp class.
            private static Emp emp;

            // Private empty constructor to restrict end use to deny creating the object.
            private Emp()
            {
            }

            // A public method to access outside of the class to create an object.
            public static Emp CreateObject()
            {
                // If the object is null for first time instantiate it once.
                if (emp == null)
                {
                    emp = new Emp();
                }

                // Return the emp object, when user request for create an instance.
                return emp;
            }
        }

        private class Program
        {
            private static void Main(string[] args)
            {
                Emp emp1 = Emp.CreateObject();
                emp1.No = 10;
                emp1.Name = "Sai";
                emp1.Sal = "10000";
                Console.WriteLine("Employee 1 Details:\n No: " + emp1.No + "\n Name: " + emp1.Name + "\n Sal: " + emp1.Sal);

                Emp emp2 = Emp.CreateObject();
                emp2.Name = "Sri";
                Console.WriteLine("Employee 2 Details:\n No: " + emp2.No + "\n Name: " + emp2.Name + "\n Sal: " + emp2.Sal);

                Emp emp3 = Emp.CreateObject();
                emp1.Sal = "5000";
                Console.WriteLine("Employee 2 Details:\n No: " + emp3.No + "\n Name: " + emp3.Name + "\n Sal: " + emp3.Sal);
                Console.ReadLine();
            }
        }

        // Example 2: Property initalization
        public class Singleton
        {
            // Private static object can access only inside the Emp class.
            private static Singleton instance;

            // Private empty constructor to restrict end use to deny creating the object.
            private Singleton()
            {
            }

            // A public property to access outside of the class to create an object.
            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        // Example 3:  Sealed implementation
        public sealed class SealedSingleton
        {
            private static readonly SealedSingleton instance = new SealedSingleton();

            private SealedSingleton()
            {
            }

            public static SealedSingleton Instance
            {
                get
                {
                    return instance;
                }
            }
        }

        // Example 4: Thread-safe implementation for multi-threading use
        //sealed modifier prevents other classes from inheriting from it.
        public sealed class MultiThreadSingleton
        {
            // Private static object can access only inside the MultiThreadSingleton class.
            // volatile keyword indicates that a field might be modified by multiple threads that are executing at the same time.
            // Fields that are declared volatile are not subject to compiler optimizations that assume access by a single thread.
            // This ensures that the most up-to-date value is present in the field at all times.
            // The volatile modifier is usually used for a field that is accessed by multiple threads without using the lock statement to serialize access.
            private static volatile MultiThreadSingleton instance;

            private static object syncRoot = new Object();

            // Private empty constructor to restrict end use to deny creating the object.
            private MultiThreadSingleton()
            {
            }

            // A public property to access outside of the class to create an object.
            public static MultiThreadSingleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (syncRoot)
                        {
                            if (instance == null)
                            {
                                instance = new MultiThreadSingleton();
                            }
                        }
                    }
                    return instance;
                }
            }
        }
    }
}