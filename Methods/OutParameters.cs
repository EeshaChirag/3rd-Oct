using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class OutParameters
    {
		void Calculation(float n1, float n2, int l, out float s, out float p, out int c)
		{
			s = n1 + n2;
			p = n1 * n2;
			c = l + 2 * 4;
		}

		//Only one params keyword is allowed and no additional parameters is permitted after the params keyword
		void Studentdetails(string name, params string[] hobbies)
		{
			Console.WriteLine("Id:{0}", name);
			for (int i = 0; i < hobbies.Length; i++)
			{
				Console.WriteLine(hobbies[i]);
			}
		}

		static void Main()
		{
			//Out Parameter
			float num1 = 10, num2 = 80, sum = 0, product = 0;
			int length = 10, cal = 0;
			OutParameters obj = new OutParameters();
			obj.Calculation(num1, num2, length, out sum, out product, out cal);
			if (sum > 0 && product > 0)
			{
				Console.WriteLine("Sum: {0} || Product: {1} || Cal:{2}", sum, product, cal);
			}

			Console.WriteLine("--------------------------------------------------");
			//string[] h = new string[3] {"Singing", "Playing", "Reading"};
			//obj.Studentdetails(1001, h);

			//Params is a keyword which is used to specify that takes variable 
			obj.Studentdetails("Sunitha", "Singing", "Playing", "Reading");


			Console.ReadLine();
		}
	}
}
