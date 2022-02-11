using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnection databaseConnection = DatabaseConnection.MyObject();
            databaseConnection.PrintOnConsole();
        }
    }

    public sealed class DatabaseConnection
    {
        private DatabaseConnection()
        {

        }

        public static DatabaseConnection instance = null;

        public static DatabaseConnection MyObject()
        {
            if (instance == null)
            {
                return new DatabaseConnection();
            }
            return instance;
        }

        public void PrintOnConsole()
        {
            Console.WriteLine("Singleton Design Pattern Executed ..!");
        }
    }
}
