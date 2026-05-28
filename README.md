# 🛡️ Cybersecurity Awareness Assistant (WPF Chatbot)

A desktop chatbot built with **C# and WPF (.NET)** that helps users learn basic cybersecurity awareness through interactive conversation.

This project was created as part of a programming assignment and focuses on safe online habits such as password security, phishing awareness, malware protection, WiFi safety, and personal privacy.

---

## 📌 Features

### ✅ Keyword Recognition
The chatbot detects cybersecurity-related keywords and responds with helpful information.

Supported topics:

- 🔒 Password Security
- 🎣 Phishing Awareness
- 🦠 Malware Protection
- 📶 WiFi Security
- 🔐 Privacy Protection

Example:

User:
password

Bot:
🔒 Never reuse passwords across accounts.

---

### ✅ Random Responses
Each topic contains multiple responses.

Example:

Typing `password` multiple times may return:

- Use a strong passphrase
- Enable Multi-Factor Authentication
- Never reuse passwords

---

### ✅ Memory Recall
The chatbot remembers the user’s name.

Example:

User:
my name is John

Bot:
Nice to meet you, John!

---

### ✅ Conversation Flow
Users can continue conversations naturally.

Examples:

- another
- more

The bot returns another response from the previous topic.

---

### ✅ Menu Bar
Quick access menu:

### File
- Clear Chat
- Exit

### Topics
- Passwords
- Phishing
- Malware
- WiFi Security
- Privacy

### Help
- About

---

### ✅ GUI Chat Interface
Styled chat bubbles:

- User messages → blue
- Bot messages → dark grey

Scrollable conversation window included.

---

### ✅ ASCII Art Banner
Displays a cybersecurity-themed banner at startup.

---

## 🛠 Technologies Used

- C#
- WPF
- .NET
- Visual Studio

---

## 📂 Project Structure

```bash
Chatbot.Cakes/
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── App.xaml
├── App.xaml.cs
├── README.md
```

---

## ▶️ How To Run

### 1. Clone repository

```bash
git clone https://github.com/yourusername/Chatbot.Cakes.git
```

---

### 2. Open in Visual Studio

Open:

```bash
Chatbot.Cakes.sln
```

---

### 3. Build project

Press:

```bash
Ctrl + Shift + B
```

---

### 4. Run

Press:

```bash
F5
```

---

## 💬 Example Usage

### Enter name

```text
my name is Sarah
```

---

### Ask about passwords

```text
password
```

Response:

```text
🔒 Enable MFA.
```

---

### Ask about phishing

```text
phishing
```

Response:

```text
🎣 Hover over suspicious links before clicking.
```

---

### Continue

```text
another
```

---

## 🎯 Learning Outcomes

This project demonstrates:

- Object-Oriented Programming
- Collections (Dictionary + List)
- Random response generation
- Event handling
- WPF UI development
- User input processing
- Keyword matching
- Basic chatbot conversation flow

---

## 👨‍💻 Author

Created by **Tebogo Mashego**

GitHub:
https://github.com/yourusername

---

## 📄 License

This project is for educational purposes.
