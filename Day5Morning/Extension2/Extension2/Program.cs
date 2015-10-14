using System;

namespace Extension2
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/* Assigning null and printing */

			int? numberValue = null;
			if(!numberValue.HasValue)
				Console.WriteLine ("Null Value");

			/* Assigning value and printing */

			numberValue = 10;

			if(numberValue.HasValue)
				Console.WriteLine (numberValue.Value);
		}
	}
}