### *Session 8*
## 3. Inheritance

One of the most important concepts in object-oriented programming is inheritance. Inheritance allows us to define a class in terms of another class, which makes it easier to create and maintain an application. This also provides an opportunity to reuse the code functionality and speeds up implementation time.

When creating a class, instead of writing completely new data members and member functions, the programmer can designate that the new class should inherit the members of an existing class. This existing class is called the `base` class, and the new class is referred to as the `derived` class.

The idea of inheritance implements the `IS-A` relationship. For example, mammal IS A animal, dog `IS-A` mammal hence dog `IS-A` animal as well, and so on.

### Base and Derived Classes

The syntax used in C# for creating derived classes is as follows −
```C#
<acess-specifier> class <base_class> {
   ...
}

class <derived_class> : <base_class> {
   ...
}
```

Example:
```C#
using System;

namespace InheritanceApplication {
   class Shape {
      public void setWidth(int w) {
         width = w;
      }
      public void setHeight(int h) {
         height = h;
      }
      protected int width;
      protected int height;
   }

   // Derived class
   class Rectangle: Shape {
      public int getArea() { 
         return (width * height); 
      }
   }

   class RectangleTester {
      static void Main(string[] args) {
         Rectangle Rect = new Rectangle();

         Rect.setWidth(5);
         Rect.setHeight(7);

         // Print the area of the object.
         Console.WriteLine("Total area: {0}",  Rect.getArea());
      }
   }
}
```

<br>

> ### Multiple Inheritance in C#
> **C# does not support multiple inheritance.** However, you can use *interfaces* to implement multiple inheritance, explained in the upcoming concepts.

## :white_check_mark: Tasks
:white_check_mark: Write a program to create a base class called `MusicInstrument` with common members like `name`, `brand`, `model`, `price` and inherit the same into sub classes like 
* `Guitar` - with members like `bodyStyle`, `scaleLength`, `FretSize` 
* `Keyboard` - with members like `totalKeys`, `totalPresets`, `hasAuxSupport`
* `Drums` - with members like `material`, `totalDrums`, `bassDrumFrequency`, `snareDrumFrequency`
* Create few methods called `Assemble()` and `Play()` in each of the sub classes.

## Abstract class and Inheritance - explained:

An abstract class is a `class` which must contain at least one `abstract` method. An `abstract` method is a method which is declared using `abstract` keyword and has an empty body. Its definition is defined in the sub classes.

Since `abstract` class is not a complete implementation (since it will have few method declaration but no definition) it is not allowed to create an instance of abstract class.

Consider an example of `Employee` object, where in an organization there could be two types of Employees, `FullTimeEmployee` and `ContractEmployee` where the logic behind calculation of their monthly salary might vary on various policies defined within the organization.

Example:

`FullTimeEmployee.cs`
```C#
public int ID { get; set;}    
public string FirstName { get; set; }    
public string LastName { get; set; }
public string ProjectName { get; set; }   

public int AnnualSalary { get; set; }    
    
public string GetFullName()    
{    
    return this.FirstName + " " + this.LastName;    
}    

public int GetMonthlySalary()    
{    
    return this.AnnualSalary / 12;    
}    
```

`ContractEmployee.cs`
```C#
public int ID { get; set; }    
public string FirstName { get; set; }    
public string LastName { get; set; }
public string ProjectName { get; set; }

public int HourlyPay { get; set; }    
public int TotalHours { get; set; }    


public string GetFullName()    
{    
    return this.FirstName + " " + this.LastName;    
}    

public int GetMonthlySalary()    
{    
    return this.TotalHours * this.HourlyPay;    
}    
```

