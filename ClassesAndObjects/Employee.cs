using System;


namespace ClassesAndObjects
{
    class Employee
    {
		string Name;
		int age;
		string degree;

		void DisplayDetails()
		{
			Console.WriteLine("Name:{0} || Age: {1} || Degree: {2}", Name, age, degree);

		}

		static void Main()
		{
			Employee employee1 = new Employee();
			employee1.Name = "Eesha";
			employee1.age = 24;
			employee1.degree = "M.Tech";
			employee1.DisplayDetails();//Eesha Info


			Employee employee2 = new Employee();
			employee2.Name = "Sasi";
			employee2.age = 34;
			employee2.degree = "M.Sc";
			employee1.DisplayDetails();//Eesha Info
			employee2.DisplayDetails(); // Sasi Info
			Console.ReadLine();
		}
	}
}
