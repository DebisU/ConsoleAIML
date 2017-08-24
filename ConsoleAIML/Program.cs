using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAIML
{
    class Program
    {
        static Lucy bot;
        static void Main(string[] args)
        {
            string input = "start";
            while (input != "exit")
            {

                bot = new Lucy();
                Console.Write("You: ");
                input = Console.ReadLine();
                var output = bot.getOutput(input);

                //Console.WriteLine(input);
                Console.WriteLine("Bot: " + output);

                //Make the bot Speak
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10

                // Synchronous
                synthesizer.Speak(output);

                // Asynchronous
                // synthesizer.SpeakAsync(output);

            }
        }
    }
}
