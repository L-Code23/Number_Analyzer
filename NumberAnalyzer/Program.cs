// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//use if statements, conditionals, %



//While loop for validation of number between 1 and 100

    Console.WriteLine("Please enter your name.");
    string name = Console.ReadLine();

while (true)
{
    Console.WriteLine($"Hello {name}. Please enter an integer between 1 and 100");//interpolation of string
    //Input
    int input = int.Parse(Console.ReadLine());
    if( input <=0 || input > 100)
    {
        Console.WriteLine("Integer must be between 1 and 100 inclusive.");
        continue;
    }

    //if statements, if(input%2 == 0--Input is even else input is odd 

    if (input <= 60 && input % 2 > 0)
    {
        Console.WriteLine("Odd and less than 60");
    }
    
    else if (input >= 2 && input <= 24 && input % 2 == 0)
    {
        Console.WriteLine("Even and less than 25.");
    }
    else if (input >= 26 && input <= 60 && input % 2 == 0)
    {
        Console.WriteLine("Even and between 26 and 60 inclusive");

    }
    else if (input >= 60 && input % 2 == 0)
    {
        Console.WriteLine("Even and greater than 60");
    }
    else
    {
        Console.WriteLine("Odd and greater than 60");
    }
    Console.WriteLine("End program? enter y/n");
    string endProgram = Console.ReadLine();
    if(endProgram == "y")
    {
        break;
    }
}