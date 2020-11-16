/*This program calculates the average of a group of marks*/
using System;
public class Average{
	public static void Main()
	{
		double total=0, number, average;
		int counter=0;
		string mark;
		Console.Write("Insert a mark: ");
		mark=Console.ReadLine();
		while(mark!="end")
		{
			number=Convert.ToDouble(mark);
			counter++;
			total+=number;
			Console.Write("Insert a mark: ");
			mark=Console.ReadLine();
		}
		if(counter!=0)
		{
			average=total/counter;
			Console.WriteLine("The average is {0}.",average);
		}
	}
}
