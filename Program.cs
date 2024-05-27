using System;

public class Program
{
	static void Main ( string [] args)
	{
		Console.WriteLine("Hello Welcome to My Grade Average Calculator!");
		Console.WriteLine("Please Enter Your Grades Below");
		
		int index = 1;
		double sum = 0;
		double sum1 = 0;
		double[] grades = new double[index];
		double[] units = new double[index];
		
		for (int counter = 0; counter < index ;counter++)
		{
			
			Console.Write("Enter Grades:\t");
			double grade = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter Units:\t");
			double unit = Convert.ToDouble(Console.ReadLine());
			
			sum1 = sum1 + unit;
			sum = sum + (grade*unit);
			
			Console.Write("Dou You Want To Continue Entering Grades? (Press Enter To Continue or Press 1 to Compute)");
			string choice = Console.ReadLine();
			
			index = index + 1;
			if (choice == "0")
			{
			}
			else if (choice == "1")
			{
				break;
			}

		}
		
		double average = sum/sum1;
		
		Console.WriteLine("Your Average is "+ average);
		
	}
}
	
