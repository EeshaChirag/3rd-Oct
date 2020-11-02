using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	class Shape
	{
		internal double Area(int r)
		{
			return (3.14 * r * r);
		}
		internal int Area(int l, int b)
		{
			return l * b;
		}
	}
	class MethodOverLoading
    {
		static void Main()
		{
			Shape shape = new Shape();
			Console.WriteLine("Area of a Circle:{0}", shape.Area(4));
			Console.WriteLine("Area of a Circle:{0}", shape.Area(6, 7));
			Console.ReadLine();

		}
	}
}
