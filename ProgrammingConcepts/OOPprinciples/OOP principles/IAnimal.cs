using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_principles
{
   public interface IAnimal  //declaring the interface public allows for access from classes outside the same package in java or namespace in c# 
    {

        /*interfaces can be used to achieve polymorphism or to contract some functionality without defining how this is to be done or inverting dependencies
        - since most languages allow inheriting from multiple interfaces it can be useful to split functionality up through interface segregation*/

        void speak(); 


        void eat(String food); 


    }
}
