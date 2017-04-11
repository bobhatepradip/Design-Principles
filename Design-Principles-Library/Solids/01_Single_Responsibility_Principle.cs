using System;

namespace Design_Principles_Library
{
    internal class _01_Single_Responsibility_Principle
    {
        //1. Single Responsibility Principle

        // Data access class is only responsible for data base related operations
        private class DataAccess
        {
            public static void InsertData()
            {
                Console.WriteLine("Data inserted into database successfully");
            }
        }

        // Logger class is only responsible for logging related operations
        private class Logger
        {
            public static void WriteLog()
            {
                Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " Log  Data insertion completed successfully");
            }
        }
    }
}