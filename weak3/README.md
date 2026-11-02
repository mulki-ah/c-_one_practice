# CHAPTER 3: MAKING DECISIONS

## 1. Introduction to Making Decisions

Making decisions means allowing a program to choose what to do depending on a given condition.

In C#, we use decision statements to control how our program works.

For example, a program can check whether a student passed or failed an exam.

## 2. Control Structures

Control structures determine how statements are executed in a program.

There are two main types:

**A. Sequence Structure**

Sequence means that instructions run one after another in the order they are written.

**B. Decision Structure**

Decision structure allows a program to choose what to do based on a condition.

## 3. Relational Operators

Relational operators are used to compare two values. They return true or false.

| Operator | Meaning                  |
| -------- | ------------------------ |
| `>`      | Greater than             |
| `<`      | Less than                |
| `==`     | Equal to                 |
| `!=`     | Not equal to             |
| `>=`     | Greater than or equal to |
| `<=`     | Less than or equal to    |

## 4. If Statement

The if statement is used when we want the program to perform an action only if a condition is true.

Example:

```csharp
int age = 20;

if (age >= 18)
{
    MessageBox.Show("You are an adult");
}
```

If the condition is true, the message will appear.

## 5. If-Else Statement

The if-else statement gives the program two choices.

If the condition is true, the if block runs. Otherwise, the else block runs.

Example:

```csharp
int mark = 40;

if (mark >= 50)
{
    MessageBox.Show("Pass");
}
else
{
    MessageBox.Show("Fail");
}
```

## 6. Nested If Statement

Nested if means putting one if statement inside another if statement.

It is used when we need to check more than one condition.

Example:

```csharp
int age = 20;

if (age >= 18)
{
    if (age <= 30)
    {
        MessageBox.Show("Accepted");
    }
}
```

The second condition is checked only when the first condition is true.

## 7. If-Else-If Statement

This statement is used when we have many conditions to check.

The program checks the conditions one by one until it finds a true condition.

Example:

```csharp
int mark = 85;

if (mark >= 90)
{
    MessageBox.Show("Grade A");
}
else if (mark >= 80)
{
    MessageBox.Show("Grade B");
}
else if (mark >= 70)
{
    MessageBox.Show("Grade C");
}
else
{
    MessageBox.Show("Fail");
}
```

It is commonly used in student grading systems.

## 8. Logical Operators

Logical operators help us combine two or more conditions.

There are three main logical operators:

**A. AND (&&)**

Both conditions must be true.

Example:

```csharp
if (age >= 18 && age <= 30)
{
    MessageBox.Show("Accepted");
}
```

**B. OR (||)**

At least one condition must be true.

Example:

```csharp
if (mark >= 90 || mark == 80)
{
    MessageBox.Show("Good Result");
}
```

**C. NOT (!)**

NOT changes true to false and false to true.

Example:

```csharp
bool isAbsent = false;

if (!isAbsent)
{
    MessageBox.Show("Student is present");
}
```

## 9. Boolean Variables and Flags

A Boolean variable stores only two values: true or false.

Example:

```csharp
bool isStudent = true;
```

A flag is a Boolean variable used to show whether something has happened or not.

Example:

```csharp
bool isFound = false;

if (isFound == false)
{
    MessageBox.Show("Not Found");
}
```

## 10. Comparing Strings

String comparison means checking whether two text values are the same or different.

Example:

```csharp
string name1 = "Ahmed";
string name2 = "Ahmed";

if (name1 == name2)
{
    MessageBox.Show("Names are equal");
}
else
{
    MessageBox.Show("Names are different");
}
```

Remember that normal string equality is case-sensitive. For example, "Ahmed" and "ahmed" are different.

## 11. TryParse

TryParse is used to convert user input into a number safely.

It helps prevent errors when someone enters letters instead of numbers.

Example:

```csharp
int age;

if (int.TryParse(textBox1.Text, out age))
{
    MessageBox.Show(age.ToString());
}
else
{
    MessageBox.Show("Invalid Input");
}
```

If the input is a valid number, it returns true. Otherwise, it returns false.

## 12. Input Validation

Input validation means checking information entered by the user before using it.

