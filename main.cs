using System;
using System.Collections.Generic;

class MainClass {

  	public static void Main (string[] args) {
		Random rand = new Random();
		
		Console.WriteLine("Genereting list...");

		List<int> lis = new List<int>();

		for (int i = 0; i < 10000000; i++) {
			lis.Add(rand.Next(100000000));
		}

		Console.WriteLine("Generated list.");

		Console.WriteLine("Sorting list...");

		lis.Sort(); //this line is what sorts it it's one line

		Console.WriteLine("Sorted list.");

		//Console.WriteLine("Printing list...");

		//for (int i = 0; i < lis.Count; i++) {
		//	Console.WriteLine(lis[i]);
		//}

		Console.WriteLine("There you fucking go.");
	}
}