`Program.cs`
```C#
class Program    
{    
    static void Main(string[] args)    
    {    
        FullTimeEmployee fte = new FullTimeEmployee();    
        {    
            fte.ID = 101;    
            fte.FirstName="Brody";    
            fte.LastName = "Koch";    
            fte.AnnualSalary=60000;    

        };    
        Console.WriteLine(fte.GetFullName());    
        Console.WriteLine(fte.GetMonthlySalary());    
        Console.WriteLine("--------------");    



        ContractEmployee cte = new ContractEmployee();    
        {    
            cte.ID = 101;    
            cte.FirstName = "Dahlia";    
            cte.LastName = "Moreno";  

            cte.HourlyPay = 200;    
            cte.TotalHours = 40;    

        };    
        Console.WriteLine(cte.GetFullName());    
        Console.WriteLine(cte.GetMonthlySalary());    
            
    }    

}    
```

But the above implementation has to repeat most of the logc, lines of statements in both the classes. The only difference we see is that FullTimeEmployee has `AnnualSalary` and ContractEmployee has `HourlyPay` and `TotalHours` properties. 

Introducing a base class called `Employee` to have common logic and properties is the right solution here.

`Employee.cs`

```C#
public int ID { get; set; }    
public string FirstName { get; set; }    
public string LastName { get; set; }    
public string ProjectName { get; set; }

public string GetFullName()    
{    
    return this.FirstName + " " + this.LastName;    
}    

public virtual int GetMonthlySalary() // make the method as virtual so it can be overriden by the sub classes.
{    
    throw new NotImplementedException();
}   
```

`FullTimeEmployee.cs`

```C#
class FullTimeEmployee : Employee // inheritance    
{    
    public int AnnualSalary { get; set; }    
    public override int GetMonthlySalary() // overriding the base class method 
    {    
        return this.AnnualSalary/12;    
    }    
}   
```

`ContractEmployee.cs`

```C#
class ContractEmployee : Employee // inheritance    
{    
    public int HourlyPay { get; set; }    
    public int TotalHours { get; set; }    

    public override int GetMonthlySalary() // overriding the base class method 
    {    
        return this.TotalHours * this.HourlyPay;    
    }    
}
```

As you can see the common logic is moved to a base class called `Employee` class and inherited two sub classes `FullTimeEmployee` and `ContractEmployee`.

But the method `GetMonthlySalary` marked as `virtual` and let the sub class `override` the implementation. But this has two drawbacks, 1 with `virtual` it is required to implement something in the body of the method even the logic is not known, 2 It is possible to create an instance of `Employee` class but the implementation is incomplete.

> At this moment `Employee emp = new Employee();` is possible!

We can rewrite the `Employee` base class to not to have the `virtual` method and also make the class and method both as `abstract`.

`Employee.cs`

```C#
public abstract class BaseEmployeeClass   // make class abstract 
{    
    public int ID { get; set; }    
    public string FirstName { get; set; }    
    public string LastName { get; set; }    

    public string GetFullName()    
    {    
        return this.FirstName + " " + LastName;    
    }    

    public abstract int GetMonthlySalary(); // abstract and no method logic
            
}  
```

`FullTimeEmployee.cs`

```C#
class FullTimeEmployee : Employee // inheritance    
{    
    public int AnnualSalary { get; set; }    
    public override int GetMonthlySalary() // overriding the base class method 
    {    
        return this.AnnualSalary/12;    
    }    
}   
```

`ContractEmployee.cs`

```C#
class ContractEmployee : Employee // inheritance    
{    
    public int HourlyPay { get; set; }    
    public int TotalHours { get; set; }    

    public override int GetMonthlySalary() // overriding the base class method 
    {    
        return this.TotalHours * this.HourlyPay;    
    }    
}
```

