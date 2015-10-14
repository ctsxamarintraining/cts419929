// Extension, Anonymous funtion and types

using System;

namespace Extension
{
	public delegate void Mydelegate(int x);
	class MainClass
	{

		public static void Main (string[] args)
		{

			Mydelegate del = new Mydelegate (myfunction);
			del (5);
			Mydelegate del1 = delegate(int x){   // Anonymous type 
				Console.WriteLine ("Hello World!");
			};
			del1 (6);
		}
		public static void myfunction(int y){
			y = y + 1;
			Console.WriteLine ("Hello World!"+y);
		}

	}
}



