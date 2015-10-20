using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//			Implement IEqualityComparer and IComparer for any custom class and give an example for both interfaces 
			//				by using any of the default classes/methods in .NET which are accepting these interfaces.

			Dictionary<Person,int> personList1 = new Dictionary<Person,int>(new MyEqualityComparer()){
				{new Person{id=1,name="phani"},1},
				{new Person{id=2,name="prasad"},2},
				{new Person{id=1,name="kishore"},3}
			};
			Console.WriteLine ("Using IEqualityComparer");
			foreach (Person p in personList1.Keys)
				Console.WriteLine (p.name);
			List<Person> myList = new List<Person> {
				new Person{ id = 1, name = "phani" },
				new Person{ id = 6, name = "krishna" },
				new Person{ id = 4, name = "kavitha" }
			};
			Console.WriteLine ("Using IComparer");
			myList.Sort (new MyComparer ());
			foreach(Person p in myList)
				Console.WriteLine (p.name);
		}
	}
	class Person{
		public string name;
		public int id;
	}
	class MyEqualityComparer : IEqualityComparer<Person>{
		#region IEqualityComparer implementation
		public bool Equals (Person x, Person y)
		{
			return x.id==y.id;
		}
		public int GetHashCode (Person obj)
		{
			return obj.GetHashCode ();
		}
		#endregion
	}
	class MyComparer : IComparer<Person>{
		#region IComparer implementation
		public int Compare (Person x, Person y)
		{
			return x.name.CompareTo (y.name);
		}
		#endregion
	}
}
