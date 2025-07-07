# C# Fundamentals

### *Session 2*
## Identifiers

In programming languages, identifiers are used for identification purposes. Or in other words, identifiers are the user-defined name of the program components. In C#, an identifier can be a namespace, class name, method name, variable name or label. 

Example: 

```C#
public class MyClass1 {
    static public void Main () 
    {
          int x;
    }
}
```

Here the total number of identifiers present in the above example is 3 and the names of these identifiers are: 

`MyClass1`: Name of the class, 
`Main`: Method name, 
`x`: Variable name

**Rules for defining identifiers in C#:**
There are certain valid **rules** for defining a valid C# identifier. These rules should be followed, otherwise, we will get a *compile-time* error. 
 

* The only allowed characters for identifiers are all alphanumeric characters([A-Z], [a-z], [0-9]), ‘_‘ (underscore). For example “geek$” is not a valid C# identifier as it contain ‘$’ – special character.
* Identifiers should not start with digits([0-9]). For example “123geeks” is a not a valid in C# identifier.

* Identifiers should not contain white spaces.
 
* Identifiers are not allowed to use as keyword unless they include @ as a prefix. For example, @as is a valid identifier, but “as” is not because it is a keyword.
* C# identifiers allow Unicode Characters.
* C# identifiers are case-sensitive.
* C# identifiers cannot contain more than 512 characters.

Observe all identifiers used in the below program:

```C#
// Simple C# program to illustrate identifiers
using System;
namespace SkillHouse // a namespace identified with the given name 'SkillHouse'
{
    class CSharpLearning { // a class identified with the given name 'CSharpLearning'
    
        // Main Method
        static public void Main() // a method identified with the given name 'Main'
        {
    
            // variable
            int a = 10; // this variable will be identified with the name 'a' in the entire program
            int b = 39; // this variable will be identified with the name 'b' in the entire program
            int c; // this variable will be identified with the name 'c' in the entire program
    
            // simple addition
            c = a + b;
            Console.WriteLine("The sum of two number is: {0}", c);
        }
    }
}
```

## Variables

A variable contains a **data value** of the specific *data type*.

Variables are used to store information to be referenced and manipulated in a computer program. 

They also provide a way of labeling data with a descriptive name, so our programs can be understood more clearly by the reader and ourselves. 

It is helpful to think of variables as containers that hold information. Their sole purpose is to label and store data in memory. This data can then be used throughout your program.

Syntax:
```
type variable_name = value; 
or
type variable_names;
```

Example:
```c#
char var = 'h'; // Declaring and Initializing character variable
int a, b, c; // Declaring variables a, b and c of int type
```

Rules for naming variables

* Variable names can contain the letters ‘a-z’ or ’A-Z’ or digits 0-9 as well as the character ‘_’.
* The name of the variables cannot be started with a digit.
* The name of the variable cannot be any C# keyword say int, float, null, String, etc unless you use **@** symbol as the prefix.


Valid Variables Names
```C#
int age;

float _studentname;

object dimension3

char @char = 'A'; // keyword used but valid because prefixed with @
```

Invalid Variables Names
```C#
int if; // "if" is a keyword

object 3dObject; // Cannot start with digit
```

### Initialization

The term initializing means to assign some value to the variable. Basically, the actual use of variables comes under the initialization part. In C# each data type has some default value which is used when there is no explicitly set value for a given variable. Initialization can be done separately or may be with declaration.

Example :
```C#
int y = 7; // Declaring and initializing the variable at same time
int x; // Declaring variable x
x = 5; // initializing x with value 5, late initialization
```


Two Ways for Initialization:

**1 Compile time initialization**

It means to provide the value to the variable during the compilation of the program. If the programmer didn’t provide any value then the compiler will provide some default value to the variables in some cases. Generally, this type of initialization helpful when the programmer wants to provide some default value.

```C#
int x = 32;              
// printing the value
Console.WriteLine("Value of x is "+x);
```
**2 Run time initialization**

In this, the user has to enter the value and that value is copied to the required variable. In this type of initialization, there is one more possibility in which value is assigned to variable after completion of a function call.

```C#
int num = Convert.ToInt32(Console.ReadLine()); // reading from user input
  
// printing the result
Console.WriteLine("Value of num is " + num);

float result = calculateArea(100, 200); // result is now known after completion of calculateArea function call.
// printing the result
Console.WriteLine("Value of result is " + result);

```

## :white_check_mark: Tasks
✅ Create a console project and perform following operations
1.  Read the following sentence and declare necessary variables of respective types for underlined words.

