using System;
using System.IO;
using System.Media;
using System.Threading;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        // Automatic property
        public string UserName { get; set; }

        private ResponseManager responseManager;
        private UIManager uiManager;

        public Chatbot()
        {
            responseManager = new ResponseManager();
            uiManager = new UIManager();
        }

        public void Start()
        {
            PlayVoiceGreeting();
            uiManager.DisplayAsciiArt();
            GetUserName();
            StartConversation();  // <-- now added
        }

        private void PlayVoiceGreeting()
        {
            string wavPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");
            if (File.Exists(wavPath))
            {
                try
                {
                    using (SoundPlayer player = new SoundPlayer(wavPath))
                    {
                        player.PlaySync();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    uiManager.ShowError($"Audio error: {ex.Message}");
                }
            }
            else
            {
                uiManager.ShowError("greeting.wav not found. Playing beep fallback.");
            }

            Console.Beep(440, 400);
            Console.Beep(523, 400);
            Console.Beep(659, 600);
        }

        private void GetUserName()
        {
            uiManager.ShowPrompt("What is your name? ");
            UserName = Console.ReadLine()?.Trim();
            while (string.IsNullOrWhiteSpace(UserName))
            {
                uiManager.ShowError("Name cannot be empty. Please enter your name: ");
                UserName = Console.ReadLine()?.Trim();
            }
            uiManager.ShowBotMessage($"Nice to meet you, {UserName}! I'm here to help you stay safe online.");
            Thread.Sleep(800);
        }

        // NEW: The conversation loop
        private void StartConversation()
        {
            while (true)
            {
                uiManager.ShowPrompt("You: ");
                string input = Console.ReadLine()?.Trim().ToLower();
                if (string.IsNullOrWhiteSpace(input))
                {
                    uiManager.ShowBotMessage("I didn't catch that. Could you please say something?");
                    continue;
                }
                if (input == "exit" || input == "quit" || input == "goodbye")
                {
                    uiManager.ShowBotMessage($"Goodbye, {UserName}! Stay safe online.");
                    break;
                }
                string reply = responseManager.GetResponse(input);
                uiManager.ShowBotMessage(reply);
            }
        }
    }
}