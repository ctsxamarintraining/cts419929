using System;

namespace PartialClassExample
{
	public partial class Employee
	{
		public  string Name;
		public int Age;
		public Employee ()
		{
			
		}
		public void displayEmployeeName(){
			Console.WriteLine ("Employee Name is " + this.Name);
		}
	}
}


