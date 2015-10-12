using System;
using System.Collections.Generic;

namespace Array4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] personArray = new Person[3] {
				new Person{ firstName = "Ravi", lastName = "Kumar", age = 30 },
				new Person{ firstName = "Kiran", lastName = "Kumar", age = 20 },
				new Person{ firstName = "Anil", lastName = "Kumar", age = 45 }
			};
			MyComparer myComparerObject = new MyComparer ();
			Array.Sort (personArray,myComparerObject);
			foreach (Person p in personArray) {
				Console.WriteLine (p.firstName);
			};

		}
	}
	class Person 
	{
		public string firstName;
		public string lastName;
		public int age;

	}
	class MyComparer : IComparer<Person>
	{
		public int Compare(Person p1, Person p2)
		{
			return p2.age.CompareTo(p1.age);
		}
	}
}