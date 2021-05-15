using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_principles
{
    class Dog : IAnimal
    {

        private String lastMeal { get; set; }
        private string Name { get; }  /*by setting the variable to private with a getter and not a setter you can make a class read only to limit access, 
                             in this instance it might be beneficial to allow a setter for Name but this is only left in as an example*/

        public Dog()
        {
            //without defining a constructor this is generally what the compiler would automatically create for you
        }
        public Dog(String Name)
        {
            this.Name = Name; //since this variable is read only it needs to be defined at initialization
        }

        public void eat(string food)
        {
            lastMeal = food;
        }

        public void speak()
        {
            Console.WriteLine("Woof!");
        }
    }
}
