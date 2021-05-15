using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public class Database
    {
        IDatabase DB; 
        /*since the database adheres to the IDatabase contract we can safely call specific methods,
        regardless of which implementation of IDatabase is passed into our constructor*/
        public Database(IDatabase DB)
        {
            this.DB = DB;
        }
        public void add(String data)
        {
            DB.insert(data);
        }
        public void connect()
        {
            DB.connect();
        }

        public void disconnect()
        {
            DB.disconnect();
        }
      
    }
}
