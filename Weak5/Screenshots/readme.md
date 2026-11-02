# C# File Handling – StreamWriter

The project contains three button click events:

1. Create and write to a file.
2. Create a file using a specific file path.
3. Append text to an existing file.

## 1. Create and Write to a File

**Method:** `File.CreateText()`

This method creates a new file or overwrites an existing file.

```csharp
StreamWriter output;

output = File.CreateText("index.txt");
output = File.CreateText("home.doc");

output.Write("Welcome Jamhuuriya University");
output.Write("Specially Campus Two");
output.WriteLine("Semester 5");
output.WriteLine("Haal9");

output.Close();
```

**Explanation:**

* `StreamWriter` is used to write data into files.
* `File.CreateText()` creates a file.
* `Write()` writes text without moving to a new line.
* `WriteLine()` writes text and moves to a new line.
* `Close()` closes the file.

## 2. Create a File Using File Path

**Method:** `File.CreateText(@"File Path")`

This method creates a file in a specific folder using its full path.

```csharp
StreamWriter output;

output = File.CreateText(
    @"C:\Users\hp\Downloads\createfiles\hello.txt");

output.WriteLine("Welcome xa242");
output.WriteLine("Courses");
output.WriteLine("Java");
output.WriteLine("C sharp");
output.WriteLine("English");
output.WriteLine("Data Logic Design");

output.Close();
```

**Explanation:**

* `File.CreateText()` creates a file at the specified location.
* `@` allows a Windows path to be written without escaping each backslash.
* `WriteLine()` writes information line by line.
* `Close()` closes the file after writing.

## 3. Append Text to a File

**Method:** `File.AppendText()`

This method adds new information to the end of an existing file without deleting its previous contents.

```csharp
try
{
    StreamWriter output;

    output = File.AppendText("home.doc");

    output.WriteLine("Hello Everyone");
    output.WriteLine("Today is Friday");

    output.Close();
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

**Explanation:**

* `File.AppendText()` adds new text to an existing file.
* `WriteLine()` writes new information.
* `Close()` closes the file.
* `try-catch` handles errors that may occur during file operations.

## Important C# File Methods

| Method              | Description                                             |
| ------------------- | ------------------------------------------------------- |
| `File.CreateText()` | Creates a new text file or overwrites an existing file. |
| `File.AppendText()` | Adds text to the end of an existing file.               |
| `Write()`           | Writes text without a new line.                         |
| `WriteLine()`       | Writes text and moves to a new line.                    |
| `Close()`           | Closes the file.                                        |

##  Important Notes

* Always close a file after writing.
* `CreateText()` overwrites existing file contents.
* `AppendText()` preserves existing contents and adds new text.
* Make sure the folder exists before creating a file.
* Use `using` statements to manage file resources safely.

##  Conclusion

This project helps students understand basic file handling in C# using the `StreamWriter` class.

It demonstrates three important file operations:

1. Creating files.
2. Writing data into files.
3. Appending new data to existing files.

These concepts are useful when developing Windows Forms applications that store information in files.
