/*
 Write a program that enters filename along with its full file path (e.g c:\Example\myexample.txt ), 
			reads its contents and prints it on the console.Find in MSDN how to use System.IO.File.ReadAllText(…). 	
			Besure to catch all possible exceptions and print user-friendly error messages.
*/
using System;
using System.IO;

namespace Exception2
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			try{
				string filepath ;
				Console.Write("Enter fileName with its path to read: ");
				filepath = Console.ReadLine();
				Console.WriteLine("The contents of file are :\n" +File.ReadAllText(@filepath));
			}
			catch(FormatException e){
				Console.WriteLine (e.Message);
			}
			catch(FileNotFoundException e){
				Console.WriteLine (e.Message);
			}
			catch(Exception e){
				Console.WriteLine (e.Message);
			}
		}
	}
}
