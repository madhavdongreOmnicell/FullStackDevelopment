### *Session 6*
# Object Oriented Programming in C#

**Object Oriented Programming (OOP)** is a programming model where programs are organized around objects and data rather than action and logic.

OOP allows decomposition of a problem into a number of entities called objects and then builds data and functions around these objects. 

**A `class` is the core of any modern Object Oriented Programming language such as C#.**


A class is a blueprint of an object that contains variables for storing data and functions to perform operations on the data.

A class will not occupy any memory space and hence it is only a logical representation of data.

To create a class, you simply use the keyword "class" followed by the class name:

```C#
class Employee
{
    // memebers of the class like private variables, public properties or methods
}
```

The complete syntax to be followed to create a class in C#:

```C#
<access specifier> class  class_name {
   // member variables
   <access specifier> <data type> variable1;
   <access specifier> <data type> variable2;
   ...
   <access specifier> <data type> variableN;
   // member methods
   <access specifier> <return type> method1(parameter_list) {
      // method body
   }
   <access specifier> <return type> method2(parameter_list) {
      // method body
   }
   ...
   <access specifier> <return type> methodN(parameter_list) {
      // method body
   }
}
```

* Access specifiers (Explained below in Encapsulation) specify the access rules for the members as well as the class itself. If not mentioned, then the default access specifier for a class type is `internal`. Default access for the members is `private`.

* Data type specifies the type of variable, and return type specifies the data type of the data the method returns, if any.

* To access the class members, you use the dot (.) operator.

* The dot operator links the name of an object with the name of a member.

Another example of defining a class and creating their instances:

```C#
using System;

namespace BoxApplication {
   class Box {
      public double length;   // Length of a box
      public double breadth;  // Breadth of a box
      public double height;   // Height of a box
   }
   class Boxtester {
      static void Main(string[] args) {
         Box Box1 = new Box();   // Declare Box1 of type Box
         Box Box2 = new Box();   // Declare Box2 of type Box
         double volume = 0.0;    // Store the volume of a box here

         // box 1 specification
         Box1.height = 5.0;
         Box1.length = 6.0;
         Box1.breadth = 7.0;

         // box 2 specification
         Box2.height = 10.0;
         Box2.length = 12.0;
         Box2.breadth = 13.0;
           
         // volume of box 1
         volume = Box1.height * Box1.length * Box1.breadth;
         Console.WriteLine("Volume of Box1 : {0}",  volume);

         // volume of box 2
         volume = Box2.height * Box2.length * Box2.breadth;
         Console.WriteLine("Volume of Box2 : {0}", volume);
         Console.ReadKey();
      }
   }
}
```

**Constructors**: A class constructor is a special member function of a class that is executed whenever we create new objects of that class.

A constructor has exactly the same name as that of class and it does not have any return type. They are used to initialize any members of the class or to do any one time operation by default when the object is being created.

A **default constructor** does not have any parameter but if you need, a constructor can have parameters. Such constructors are called **parameterized constructors**. 

Example:
```C#
using System;

namespace LineApplication {
   class Line {
      private double length;   // Length of a line
      private double weightPixel; // Weight of the line
      
      public Line() { // default constructor
         Console.WriteLine("Object is being created");
      }

      public Line(double l, double w) { // parameterized constructor
          this.length = l;
          this.weightPixel = w;
          Console.WriteLine("Object is being created");
      }
      ...
      ...
      ...
   }
```

Different types of classes are explained in the corresponding concepts of OOPs.

### *End of session 6*

<br>

### *Session 7*

## Four Pillars of OOPs

1. Encapsulation
2. Abstraction
3. Inheritance
4. Polymorphism

## 1. Encapsulation: 

Wrapping up a data member and a method together into a single unit (in other words class) is called Encapsulation.

Encapsulation is like enclosing in a capsule. That is enclosing the related operations and data related to an object into that object, example think of a Bag in which you can keep your pen, book etc. It means this is the property of encapsulating members and functions.

```C#
class Bag {
    book;
    pen;
    ReadBook();
}
```

It is about hiding the internal details of an object, a technique used to protect the information in an object from another object with the help of *access specifier*.

An **access specifier** defines the scope and visibility of a class member. C# supports the following access specifiers −

* Public
* Private
* Protected
* Internal
* Protected internal

### Public Access Specifier
Public access specifier allows a class to expose its member variables and member functions to other functions and objects. Any public member can be accessed from outside the class.

The following example illustrates this −
```C#
using System;

namespace RectangleApplication {
   class Rectangle {
      //member variables
      public double length;
      public double width;
      
      public double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.length = 4.5;
         r.width = 3.5;
         r.Display();
         Console.ReadLine();
      }
   }
}
```

In the preceding example, the member variables length and width are declared `public`, so they can be accessed from the function `Main()` using an instance of the Rectangle class, named `r`.

The member function `Display()` and `GetArea()` can also access these variables directly without using any instance of the class.

