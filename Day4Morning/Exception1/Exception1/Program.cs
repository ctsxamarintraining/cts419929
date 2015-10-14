	
/*Write a program that reads an integer number and calculates and prints its square root. 			If the number is invalid or negative, print "Invalid number”. In all cases finally print "Goodbye". " +
 * "Use try-catch-finally.
*/
using System;

namespace Exception1
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			try {
				int numberInteger = 0;
				Console.Write ("Enter one number = ");
				if (numberInteger < 0)
					throw new NegativeNumberException ("Invalid number");
				numberInteger = Convert.ToInt16 (Console.ReadLine ());
				Console.WriteLine ("The square root of given " + numberInteger + " is " + Math.Sqrt (numberInteger));
			} catch (FormatException e) {
				Console.WriteLine (e.Message);
				Console.WriteLine ("Invalid number");
			} catch (NegativeNumberException e) {
				Console.WriteLine (e.Message);
			} catch (Exception e) {
				Console.WriteLine ("Invalid number");
			} finally {
				Console.WriteLine ("Goodbye");
			}

		}
			class NegativeNumberException:ApplicationException
			{
				public NegativeNumberException(string message):base(message){
					//				Console.WriteLine("Use positive numbers only");
				}
				// show message
			}

	}
}
