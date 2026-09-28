 ##  Textbox


 This code is C# Windows Forms, and it shows three ways to clear a TextBox. 
 The first line is a comment, which the compiler ignores. 
 The second line, txtdayofthewek.Text = "";, replaces the text with an empty string, so the TextBox becomes empty. 
 The third line, txtdayofthemonth.Text = String.Empty;, does the same thing, except String.Empty is a built-in constant equal to "".
  The fourth line, txtdayofthenumeric.Clear();, is a method that removes all the text directly, without assigning any value. All three have the same result: the TextBox ends up empty.
##  Concatenates
Student Info Formatter

Combines a student's name, ID, department, and semester into one comma-separated string.

Example:
fullinfo = name + ", " + studentid + ", " + department + ", " + semester;
Output: Ali, 123, IT, 2

## Var
This code gets date information entered by the user from different TextBox controls. It stores the day of the week, month name, numeric day, and year in separate variables using the `var` keyword. These variables can then be used to display or process the date information in the program.