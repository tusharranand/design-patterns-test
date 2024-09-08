using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// deals with the creation of objects suitable for a given situation
namespace Creational
{
    public class Program
    {
        static void Main(string[] args)
        {
            //new AbstractFactory.Client().Main(); Console.WriteLine();

            //new Builder.StartPoint().Main(); Console.WriteLine();

            //new Factory.Client().Main(); Console.WriteLine();

            //---allows cloning of an object without making our code dependent on the class of said object
            //new Prototype.StartPoint().Main(); Console.WriteLine();

            //---only one instance of the class should exist
            new Singleton.StartPoint().Main(); Console.WriteLine();


            Console.ReadKey();
        }
    }
}
