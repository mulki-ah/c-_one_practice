# C# Chapter 2 – Processing Data

## Introduction

In this chapter, I learned how C# works with data inside a Windows Forms application. The main idea is that the user gives some information, the program stores it, processes it, and then shows the result.

The simple concept I understood is:

**Input → Store → Process → Output**

For example, when a user enters a number in a TextBox, the program can take that value, convert it into a number, calculate something with it, and show the answer in a Label.

---

## 1. TextBox

A **TextBox** is used to receive information from the user.

For example:

```csharp
string name = txtName.Text;
```

Here, `txtName.Text` gets whatever the user typed into the TextBox.

A TextBox normally receives the input as a **string**.

---

## 2. Variables

A **variable** is a place in memory where we can store data.

For example:

```csharp
string name;
int age;
double salary;
```

Each variable has a data type depending on the kind of information we want to store.

The basic format is:

```csharp
DataType VariableName;
```

It is also important to give variables meaningful names so the code is easier to understand.

---

## 3. Data Types

Different types of data need different data types.

Some common C# data types are:

* `string` → text
* `int` → whole numbers
* `double` → numbers with decimal values
* `decimal` → commonly used for accurate financial values

For example:

```csharp
string name = "Ali";
int age = 20;
double temperature = 25.5;
decimal price = 10.50m;
```

---

## 4. Calculations

C# can perform normal mathematical calculations using operators.

The main operators are:

```text
+   Addition
-   Subtraction
*   Multiplication
/   Division
%   Modulus
```

Example:

```csharp
int number1 = 10;
int number2 = 5;

int result = number1 + number2;
```

The result will be `15`.

---

## 5. Converting TextBox Input

One important thing I learned is that data entered into a TextBox is treated as a string, even when the user enters a number.

For example:

```csharp
int age = int.Parse(txtAge.Text);
```

Here, `int.Parse()` converts the TextBox value from a string into an integer.

Other examples include:

```csharp
double.Parse()
decimal.Parse()
```

This is useful when we want to perform calculations with user input.

---

## 6. Displaying the Result

A Label can be used to display information to the user.

For example:

```csharp
lblResult.Text = result.ToString();
```

The `ToString()` method converts the number into a string so it can be displayed by the Label.

We can also combine text and numbers:

```csharp
lblResult.Text = "Your age is " + age;
```

---

## 7. ToString() and Formatting

The `ToString()` method can also be used to format numbers.

For example:

```csharp
double price = 25.5;

lblPrice.Text = price.ToString("C");
```

It can be useful when we want numbers to appear in a specific format, such as currency, percentage, or decimal places.

---

## 8. Exception Handling

Sometimes the user may enter incorrect information.

For example, if the program expects a number but the user enters letters, an error can happen.

We can use `try-catch` to handle this:

```csharp
try
{
    int number = int.Parse(txtNumber.Text);
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}
```

The `try` block contains the code that may cause an error.

The `catch` block handles the error and gives the user a message instead of allowing the program to stop.

---

## 9. Constants

A **constant** is a value that should not change while the program is running.

We use the `const` keyword.

Example:

```csharp
const double INTEREST_RATE = 0.129;
```

Once a constant is declared, its value cannot be changed during program execution.

---

## 10. Math Class

C# has a `Math` class that helps us perform mathematical operations.

Some examples are:

```csharp
Math.Sqrt(x);
Math.Pow(x, y);
Math.Max(x, y);
Math.Min(x, y);
Math.Round(x);
```

For example:

```csharp
double result = Math.Sqrt(25);
```

The result is `5`.

---

## 11. Debugging

Sometimes a program runs without showing a syntax error, but the result is still wrong. This is called a **logic error**.

Visual Studio provides debugging tools to help find these problems.

One useful tool is a **breakpoint**.

A breakpoint pauses the program at a specific line so we can check the values of variables and understand what is happening.

---

## My Understanding

The main thing I understood from this chapter is that processing data is about taking information from the user and doing something useful with it.

For example:

```text
User enters data
       ↓
TextBox receives it
       ↓
Variable stores it
       ↓
Data is converted if needed
       ↓
Calculation is performed
       ↓
Result is displayed
```

So, the basic idea of this chapter is:

**Get the data → Store the data → Process the data → Show the result.**

## Conclusion

This chapter helped me understand the basic way C# Windows Forms applications work with data. I learned about TextBox input, variables, data types, calculations, data conversion, formatting, exception handling, constants, the Math class, and debugging. These are basic concepts that I can use in future C# projects.
