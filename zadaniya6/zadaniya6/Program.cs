using System;

namespace zadaniya6
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int k, s, n;
			n =-1;
			k = Convert.ToInt32(Console.ReadLine());
			s = ((k + n) % 7) + 1;
			Console.WriteLine(s);

			Console.ReadKey();

		}
	}
}
