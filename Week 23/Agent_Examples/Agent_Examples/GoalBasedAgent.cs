using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Examples
{

        class GoalBasedAgent
        {
            public void ScoreGoal()
            {
                SideRoom DaRoom = new SideRoom();
                RoboCleaner Roomba = new RoboCleaner(DaRoom);
                Roomba.Sweep();
                Console.WriteLine("\n\nRoom Cleaned!\n");
                Console.ReadKey();
            }
        }

        class SideRoom
        {
            public bool HasDirt { get; set; } = true;
            public int DirtLocationX { get; set; } = 0;
            public int DirtLocationY { get; set; } = 0;
        }

        class RoboCleaner
        {
            SideRoom DaRoom;
            int x;
            int y;

            public RoboCleaner(SideRoom DaRoom)
            {
                this.DaRoom = DaRoom;
                x = 0;
                y = 0;
            }

            public void Sweep()
            {
                List<Action> plan = GetPlan();
                foreach (Action action in plan)
                {
                    action();
                }
                Console.WriteLine("Room is clean!");
            }

            private List<Action> GetPlan()
            {
                List<Action> plan = new List<Action>();
                while (DaRoom.HasDirt)
                {
                    plan.Add(MoveToDirtLocation);
                    plan.Add(CleanDirt);
                }
                return plan;
            }

            private void MoveToDirtLocation()
            {
                Console.WriteLine("Moving to location ({0},{1})", DaRoom.DirtLocationX, DaRoom.DirtLocationY);
                x = DaRoom.DirtLocationX;
                y = DaRoom.DirtLocationY;
            }

            private void CleanDirt()
            {
                Console.WriteLine("Cleaning dirt at location ({0},{1})", x, y);
                DaRoom.HasDirt = false;
            }
        }
    }
