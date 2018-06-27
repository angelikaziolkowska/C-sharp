// Task 2
// Angelika Ziolkowska

//here it is rounded down on division but can be updated to return float if required
using System;
					
public class Task2
{
	public static void Main()
    {
		int op=0,first,second, final=0,end;
		string operation = Console.ReadLine();
		
		for(int i=1;i<operation.Length-1;i++)
        {
			if(operation[i].Equals('+') || operation[i].Equals('-') || operation[i].Equals('/') || operation[i].Equals('*'))
            {				
				op=i;
			}  
		}

		first = Convert.ToInt32(operation.Substring(0,op));
		second = Convert.ToInt32(operation.Substring(op+1,operation.Length-op-1));
		
		if(operation[op].Equals('+'))
        {
			final = first + second;			
		}
		else if(operation[op].Equals('-'))
        {
			final = first - second;
		}
		else if(operation[op].Equals('/'))
        {
			final = first / second;
		}
		else if(operation[op].Equals('*'))
        {
			final = first * second;			
		}
		Console.WriteLine(final);
	}
}