`Program.cs`
```C#
class Program    
{    
    static void Main(string[] args)    
    {    
        Employee fte = new FullTimeEmployee();  // Base type Employee can be used  
        {    
            fte.ID = 101;    
            fte.FirstName="Brody";    
            fte.LastName = "Koch";    
            fte.AnnualSalary=60000;    

        };    
        Console.WriteLine(fte.GetFullName());    
        Console.WriteLine(fte.GetMonthlySalary());    
        Console.WriteLine("--------------");    



        Employee cte = new ContractEmployee();  // Base type Employee can be used   
        {    
            cte.ID = 101;    
            cte.FirstName = "Dahlia";    
            cte.LastName = "Moreno";  

            cte.HourlyPay = 200;    
            cte.TotalHours = 40;    

        };    
        Console.WriteLine(cte.GetFullName());    
        Console.WriteLine(cte.GetMonthlySalary()); 

        Employee emp = new Employee(); // Error: Cannot create instance of Abstract class.   
            
    }    

}   
```

As you can see when the child classes inherits any abstract class it enforces the child classes to implement all abstract members of base class. 

In the above example `public override int GetMonthlySalary()` is done in both the child classes otherwise it would give a compile time error.

Also in the `Program.cs` you can see the base type of both the instances of child class is represented as `Employee` class. Also at the end of the same file creating an instance of `Employee` class is not possible as mentioned in the comment.

## :white_check_mark: Tasks
:white_check_mark: Create a new program to demonstrate `abstraction` and `inheritance`. The program is to create different animals like `Dog`, `Cat` and `Cow` having common properties like `name` - to identify what animal it is, `height`, `weight` and `color`. They should also have some actions like `sleep()`, `walk()`, `sound()` and `stand()`. You can decide which action can have very *common implementation* and do the necessary changes in the program. Also ensure that you provide some Animal specific properties like for `Cow` you can have a property called `milkPerDay` and for `Dog` it can be `barkType`.

### *End of session 8*

<br>

### *Session 9*

## 4. Polymorphism

Method overloading, constructor overloading and operator overloading are considered compile-time (also called static or ad-hoc) polymorphism, or early binding. Method overriding, which involves inheritance and virtual functions, is called runtime (also called dynamic, inclusion, or subtyping) polymorphism, or late binding. 

In the case of compile-time polymorphism, identification of the overloaded method to be executed is carried out at compile time. However, in runtime polymorphism, the type of the object from which the overridden method will be called is identified at run time.

* At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and collections or arrays. When this polymorphism occurs, the object's declared type is no longer identical to its run-time type.

* Base classes may define and implement virtual methods, and derived classes can override them, which means they provide their own definition and implementation. At run-time, when client code calls the method, the CLR looks up the run-time type of the object, and invokes that override of the virtual method. In your source code you can call a method on a base class, and cause a derived class's version of the method to be executed.

 For example, suppose you have a drawing application that enables a user to create various kinds of shapes on a drawing surface. You don't know at compile time which specific types of shapes the user will create. However, the application has to keep track of all the various types of shapes that are created, and it has to update them in response to user mouse actions.

 The below code demonstrates the polymorphism:

 ```C#
public class Shape
{
    // A few example members
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Height { get; set; }
    public int Width { get; set; }

    // Virtual method
    public virtual void Draw()
    {
        Console.WriteLine("Performing base class drawing tasks");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        // Code to draw a circle...
        Console.WriteLine("Drawing a circle");
        base.Draw();
    }
}
public class Rectangle : Shape
{
    public override void Draw()
    {
        // Code to draw a rectangle...
        Console.WriteLine("Drawing a rectangle");
        base.Draw();
    }
}
public class Triangle : Shape
{
    public override void Draw()
    {
        // Code to draw a triangle...
        Console.WriteLine("Drawing a triangle");
        base.Draw();
    }
}
```

To update the drawing surface, use a `foreach` loop to iterate through the list and call the `Draw` method on each `Shape` object in the list. Even though each object in the list has a declared type of `Shape`, it's the run-time type (the overridden version of the method in each derived class) that will be invoked.

