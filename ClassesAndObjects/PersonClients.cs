using System;


namespace ClassesAndObjects
{
    class PersonClients
    {
		static void Main()
		{
			Person person = new Person();
			person.name = "Sai";
			person.age = 45;
			person.DisplayPerson();
			Console.ReadLine();
		}
	}
}
