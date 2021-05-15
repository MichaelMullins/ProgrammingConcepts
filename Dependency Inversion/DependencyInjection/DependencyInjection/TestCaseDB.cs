using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class TestCaseDB : IDatabase
    {
        public void connect()
        {
            Console.WriteLine("Test Case: Database Connected");
        }

        public void disconnect()
        {
            Console.WriteLine("Test Case: Database Disonnected");
        }

        public void insert(String data)
        {
            Console.WriteLine("Test Case: Data Inserted");
        }
    }
}
