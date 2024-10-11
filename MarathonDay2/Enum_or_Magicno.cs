/*Enumerations (enums) in C# provide a way to define a set of named constants, which makes your code more readable and maintainable. Instead of using "magic numbers" (unexplained numeric literals), you can use descriptive names that make the code self-explanatory.*/
//Without Enums (Using Magic Numbers)
using System;

class Program
{
    static void Main()
    {
        int trafficLight = 1; // 0: Red, 1: Yellow, 2: Green
        
        if (trafficLight == 0)
        {
            Console.WriteLine("Stop");
        }
        else if (trafficLight == 1)
        {
            Console.WriteLine("Caution");
        }
        else if (trafficLight == 2)
        {
            Console.WriteLine("Go");
        }
    }
}
Issues:
Readability: It’s not immediately clear what 0, 1, and 2 represent.
Maintainability: If you need to change these values or add new states, you might forget what the numbers refer to.

  
//With Enums
using System;

enum TrafficLight
{
    Red = 0,
    Yellow = 1,
    Green = 2
}

class Program
{
    static void Main()
    {
        // Declare and initialize the trafficLight variable
        TrafficLight trafficLight = TrafficLight.Yellow;

        // Use a switch statement to handle the different traffic light states
        switch (trafficLight)
        {
            case TrafficLight.Red:
                Console.WriteLine("Stop");
                break;
            case TrafficLight.Yellow:
                Console.WriteLine("Caution");
                break;
            case TrafficLight.Green:
                Console.WriteLine("Go");
                break;
        }
    }
}
/*Using enumerations instead of magic numbers enhances code readability and maintainability, making it easier for anyone (including your future self) to understand what your code is doing. It's a good practice to use enums whenever you have a set of related constants.*/
