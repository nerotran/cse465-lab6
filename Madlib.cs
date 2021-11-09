// TODO:  Write the Madlib program in C#
//
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a Name: ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter a Color: ");
        string color = Console.ReadLine();

        Console.WriteLine("Enter a Noun (pl): ");
        string noun = Console.ReadLine();
		Console.WriteLine();

        string poem = $"Roses are {color}\n{noun} are blue,\n{name} loves you.";
		
		Console.WriteLine(poem);
	}
}

