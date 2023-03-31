using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleReflexAgent Test = new SimpleReflexAgent();
            Test.Vacuum();
            ModelBasedReflexAgent Test2 = new ModelBasedReflexAgent();
            Test2.DoThing();
            //GoalBasedAgent Test3 = new GoalBasedAgent();
            //Test3.ScoreGoal();
            //UtilityBasedAgent Test4 = new UtilityBasedAgent();
            //Test4.DoStonks();
            LearningAgent Test5 = new LearningAgent();
            Test5.Run();
        }

    }
}


