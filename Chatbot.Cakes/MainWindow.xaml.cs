using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Media;

namespace CybersecurityAwarenessBot
{
    public partial class MainWindow : Window
    {
        // Delegate
        public delegate void BotResponse(string message);
        private BotResponse responseHandler;

        // Random generator
        private Random random = new Random();

        // Stores previous topic
        private string lastTopic = "";

        // User memory
        private Dictionary<string, string> userMemory =
            new Dictionary<string, string>();

        // Bot responses
        private Dictionary<string, List<string>> responses =
            new Dictionary<string, List<string>>();

        // Keyword mapping
        private Dictionary<string, List<string>> keywords =
            new Dictionary<string, List<string>>();

        // USER NAME SYSTEM
        private string userName = "";
        private bool waitingForName = true;

        // prevent repeating same response
        private Dictionary<string, int> lastUsed =
            new Dictionary<string, int>();

        public MainWindow()
        {
            InitializeComponent();

            responseHandler = DisplayBotMessage;

            LoadResponses();
            LoadKeywords();
        }

        // WINDOW LOADED
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AsciiArtBox.Text =
@"
   ██████╗██╗   ██╗██████╗ ███████╗██████╗ 
  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝
  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║
   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝

        CYBERSECURITY AWARENESS CHAT BOT
";

            responseHandler(
                "Welcome to the Cybersecurity Awareness Chat Bot!"
                + Environment.NewLine +
                "Before we begin, can you please enter your name?"); 

            // Play greeting.wav
            try
            {
                SoundPlayer player =
                    new SoundPlayer("greeting.wav");

                player.Play();
            }
            catch
            {
                // continue if file missing
            }
        }

        // LOAD RESPONSES
        private void LoadResponses()
        {
            responses["password"] = new List<string>()
            {
                "Strong passwords should include uppercase, lowercase, numbers, and symbols.",
                "Use a password manager to generate and store secure passwords.",
                "Never reuse passwords across different accounts."
            };

            responses["phishing"] = new List<string>()
            {
                "Phishing emails try to trick you into giving away personal data.",
                "Always check links before clicking them.",
                "Never enter passwords on suspicious websites."
            };

            responses["scam"] = new List<string>()
            {
                "Scams often create urgency like 'your account is locked'.",
                "If it sounds too good to be true, it probably is.",
                "Never share OTPs or banking details."
            };

            responses["privacy"] = new List<string>()
            {
                "Limit what personal information you share online.",
                "Review social media privacy settings regularly.",
                "Enable multi-factor authentication for better protection."
            };

            responses["malware"] = new List<string>()
            {
                "Malware includes viruses, ransomware, spyware, and trojans.",
                "Avoid downloading files from unknown sources.",
                "Keep antivirus software updated."
            };

            responses["wifi"] = new List<string>()
            {
                "Public Wi-Fi can expose your data to attackers.",
                "Avoid logging into banking accounts on public Wi-Fi.",
                "Use a VPN when on public networks."
            };

            responses["social engineering"] = new List<string>()
            {
                "Attackers manipulate people into revealing sensitive information.",
                "Always verify requests before sharing data.",
                "Be cautious of urgency or fear-based messages."
            };

            responses["2fa"] = new List<string>()
            {
                "2FA adds an extra security layer beyond passwords.",
                "Authenticator apps are safer than SMS codes.",
                "Enable 2FA wherever possible."
            };

            responses["identity theft"] = new List<string>()
            {
                "Identity theft involves stealing personal information to impersonate you.",
                "Monitor your accounts regularly for suspicious activity.",
                "Use strong, unique passwords for every account."
            };

            responses["data breach"] = new List<string>()
            {
                "A data breach exposes sensitive user information.",
                "Change passwords immediately after a breach.",
                "Avoid reusing passwords across sites."
            };

            responses["vpn"] = new List<string>()
            {
                "A VPN encrypts your internet connection.",
                "VPNs improve privacy on public Wi-Fi.",
                "Always use trusted VPN providers."
            };

            responses["encryption"] = new List<string>()
            {
                "Encryption protects data by making it unreadable without a key.",
                "HTTPS websites use encryption for security.",
                "Messaging apps often use end-to-end encryption."
            };
        }

