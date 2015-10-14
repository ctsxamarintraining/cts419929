using System;

namespace Anonymous1
{

	class MainClass
	{
		/* Delegate for representing Anonymous method */

		delegate int Substration(int number1, int number2);

		public static void Main(string[] args)
		{
			/* Anonymous method using delegate keyword */

			Substration sub = delegate(int number1, int number2)
			{ 
				return number1 - number2;
			};
			int result = sub(12, 8);

			Console.WriteLine(result);
		}
	}
}