using System;

namespace Design_Principles_Library
{
    internal class _04_Interface_Segregation_Principle
    {
        // Only common generic methods exists for all derived classes.
        private interface IDataProvider
        {
            int OpenConnection();

            int CloseConnection();
        }

        // Implement methods specific to the respective derived classes
        private interface ISqlDataProvider : IDataProvider
        {
            int ExecuteSqlCommand();
        }

        // Implement methods specific to the respective derived classes
        private interface IOracleDataProvider : IDataProvider
        {
            int ExecuteOracleCommand();
        }

        // Client 1
        // Should not force SqlDataProvider client to implement ExecuteOracleCommand, as it wont required that method to be implemented.
        // So that we will derive ISqlDataProvider not IOracleDataProvider
        private class SqlDataClient : ISqlDataProvider
        {
            public int OpenConnection()
            {
                Console.WriteLine("\nSql Connection opened successfully");
                return 1;
            }

            public int CloseConnection()
            {
                Console.WriteLine("Sql Connection closed successfully");
                return 1;
            }

            // Implemeting ISqlDataProvider, we are not forcing the client to implement IOracleDataProvider
            public int ExecuteSqlCommand()
            {
                Console.WriteLine("Sql Server specific Command Executed successfully");
                return 1;
            }
        }

        // Client 2
        // Should not force OracleDataProvider client to implement ExecuteSqlCommand, as it wont required that method to be implemented.
        // So that we will derive IOracleDataProvider not ISqlDataProvider
        private class OracleDataClient : IOracleDataProvider
        {
            public int OpenConnection()
            {
                Console.WriteLine("\nOracle Connection opened successfully");
                return 1;
            }

            public int CloseConnection()
            {
                Console.WriteLine("Oracle Connection closed successfully");
                return 1;
            }

            // Implemeting IOracleDataProvider, we are not forcing the client to implement ISqlDataProvider
            public int ExecuteOracleCommand()
            {
                Console.WriteLine("Oracle specific Command Executed successfully");
                return 1;
            }
        }

        private class InterfaceSegregationPrincipleDemo
        {
            public static void ISPDemo()
            {
                Console.WriteLine("\n\nInterface Inversion Principle Demo ");

                // Each client will implement their respective methods no base class forces the other client to implement the methods which dont required.
                // From the above implementation, we are not forcing Sql client to implemnt orcale logic or Oracle client to implement sql logic.

                ISqlDataProvider SqlDataProviderObject = new SqlDataClient();
                SqlDataProviderObject.OpenConnection();
                SqlDataProviderObject.ExecuteSqlCommand();
                SqlDataProviderObject.CloseConnection();

                IOracleDataProvider OracleDataProviderObject = new OracleDataClient();
                OracleDataProviderObject.OpenConnection();
                OracleDataProviderObject.ExecuteOracleCommand();
                OracleDataProviderObject.CloseConnection();
            }
        }
    }
}