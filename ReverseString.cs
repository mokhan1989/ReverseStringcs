using System;
					
public class Program
{
	public static void Main()
	{
		 String text = "My name is Mohammad";
		 int j = text.Length - 1;
		
		 Char [] Letters = text.ToCharArray();
		
		for(int i = 0; i < text.Length/2; i++)
		{
			char temp = Letters[i];
			
			Letters[i] = Letters[j];
			
			Letters[j] = temp;
			//Console.WriteLine(j);
			
			j--;
		}
		
		String ReversedText = new string(Letters);
		

		
		Console.WriteLine(ReversedText);
	}
		
}