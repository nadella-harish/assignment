using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Q2
    {
		public static void Main()
		{
			int n;
			Console.Write("enter the day:");
			n = int.Parse(Console.ReadLine());
			if (n > 0 && n <= 7)
			{
				if (n > 0 && n < 6)
					Console.WriteLine("working day");
				else
					Console.WriteLine("holiday");
			}
			else
				Console.WriteLine("invalid input");
		}

	}
}
