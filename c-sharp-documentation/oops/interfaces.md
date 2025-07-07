# Interfaces

An interface defines a contract. Any `class` that implements that contract must provide an implementation of the members defined in the `interface`.

It is like `abstract` class because all the methods which are declared inside the `interface` are `abstract` methods. It cannot have method body and cannot be instantiated.

It is used to achieve *multiple inheritance* which can't be achieved by class. It is used to achieve *fully abstraction* because it cannot have method body.

<br>

> Naming convention of interface is to prefix the name with I, example Person -> IPerson or Printer -> IPrinter

<br>

In the following example, class `ImplementationClass` must implement a method named `SampleMethod` that has no parameters and returns `void`.

```C#
interface ISampleInterface
{
    void SampleMethod();
}

class ImplementationClass : ISampleInterface
{
    // Explicit interface member implementation:
    void ISampleInterface.SampleMethod()
    {
        // Method implementation.
    }

    static void Main()
    {
        // Declare an interface instance.
        ISampleInterface obj = new ImplementationClass();

        // Call the member.
        obj.SampleMethod();
    }
}
```

A class can also implement more than one interfaces, example

```C#
interface IFlyable {
    void Fly();
}

interface ISwimmable {
    void Swim();
}

interface IClimbable {
    void Climb();
}

class Swan : IFlyable, ISwimmable {
    void Fly () {
        // implementation of flying
    }

    void Swim () {
        // implementation of Swimming
    }
}

class ButterFly : IFlyable {
    void Fly () {
        // implementation of flying
    }
}

class Jaguar : IClimbable, ISwimmable {
    void Climb () {
        // implementation of climbing
    }

    void Swim () {
        // implementation of Swimming
    } 
}

static void Main()
{
    IFlyable[] flyables = new { new Swan(), new ButterFly() };
    foreach(IFlyable i in flyables) {
        i.Fly();
    }
}

```

## :white_check_mark: Tasks
:white_check_mark: Write a program to define two interfaces with the example: `IAudio`, `IVideo`, where `IAudio` has method `PlayAudio` and `IVideo` has method `PlayVideo`. Create classes that implements the interfaces like `NewsMedia : IAudio, IVideo` or `Audible : IAudio` or `GIFVideo` : `IVideo` or any combinations.

### *End of session 10*

<br>

### *Session 11*

# Collectons in C#

C# collection types are designed to store, manage and manipulate collection of similar data more efficiently. Data manipulation includes adding, removing, finding, and inserting data in the collection. Collection types implement the following common functionality: 

* Adding and inserting items to a collection
* Removing items from a collection
* Finding, sorting, searching items
* Replacing items
* Copy and clone collections and items
* Capacity and Count properties to find the capacity of the collection and number of items in the collection

One of the most commonly used collection in C# is `List`.

## List
List is a collection which allows us to add items dynamically and the capacity of the collection grows as it is added. Unlike arrays where their size must be known in prior, the List can be declared and added items later as needed. The type of this collection can be passed within the symbol `< >`.

<br>

> You must import the namespace to use List in the program, `using System.Collections.Generic;`

<br>

Example:
```C#
List<int> myList = new List<int>(); // this list is defined to contain only values of type integers.
myList.Add(100);
myList.Add(200);
myList.Add(300);
myList.Add(400);

myList.Add("A String!?"); // Gives an error for this.
```

#### Looping through the collection

We can iterate through collection using index based for loop or we can use `foreach`.

Example:

```C#
for (var index = 0; index < myList.Count; index++) // using Count
{
    Console.Write(myList[index] + " "); // access using index (like array)
}

OR

foreach (var value in myList)
{
    Console.Write(value + " ");
}
```

We can use the `List` to contain collection of classes as well, example:

```C#
List<Shape> allShapes = new List<Shape>();
allShapes.Add(new Shape());
allShapes.Add(new Rectangle()); // assume Rectangle is derived from Shape class
allShapes.Add(new Triangle()); // assume Triangle is derived from Shape class
```

We can perform the same `foreach` loop for the above `allShapes` List too.

## Dictionary

Dictionary is also a Generic List which is used commonly in many cases. As the name implies it is used to store collection of dictionary values with the combination of `key` and `value`. A `key` must be unique and we can use the key to quick find the value easily.

Example:
```C#
Dictionary<int, string> dct = new Dictionary<string, Shape>();
dct.Add("circle", new Circle());
dct.Add("square", new Square());
dct.Add("rectangle", new Rectangle());
dct.Add("triangle", new Triangle());

foreach (KeyValuePair<int, string> kvp in dct)
{
    Response.Write(kvp.Key + " " + kvp.Value); // .Key will get the key, .Value will retrieve the value
}

Triangle myTriangle = dct["triangle"];
```

## :white_check_mark: Tasks
:white_check_mark: Create a class called `User` with properties like `FirstName`, `LastName`, `Address`, `Email`, `Password` and `LastLoggedIn - type DateTime`. 

:white_check_mark: Create a List of `User` class, do a `foreach` on the list and set the `LastLoggedIn` as current date (`DateTime.Now`).


### *End of session 11*

<br>

### [NEXT - LINQ](./linq.md)