using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomYesNoPicker
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> evalCounter = new Dictionary<string, int>();// { ["Yes"] = 0, ["No"] = 0 };

			int count = 0;

			var random = new Random();
			//List<string> list = new List<string> { "Yes", "No" };

			List<string> list = new List<string> { "Exam AZ-204: Developing Solutions for Microsoft Azure",
"Exam DP-900: Microsoft Azure Data Fundamentals",
"Exam PL-900: Microsoft Power Platform Fundamentals",
"Certified scrum master(CSM)" };

			while (count < 2520)//2520 is: the smallest number divisible by all integers from 1 to 10, i.e., it is their least common multiple.
			{
				int index = random.Next(list.Count);

				string item = list[index];
				//initialize or increment the count for this item
				if (evalCounter.ContainsKey(item))
				{
					evalCounter[item]++;
				}
				else
				{
					evalCounter.Add(item, 1);
				}
				count++;
			}

			//var lines = evalCounter.Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
			var ordered = evalCounter.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
			Console.WriteLine("Winner is : \n"+string.Join(Environment.NewLine, ordered));
		}
	}
}
