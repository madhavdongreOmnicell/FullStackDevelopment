### *Session 3*
# Data types

C# is a **strongly-typed** language. It means we must declare the type of a variable that indicates the kind of values it is going to store, such as integer, float, decimal, text, etc.

The following declares and initialized variables of different data types.

```c#
string stringVar = "Hello World!!";
int intVar = 100;
float floatVar = 10.2f;
char charVar = 'A';
bool boolVar = true;
```

C# mainly categorized data types in two types: **Value types** and **Reference types**. 

**Value types:** Include simple types (such as int, float, bool, and char), enum types, struct types, and Nullable value types. 

**Reference types:** Include class types, interface types, delegate types, and array types.

![alt](/images/fundamentals/datatypes.png)

## Value Data types:

Value Data Type stores the value directly in the variable, they are simple types where the values can be a piece of information not too complex. 

For example, consider integer variable `int i = 100;`

The system stores 100 in the memory space allocated for the variable `i`. The following image illustrates how 100 is stored at some hypothetical location in the memory (0x239110) for '`i`':

![alt](/images/fundamentals/value-type-memory-allocation.png)

It will also accept both signed and unsigned literals. The derived class for these data types are `System.ValueType`. Following are different Value Data Types in C# programming language :

  * **Signed & Unsigned Integral Types** : There are 8 integral types which provide support for 8-bit, 16-bit, 32-bit, and 64-bit values in signed or unsigned form.

  <table>
  <thead>
  <tr><th>Keyword</th><th>Range</th><th>Size</th><th>.NET Type</th></tr>
  </thead>
  <tbody>
  <tr>
  <td>sbyte</td>
  <td>-128 to 127</td>
  <td>Signed 8-bit integer</td>
  <td>System.SByte</td>
  </tr>
   <tr>
  <td>byte</td>
  <td>0 to 255</td>
  <td>Unsigned 8-bit integer</td>
  <td>System.Byte</td>
  </tr>
  <tr>
  <td>short</td>
  <td>-32,768 to 32,767</td>
  <td>Signed 16-bit integer</td>
  <td>System.Int16</td>
  </tr>
    <tr>
  <td>ushort</td>
  <td>0 to 65,535</td>
  <td>Unsigned 16-bit integer</td>
  <td>System.UInt16</td>
  </tr>
  <tr>
  <td>int</td>
  <td>-2,147,483,648 to 2,147,483,647</td>
  <td>Signed 32-bit integer</td>
  <td>System.Int32</td>
  </tr>
  <tr>
  <td>uint</td>
  <td>0 to 4,294,967,295</td>
  <td>Unsigned 32-bit integer</td>
  <td>System.UInt32</td>
  </tr>
  <tr>
  <td>long</td>
  <td>-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807</td>
  <td>Signed 64-bit integer</td>
  <td>System.Int64</td>
  </tr>
    <tr>
  <td>ulong</td>
  <td>0 to 18,446,744,073,709,551,615</td>
  <td>Unsigned 64-bit integer</td>
  <td>System.UInt64</td>
  </tr>
  </tbody>
  </table>

  * **Floating Point Types** : There are 3 floating point data types which contain the decimal point.

  <table>
  <thead>
  <tr><th>Keyword</th><th>Range</th><th>Precision</th><th>Size</th><th>.NET Type</th></tr>
  </thead>
  <tbody>
  <tr>
  <td>float</td>
  <td>±1.5 x 10<sup>−45</sup> to ±3.4 x 10<sup>38</sup></td>
  <td>~6-9 digits</td>
  <td>4 bytes</td>
  <td>System.Single</td>
  </tr>
   <tr>
   <td>double</td>
  <td>±5.0 × 10<sup>-324</sup> to ±1.7 × 10<sup>308</sup></td>
  <td>~15-17 digits</td>
  <td>8 bytes</td>
  <td>System.Double</td>
  </tr>
  <tr>
   <td>decimal</td>
  <td>±1.0 x 10<sup>-28</sup> to ±7.9228 x 10<sup>28</sup></td>
  <td>28-29 digits</td>
  <td>16 bytes</td>
  <td>System.Decimal</td>
  </tr>
  </tbody>
  </table>
  
 * **Character Types** : The character types represents a UTF-16 code unit or represents the 16-bit Unicode character.

 <table>
  <thead>
  <tr><th>Keyword</th><th>Range</th><th>Size</th><th>.NET Type</th></tr>
  </thead>
  <tbody>
  <tr>
  <td>char</td>
  <td>U+0000 to U+FFFF</td>
  <td>16 bit</td>
  <td>System.Char</td>
  </tr>
  </tbody>
  </table>

  The default value of the char type is \0, that is, U+0000.

  * **Boolean Types** : The boolean types represent either `true` or `false` value.

    The default value of the bool type is `false`.
    
  * **Nullable Value Types** : A nullable value type `T?` represents all values of its underlying value type `T` and an additional null value. For example, you can assign any of the following three values to a `bool?` variable: `true`, `false`, or `null`. An underlying value type `T` cannot be a nullable value type itself.

  Example for all Value types:

  ```C#
  // C# program to demonstrate the Sbyte
  // signed integral data type
  using System;
  namespace ValueTypeTest {

    class Test {
      
        // Main function
        static void Main()
        {
            // declaring character
          char a = 'G';
    
          // Integer data type is generally
          // used for numeric values
          int i = 89;
    
          short s = 56;
    
          // long uses Integer values which 
          // may signed or unsigned
          long l = 4564;
    
          // UInt data type is generally
          // used for unsigned integer values
          uint ui = 95;
    
          ushort us = 76;
    
          // ulong data type is generally
          // used for unsigned integer values
          ulong ul = 3624573;
    
          // by default fraction value
          // is double in C#
          double d = 8.358674532;
    
          // for float use 'f' as suffix
          float f = 3.7330645f;
    
          // for float use 'm' as suffix
          decimal dec = 389.5m;

          char? ch;

          decimal? number = ch == null ? 233.456 : null;
    
          Console.WriteLine("char: " + a);
          Console.WriteLine("integer: " + i);
          Console.WriteLine("short: " + s);
          Console.WriteLine("long: " + l);
          Console.WriteLine("float: " + f);
          Console.WriteLine("double: " + d);
          Console.WriteLine("decimal: " + dec);
          Console.WriteLine("Unsinged integer: " + ui);
          Console.WriteLine("Unsinged short: " + us);
          Console.WriteLine("Unsinged long: " + ul);
          Console.WriteLine("Nullable char: " + ch);
          Console.WriteLine("Nullable decimal: " + number);
        }
    }
  }
  ```


