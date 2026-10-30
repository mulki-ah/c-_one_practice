## Code Sections & Explanation

### 1. Simple Label Text Assignment (`helloword.png`)
```csharp
private void Fullnamelpl_Click(object sender, EventArgs e)
{
    // Display text inside the Label
    Fullnamelpl.Text = "Hello World";
}

Explanation: This is an event handler for a click event (Fullnamelpl_Click). When the user clicks on the label control named Fullnamelpl, it directly assigns and displays the string "Hello World" inside the label'


## Variable Declaration

 // creating varible //
string Firstname;
string Lastname;
string fullname;

Explanation: Declares three string variables (Firstname, Lastname, and fullname) which are used to store textual data like first name, last name, and the combined full name


##3. String Concatenation

// process - concatination first and last
fullname = Firstname + " " + Lastname;

Explanation: Combines (concatenates) the values stored in Firstname and Lastname with a space " " in between, and assigns the combined result to the fullname variable


## 4. Displaying Variable Content

// display//
Fullnamelpl.Text = fullname;

Explanation: Assigns the concatenated full name string (fullname) to the Text property of the label Fullnamelpl so that the user can see the full name on the User Interface.



