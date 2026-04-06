using System;

namespace CybersecurityChatbot
{
    public class UIManager
    {
        public void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string art = @"
╔══════════════════════════════════════════════════════════════╗
║                     CYBERSECURITY                            ║
║                    AWARENESS BOT                             ║
╚══════════════════════════════════════════════════════════════╝
";
            Console.WriteLine(art);
            Console.ResetColor();
            Console.WriteLine();
        }

        public void ShowPrompt(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
        }

        public void ShowBotMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Bot: {message}");
            Console.ResetColor();
        }

        public void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}