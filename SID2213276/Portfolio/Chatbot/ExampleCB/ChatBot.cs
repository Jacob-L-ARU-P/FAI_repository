using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace ExampleCB
{
    class ChatBot
    {
        private Dictionary<string, string> knowledge = new Dictionary<string, string>();

        public void Learn(string question, string answer)
        {
            knowledge.Add(question, answer);
        }

        public string Respond(string input)
        {
            if (knowledge.ContainsKey(input))
            {
                return knowledge[input];
            }
            else
            {
                return "I don't know the answer to that. Could you teach me?";
            }
        }

        public void aaaa()
        {
            // Save dictionary to file
            using (StreamWriter writer = new StreamWriter("knowledge.txt"))
            {
                foreach (var question in knowledge)
                {
                    writer.WriteLine(question.Key + "," + question.Value);
                }
            }

            // Read dictionary from file
            Dictionary<string, string> readKnowledge = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader("questions.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] kv = line.Split(',');
                    readKnowledge.Add(kv[0], kv[1]);
                }
            }
        }
    }
}
