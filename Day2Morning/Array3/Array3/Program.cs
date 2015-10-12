using System;

namespace Arrays3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] personsArray = new Person[3] {
				new Person{ firstName = "Ravi", lastName = "Kumar", age = 30 },
				new Person{ firstName = "Santosh", lastName = "Reddy", age = 20 },
				new Person{ firstName = "Anil", lastName = "Kumar", age = 45 }
			};

			Array.Sort (personsArray);
			foreach (Person p in personsArray) {
				Console.WriteLine (p.firstName);
			};

		}
	}
	class Person : IComparable<Person>
	{
		public string firstName;
		public string lastName;
		public int age;
		public int CompareTo(Person other)
		{
			return other.age.CompareTo(this.age);
		}
	}
}