```C#
// Polymorphism at work #1: a Rectangle, Triangle and Circle
// can all be used whereever a Shape is expected. No cast is
// required because an implicit conversion exists from a derived
// class to its base class.
var shapes = new List<Shape>
{
    new Rectangle(),
    new Triangle(),
    new Circle()
};

// Polymorphism at work #2: the virtual method Draw is
// invoked on each of the derived classes, not the base class.
foreach (var shape in shapes)
{
    shape.Draw();
}
/* Output:
    Drawing a rectangle
    Performing base class drawing tasks
    Drawing a triangle
    Performing base class drawing tasks
    Drawing a circle
    Performing base class drawing tasks
*/
```

<br>

# Other Class types in C#

## Sealed Class

Sealed classes are used to restrict the users from **inheriting** the class. A class can be sealed by using the `sealed` keyword. The keyword tells the compiler that the class is sealed, and therefore, cannot be extended. No class can be derived from a sealed class.

## Static class

A static class is a class that cannot be instantiated. Because there is no instance variable, you access the members of a static class by using the class name itself. For example, if you have a static class that is named UtilityClass that has a public static method named MethodA, you call the method as shown in the following example:

```C#
UtilityClass.MethodA(); 
```

A static class can be used as a convenient container for sets of methods that just operate on input parameters and do not have to get or set any internal instance fields. For example, in the .NET Class Library, the static System.Math class contains methods that perform mathematical operations, without any requirement to store or retrieve data that is unique to a particular instance of the Math class. That is, you apply the members of the class by specifying the class name and the method name, as shown in the following example.

```C#
double dub = -3.14;  
Console.WriteLine(Math.Abs(dub));  
Console.WriteLine(Math.Floor(dub));  
Console.WriteLine(Math.Round(Math.Abs(dub)));  
  
// Output:  
// 3.14  
// -4  
// 3  
```

Here is a complete example:

``` C#
public static class TemperatureConverter
{
    public static double CelsiusToFahrenheit(string temperatureCelsius)
    {
        // Convert argument to double for calculations.
        double celsius = Double.Parse(temperatureCelsius);

        // Convert Celsius to Fahrenheit.
        double fahrenheit = (celsius * 9 / 5) + 32;

        return fahrenheit;
    }

    public static double FahrenheitToCelsius(string temperatureFahrenheit)
    {
        // Convert argument to double for calculations.
        double fahrenheit = Double.Parse(temperatureFahrenheit);

        // Convert Fahrenheit to Celsius.
        double celsius = (fahrenheit - 32) * 5 / 9;

        return celsius;
    }
}

class TestTemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Please select the convertor direction");
        Console.WriteLine("1. From Celsius to Fahrenheit.");
        Console.WriteLine("2. From Fahrenheit to Celsius.");
        Console.Write(":");

        string selection = Console.ReadLine();
        double F, C = 0;

        switch (selection)
        {
            case "1":
                Console.Write("Please enter the Celsius temperature: ");
                F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                break;

            case "2":
                Console.Write("Please enter the Fahrenheit temperature: ");
                C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                break;

            default:
                Console.WriteLine("Please select a convertor.");
                break;
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
/* Example Output:
    Please select the convertor direction
    1. From Celsius to Fahrenheit.
    2. From Fahrenheit to Celsius.
    :2
    Please enter the Fahrenheit temperature: 20
    Temperature in Celsius: -6.67
    Press any key to exit.
 */
 ```

### *End of session 9*

<br>

### *Session 10*
### Static members: 
A non-static class can contain static methods, fields, properties, or events. The static member is callable on a class even when no instance of the class has been created. The static member is always accessed by the class name, not the instance name. Only one copy of a static member exists, regardless of how many instances of the class are created. Static methods and properties cannot access non-static fields and events in their containing type, and they cannot access an instance variable of any object unless it's explicitly passed in a method parameter.

## Partial Class

In C#, you can split the implementation of a `class` in multiple `.cs` files using the `partial` keyword. The compiler will combine all the implementation from multiple `.cs` files when the program is compiled.


<br>

### [NEXT - Interfaces](./interfaces.md)