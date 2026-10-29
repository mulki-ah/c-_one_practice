# 📁 practicFiles - C# Windows Forms File Handling App

`practicFiles` is a simple C# Windows Forms application designed to demonstrate basic file input/output (I/O) operations using `StreamWriter` and `StreamReader`.

##  Features

- **Create File:** Creates a new text file (`Home.doc`) and writes sample lines into it.


- **Read File:** Reads the file line-by-line using a `while` loop and displays the contents inside a `ListBox` (`lstFileContents`).

- **Clear File Contents:** Clears all text inside the existing file without deleting the file itself.

- **Delete File:** Permanently deletes the file from the directory.

## 🛠️ Technologies Used

- C# (.NET Framework / .NET Core)
- Windows Forms (WinForms)
- `System.IO` namespace (`StreamWriter`, `StreamReader`, `File` class)

## 📌 Code Methods & Descriptions

| Method Name | Description |
| :--- | :--- |
| `btncreatenewFile_Click` | Creates `Home.doc` and writes initial sample text lines. |
| `btnReadLines_Click` | Opens `Home.doc`, reads lines using a `while` loop, and populates the `ListBox`. |
| `btnClearContents_Click` | Empties the text contents of `Home.doc`. |
| `btnDeleteFile_Click` | Deletes `Home.doc` from the system. |

## 💻 How to Run

1. Open **Visual Studio**.
2. Create or open a **Windows Forms App** project named `practicFiles`.
3. Add the necessary controls to `Form1`:
   - Buttons for creating, reading, clearing, and deleting the file.
   - A `ListBox` named `lstFileContents`.
4. Replace the code in `Form1.cs` with the project code.
5. Build and run the application (`F5`).

