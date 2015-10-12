using System;

namespace Arrays2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,,,] stringArray = new string[2, 2, 2, 2] { { { 
						{ "1", "2" }, { "3", "4" }  
					}, { 
						{ "5", "6" }, { "7", "8" }  
					} 

				}, { { 
						{ "9", "10" }, { "11", "12" }
					}, { 
						{ "13", "14" }, { "15", "16" }
					} 
				} 
			};
			int[,] intArray = new int[,] {
				{ 1, 2 },
				{ 3, 4 }
			};
			printArray (stringArray);
			printArray (intArray);


		}
		public static void printArray(Array arraySample){
			foreach (var anyObject in arraySample) {
				Console.WriteLine (anyObject);
			}
		}
	}
}