## Reference data types:

Variables of reference types store references to their data (objects).  It stores the address where the value is being stored. In other words, a reference type contains a pointer to another memory location that holds the actual data.

For example, consider the following string variable:

`string s = "Hello World!!";`

The following image shows how the system allocates the memory for the above string variable.

![alt](/images/fundamentals/raference-type-memory-allocation.png)

As you can see in the above image, the system selects a random location in memory (0x803200) for the variable s. The value of a variable s is 0x600000, which is the memory address of the actual data value. Thus, reference type stores the address of the location where the actual value is stored instead of the value itself.

The followings are the built in reference types:

### The Object Type 

The `object` type is an alias for `System.Object` in .NET. In the unified type system of C#, all types, predefined and user-defined, reference types and value types, inherit directly or indirectly from `System.Object`. You can assign values of any type to variables of type object. Any `object` variable can be assigned to its default value using the literal `null`. When a variable of a value type is converted to `object`, it is said to be *boxed*. When a variable of type object is converted to a value type, it is said to be *unboxed*.

Example:

```C#
object totalCountObj = 200; // is boxing, converting the numeric value to an object type
object objHasFailed = true; // is also boxing, converting a boolean value to an object type

int totalCount = (int)(totalCountObj); // is unboxing, converting totalCountObj back to the actual type (int)

bool hasFailed = (bool)(objHasFailed); // is also unboxing, converting objHasFailed back to the actual type (bool)

```

> When the common language runtime (CLR) boxes a value type, it wraps the value inside a System.Object instance and stores it on the managed heap. Unboxing extracts the value type from the object. Boxing is implicit; unboxing is explicit.

<br>

