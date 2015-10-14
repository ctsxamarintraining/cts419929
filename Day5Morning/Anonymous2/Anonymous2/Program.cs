using System;

namespace Anonymous2
{
	

	class MainClass
	{

		/* Delegate for representing Anonymous method */

		delegate void employeeProfile(Employee employee);

		public static void Main (string[] args)
		{
			Employee empDetails = new Employee {Id = 419929, Name = "Chaitanya", Country = "India", age = 23} ;

			/* Anonymous method using delegate keyword */

			employeeProfile profile = delegate(Employee employee){
				Console.WriteLine("Id: " + employee.Id);
				Console.WriteLine("Name: " + employee.Name);
				Console.WriteLine("Country: " + employee.Country);
				Console.WriteLine("Age: " + employee.age);
			};


			profile (empDetails);

		}
	}

	/* Custom Class Person */

	public class Employee
	{
		public int Id;
		public int age;
		public string Name;
		public string Country;
	}
}