using System;
using System.Collections.Generic;
using DataObject;

namespace MyCSharpApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            Duck duck = new Duck();
            duck.quack();

            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.display();

            List<Duck> ducks = new List<Duck>();
            ducks.Add(duck);
            ducks.Add(new Duck(){ });
            Console.WriteLine(ducks.Count);
            
            Console.ReadKey();
        }
    }
}