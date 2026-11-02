# CHAPTER 5: FILE ACCESSING, DIALOGS, AND ADDITIONAL CONCEPTS

## 1. Using Files for Data Storage

File storage is used to save information permanently so that we can use it again later.

When a program works with a file, it follows three main steps:

### 1. Open

Opening means creating a connection between the program and the file.

### 2. Process

Processing means reading data from the file or writing new data into it.

### 3. Close

Closing means disconnecting the file from the program after finishing the work.

### Types of Files

There are two main types of files:

**A. Text Files**

Text files store information in a readable text format using character encoding such as Unicode.

Example:

```text
Name: Ahmed
Age: 22
Course: IT
```

**B. Binary Files**

Binary files store information in binary format (bytes), which is not directly readable as normal text.

Examples:

* Images
* Videos
* Audio files

---

## 2. Writing Data to a File (StreamWriter)

StreamWriter is a C# class used to write information into text files.

### Methods to Open a File

**A. File.CreateText()**

This method creates a new text file. If the file already exists, its previous contents will be erased.

Example:

```csharp
StreamWriter output;

output = File.CreateText("students.txt");

output.WriteLine("Ahmed");
output.WriteLine("Computer Science");

output.Close();
```

**B. File.AppendText()**

This method opens an existing file and adds new information at the end without deleting the old data.

Example:

```csharp
StreamWriter output;

output = File.AppendText("students.txt");

output.WriteLine("Mohamed");
output.WriteLine("Information Technology");

output.Close();
```

### Methods to Write Data

**1. WriteLine()**

Writes data into a file and moves to the next line.

```csharp
output.WriteLine("Hello");
output.WriteLine("Welcome");
```

Output:

```text
Hello
Welcome
```

**2. Write()**

Writes data without moving to a new line.

```csharp
output.Write("Hello ");
output.Write("World");
```

Output:

```text
Hello World
```

---

## 3. Reading Data from a File (StreamReader)

StreamReader is a C# class used to read information from text files.

We use `File.OpenText()` to open a text file for reading.

Example:

```csharp
StreamReader input;

input = File.OpenText("students.txt");

string data = input.ReadToEnd();

MessageBox.Show(data);

input.Close();
```

### Methods to Read Data

**A. ReadLine()**

Reads one line from the file and returns it as a string.

```csharp
string line = input.ReadLine();
```

**B. Read()**

Reads the next character or characters from the input stream.

```csharp
int character = input.Read();
```

**C. ReadToEnd()**

Reads all the remaining text from the file.

```csharp
string data = input.ReadToEnd();
```

**D. File.ReadAllText()**

Reads the entire contents of a file at once.

```csharp
string data = File.ReadAllText("students.txt");

MessageBox.Show(data);
```

### Reading a File Using a Loop (EndOfStream)

EndOfStream is a property that checks whether the reader has reached the end of the file.

We use it with a while loop to read all lines until the file ends.

Example:

```csharp
StreamReader reader = File.OpenText("students.txt");

while (!reader.EndOfStream)
{
    string line = reader.ReadLine();

    listBox1.Items.Add(line);
}

reader.Close();
```

**Explanation:**

* `File.OpenText()` opens the file.
* `EndOfStream` checks whether the end of the file has been reached.
* `while` repeats the process until the end.
* `ReadLine()` reads one line.
* `Items.Add()` displays the line inside the ListBox.
* `Close()` closes the file.

---

## 4. OpenFileDialog and SaveFileDialog Controls

OpenFileDialog and SaveFileDialog are Windows Forms controls used to display standard Windows dialog boxes.

They help users select files to open or choose where to save files.

### A. OpenFileDialog

OpenFileDialog allows the user to browse and select an existing file.

Example:

```csharp
OpenFileDialog openFileDialog1 = new OpenFileDialog();

if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
    string path = openFileDialog1.FileName;

    MessageBox.Show(path);
}
```

### B. SaveFileDialog

SaveFileDialog allows the user to choose a location and filename for saving a file.

Example:

```csharp
SaveFileDialog saveFileDialog1 = new SaveFileDialog();

if (saveFileDialog1.ShowDialog() == DialogResult.OK)
{
    string path = saveFileDialog1.FileName;

    MessageBox.Show(path);
}
```

### Important Properties and Methods

**1. ShowDialog()**

Displays the dialog box and returns a DialogResult.

It can return:

* OK – The user selects or confirms a file.
* Cancel – The user cancels the operation.

**2. FileName**

