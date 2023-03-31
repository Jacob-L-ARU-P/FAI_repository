using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightWithCrossing
{
        enum States
        {
            Green,
            Yellow,
            Red,
            RedYellow,
            PedestrianRed,
            PedestrianGreen
        }

        class Program
        {
            static States currentState = States.Green;

            static void Main(string[] args)
            {
                while (true)
                {
                    switch (currentState)
                    {
                        case States.Red:
                            Console.WriteLine("Red light is on.");
                            Console.WriteLine("Wait for green light.");
                            System.Threading.Thread.Sleep(5000);
                            currentState = States.Green;
                            break;
                        case States.Green:
                            Console.WriteLine("Green light is on.");
                            Console.WriteLine("Wait for yellow light.");
                            System.Threading.Thread.Sleep(3000);
                            currentState = States.Yellow;
                            break;
                        case States.Yellow:
                            Console.WriteLine("Yellow light is on.");
                            Console.WriteLine("Wait for red light.");
                            System.Threading.Thread.Sleep(2000);
                            currentState = States.Red;
                            break;
                    }
                }
            }
        }


    }