Another simple example when you can use `object`:

```C#
object fruit;
Console.WriteLine("What fruit juice do you want to have? Enter your choice, 1. Apple, 2. Mango, 3. Orange, 4. Pineapple");

var choice = Convert.ToInt32(Console.ReadLine());

switch(choice)
{
    case 1: fruit = new Apple(); 
    break;

    case 2: fruit = new Mango(); 
    break;

    case 3: fruit = new Orange(); 
    break;

    case 4: fruit = new Pineapple(); 
    break;

    default: fruit = new Apple(); 
    break;
}

Console.WriteLine("Your choice is " + fruit.GetType().FullName);


class Apple
{
}
class Mango
{
}

class Orange
{
}

class Pineapple
{
}
```



### The String type

The string type represents a sequence of zero or more Unicode characters. string is an alias for `System.String` in .NET.

```C#
string a = "hello";
string b = "world";
// Append to contents of 'a' and 'b'
string result = a + b; // operator + concatenates the strings.
Console.WriteLine(result);
```

Verbatim string literals start with `@` and are also enclosed in double quotation marks. For example:

```C#
@"good morning"  // a string literal
```

The advantage of verbatim strings is that escape sequences are not processed, which makes it easy to write, for example, a fully qualified Windows file name:

```C#
@"c:\Docs\Source\a.txt"  // rather than "c:\\Docs\\Source\\a.txt"
```

To include a double quotation mark in an @-quoted string, double it:

```C#
@"""Ahoy!"" cried the captain." // "Ahoy!" cried the captain.
```

### The delegate type

The declaration of a delegate type is similar to a method signature. It has a return value and any number of parameters of any type:

```C#
public delegate void MessageDelegate(string message);
public delegate int AnotherDelegate(MyType m, long num);
```

A `delegate` is a reference type that can be used to encapsulate a named or an anonymous method. Delegates are similar to function pointers in C++; however, delegates are type-safe and secure.

Delegates are used to pass methods as arguments to other methods (callbacks), also as an *Event handlers* to be executed when a specific event occurs during user interaction. For example, if you click on a Button in an application, the program would call a specific method or chain of methods as designed. The program uses delegates to reference all the methods to be invoked when an event occurs.

Example using a callback:

```C#
public class Program
{
    public delegate void StartMeetingDelegate(string meetingName, DateTime startTime); // declare different delegates with method signatures
    public delegate void JoinMeetingDelegate(string username, string meetingName);
    public delegate void EndMeetingDelegate(string meetingName, List<string> members);
    class Meeting
    {
        string meetingName;
        List<string> members;
        public Meeting(string meetingId)
        {
            this.meetingName = meetingId;
            this.members = new List<string>();
        }

        public void StartMeeting(StartMeetingDelegate onStart)
        {
            // start meeting ...
            Console.WriteLine("Meeting started...");

            // Invoking the callback
            onStart(meetingName, DateTime.Now);
        }

        public void JoinMeeting(string userName, JoinMeetingDelegate onMemberJoin)
        {
            // join member to the meeting ...
            Console.WriteLine("Adding {0} to the meeting", userName);
            this.members.Add(userName);

            // invoking the callback
            onMemberJoin(userName, meetingName);
        }

        public void EndMeeting(EndMeetingDelegate onEnd)
        {
            // End meeting...
            Console.WriteLine("Ending the meeting {0}...", meetingName);

            // invoking the callback
            OnMeetingEnd(meetingName, members);
        }
    }

    public static void Main()
    {
        StartMeetingDelegate onMeetingStart = OnMeetingStart; // define each delegates with the actual method
        JoinMeetingDelegate onJoinMeeting = OnMemberJoinMeeting;
        EndMeetingDelegate onMeetingEnd = OnMeetingEnd;

        var meeting1 = new Meeting("NSS Special Camping Programme - Discussion"); // create an instance of meeting
        meeting1.StartMeeting(onMeetingStart); // provide callbacks to each actions.
        meeting1.JoinMeeting("Dani Stuart", onJoinMeeting);
        meeting1.JoinMeeting("Marek Friedman", onJoinMeeting);
        meeting1.JoinMeeting("Carwyn Vo", onJoinMeeting);
        meeting1.JoinMeeting("Adelina Bate", onJoinMeeting);

        var meeting2 = new Meeting("Marathon Event Planning - Discussion");
        meeting2.StartMeeting(onMeetingStart);
        meeting2.JoinMeeting("Fenella Sheldon", onJoinMeeting);
        meeting2.JoinMeeting("Jerry Barajas", onJoinMeeting);
        meeting2.JoinMeeting("Rudi Lees", onJoinMeeting);
        meeting2.JoinMeeting("Sian Mckee", onJoinMeeting);

        meeting1.EndMeeting(onMeetingEnd);
        meeting2.EndMeeting(onMeetingEnd);

        Console.ReadLine();
    }

    // actual methods to be invoked as callbacks
    public static void OnMeetingStart(string meetingName, DateTime meetingStartTime)
    {
        Console.WriteLine("Meeting {0} started at {1}", meetingName, meetingStartTime);
    }

    public static void OnMemberJoinMeeting(string userName, string meetingName)
    {
        Console.WriteLine("Member {0} has joined the meeting {1}", userName, meetingName);
    }

    public static void OnMeetingEnd(string meetingName, List<string> members)
    {
        Console.WriteLine("Meeting {0} has ended and the participants were: {1}", meetingName, string.Join(", ", members));
    }
}
```

