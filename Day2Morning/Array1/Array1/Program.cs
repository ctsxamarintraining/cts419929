using System;

namespace Arrays1
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
			foreach (string stringVariable in stringArray) {
				Console.WriteLine (stringVariable);
			}
		}
	}
}