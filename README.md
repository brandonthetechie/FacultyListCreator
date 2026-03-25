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
