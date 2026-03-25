# Faculty List Creator

## About The Project
This is a Windows Forms desktop application built with C# and the .NET Framework. I built this project to learn the fundamentals of graphical user interfaces (GUI), event-driven programming, and file handling in C#. 

The application allows a user to input data about a university faculty (Name, Dean, Abbreviation) through dynamic popup dialogue windows, and saves that data to a properly formatted text file.

## Features
* **Read-Only UI:** The main interface uses read-only text boxes to prevent accidental user edits, forcing data entry through a controlled menu system.
* **Dynamic Dialog Windows:** Utilizes a secondary Form (`Form2`) that dynamically changes its prompt text based on which menu item the user clicks.
* **File I/O & Encoding:** Automatically generates a text file (`TSU.txt`) or appends to it if it already exists. 
* **Unicode Support:** Safely encodes Russian/Cyrillic characters using UTF-16 (`Encoding.Unicode`) to prevent data corruption.

## Built With
* C#
* .NET Framework 4.8
* Visual Studio

## What I Learned
Through this project, I learned:
1. How to pass data safely between two different Windows Forms.
2. How to use `System.IO` to create and append data to external text files.
3. The importance of text encoding when dealing with non-English alphabets.
4. How to use the `DialogResult` property to confirm user actions.



## App Walkthrough & Screenshots
<img width="1417" height="599" alt="Screenshot 2026-03-25 222220" src="https://github.com/user-attachments/assets/0e6a0080-7792-4719-9415-3af88cdd78fd" />
<img width="510" height="372" alt="Screenshot 2026-03-25 222246" src="https://github.com/user-attachments/assets/cc5da86c-fbfa-4834-b892-dfc5c0ca9e75" />
<img width="1077" height="591" alt="Screenshot 2026-03-25 222342" src="https://github.com/user-attachments/assets/9593f94d-6ae5-4610-b515-d5ce4ae2b251" />
<img width="1507" height="741" alt="Screenshot 2026-03-25 222458" src="https://github.com/user-attachments/assets/521aee39-238c-4b81-9d22-bd666b5ed5c4" />
<img width="487" height="366" alt="Screenshot 2026-03-25 222525" src="https://github.com/user-attachments/assets/df9ef037-3dbd-4249-a13b-f142819f8c20" />
<img width="658" height="462" alt="Screenshot 2026-03-25 222541" src="https://github.com/user-attachments/assets/8388a241-f386-4a0b-92cb-9294f691f6ba" />

