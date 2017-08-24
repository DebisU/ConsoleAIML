using AIMLbot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAIML
{
    public class Lucy
    {
        const string UserId = "DebisU";
        private Bot AimlBot;
        private User myUser;

        public Lucy()
        {

            Console.ForegroundColor = ConsoleColor.Green;

            AimlBot = new Bot();
            myUser = new User(UserId, AimlBot);
            Console.Title = "Lucy AIML";
            Initialize();
        }

        // Loads all the AIML files in the \AIML folder         
        public void Initialize()
        {
            AimlBot.loadSettings();
            AimlBot.isAcceptingUserInput = false;
            AimlBot.loadAIMLFromFiles();
            AimlBot.isAcceptingUserInput = true;
        }

        // Given an input string, finds a response using AIMLbot lib
        public String getOutput(String input)
        {
            Request r = new Request(input, myUser, AimlBot);
            Result res = AimlBot.Chat(r);
            return (res.Output);
        }
    }
}
