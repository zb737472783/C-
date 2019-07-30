using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 黑马程序员
{
	public class ValueParam
	{
		public void Add1(int a)
		{
			a = 1;
			Console.WriteLine("Add1" + a);
		}

		public void Add2(ref int a)
		{
			a = 2;
		}

		public void Add3(out int a)
		{
			a = 3;
			Console.WriteLine(a);
		}
	}
}
