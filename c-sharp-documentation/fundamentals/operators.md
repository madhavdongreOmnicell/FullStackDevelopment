# C# Operators

Operators are the foundation of any programming language. Operators allow us to perform different kinds of operations on operands, example `int x =  5 + 5` OR `string greeting = "Hello" + "world"`.

 In C#, operators Can be categorized based upon their different functionality :

## Arithmetic operator: 
The arithmetic operators perform arithmetic operations on all the numeric type operands such as sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.

<table>
<thead>
<tr>
<th>Operator</th><th>Name</th><th>Description</th><th>Example</th>
</tr>
</thead>
<tbody>
<tr>
<td>+</td><td>Addition</td><td>Computes the sum of left and right operands.</td><td>int x = 5 + 5;</td>
</tr>
<tr>
<td>-</td><td>Substraction</td><td>Subtract the right operand from the left operand</td><td>int x = 5 - 1;</td>
</tr>
<tr>
<td>*</td><td>Multiplication</td><td>Multiply left and right operand.</td><td>int x = 5 * 1;</td>
</tr>
<tr>
<td>/</td><td>Division</td><td>Divides the left operand by the right operand.</td><td>int x = 10 / 2;</td>
</tr>
<tr>
<td>%</td><td>Remainder</td><td>Computes the remainder after dividing its left operand by its right operand.</td><td>int x = 5 % 2;</td>
</tr>
<tr>
<td>++</td><td>Unary increment</td><td>Unary increment ++ operator increases its operand by 1.</td><td>x++;</td>
</tr>
<tr>
<td>--</td><td>Unary decrement</td><td>Unary decrement -- operator decreases its operand by 1.</td><td>x--;</td>
</tr>
<tr>
<td>+</td><td>Unary plus</td><td>Returns the value of operand.</td><td>int five = +5</td>
</tr>
<tr>
<td>-</td><td>	Unary minus</td><td>Computes the numeric negation of its operand.</td><td>int minusFive = -5;</td>
</tr>
</tbody>
</table>

Example:
```C#
static void Main(string[] args)
{
    var addition = 5 + 12 + 100;
	var substraction = 180 - 20;
	var multiplication = 10 * 45;
	var division = 64 / 8;
	var remainder = 65 % 6;
	var num = 10;
	var increment = num++;
	var decrement = num--;
	var unaryPlus = +5;
	var unaryMinus = -5;
}
```

## :white_check_mark: Tasks
:white_check_mark: Write a program to implement a simple banking system using different possible arithmetic operations, follow the below tasks.
:white_check_mark: Create a variable called `accountBalance` with value 0.
:white_check_mark: Deposit 15000 in bank, you should identify what arithmetic operation to perform.
:white_check_mark: Received a money transfer of Rs 183.77, add the same to the bank balance.
:white_check_mark: Paying rent of Rs 4000. Amount must be deducted from the account balance.
:white_check_mark: Interest capitalized worth 0.0045% on the account balance. Find 0.0045 percentage of the current account balance and add it to the account balance.
:white_check_mark: Decrement account balance by 1 as service fee.

## Relational Operators:
Following table shows all the relational operators supported by C#. Assume variable A holds 10 and variable B holds 20, then −

<table class="demo">
	<thead>
	<tr>
		<th>Operator</th>
		<th>Description</th>
		<th>Example</th>
	</tr>
	</thead>
	<tbody>
	<tr>
		<td>==</td>
		<td>Checks if the values of two operands are equal or not, if yes then condition becomes true.</td>
		<td>(A == B) is not true.</td>
	</tr>
	<tr>
		<td>!=</td>
		<td>Checks if the values of two operands are equal or not, if values are not equal then condition becomes true.</td>
		<td>(A != B) is true.</td>
	</tr>
	<tr>
		<td>&gt;</td>
		<td>Checks if the value of left operand is greater than the value of right operand, if yes then condition becomes true.</td>
		<td>(A &gt; B) is not true.</td>
	</tr>
	<tr>
		<td>&lt;</td>
		<td>Checks if the value of left operand is less than the value of right operand, if yes then condition becomes true.</td>
		<td>(A &lt; B) is true.</td>
	</tr>
	<tr>
		<td>&gt;=</td>
		<td>Checks if the value of left operand is greater than or equal to the value of right operand, if yes then condition becomes true.</td>
		<td>(A &gt;= B) is not true.</td>
	</tr>
	<tr>
		<td>&lt;=</td>
		<td>Checks if the value of left operand is less than or equal to the value of right operand, if yes then condition becomes true.</td>
		<td>(A &lt;= B) is true.</td>
	</tr>
	<tbody>
