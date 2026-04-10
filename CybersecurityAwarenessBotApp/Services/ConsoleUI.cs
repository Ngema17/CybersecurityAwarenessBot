using System.Threading;

namespace CybersecurityAwarenessBotApp.Services
{
    internal class ConsoleUI
    {
        public void DisplayHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("==============================================================");
            Console.WriteLine("              CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("==============================================================");
            Console.WriteLine(@"
   _____
  / ___  /|
 / / ___/ / |
/ / /__  /  |
| |  __  | |  |
| | |  | | |  |
| | |__| | |  |
| |__| | /
|/___|/ /

          [ SAFE • SMART • SECURE ]
");
            Console.ResetColor();
        }

        public void DisplayDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
        }

        public void TypeText(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            foreach (char character in message)
            {
                Console.Write(character);
                Thread.Sleep(15);
            }

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}