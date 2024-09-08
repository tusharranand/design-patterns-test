using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral
{
    public class Program
    {
        static void Main(string[] args)
        {
            //---allows you to pass a request along a chain of handlers which decide either to process the request or to pass it to another
            //new ChainOfResponsibility.Client().Main(); Console.WriteLine();

            //---turns a request into a stand-alone object that contains all information about the request
            //new Command.StartPoint().Main(); Console.WriteLine();

            //---allows to traverse elements of a collection without exposing it's underlying logic
            //new Iterator.StartPoint().Main(); Console.WriteLine();

            //---restricts direct communications between the objects and forces them to collaborate only via a mediator object, reducing chaotic dependencies
            //new Mediator.StartPoint().Main(); Console.WriteLine();

            //---save and restore the previous state of an object without revealing the details of its implementation
            //new Memento.StartPoint().Main(); Console.WriteLine();

            //---allows you to define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing
            //new Observer.StartPoint().Main(); Console.WriteLine();

            //---lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.
            new State.StartPoint().Main(); Console.WriteLine();

            //---lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable
            //new Strategy.StratPoint().Main();

            //---defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure
            new Template.Client().Main(); Console.WriteLine();

            //---allows you to separate algorithms from the objects on which they operate
            new Visitor.Client().Main();
        }
    }
}
