using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
	class Pen
	{
		int ISBN; //private
		public string Brand;
		internal string Color;
		//Constructor--Special Method, by default private
		//Constructor name should be same that of the class name
		//Constructor doe not have a return type
		//Constructor Overloading

		internal Pen() // no arguments
		{
			Console.WriteLine("Default Constructor");
		}

		internal Pen(int ISBN) //1 argumrnts
		{
			this.ISBN = ISBN;
			Console.WriteLine("ISBN Number");
		}
		internal Pen(string b, string Color)
		{
			Brand = b;
			//refers to current class instance-->Pen
			this.Color = Color;
		}
		internal void Display()
		{
			Console.WriteLine("Brand:{0} || Color:{1}", Brand, Color);
		}
	}
	class Constructor
    {
		static void Main()
		{
			Pen p = new Pen(); //With 0 arguments
			Pen p1 = new Pen(123); //With 1 arguments
			Pen pen = new Pen("Parker", "Blue"); //With 2 arguments
			/*pen.brand = "Parker";
			pen.color = "Blue";*/
			pen.Display();
			Console.Read();
		}
	}
}