“A car named <u>i20</u> made by the company named <u>Hyundai</u> runs at the maximum speed of <u>120</u> km/hr. It has got <u>4</u> wheels. Mileage given by the car is <u>12.5</u> kms/litre. System asks the user to input the <u>number of Kilometres</u> that user wants to drive and collects the information. Based on what user entered and current mileage, system calculates the <u>number of litres (Fuel)</u> required to make the journey”


# Constants or Literals

The fixed values are called as Literal. Literal is a value that is used by the variables. Values can be either an integer, float or string, etc. 

The constants are treated just like regular variables except that their values cannot be modified after their definition.

Literals can be of the following types: 

* Integer Literals
* Floating-point Literals
* Character Literals
* String Literals
* Null Literals
* Boolean Literals

**Integer Literals**: A literal of integer type is know as the integer literal. It can be octal, decimal, binary, or hexadecimal constant. No prefix is required for the decimal numbers. A suffix can also be used with the integer literals like U or u are used for unsigned numbers while l or L are used for long numbers.

  * Decimal literals (Base 10): In this form, the allowed digits are 0-9.
  `int x = 101;`

  * Octal literals (Base 8): In this form, the allowed digits are 0-7.

    ```C#
    // The octal number should be prefix with 0.
    int x = 0146;
    ```
  * Hexa-decimal literals (Base 16): In this form, the allowed digits are `0-9` and characters are `a-f`. We can use both uppercase and lowercase characters.

    ```C#
    // The hexa-decimal number should be prefix
    // with 0X or 0x.
    int x = 0X123Face; 
    ```

  * Binary literals (Base 2): In this form, the allowed digits are only 1’s and 0’s.

    ```C#
    // The binary number should be prefix with 0b.
    int x = 0b101
    ```
  Examples:

    ```C#
    07778    // invalid: 8 is not an octal digit 
    045uu    // invalid: suffix (u) is repeated
    0b105    // invalid: 5 is not a binary digit
    0b101    // valid binary literal
    456      // valid decimal literal
    02453    // valid octal literal 
    0x65d    // valid hexadecimal literal 
    12356    // valid int literal 
    304U     // valid unsigned int literal 
    3078L    // valid long literal 
    965UL    // valid unsigned long literal 
    ```

**Floating-point Literals:** The literal which has an integer part, a decimal point, a fractional part, and an exponent part is known as the floating-point literal. These can be represented either in decimal form or exponential form.

Here are some examples of floating-point literals:

```C#
float 3.14159  
double 314159E-5F
double 784f
```

**Character Literals:** For character data types we can specify literals in 3 ways: 

  * Single quote: We can specify literal to char data type as single character within single quote.

    `char ch = 'a';`

  * Unicode Representation: We can specify char literals in Unicode representation ‘`\uxxxx`’. Here xxxx represents 4 hexadecimal numbers.

    `char ch = '\u0061';// Here /u0061 represent a.`

  * Escape Sequence: Every escape character can be specified as char literals.

    `char ch = '\n';`

    List of escape sequence can be used in C#

    <table>
    <thead>
    <tr>
    <th>Escape sequence</th> <th>Meaning</th>
    </tr>
    </thead>
    <tbody>
    <tr>
    <td>\\</td>
    <td>\ character</td>
    </tr>
    <tr>
    <td>\’</td>
    <td>’ character</td>
    </tr>
    <tr>
    <td>\?</td>
    <td>? character</td>
    </tr>
    <tr>
    <td>\”</td>
    <td>” character</td>
    </tr>
    <tr>
    <td>\b</td>
    <td>b character</td>
    </tr>
    <tr>
    <td>\a</td>
    <td>a character</td>
    </tr>
    <tr>
    <td>\n</td>
    <td>n character</td>
    </tr>
    <tr>
    <td>\f</td>
    <td>f character</td>
    </tr>
    <tr>
    <td>\r</td>
    <td>r character</td>
    </tr>
    <tr>
    <td>\v</td>
    <td>v character</td>
    </tr>
    </tbody>
    </table>

**String Literals:** Literals which are enclosed in double **quotes(“”)** or starts with **@””** are known as the String literals. 

Example:

```C#
String s1 = "Hello Geeks!";

String s2 = @"Hello Geeks!";
```

**Boolean Literals:** Only two values are allowed for Boolean literals i.e. `true` and `false`.

Example :

```C#
bool b = true;
bool c = false;
```

### *End of session 2*

<br>

### [NEXT - Data types](datatypes.md)