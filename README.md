Cybersecurity Awareness Assistant (WPF Chatbot)

A desktop chatbot built with C# and WPF that helps users learn basic cybersecurity awareness through interactive conversation.

This project was created as part of a programming assignment and focuses on safe online habits such as password security, phishing awareness, malware protection, WiFi safety, and personal privacy.

Features

Keyword Recognition
The chatbot detects cybersecurity-related keywords and responds with helpful information.

You can ask about:

Password Security
Phishing Awareness
Malware Protection
WiFi Security
Privacy Protection

For instance, if you type password, the bot might reply: Never reuse passwords across accounts.

Random Responses
Each topic contains multiple responses to keep the conversation fresh.

If you type password multiple times, you might get different answers like:

Use a strong passphrase
Enable Multi-Factor Authentication
Never reuse passwords

Memory Recall
The chatbot remembers who you are to make the interaction more personal.

For example, if you type my name is John, the bot will reply: Nice to meet you, John!

Conversation Flow
You can keep the conversation going naturally without repeating yourself.

Try typing words like another or more. The bot understands you want another tip from the previous topic.

Menu Bar
I included a quick access menu at the top:

File
Clear Chat
Exit

Topics
Passwords
Phishing
Malware
WiFi Security
Privacy

Help
About

GUI Chat Interface
The interface is styled with chat bubbles to make it easy to read.

Your messages appear in blue
Bot messages appear in dark grey

The conversation window is also scrollable so you can look back at previous tips.

ASCII Art Banner
To give it some character, the bot displays a cybersecurity-themed banner when it starts up.

Technologies Used

C#
WPF
.NET
Visual Studio

Project Structure

Chatbot.Cakes/

MainWindow.xaml
MainWindow.xaml.cs
App.xaml
App.xaml.cs
README.md

How To Run

1. Clone the repository

git clone https://github.com/yourusername/Chatbot.Cakes.git

2. Open in Visual Studio

Open the file named Chatbot.Cakes.sln

3. Build the project

Press Ctrl + Shift + B

4. Run the application

Press F5

Example Usage

Enter your name

my name is Sarah

Ask about passwords

password

Response:

Enable MFA.

Ask about phishing

phishing

Response:

Hover over suspicious links before clicking.

Continue the conversation

another

Learning Outcomes

This project helped me practice and understand several core concepts:

Object-Oriented Programming
Using Collections like Dictionary and List
Generating random responses
Handling events in the UI
Developing interfaces with WPF
Processing user input
Matching keywords
Managing basic conversation flow

Author

Created by Tebogo Mashego

GitHub: https://github.com/yourusername

License

This project is for educational purposes.
