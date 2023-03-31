using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace ExampleCB
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatBot bot = new ChatBot();

            string fileName = "knowledge.txt";

            if (File.Exists(fileName))
            {
                Console.WriteLine("The file " + fileName + " exists in the current directory.");
            }
            else
            {
                Console.WriteLine("The file " + fileName + " does not exist in the current directory.");
            }

            while (true)
            {
                Console.Write("You: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {

                    break;
                }

                string response = bot.Respond(input);
                Console.WriteLine("Chatbot: " + response);

                if (response == "I don't know the answer to that. Could you teach me?")
                {
                    Console.Write("Please type the response to your question so I can learn: ");
                    string answer = Console.ReadLine();
                    bot.Learn(input, answer);
                }
            }
        }
    }
}