        // LOAD KEYWORDS
        private void LoadKeywords()
        {
            keywords["password"] = new List<string> { "password", "passwords", "passcode" };
            keywords["phishing"] = new List<string> { "phishing", "fake email", "scam email", "suspicious email" };
            keywords["scam"] = new List<string> { "scam", "fraud", "fake website" };
            keywords["privacy"] = new List<string> { "privacy", "personal information" };
            keywords["malware"] = new List<string> { "malware", "virus", "trojan", "ransomware", "spyware" };
            keywords["wifi"] = new List<string> { "wifi", "public wifi", "wireless network" };
            keywords["social engineering"] = new List<string> { "social engineering", "manipulation" };
            keywords["2fa"] = new List<string> { "2fa", "two factor authentication", "mfa" };
            keywords["identity theft"] = new List<string> { "identity theft", "identity fraud" };
            keywords["data breach"] = new List<string> { "data breach", "leaked data" };
            keywords["vpn"] = new List<string> { "vpn", "virtual private network" };
            keywords["encryption"] = new List<string> { "encryption", "encrypted" };
        }

        // SEND BUTTON
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
                return;

            ChatBox.AppendText(
                "You: " + input +
                Environment.NewLine +
                Environment.NewLine);

            if (waitingForName)
            {
                userName = input;
                waitingForName = false;

                responseHandler(
                    "Nice to meet you, " + userName +
                    "! Ask me about passwords, phishing, scams, malware, VPNs, and privacy.");

                InputBox.Clear();
                ChatBox.ScrollToEnd();
                return;
            }

            string reply = GetResponse(input);

            responseHandler(reply);

            InputBox.Clear();
            ChatBox.ScrollToEnd();
        }

        // BOT LOGIC
        private string GetResponse(string input)
        {
            string lower = input.ToLower();

            if (lower.Contains("hello") || lower.Contains("hi"))
                return "Hello " + userName + "! How can I help you stay safe online?";

            if (lower.Contains("thank"))
                return "You're welcome, " + userName + "!";

            if (lower.Contains("bye") || lower.Contains("goodbye"))
                return "Goodbye " + userName + "! Stay safe online.";

            if (lower.Contains("worried"))
                return "It's normal to feel worried. Learning helps reduce risk. "
                    + GetRandom("scam");

            if (lower.Contains("interested in privacy"))
            {
                userMemory["interest"] = "privacy";
                return "Got it! I'll remember you're interested in privacy.";
            }

            if (lower.Contains("interested in phishing"))
            {
                userMemory["interest"] = "phishing";
                return "Got it! I'll remember you're interested in phishing.";
            }

            if (lower.Contains("tell me more") ||
                lower.Contains("another tip"))
            {
                if (!string.IsNullOrEmpty(lastTopic))
                    return GetRandom(lastTopic);

                return "Please choose a topic like passwords, phishing, or malware.";
            }

            foreach (var item in keywords)
            {
                foreach (var keyword in item.Value)
                {
                    if (lower.Contains(keyword))
                    {
                        lastTopic = item.Key;
                        return GetRandom(item.Key);
                    }
                }
            }

            if (userMemory.ContainsKey("interest"))
            {
                return "Since you're interested in "
                    + userMemory["interest"] +
                    ", remember to stay cautious and use strong security habits.";
            }

            return "I'm not sure I understand. Try asking about passwords, phishing, malware, VPNs, or privacy.";
        }

        // RANDOM RESPONSE
        private string GetRandom(string topic)
        {
            if (!responses.ContainsKey(topic))
                return "I don't have information on that yet.";

            var list = responses[topic];

            int index;

            do
            {
                index = random.Next(list.Count);
            }
            while (list.Count > 1 &&
                   lastUsed.ContainsKey(topic) &&
                   lastUsed[topic] == index);

            lastUsed[topic] = index;

            return list[index];
        }

        // DISPLAY BOT MESSAGE
        private void DisplayBotMessage(string message)
        {
            ChatBox.AppendText(
                "CyberBot: " + message +
                Environment.NewLine +
                Environment.NewLine);

            ChatBox.ScrollToEnd();
        }

        // EXIT
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}