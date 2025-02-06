# Pratik - Try-Catch

Şu şekilde kısa ve açıklayıcı bir **README.md** dosyası oluşturabiliriz:  

---

# **Try-Catch Example**

## **Description**
This is a simple C# console application that demonstrates the use of **try-catch** for handling invalid user input. The program asks the user to enter a number and calculates its square. If the user enters an invalid input (e.g., letters or symbols), an error message is displayed.

## **Features**
- Takes user input from the console.
- Uses **try-catch** to handle incorrect inputs.
- Displays the square of the entered number if valid.
- Shows an error message if the input is invalid.

## **Code Example**
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int square = number * number;
            Console.WriteLine($"The square of the number is: {square}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}
```

## **Expected Output**
✅ **Valid Input:**
```
Enter a number: 5
The square of the number is: 25
```
❌ **Invalid Input:**
```
Enter a number: abc
Invalid input! Please enter a valid number.
```

## **Requirements**
- .NET Core / .NET 5+
- Any C# compatible IDE (e.g., Visual Studio, Visual Studio Code)

## **How to Run**
1. Clone this repository.
2. Open the project in Visual Studio.
3. Run the program and enter a number.
