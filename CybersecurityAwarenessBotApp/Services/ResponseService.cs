namespace CybersecurityAwarenessBotApp.Services
{
    internal class ResponseService
    {
        public string GetResponse(string input, string userName)
        {
            if (input.Contains("how are you"))
            {
                return $"I am doing well, {userName}. Thank you for asking.";
            }
            else if (input.Contains("what is your purpose") || input.Contains("what's your purpose"))
            {
                return "My purpose is to teach users about cybersecurity awareness.";
            }
            else if (input.Contains("what can i ask you about"))
            {
                return "You can ask me about passwords, phishing, safe browsing, and scams.";
            }
            else if (input.Contains("password"))
            {
                return "Use a strong password with uppercase letters, lowercase letters, numbers, and symbols.";
            }
            else if (input.Contains("phishing"))
            {
                return "Phishing is a scam where criminals try to trick you into giving away personal information.";
            }
            else if (input.Contains("safe browsing") || input.Contains("browsing"))
            {
                return "Safe browsing means visiting trusted websites, avoiding suspicious downloads, and checking for HTTPS.";
            }
            else if (input.Contains("scam"))
            {
                return "Always verify suspicious messages before clicking links or sharing information.";
            }
            else if (input.Contains("hello") || input.Contains("hi"))
            {
                return $"Hello, {userName}! How can I help you today?";
            }
            else if (input.Contains("thanks") || input.Contains("thank you"))
            {
                return "You are welcome. Stay safe online!";
            }
            else
            {
                return "I didn't quite understand that. Could you rephrase? You can ask about passwords, phishing, or safe browsing.";
            }
        }
    }
}