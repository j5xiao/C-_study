// See https://aka.ms/new-console-template for more information

// Console.Write("Your First name: ");
// string first_name = Console.ReadLine();

// Console.Write("Your Last name: ");
// string last_name = Console.ReadLine();

// Console.Write("Your Age: ");
// int age = int.Parse(Console.ReadLine());

// Console.Write("Are you a student (yes/no): ");
// string studentInput = Console.ReadLine().ToLower();
// bool isStudent = studentInput == "yes";

// Console.WriteLine($"Hello, my name is {first_name} {last_name}, I am {age} years old.");

// if (isStudent){
//     Console.WriteLine($"I am a student");
// } else
// {
//     Console.WriteLine($"I am not a student");
// }


// Area and Perimeter of a Circle
Console.WriteLine("Please enter the radius of Circle: ");
float radius = float.Parse(Console.ReadLine());

Console.WriteLine($"Perimeter: {2*radius*Math.PI}");
Console.WriteLine($"Area: {radius*radius*Math.PI}");