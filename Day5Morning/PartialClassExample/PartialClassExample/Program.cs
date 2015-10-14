using System;

namespace PartialClassExample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//			Create the partial classes in two file with two methods each. And call them in main method.
			Employee emp = new Employee{Name = "C #",Age = 40};
			emp.displayEmployeeName ();
			emp.displayEmployeeAge ();

		}
	}
}