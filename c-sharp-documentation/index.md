1. [Introduction to C#](#introduction)

2. [What is .NET ?](#what-is-net)

3. [Architecture of .NET Applications](#architecture-of-net-applications)

4. [Very First C# Application](#first-c-application)

5. [Fundamentals](./fundamentals/index.md)
   * [Identifiers](./fundamentals/index#identifiers)
   * [Variables and Constants](./fundamentals/index#variables)
   * [Data types](./fundamentals/datatypes)
   * [Operators](./fundamentals/operators)
   * [Loops](./fundamentals/loops)

6. [OOP's](./oops/index.md)
   * [Pillars of OOPS](./oops/index.md#four-pillars-of-oops)
   * [Encapsulation](./oops/index.md#1-encapsulation)
   * [Abstraction](./oops/index.md#2-abstraction)
   * [Inheritance](./oops/inheritance.md#3-inheritance)
   * [Polymorphism](./oops/inheritance.md#4-polymorphism)
   * [Class types](./oops/inheritance.md#Other-Class-types-in-C#)
   * [Interfaces](./oops/interfaces.md)
7. [Collections in C#](./oops/interfaces.md#collectons-in-c)
8. [LINQ](./oops/linq.md)
<br>
<br>

### *Session 1*
# Introduction

C# is a simple, modern, general-purpose, object-oriented **programming** language developed by Microsoft within its .NET initiative led by Anders Hejlsberg, it is pronounced as **“C sharp”**. 

C# can be used to create various types of applications, such as web, windows, console applications, or other types of applications using Visual studio.

C# programming is very much based on C and C++ programming languages, so if you have a basic understanding of C or C++ programming, then it will be fun to learn C#.

<br>

# What is .NET ?

.NET is a free, open-source **development platform** for building many kinds of application such as Web applications, Web API's, Microservices, Mobile applications, Dekstop applications, Game development, Internet of Things, Machine learning etc.

There is a variety of programming languages available on the .NET platform, `VB.NET` and `C#` being the most common ones.

.NET Framework supports more than **60** programming languages in which **11** programming languages are *designed and developed* by **Microsoft**. The remaining Non-Microsoft Languages are supported by .NET Framework but not designed and developed by Microsoft. 

The **11** Programming Languages which are designed and developed by Microsoft are: 

* C#.NET
* VB.NET
* C++.NET
* J#.NET
* F#.NET
* JSCRIPT.NET
* WINDOWS POWERSHELL
* IRON RUBY
* IRON PYTHON
* C OMEGA
* ASML(Abstract State Machine Language)

<br>

# First C# Application

Here, you will learn to create a simple console application in C# and understand the basic building blocks of a console application.

C# can be used in a window-based, web-based, or console application. To start with, we will create a console application to work with C#.

## Visual Studio - The IDE

![alt](images/visual-studio-2013-logo.png)

Visual studio is a developer friendly, feature-rich program that supports many aspects of software development. The Visual Studio IDE is a creative launching pad that you can use to edit, debug, and build code, and then publish an app.

Over and above the standard editor and debugger that most IDEs provide, Visual Studio includes compilers, code completion tools, graphical designers, and many more features to enhance the software development process.

You can download and install a free and latest community version of visual studio here: https://visualstudio.microsoft.com/vs/community/

### Create new project

Open Visual Studio installed on your local machine. Click on File -> New -> Project from the top menu, as shown below.

![alt](images/create-project-in-visualstudio.png)

From the New Project popup, shown below, select Visual C# in the left side panel and select the Console App in the right-side panel.

![alt](images/create-csharp-console-project.png)

In the name section, give any appropriate project name, a location where you want to create all the project files, and the name of the project solution.

Click OK to create the console project. Program.cs will be created as default a C# file in Visual Studio where you can write your C# code in Program class, as shown below. (The .cs is a file extension for C# file.)

![alt](images/csharp-program.png)

Every console application starts from the Main() method of the Program class. The following example displays "Hello World!!" on the console.

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillHouseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!!";

            Console.WriteLine(message);
        }
    }
}
```

Let's understand the above C# structure.

1. Every .NET application takes the reference of the necessary .NET framework namespaces that it is planning to use with the `using` keyword, e.g., `using System.Text`.
2. Declare the namespace for the current class using the `namespace` keyword, e.g., namespace `SkillHouseCSharp`
3. We then declared a class using the `class` keyword: `class Program`
4. The `Main()` is a method of Program class is the entry point of the console application.
5. `String` is a data type.
6. A `message` is a variable that holds the value of a specified data type.
7. "Hello World!!" is the value of the message variable.
8. The `Console.WriteLine()` is a static method, which is used to display a text on the console.

## Compile and Run C# Program
To see the output of the above C# program, we have to compile it and run it by pressing Ctrl + F5 or clicking the Run button or by clicking the "Debug" menu and clicking "Start Without Debugging".

## .NET Fiddle

![alt](images/dotnet-fiddle.jpg)

If you want to try C# editor online quickly without opening Visual Studio, you can try .NET Fiddle tool which provides an environment to directly write some C# code and execute them on your browser.

https://dotnetfiddle.net/

## :white_check_mark: Tasks
:white_check_mark: Create a new Console application in Visual Studio and language as C# and write a program to print `Hello Skillhouse!`.
:white_check_mark: Create a new Console application in Visual Studio and language as C# and perform following operations:
1.	Read the options such as Add, Subtract, Multiply and Divide from the user
Hint: `Console.ReadLine`
2.	Based on the operation selected ask for following input
3.	If Addition is selected, Enter the first and second number for addition
4.	If Subtraction is selected, Enter the number 1 and number 2 for subtraction
5.	If Multiplication is selected, Enter the number 1 and number 2 for multiplication
6.	If Division is selected, Enter the number 1 and number 2 for Division 
7.	Display the result

:white_check_mark: Create a new Console application in Visual Studio and language as C# and perform following tasks:
1.	Add a new class named `Employee.cs` to the project
2.	Add properties like Name, Age, Salary with respective data types. Hint: Name is of type `string`.
3.	Add properties like AddressStreet1, AddressStreet2 and City with respective data types
4.	Create an instance of the class named `Employee` in the `Main.cs`
5.	Assign values to the object (all the Employee properties)
6.	Display the Employee Name and Salary. Hint: `Console.WriteLine`

✅ Perform below Visual studio interactions:
1. Open Solution Explorer. Pin solution explorer, Unpin solution explorer
2. Open Output Window
3. Open Package Manager Console
4. Debug the application. Put a break point and hit the break point. 
5. Close the visual studio and open the solution again by File->Open Solution window


### *End of session 1*

<br>


### [NEXT - Fundamentals](./fundamentals/index.md)