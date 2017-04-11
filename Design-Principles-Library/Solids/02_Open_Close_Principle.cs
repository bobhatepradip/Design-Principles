using System;

namespace Design_Principles_Library
{
    internal class _02_Open_Close_Principle
    {
        //2. Open Close Principle
        // Here DataProvder is open for extension (extends to Sql, Oracle, Oledb Providers and so on..) and closed for manipulation
        private abstract class DataProvider
        {
            public abstract int OpenConnection();

            public abstract int CloseConnection();

            public abstract int ExecuteCommand();
        }

        private class SqlDataProvider : DataProvider
        {
            public override int OpenConnection()
            {
                Console.WriteLine("\nSql Connection opened successfully");
                return 1;
            }

            public override int CloseConnection()
            {
                Console.WriteLine("Sql Connection closed successfully");
                return 1;
            }

            public override int ExecuteCommand()
            {
                Console.WriteLine("Sql Command Executed successfully");
                return 1;
            }
        }

        private class OracleDataProvider : DataProvider
        {
            public override int OpenConnection()
            {
                Console.WriteLine("Oracle Connection opened successfully");
                return 1;
            }

            public override int CloseConnection()
            {
                Console.WriteLine("Oracle Connection closed successfully");
                return 1;
            }

            public override int ExecuteCommand()
            {
                Console.WriteLine("Oracle Command Executed successfully");
                return 1;
            }
        }

        private class OledbDataProvider : DataProvider
        {
            public override int OpenConnection()
            {
                Console.WriteLine("OLEDB Connection opened successfully");
                return 1;
            }

            public override int CloseConnection()
            {
                Console.WriteLine("OLEDB Connection closed successfully");
                return 1;
            }

            public override int ExecuteCommand()
            {
                Console.WriteLine("OEDB Command Executed successfully");
                return 1;
            }
        }

        private class OpenClosePrincipleDemo
        {
            public static void OSPDemo()
            {
                Console.WriteLine("\n\nOpen Close Principle Demo ");

                DataProvider DataProviderObject = new SqlDataProvider();
                DataProviderObject.OpenConnection();
                DataProviderObject.ExecuteCommand();
                DataProviderObject.CloseConnection();

                DataProviderObject = new OracleDataProvider();
                DataProviderObject.OpenConnection();
                DataProviderObject.ExecuteCommand();
                DataProviderObject.CloseConnection();
            }
        }
    }
}