using System;

namespace OOP_principles
{
    class program
    { 
        static void Main(string[] args)
        {
            IAnimal kitty = new Cheetah();
            /*initializing a new cheetah object as an instance of the IAnimal type limits to whatever methods are inside the IAnimal interface
             you can downcast kitty into the cheetah class and even back up to the IAnimal type 
             however if a subclass of cheetah existed it would not be possible to downcast any further*/

            Cheetah downcastedKitty = (Cheetah)kitty;

            Cheetah pepper = new Cheetah("pepper"); // constructor overloading example

            kitty = downcastedKitty; //upcasting can be implicitly done by the compiler 
            Dog puppy = new Dog();

            IAnimal[] animals = new IAnimal[2];

            animals[0] = kitty;
            animals[1] = puppy;
            //even though both objects are different classes they both inherit from the IAnimal interface and can be stored together using polymorphism

            foreach(IAnimal animal in animals)
            {
                animal.speak();
                //this operation is safe since all IAnimal instances must have the speak method, a benefit of polymorphism
            }

            //polymorphism also allows us to pass objects into functions and methods allowing for reusability and cleaner code
        void animalSpeak(IAnimal animal)
        {
             animal.speak();
        }
            animalSpeak(puppy);
        }
       
    }
}