The member functions `Display()` is also declared public, so it can also be accessed from `Main()` using an instance of the Rectangle class, named `r`.

### Private Access Specifier
Private access specifier allows a class to hide its member variables and member functions from other functions and objects. Only functions of the same class can access its private members. Even an instance of a class cannot access its private members.

The following example illustrates this −

```C#
using System;

namespace RectangleApplication {
   class Rectangle {
      //member variables
      private double length;
      private double width;
      
      public void Acceptdetails() {
         Console.WriteLine("Enter Length: ");
         length = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter Width: ");
         width = Convert.ToDouble(Console.ReadLine());
      }
      public double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.ReadLine();
      }
   }
}
```

In the preceding example, the member variables `length` and `width` are declared `private`, so they cannot be accessed from the function `Main()`. The member functions `AcceptDetails()` and `Display()` can access these variables. Since the member functions `AcceptDetails()` and `Display()` are declared public, they can be accessed from `Main()` using an instance of the Rectangle class, named `r`.

### Protected Access Specifier

Protected access specifier allows a child class to access the member variables and member functions of its base class. This way it helps in implementing **inheritance**.

### Internal Access Specifier

Internal access specifier allows a class to expose its member variables and member functions to other functions and objects in the current assembly. In other words, any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined.

### Protected Internal Access Specifier
The protected internal access specifier allows a class to hide its member variables and member functions from other class objects and functions, except a child class within the same application. This is also used while implementing inheritance.

Simple program that demonstrates Encapsulation

```C#
using System;

namespace Technology {
   class MobilePhone {
      //member variables
      private string processor;
      private string network;
      private float width;
      private float height;
      private string OSVersion;
      private string chipset;
      private string CPU;

      private string brand;

      constructor() {
          this.processor = "Adreno 730 Snapdragon",
          this.netWork = "GSM / CDMA / HSPA / EVDO / LTE / 5G"
          this.width = 2.91;
          this.height = 6.42;
          this.OSVersion = "Android 12.1, ColorOS 12.1";
          this.chipset = "Qualcomm SM8450 Snapdragon 8 Gen1 (4 nm)";
          this.CPU = "Octa-core (1x3.00 GHz Cortex-X2 & 3x2.50 GHz Cortex-A710 & 4x1.80 GHz Cortex-A510)";
          this.brand = "OnePlus 10 Pro";
      }

      private void StartDevice() {
          // starting the device
          Console.WriteLine("Starting the device");
      }
      
      public void TurnOn() {
        this.StartDevice();
        Console.WriteLine("Device Started");
      }
      public void OpenCamera() {
          Console.WriteLine("Starting the camera");
         // perform camera actions with the device
         Console.WriteLine("Camera started");
      }
      public void DisplaySMS() {
          // read SMS functionality
         Console.WriteLine("Displaying SMS");
      }

      public string GetBrandName () {
          return this.brand;
      }

      public string GetProcessorInfo () {
          return this.processor + " " + this.CPU;
      }

      public void TurnOff() {
          Console.WriteLine("Device Stopped");
      }
   }
   
   class ExecuteRectangle {
      static void Main(string[] args) {
         // Use the Phone
         MobilePhone myPhone = new MobilePhone();
         myPhone.TurnOn();
         myPhone.DisplaySMS();
         string brandName - myPhone.GetBrandName();
         Console.WriteLine(brandName);
         myPhone.TurnOff();
      }
   }
}
```

## :white_check_mark: Tasks
:white_check_mark: To demonstrate Encapsulation, create a new class called `HeadPhone` and define necessary properties and expose necessary methods/functions, decide what can be public or private members.

## 2. Abstraction

Abstraction is "To represent the essential feature without representing the background details.", it lets you focus on **what the object does instead of how it does it**. It is the process of hiding the working style of an object, and showing the information of an object in an understandable manner.

Consider a real-life scenario of withdrawing money from ATM. The user only knows that in ATM machine first enter ATM card, then enter the pin code of ATM card, and then enter the amount which he/she wants to withdraw and at last, he/she gets their money. The user does not know about the inner mechanism of the ATM or the implementation of withdrawing money etc. The user just simply knows how to operate the ATM machine, this is called abstraction.

In C# abstraction is achieved with the help of **Abstract classes**.

## Abstract classes

* An abstract class is declared with the help of `abstract` keyword.
* You are not allowed to create objects of the `abstract class`.
* Class that contains the abstract keyword with all of its methods is known as pure Abstract Base Class.

The `abstract` keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class.

There are situations in which we want to define a superclass that declares the structure of a given abstraction without providing a complete implementation of every method. That is, sometimes we want to create a superclass that only defines a generalized form that will be shared by all of its subclasses, leaving it to each subclass to fill in the details.

Explained with example in the *Inheritance* section.

### *End of session 7*

<br>

### [NEXT - Inheritance](./inheritance.md)