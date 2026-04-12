# CybersecurityChatbot
﻿# Cybersecurity Awareness Chatbot

A console-based chatbot that educates South African citizens about cybersecurity threats including phishing, password safety, and safe browsing.

## Features
- Voice greeting (recorded WAV with fallback beeps)
- ASCII art logo with coloured console UI
- Personalised interaction using user's name
- Responses to cybersecurity questions
- Input validation for empty or unrecognised queries
- Simulated conversation flow with exit commands

## How to Run the Program

### Prerequisites
- Windows OS (for full audio support)
- Visual Studio 2019 or later (or .NET Framework 4.7.2 SDK)

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/Sophycoder519/CybersecurityChatbot

 2.Open the solution
Navigate into the cloned folder and double‑click CybersecurityChatbot.sln to open it in Visual Studio.

3.Build and run
Press F5 or click Debug → Start Debugging.

4.Interact with the chatbot

Enter your name when prompted.

Ask questions like: password, phishing, safe browsing, how are you, what is your purpose.

Type exit, quit, or goodbye to end the conversation.

Note: The greeting.wav file is automatically copied to the output directory. If no audio device is available, the program will play a sequence of beeps as a fallback.

GitHub Actions CI
This project uses GitHub Actions to automatically build the solution on every push. The workflow runs on windows-latest and uses MSBuild.

## GitHub Actions CI

![CI Build Passing](screenshot.png)

The screenshot above shows the GitHub Actions workflow completing successfully (green check mark).

Video Presentation
A full demonstration and code explanation video is available here:
Watch the video presentation ()

The video covers:

Code structure (Program.cs, Chatbot.cs, ResponseManager.cs, UIManager.cs)

Voice greeting implementation using System.Media.SoundPlayer

ASCII art and console formatting

Input validation and response logic

Automatic property usage

Live demonstration of the running chatbot

---