Stores the selected file name and its complete path.

**3. InitialDirectory**

Specifies the folder that appears first when the dialog box opens.

Example:

```csharp
openFileDialog1.InitialDirectory = @"C:\Users\hp\Documents";
```

---

## 5. Random Numbers and The Load Event

### A. Random Class

The Random class is used to generate random numbers in C#.

First, we create a Random object:

```csharp
Random rand = new Random();
```

There are two important methods:

**1. Next()**

Generates a random integer.

Example:

```csharp
Random rand = new Random();

int number = rand.Next(1, 10);

MessageBox.Show(number.ToString());
```

This generates an integer from 1 up to 9.

**2. NextDouble()**

Generates a random decimal number from 0.0 up to, but not including, 1.0.

Example:

```csharp
Random rand = new Random();

double number = rand.NextDouble();

MessageBox.Show(number.ToString());
```

### B. Form Load Event

The Form Load event occurs when a Windows Form is loaded into memory.

It is commonly used to initialize the application before the user starts working with it.

**Uses of Form Load Event:**

* Initializing variables.
* Loading information from files.
* Generating random numbers.
* Preparing controls.
* Setting default values.

Example:

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    Random rand = new Random();

    int number = rand.Next(1, 100);

    label1.Text = number.ToString();
}
```

This code generates a random number when the form loads and displays it in a Label.

---

# IMPORTANT REVISION TABLE

| Method / Class    | Purpose                                         |
| ----------------- | ----------------------------------------------- |
| StreamWriter      | Writes data into a file.                        |
| StreamReader      | Reads data from a file.                         |
| File.CreateText() | Creates a text file.                            |
| File.AppendText() | Adds data to an existing file.                  |
| File.OpenText()   | Opens a text file for reading.                  |
| Write()           | Writes without a new line.                      |
| WriteLine()       | Writes and moves to a new line.                 |
| Read()            | Reads characters.                               |
| ReadLine()        | Reads one line.                                 |
| ReadToEnd()       | Reads all remaining text.                       |
| EndOfStream       | Checks whether the end of a file is reached.    |
| OpenFileDialog    | Allows the user to select a file.               |
| SaveFileDialog    | Allows the user to choose where to save a file. |
| ShowDialog()      | Displays a dialog box.                          |
| FileName          | Gets the selected file path and name.           |
| InitialDirectory  | Sets the starting folder.                       |
| Random            | Generates random numbers.                       |
| Next()            | Generates random integers.                      |
| NextDouble()      | Generates random decimal numbers.               |
| Form Load         | Runs code when the form loads.                  |

# IMPORTANT DIFFERENCES

### 1. CreateText vs AppendText

| CreateText                               | AppendText                  |
| ---------------------------------------- | --------------------------- |
| Creates a new file.                      | Opens a file for appending. |
| Removes old contents if the file exists. | Keeps old contents.         |
| Writes new data.                         | Adds new data at the end.   |

### 2. Write vs WriteLine

| Write                        | WriteLine                 |
| ---------------------------- | ------------------------- |
| Does not move to a new line. | Moves to a new line.      |
| Writes on the same line.     | Writes on separate lines. |

### 3. StreamReader vs StreamWriter

| StreamReader                 | StreamWriter                  |
| ---------------------------- | ----------------------------- |
| Used for reading files.      | Used for writing files.       |
| Gets information from files. | Saves information into files. |

### 4. OpenFileDialog vs SaveFileDialog

| OpenFileDialog                   | SaveFileDialog                       |
| -------------------------------- | ------------------------------------ |
| Used to select an existing file. | Used to choose where to save a file. |
| Opens files.                     | Helps save files.                    |

|   |
| - |

---

# CHAPTER 5 SUMMARY

In this chapter, we learned how to work with files and additional Windows Forms concepts in C#.

The main topics are:

1. Using files for data storage.
2. Opening, processing and closing files.
3. Text files and binary files.
4. Writing data using StreamWriter.
5. Creating files using CreateText().
6. Adding data using AppendText().
7. Reading data using StreamReader.
8. Reading files using ReadLine(), Read() and ReadToEnd().
9. Using EndOfStream with a while loop.
10. Using OpenFileDialog and SaveFileDialog.
11. Generating random numbers using the Random class.
12. Understanding the Form Load event.

**Conclusion:**

File accessing helps us save and read information, while dialog controls make it easier for users to open and save files. Random numbers and the Form Load event also help us create more interactive Windows Forms applications.