</table>

## Logical Operators

Following table shows all the logical operators supported by C#. Assume variable A holds Boolean value true and variable B holds Boolean value false, then −

<table>
		<thead>
			<tr>
				<th>Operator<br></th>
				<th>Description</th>
				<th>Example</th>
			</tr>
		</thead>
		<tbody>
			<tr>
				<td>&amp;&amp;</td>
				<td>Called Logical AND operator. If both the operands are non zero then condition becomes true.&</td>
				<td>(A &amp;&amp; B) is false.</td>
			</tr>
			<tr>
				<td>||</td>
				<td>Called Logical OR Operator. If any of the two operands is non zero then condition becomes true.</td>
				<td>(A || B) is true.</td>
			</tr>
			<tr>
				<td>!</td>
				<td>Called Logical NOT Operator. Use to reverses the logical state of its operand. If a condition is true then Logical NOT operator will make false.</td>
				<td>!(A &amp;&amp; B) is true.</td>
			</tr>
		</tbody>
	</table>


## Assignment Operators
C# also supports standard assignment operators like `=`, `+=`, `-=`, `*=`, `/=` and `%=` etc.

Here is an example program which demonstrates some operators in C#:

```C#
using System;
namespace SkillHouse {					
	public class Program
	{
		public static void Main()
		{
			int x = 100;
			int y = 200;

			string userChoice = Console.ReadLine('Press 1 for addition, 2 for substraction');

			if (userChoice == "1") { // comparision operator used here ==
				int result = x + y; // assignment and arithmetic operators used here, = and +
			} else {
				int result = x - y; // assignment and arithmetic operator used here.
			}

			bool nightMode = true;
			bool language = 'C#'

			string theme = isNightMode == true && language == 'C#' ? 'C-Sharp-Night-Theme.css' : 'C-Sharp-Normal-Theme.css'; // Logical AND and Conditional operator ? : are used here.
		}
	}
}
```

## :white_check_mark: Tasks
:white_check_mark: Write a C# program to find a given number is Odd or Even. The logic could be to perform % (mod) operation on the given number by 2 and check if the result is zero, ex: `i % 2 == 0` is Even number otherwise Odd number.

:white_check_mark: Write a C# program to perform different arithmetic operation like Add, Substract, Multiply and Division operation on any two number.

:white_check_mark: Write a C# program to perform following operations in a Car.

1. Read the Car Name, Milage, Current Speed at which car is moving from the user into different variables. (Hint: `Console.ReadLine`)
2. Read current weather information into different variables like: temperature, is raining ?, is foggy ?
2. If current speed of the car is equal 60, display a message in console saying “Safe Drive..! Well done”. If current speed is greater than 60 but lesser than 80, display message saying “Be focused please…!”. If the current speed is greater than 80, display “Careful…Slow Down…”. If the speed is lesser than 60, display saying “You can speed up little bit..!”.
3. If it is raining, display a message saying “Switching on the Wiper” else display “Wiper is switched off”
4. If the weather temperature is above 24, display a message "Car AC is recommended", if below 24 but above 18, display "Car AC is optional", if the weather temperature is below 18, display "Car AC is not recommended".
5. If it is foggy, display "Fog lights are ON" else "Fog lights are off".


### *End of session 4*

<br>

### [NEXT - Loops](loops.md)