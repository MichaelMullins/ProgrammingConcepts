using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Database DB = new Database(new TestCaseDB()) ;
            //dependency injection allows for code to be tested without needing specific resources during development
            doDatabaseStuff();

            /*by using dependency injection you can decouple dependencies, making your code more modular,
               you can swap out major components*/

            DB = new Database(new SQLdatabase());
            doDatabaseStuff();


         void doDatabaseStuff()
        {
            DB.connect();
            DB.add("data");
            DB.disconnect();
        }
        }
    }
}
