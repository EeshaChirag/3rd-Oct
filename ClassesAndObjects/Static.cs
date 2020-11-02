using System;

namespace ClassesAndObjects
{
	class Student
	{
		internal static string collegename;
		string name;
		string dept;

		internal Student(string name, string dept)
		{
			this.name = name;
			this.dept = dept;
		}

		internal void DisplayDetails()
		{
			Console.WriteLine("Name:{0} || Dept:{1} ||Collegename:{2}", name, dept, collegename);
		}

	}
	class Static
    {
		static void Main()
		{
			//accessing static variable by class name
			Console.Write("Enter the college Name: ");
			Student.collegename = Console.ReadLine();

			string name, dept;
			Console.Write("Enter the number of students: ");
			int no = Convert.ToInt32(Console.ReadLine());
			Student[] student = new Student[no];
			for (int i = 0; i < student.Length; i++)
			{
				Console.Write("Enter the Name{0}: ",i);
				name = Console.ReadLine();
				Console.Write("Enter the department{0}: ", i);
				dept = Console.ReadLine();
				student[i] = new Student(name, dept);
			}
			for (int i = 0; i < no; i++)
			{
				student[i].DisplayDetails();
			}
			Console.ReadLine();
		}
	}
}
