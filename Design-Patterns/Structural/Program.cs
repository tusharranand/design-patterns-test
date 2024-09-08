using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural
{
    public class Program
    {
        static void Main(string[] args)
        {
            //---Allows the objects with incompatible interfaces to collaborate
            //new Adapter.StartPoint().Main(); Console.WriteLine();

            //---lets you split a large class or a set of closely related classes into two separate hierarchies which can be developed independently of each other
            //new Bridge.Client().ClientCode(); Console.WriteLine();

            //---compose objects into tree structures and then work with these structures as if they were individual objects
            //new Composite.Client().Main(); Console.WriteLine();

            //---lets you attach new behaviours to objects by placing them inside special wrapper objects that contain the behaviours
            new Decorator.Client().Main(); Console.WriteLine();

            //---provides a simplified interface to a library, a framework or any other complex set of classes
            new Facade.Client().Main(); Console.WriteLine();

            //---lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object
            //---an object that only stores the intrinsic state is called a flyweight
            new Flyweight.StartPoint().Main(); Console.WriteLine();

            //---aloows to provide a substitute or placeholder for another object, which controls the access for the original object
            new Proxy.Client().Main(); Console.WriteLine();
        }
    }
}
