using System;
using System.Collections.Generic;

namespace CyberSecurityBotGUI.Services
{
    public class ChatbotService
    {
        private Dictionary<string, List<string>> responses;
        private Random random = new Random();

      
        private string favouriteTopic = "";
        private string currentTopic = "";
        private string userName = "";

        public ChatbotService()
        {
            responses = new Dictionary<string, List<string>>();



           
            responses["password"] = new List<string>()
            {
                "Use strong passwords with symbols and numbers.",
                "Avoid using birthdays in passwords.",
                "Use a unique password for every account."
            };

         
            responses["phishing"] = new List<string>()
            {
                "Do not click suspicious email links.",
                "Check the sender's email carefully.",
                "Scammers often pretend to be trusted companies."
            };

           
            responses["privacy"] = new List<string>()
            {
                "Review your social media privacy settings regularly.",
                "Avoid sharing sensitive information publicly.",
                "Use two-factor authentication for better privacy."
            };

          
            responses["scam"] = new List<string>()
            {
                "Never send money to unknown people online.",
                "Scammers often create fake urgency.",
                "Always verify before sharing personal details."
            };
        }
        private string GetName()
        {
            return string.IsNullOrEmpty(userName) ? "friend" : userName;
        }

        public string GetResponse(string input)
        {
            input = input.ToLower();
        
            if (input.StartsWith("my name is"))
            {
                userName = input.Replace("my name is", "").Trim();

                return $"Nice to meet you, {userName}! I'll remember your name.";
            }







            if (string.IsNullOrWhiteSpace(input))
            {
                return "Please type something so I can help you.";
            }

            
            if (input.Contains("worried"))
            {
                return "It's understandable to feel worried about cybersecurity threats. Stay calm and follow safe online practices. One important tip is to never share sensitive information with unknown sources.";
            }

            if (input.Contains("frustrated"))
            {
                return "Cybersecurity can feel overwhelming sometimes, but you're doing the right thing by learning about it step by step.";
            }

            if (input.Contains("curious"))
            {
                return "Curiosity is great in cybersecurity! The more you learn, the safer you become online.";
            }

           
            if (input.Contains("i like"))
            {
                if (input.Contains("privacy"))
                {
                    favouriteTopic = "privacy";

                    return "Great! I'll remember that you're interested in privacy.";
                }

                if (input.Contains("password"))
                {
                    favouriteTopic = "password safety";

                    return "Awesome! I'll remember that you're interested in password safety.";
                }
            }



            
            if (input.Contains("tell me more") ||
                input.Contains("another tip") ||
                input.Contains("explain more"))
            {
                if (!string.IsNullOrEmpty(currentTopic))
                {
                    List<string> topicResponses = responses[currentTopic];

                    int randomIndex = random.Next(topicResponses.Count);

                    return "Here is another tip about " + currentTopic + ": " +
                           topicResponses[randomIndex];
                }

                return "Could you specify which topic you'd like to know more about?";
            }

         
            if (input.Contains("how are you"))
            {
                return $"I'm functioning perfectly,{GetName()}, and ready to help you stay safe online!";
            }

            if (input.Contains("purpose"))
            {
                return $"My purpose is to help users like you,{GetName()}, stay safe online and learn cybersecurity awareness.";
            }

            if (input.Contains("what can i ask"))
            {
                return $"{GetName()}, you can ask me about passwords, phishing, scams, privacy, and safe browsing.";
            }



            foreach (var keyword in responses.Keys)
            {
                if (input.Contains(keyword))
                {
                    currentTopic = keyword;

                    List<string> possibleResponses = responses[keyword];

                    int index = random.Next(possibleResponses.Count);

                    string response = possibleResponses[index];

                   
                    if (!string.IsNullOrEmpty(favouriteTopic))
                    {
                        response += "\n\nSince you're interested in " +
                                    favouriteTopic +
                                    ", this topic is especially important.";
                    }

                    return response;
                }
            }

           
            return "I'm not sure I understand. Can you try rephrasing?";
        }

    }
}