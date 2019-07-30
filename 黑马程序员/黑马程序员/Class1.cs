using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 黑马程序员
{
	public delegate void DelegateAdd(int a, int b);

	public class Dog
	{
		public event Action HelloEvent; //事件,本质是委托对象,调用只能在类的内部完成,外部只能-= +=

		public void SayHello()
		{
			HelloEvent();
		}
	}
}