For example, a student's mark should be between 0 and 100.

Example:

```csharp
int mark;

if (int.TryParse(textBox1.Text, out mark))
{
    if (mark >= 0 && mark <= 100)
    {
        MessageBox.Show("Valid Mark");
    }
    else
    {
        MessageBox.Show("Invalid Mark");
    }
}
else
{
    MessageBox.Show("Enter a Number");
}
```

## 13. RadioButton and CheckBox

These are controls used in Windows Forms to select options.

**A. RadioButton**

RadioButton allows the user to select only one option within a group.

Example:

```csharp
if (radioButton1.Checked)
{
    MessageBox.Show("Male");
}
else if (radioButton2.Checked)
{
    MessageBox.Show("Female");
}
```

**B. CheckBox**

CheckBox allows the user to select more than one option.

Example:

```csharp
if (checkBox1.Checked)
{
    MessageBox.Show("Java Selected");
}

if (checkBox2.Checked)
{
    MessageBox.Show("C# Selected");
}
```

**C. CheckedChanged Event**

This event happens whenever the checked state of a RadioButton or CheckBox changes.

## 14. Switch Statement

Switch is used when a program has several choices based on one value.

Example:

```csharp
int day = 2;

switch (day)
{
    case 1:
        MessageBox.Show("Monday");
        break;

    case 2:
        MessageBox.Show("Tuesday");
        break;

    case 3:
        MessageBox.Show("Wednesday");
        break;

    default:
        MessageBox.Show("Invalid Day");
        break;
}
```

Important keywords:

* `switch`: Starts the selection.
* `case`: Represents a possible value.
* `break`: Stops the current case.
* `default`: Runs when no case matches.

## 15. ListBox Control

ListBox is a Windows Forms control used to display a list of items. The user can select items from the list.

### Important Properties

| Property      | Meaning                                 |
| ------------- | --------------------------------------- |
| Items         | Contains all list items.                |
| Items.Count   | Counts the items in the list.           |
| SelectedItem  | Gets the selected item.                 |
| SelectedIndex | Gets the position of the selected item. |

**Note:** SelectedIndex returns -1 when no item is selected.

### Important Methods

**Add() –** Adds a new item.

```csharp
listBox1.Items.Add("Ahmed");
```

**Remove() –** Removes a specific item.

```csharp
listBox1.Items.Remove("Ahmed");
```

**RemoveAt() –** Removes an item using its index.

```csharp
listBox1.Items.RemoveAt(0);
```

**Clear() –** Removes all items.

```csharp
listBox1.Items.Clear();
```

---

# IMPORTANT DIFFERENCES

### 1. If-Else vs If-Else-If

| If-Else               | If-Else-If                 |
| --------------------- | -------------------------- |
| Has two choices.      | Has multiple choices.      |
| Checks one condition. | Checks several conditions. |

### 2. RadioButton vs CheckBox

| RadioButton                    | CheckBox                      |
| ------------------------------ | ----------------------------- |
| Selects one option in a group. | Selects multiple options.     |
| Used for one choice.           | Used for independent choices. |

### 3. AND vs OR

| AND (&&) | OR (||) |
|---|---|
| Both conditions must be true. | One or both conditions can be true. |

### 4. SelectedItem vs SelectedIndex

| SelectedItem                | SelectedIndex                              |
| --------------------------- | ------------------------------------------ |
| Returns the selected value. | Returns the position of the selected item. |
| Gives the actual item.      | Gives its index number.                    |

---

# CHAPTER 3 – FINAL SUMMARY

In this chapter, we learned how to make decisions in C# using different statements.

We studied:

1. Control Structures.
2. Sequence and Decision Structures.
3. Relational Operators.
4. If and If-Else Statements.
5. Nested If.
6. If-Else-If.
7. Logical Operators.
8. Boolean Variables and Flags.
9. String Comparison.
10. TryParse.
11. Input Validation.
12. RadioButtons and CheckBoxes.
13. CheckedChanged Event.
14. Switch Statement.
15. ListBox Control.

**Conclusion:**

Making decisions is important in programming because it helps a program choose the correct action based on different conditions. These concepts are commonly used when developing C# Windows Forms applications.
