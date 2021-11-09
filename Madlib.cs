// TODO:  Write the Madlib program in C#
//
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a Name: Enter a Color: Enter a Noun (pl): ");
        string name = Console.ReadLine();
        string color = Console.ReadLine();
        string noun = Console.ReadLine();
		Console.WriteLine();

        string poem = $"Roses are {color}\n{noun} are blue,\n{name} loves you.";
		
		Console.WriteLine(poem);
	}
}