### The dynamic type

The `dynamic` type indicates that use of the variable and references to its members bypass compile-time type checking. Instead, these operations are resolved at run time.

Type `dynamic` behaves like type `object` in most circumstances. In particular, any non-null expression can be converted to the `dynamic` type. The `dynamic` type differs from `object` in that operations that contain expressions of type `dynamic` are not resolved or type checked by the compiler. The compiler packages together information about the operation, and that information is later used to evaluate the operation at run time. As part of the process, variables of type `dynamic` are compiled into variables of type `object`. Therefore, type `dynamic` exists only at compile time, not at run time.

The following example uses `dynamic` in several declarations. The `Main` method also contrasts compile-time type checking with run-time type checking.

```C#
using System;

namespace DynamicExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass ec = new ExampleClass();
            Console.WriteLine(ec.exampleMethod(10));
            Console.WriteLine(ec.exampleMethod("value"));

            // The following line causes a compiler error because exampleMethod
            // takes only one argument.
            //Console.WriteLine(ec.exampleMethod(10, 4));

            dynamic dynamic_ec = new ExampleClass();
            Console.WriteLine(dynamic_ec.exampleMethod(10));



            // Because dynamic_ec is dynamic, the following call to exampleMethod with two arguments does not produce an error at compile time. However, it does cause a run-time error.
            Console.WriteLine(dynamic_ec.exampleMethod(10, 4));
        }
    }

    class ExampleClass
    {
        static dynamic field;
        dynamic prop { get; set; }

        public dynamic exampleMethod(dynamic d)
        {
            dynamic local = "Local variable";
            int two = 2;

            if (d is int)
            {
                return local;
            }
            else
            {
                return two;
            }
        }
    }
}
// Results:
// Local variable
// 2
// Local variable
```
## :white_check_mark: Tasks

Take an example of a glass in the below image with its different attributes.

![alt](/images/glass.png)

:white_check_mark: Identify the suitable data types for all the attributes mentioned in the image and write a program with those variables and print them in the console.

:white_check_mark: Create a new class called `Glass` and move all the variables inside the class. 
Example:

```C#
public class Glass {
  string material = "Glass";
  string color = "Transparent";
  // so on...
}
```

:white_check_mark: Create three more classes like `Water`, `Milk` and `Curd` with a property called `quality`. And these classes can be used later to fill the glass.

```C#
public class Water {
  public string quality;
}

public class Milk {
  public string quality;
}

public class Curd {
  public string quality;
}
```

:white_check_mark: Add a new member called `content` in the `Glass` class, which can be **Anything** like Water, Milk or Curd etc, you must identify what can be the type of the member (a type which can represent anything).


