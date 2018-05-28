using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var inputSentence = whats the matter with kansas;
		var inputWord = inputSentence.Split();
		var result = string.Join( , 
                 inputWord.Select((w, i) => 
                                  i % 2 == 0
                                  ? w 
                                  :new string(w.Reverse().ToArray())
                 ));
		Console.WriteLine(result);
	}
}