using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class SQLdatabase : IDatabase
    {
        
        //specific code to connect, insert and disconnect to the sql database would be abstracted into this class method
        public void connect()
        {
            
            Console.WriteLine("SQL Database Connected");
        }

        public void disconnect()
        {
            Console.WriteLine("SQL Database Disonnected");
        }

        public void insert(String data)
        {
            Console.WriteLine("Data Inserted");
        }
    }
}
