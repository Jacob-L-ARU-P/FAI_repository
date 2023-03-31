using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Examples
{
        class ModelBasedReflexAgent
        {
            public void DoThing()
            {
                Room room = new Room();
                CleaningRobot robot = new CleaningRobot(room);
                robot.Clean();
            Console.WriteLine("\n\nTest 2 Complete!\n");
            Console.ReadKey();
            }
        }

        class Room
        {
            public bool HasDirt { get; set; } = true;
            public int DirtLocationX { get; set; } = 0;
            public int DirtLocationY { get; set; } = 0;
        }

        class CleaningRobot
        {
            Room room;
            int x;
            int y;

            public CleaningRobot(Room room)
            {
                this.room = room;
                x = 0;
                y = 0;
            }

            public void Clean()
            {
                while (room.HasDirt)
                {
                    if (room.DirtLocationX == x && room.DirtLocationY == y)
                    {
                        Console.WriteLine("Cleaning dirt at location ({0},{1})", x, y);
                        room.HasDirt = false;
                    }
                    else
                    {
                        Console.WriteLine("Moving to location ({0},{1})", room.DirtLocationX, room.DirtLocationY);
                        x = room.DirtLocationX;
                        y = room.DirtLocationY;
                    }
                }
                Console.WriteLine("Room is clean!");
            }
        }
    }

