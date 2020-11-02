using System;


namespace HW
{
	class Swap
	{
		internal  void Nswap(int a, int b)
		{
			Console.WriteLine("Before swapping  number 1={0},number 2={1}", a, b);
			a = a + b;      
			b = a - b;      
			a = a - b;
			Console.WriteLine("After swapping  number 1={0},number 2={1}", a, b);
		}
		internal void Sswap(string c , string d)
		{
			Console.WriteLine("Before Swapping string 1={0}, string 2 = {1}", c, d);
			//Append second string to first string and store in first string:
			c = c + d;

			//Call the Substring Method (int startIndex, int length) by passing startindex as 
			//0 and length as, a.Length - b.Length:
			d = c.Substring(0, c.Length - d.Length);

			//Call the Substring Method(int startIndex) by passing  startindex as b.Length 
			//as the argument to store the value of initial b string in a
			c = c.Substring(d.Length);
			Console.WriteLine("After Swapping string 1={0}, string 2 = {1}", c, d);
		}
	}
	class Swapping
    {
		static void Main()
		{
			int n1, n2;
			string s1, s2;

			Console.Write("Insert number 1:");
			n1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Insert number 2:");
			n2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Insert string 1:");
			s1 = Console.ReadLine();

			Console.Write("Insert string 2:");
			s2 = Console.ReadLine();



			Swap s = new Swap();
			s.Nswap(n1, n2);

			Swap swap = new Swap();
			swap.Sswap(s1,s2);
			Console.ReadLine();

		}
	}
}
