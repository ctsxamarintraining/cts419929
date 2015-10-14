using System;
using System.Collections.Generic;

namespace Generic1
{
	class MainClass
	{

		public static void PrintList(LinkedList<Object> MyLinkedList)
		{
			foreach (var element in MyLinkedList)
			{
				Console.WriteLine(element);
			}
		}

		public static void Main (string[] args)
		{

			/* Creating a Simple Linked List */

			LinkedList<Object> MyLinkedList = new LinkedList<Object>();

			/* Inserting Elements */

			MyLinkedList.AddLast ("Add");
			MyLinkedList.AddLast(4);

			/* Implementing Find */

			MyLinkedList.AddAfter(MyLinkedList.Find("Add"), 'a');

			/* Printing Elements of the List */

			PrintList (MyLinkedList);

			/* Remove a particular element from the List */

			MyLinkedList.Remove (4);

			PrintList (MyLinkedList);

			/* Printing the Count of the List */

			int linkedListCount = MyLinkedList.Count;

			Console.WriteLine (linkedListCount);

		}

	}

}