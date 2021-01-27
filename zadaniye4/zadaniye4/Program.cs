using System;

namespace zadaniye4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int a, b;
			a = Convert.ToInt16(Console.ReadLine());
			b = a / 10 + a % 10 * 10;
			Console.WriteLine(b);
			Console.ReadKey();
		}
	}
}
