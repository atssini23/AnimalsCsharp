using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Animal brain = new Animal("Brain");
            Animal asparagus = new Animal("Asparagus");
            
            //brain.Speak();
            //asparagus.Speak();

            Animal dog1 = new Dog("Michael");
            dog1.Speak();
            Dog newdog = (Dog)dog1;
            newdog.Speak();
            dog1.Move(7.5);
            System.Console.WriteLine(dog1.distance);
            // System.Console.WriteLine(dog1.Condition);

            Dog dog2 = new Dog("Hartley", 3,2);
            dog2.Speak();
            dog2.Move(2.56);
            System.Console.WriteLine(dog2.distance);
            System.Console.WriteLine(dog2.Condition);
            //System.Console.WriteLine(dog2.legs);
            dog2.EatSnack();

            dog2.EatSnack();
            


        }
    }
}
