using System;

namespace zadaniye3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double x1, y1, x2, y2;
			x1 = -6.20;
			y1 = 5.20;
			x2 = 2.10;
			y2 = 9.80;
			double result = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
