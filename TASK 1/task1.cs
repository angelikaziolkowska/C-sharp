// Task 1
// Angelika Ziolkowska

using System;
					
public class Task1
{
	public static void Main()
    {
		int num = Convert.ToInt32(Console.ReadLine());
		
		for(int i=0;i<num*2;i++)
        {
			if(i<num)
            {
				for(int j=0;j<i;j++)
                {
					Console.Write("*");
				}
				Console.WriteLine();
			}
			else
            {
				for(int j=i;num*2-j>0;j++)
                {
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}