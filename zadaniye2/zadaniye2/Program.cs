using System;

namespace zadaniye2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double A = 1.40;
			double B = 5.50;
			double C = 0.60;
			double AC = A - C;
			double BC = B + C;
			double result = AC + BC;
			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
