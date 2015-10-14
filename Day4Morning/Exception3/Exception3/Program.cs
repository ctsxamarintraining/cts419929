using System;

namespace Exception3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] integerArray = new int[10];
			int i = 0;
			do {
				try{
					Console.Write("Enter a number to add to the array : ");
					int value = Convert.ToInt32(Console.ReadLine());
					integerArray[i++] = value;
					int j = 0;
					string commaSeperatedStr = "";
					for(int k =0;k<i; k++){
						if(j==0){
							j++;
							commaSeperatedStr = commaSeperatedStr+integerArray[k];
						}
						else
							commaSeperatedStr = commaSeperatedStr + "," + integerArray[k] ;


					}
					Console.WriteLine("The array  : "+commaSeperatedStr);

				}
				catch(IndexOutOfRangeException e){
					Console.WriteLine(e.Message);
				}
				catch(FormatException e){
					Console.WriteLine(e.Message);
				}
				catch(Exception e){
					Console.WriteLine(e.Message);
				}

			} while(true);
		}
	}
}

