using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Examples
{
    class SimpleReflexAgent
    {
        enum Percept { Clean, Dirty }
        enum Action { Suck, NoOp }

        public void Vacuum()
        {

            Percept currentPercept = GetPercept();
            while (currentPercept != Percept.Clean)
            {
                Action action = GetAction(currentPercept);
                ExecuteAction(action);
                currentPercept = GetPercept();
            }
            Console.WriteLine("\n\nTest 1 Done!\n");
            Console.ReadKey();
        }

        static Percept GetPercept()
        {
            // Code to get the current percept from the environment
            // For this example, we'll return a random value
            Random rand = new Random();
            return (Percept)rand.Next(0, 2);
        }

        static Action GetAction(Percept currentPercept)
        {
            switch (currentPercept)
            {
                case Percept.Dirty:
                    return Action.Suck;
                case Percept.Clean:
                    return Action.NoOp;
                default:
                    return Action.NoOp;
            }
        }
        static void ExecuteAction(Action action)
        {
            switch (action)
            {
                case Action.Suck:
                    Console.WriteLine("Sucking dirt");
                    break;
                case Action.NoOp:
                    Console.WriteLine("No operation");
                    break;
            }
        }
    }
}
