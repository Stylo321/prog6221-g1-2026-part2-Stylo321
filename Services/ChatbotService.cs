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

            responses["virus"] = new List<string>()
{
    "Keep your antivirus software updated.",
    "Avoid downloading files from untrusted websites.",
    "Viruses can damage files and steal information."
};

            responses["hacker"] = new List<string>()
{
    "Hackers often target weak passwords.",
    "Enable two-factor authentication for better protection.",
    "Be cautious when clicking unknown links."
};

            responses["vpn"] = new List<string>()
{
    "A VPN helps protect your privacy online.",
    "VPNs encrypt your internet connection.",
    "Avoid using public Wi-Fi without protection."
};

            responses["malware"] = new List<string>()
{
    "Malware is harmful software designed to damage systems.",
    "Do not install unknown applications.",
    "Regular scans help detect malware early."
};

            responses["firewall"] = new List<string>()
{
    "A firewall helps block unauthorized access.",
    "Firewalls add an extra layer of security.",
    "Always keep your firewall enabled."
};

            responses["cyberbullying"] = new List<string>()
{
    "Report cyberbullying immediately.",
    "Avoid responding to harmful messages online.",
    "Block and report abusive users."
};

            responses["identity theft"] = new List<string>()
{
    "Never share sensitive personal information publicly.",
    "Monitor your accounts for suspicious activity.",
    "Use strong passwords to reduce identity theft risks."
};

            responses["social media"] = new List<string>()
{
    "Review your privacy settings regularly.",
    "Avoid sharing your location publicly.",
    "Think carefully before posting personal information."
};

            responses["2fa"] = new List<string>()
{
    "Two-factor authentication adds extra account security.",
    "Use authentication apps instead of SMS when possible.",
    "2FA helps protect accounts even if passwords are stolen."
};

            responses["wifi"] = new List<string>()
{
    "Public Wi-Fi networks can be risky.",
    "Avoid banking on unsecured Wi-Fi.",
    "Use a VPN on public networks for better security."
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
                List<string> emptyResponses = new List<string>()
            {
                 "Please type something so I can help you.",
                 "I didn't receive a message. Try asking me something about cybersecurity.",
                 "Type a cybersecurity question so we can continue.",
                 "I'm ready whenever you are."
            };

                return emptyResponses[random.Next(emptyResponses.Count)];
            }


           
            if (input.Contains("worried") || input.Contains("scared") || input.Contains("nervous"))
            {
                List<string> worriedResponses = new List<string>()
            {
                       "It's understandable to feel worried about cybersecurity threats. Stay calm and follow safe online practices. One important tip is to never share sensitive information with unknown sources.",

                       "A lot of people feel worried about online scams. You're already improving your safety by learning about cybersecurity.",

                       "Cyber threats can seem scary, but using strong passwords and avoiding suspicious links can greatly reduce risks."
            };

                return worriedResponses[random.Next(worriedResponses.Count)];
            }


        
            if (input.Contains("frustrated") || input.Contains("annoyed") || input.Contains("angry"))
            {
                List<string> frustratedResponses = new List<string>()
            {
                      "Cybersecurity can feel overwhelming sometimes, but you're doing the right thing by learning about it step by step.",

                      "I understand your frustration. Online safety has many parts, but even small habits can make a big difference.",

                      "Take it one step at a time. Learning cybersecurity slowly is completely normal."
            };

                return frustratedResponses[random.Next(frustratedResponses.Count)];
            }


// if tyhe user is feeling curious the system is able to read that and answer accordingly          
            if (input.Contains("curious") || input.Contains("interested"))
            {
                List<string> curiousResponses = new List<string>()
               {
                       "Curiosity is great in cybersecurity! The more you learn, the safer you become online.",

                       "That's a great mindset. Cybersecurity is all about staying informed and alert.",

                       "Being curious about cybersecurity helps you stay ahead of online threats."
               };

                return curiousResponses[random.Next(curiousResponses.Count)];
            }


            
            if (input.Contains("i like") || input.Contains("i love"))
            {
               
                if (input.Contains("privacy"))
                {
                    favouriteTopic = "privacy";

                    List<string> privacyResponses = new List<string>()
                {
                     "Great! I'll remember that you're interested in privacy.",

                     "Privacy is an important part of cybersecurity. I'll remember that's your favourite topic.",

                     "Awesome! Online privacy helps protect your personal information."
                };

                    return privacyResponses[random.Next(privacyResponses.Count)];
                }

              
                if (input.Contains("password"))
                {
                    favouriteTopic = "password safety";

                    List<string> passwordResponses = new List<string>()
                {
                     "Awesome! I'll remember that you're interested in password safety.",

                     "Strong passwords are one of the best ways to stay secure online.",

                     "Password safety is a very important cybersecurity skill."
                 };

                    return passwordResponses[random.Next(passwordResponses.Count)];
                }

                
                if (input.Contains("phishing"))
                {
                    favouriteTopic = "phishing";

                    List<string> phishingResponses = new List<string>()
                {
                     "Great choice! I'll remember that you're interested in phishing awareness.",

                     "Phishing scams are very common online, so learning about them is smart.",

                     "Understanding phishing helps you avoid dangerous scams."
                };

                    return phishingResponses[random.Next(phishingResponses.Count)];
                }

               
                if (input.Contains("scam"))
                {
                    favouriteTopic = "online scams";

                    List<string> scamResponses = new List<string>()
                {
                     "I'll remember that you're interested in online scams.",

                     "Learning about scams helps you spot fake messages faster.",
   
                     "Scam awareness is a powerful cybersecurity skill."
                };

                    return scamResponses[random.Next(scamResponses.Count)];
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