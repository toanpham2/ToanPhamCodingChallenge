Coding Challenge – WinForms (.NET 10)
This project is a C# Windows Forms application built with .NET 10. It implements three small GUI based application as specified in the coding challenge document.

1.FizzBuzz
2.Fibonacci sequence
3. A combination of 1 and 2

All functionality is accessible through a graphical user interface without the need for console usage.

How to Run:
Prerequisites:
-Windows
-Visual Studio 2022 or newer
-.NET 10 SDK

steps:
1.Open the solution in Visual Studio
2.Build the solution
3.Press F5 or click Start
4.The WinForms application will launch

Application overview:
1.FizzBuzz tab:
- Inputs:
  - `n` (count)
  - `x` divisor
  - `y` divisor
  - Phrase for `x`
  - Phrase for `y`
  - Phrase for both
- Output:
  - Numbers from `1` to `n`
  - Replaced with phrases based on divisibility rules

2.Fibonacci Tab:
Generates a Fibonacci sequence based on the recurrence
- If a referenced prior term does not exist, the value defaults to `1`
- For `a = 2` and `b = 1`, this produces the classic Fibonacci sequence

3.Combination of 1 and 2
- Generates the Fibonacci-like sequence
- Applies FizzBuzz style substitution to each term
- Displays the combined result