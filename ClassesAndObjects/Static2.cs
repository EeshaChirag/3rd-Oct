using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
	class Mobile
	{
		internal static string companyname; //class variable
		internal string Modelname; //object variable

		//static method can access only static variables
		internal void DisplayModel()
		{
			Console.WriteLine("Companyname:{0} || Modelname:{1}", companyname, Modelname);

		}
		//static method can access non static variables
		internal static void GetData()
		{
			Console.WriteLine("Companyname:{0}", companyname);

		}

	}
	class Static2
    {
		internal static void Info()
		{
			Console.WriteLine("Static Method");
		}
		static void Main()
		{
			Mobile m = new Mobile();
			m.Modelname = "Moto g4 plus";
			Mobile.companyname = "Motorola";
			m.DisplayModel();
			Mobile.GetData();
			//Info method and static method in same class.
			Info();
			Console.ReadLine();
		}
	}
}
