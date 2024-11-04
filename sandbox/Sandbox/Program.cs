using System;
/*I am adding something to see where it goes*/
class Program
{

    static int AddNumbers(int n1, int n2)
    {
        int total = n1 + n2;
        return total;
    }
    static void Main(string[] args)
    {
       int total = AddNumbers(20, 30);
        Console.WriteLine(total);
    }
}






        // List <string> myColors = new List<string>();

        // myColors.Add("Blue");
        // myColors.Add("Orange");
        // myColors.Add("Red");
        // myColors.Add("Green");

        // foreach(string color in myColors)
        // {
        //     Console.WriteLine(color);
        // }





// Console.WriteLine("Hello Sandbox World!");
//         Console.WriteLine("Please enter your name");

//         String name;

//         name = Console.ReadLine();

//         Console.WriteLine($"Your name is: {name}");
//         Console.Write("Input your age: ");
//         string userInput = Console.ReadLine();
//         int age = int.Parse(userInput);

//         Console.WriteLine($"Your age is {age}");

//         int x = 10;

//         if (x > 15){
//             Console.WriteLine("Hey Bob");
//         }

//  Console.WriteLine("Hey Bob");

//         for (int i = 0; i < 10; i++)
//         {
//             Console.WriteLine(i);
//         }

//         int age = -1;

//         while (age < 0 || age > 125)
//         {
//             Console.WriteLine("Please enter your age: (0-125)");
//             age = int.Parse(Console.ReadLine());
//             Console.WriteLine($"Your age is: {age}");
//         }