:white_check_mark: Write a method called `Fill` in the `Glass` class, which can be called with the content to be filled, also a method called `Empty`. example:
```C#
public class Glass {
  string material = "Glass";
  string color = "Transparent";
  // so on...

  ??THE_TYPE?? content;
  
  public void Fill(??THE_TYPE?? content) {
    this.content = content;
  }

  public void Empty() {

  }

}
```

Now that we can use the class `Glass` and invoke `Fill` and `Empty` methods in it, example:

```C#
Glass glassOne = new Glass();
glassOne.Fill(new Milk());

Glass glassTwo = new Glass();
glassTwo.Fill(new Water());

glassOne.Empty();

Curd curd = new Curd();
curd.quality = "Average";
glassOne.Fill(curd);

```

:white_check_mark: Modify `Fill` and `Empty` methods by accepting a *callback* like `onFill` and `onEmpty` as parameter respectively and call the same inside both the methods. Both callbacks should receive the content of the Glass as a result and the `quality` of the content must be printed in the console. You will have to decide what is the suitable data type, example:

```C#
public class Glass {
  string material = "Glass";
  string color = "Transparent";
  // so on...

  ??THE_TYPE?? content;
  
  public void Fill(??THE_TYPE?? content, OnFillCallBack onFill) { // What should be the datatype of OnFillCallBack ?
    this.content = content;
    onFill(this.content);
  }

  public void Empty(OnEmptyCallBack onEmpty) { // What should be the datatype of OnEmptyCallBack ?
    onEmpty(this.content);
  }
}
```

Using the class `Glass`:
```C#
Glass glassOne = new Glass();
Curd curd = new Curd();
curd.quality = "Average";
glassOne.Fill(curd, onGlassFilled); // fill curd to glass with the callback

glassOne.Empty(); // empty the glass
Milk milk = new Milk();
milk.quality = "Good";
glassOne.Fill(milk, onGlassFilled); // fill milk to the glass with the callback.

public void onGlassFilled(??THE_TYPE?? content) { // Identify what can be the datatype of content here ?
  Console.WriteLine("Quality of the content is: ", content.quality);
}

```

### *End of session 3*

<br>

### *Session 4*

# Implicitly typed variable

In C#, variables must be declared with the data type. These are called explicitly typed variables.

Example:
```C#
int i = 100;// explicitly typed variable
```

## The var keyword

C# `3.0` introduced `var` keyword to declare method level variables without specifying a data type explicitly.

```C#
var j = 100; // implicitly typed local variable
```

The compiler will infer the type of a variable from the expression on the right side of the = operator. Above, var will be compiled as int.

The following infers the type from an expression.

```C#
int i = 10;
var j = i + 1; // compiles as int
```

`var` can be used to declare any built-in data type or a user-defined type or an anonymous type variable. The following example shows C# compiler infers type based on the value:

Practice Exercise:

```C#
static void Main(string[] args)
{
    var i = 10;
    Console.WriteLine("Type of i is {0}", i.GetType());

    var str = "Hello World!!";
    Console.WriteLine("Type of str is {0}", str.GetType());

    var dbl = 100.50d;
    Console.WriteLine("Type of dbl is {0}", dbl.GetType());

    var isValid = true;
    Console.WriteLine("Type of isValid is {0}", isValid.GetType());

    var ano = new { name = "Steve" };
    Console.WriteLine("Type of ano is {0}", ano.GetType());

    var arr = new[] { 1, 10, 20, 30 };
    Console.WriteLine("Type of arr is {0}", arr.GetType());

    var file = new FileInfo("MyFile");
    Console.WriteLine("Type of file is {0}", file.GetType());

}
```

Implicitly-typed variables must be initialized at the time of declaration; otherwise C# compiler would give an error: Implicitly-typed variables must be initialized.

```C#
var i; // Compile-time error: Implicitly-typed variables must be initialized
i = 100;
```

## :white_check_mark: Tasks
:white_check_mark: Create a new Console application in Visual Studio and language as C# and write a program to declare and initialize variables of different data types. Example: Declare variables with suitable datatypes to represent attributes of an Employee like `EmployeeId`, `FullName`, `Age`, `IsMarried`, `Salary`, `Address`, `PhoneNumber`.

:white_check_mark: Use Implicit type for any two variables declared above.

### [NEXT - Operators](operators.md)