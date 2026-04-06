using System.Collections.Generic;

namespace CybersecurityChatbot
{
    public class ResponseManager
    {
        private readonly Dictionary<string, string> responses;

        public ResponseManager()
        {
            responses = new Dictionary<string, string>
            {
                { "how are you", "I'm just a bot, but I'm functioning perfectly! How can I help you?" },
                { "what is your purpose", "I'm here to teach you about cybersecurity – password safety, phishing, and safe browsing." },
                { "password", "Use strong passwords: at least 12 characters, mix of letters, numbers, and symbols. Never reuse passwords!" },
                { "phishing", "Phishing emails often have urgent language, suspicious links, or spelling errors. Always check the sender's address." },
                { "safe browsing", "Look for 'https://' and a padlock icon in the address bar. Avoid clicking on pop‑ups." }
            };
        }

        public string GetResponse(string userInput)
        {
            foreach (var kvp in responses)
            {
                if (userInput.Contains(kvp.Key))
                {
                    return kvp.Value;
                }
            }
            return "I didn't quite understand that. Could you rephrase? You can ask me about passwords, phishing, or safe browsing.";
        }
    }
}