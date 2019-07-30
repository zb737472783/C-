using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace 黑马程序员
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 值引用
			ValueParam p1 = new ValueParam();
			int a = 5;
			p1.Add1(a);
			p1.Add2(ref a);
		   p1.Add3(out a);
			Console.WriteLine("Main" + a);
			#endregion

			#region
			/*
			 引用类型 ref,out没变化,注意函数内部是否new了一个新的对象并把指针指向新对象,这样数据就变了
			 */
			#endregion
			Add(1, 2, 3);   //会自动构造数组

			string str = "123";
			str.ToInt32(str);   // 扩展string方法

			#region
			//委托
			DelegateAdd delegateAdd = new DelegateAdd(Add1);    //简写 DelegateAdd delegateAdd = Add1; DelegateAdd delegateAdd += Add1;(添加一个方法)  DelegateAdd delegateAdd -=Add1;(移除一个方法)
			delegateAdd(1, 2);
			#endregion

			#region
			//	lambda 表达式
			Say((b) => {	//匿名函数
				return b.ToString();
			});
			#endregion

			Dog dog = new Dog();
			dog.HelloEvent += Say1;
			dog.SayHello();

			#region
			//线程
			Thread thread1 = new Thread(()=> {
				Console.WriteLine("1");
			});
			thread1.Start();
			#endregion

			Console.ReadKey();
		}

		static void Say1()
		{
			Console.WriteLine("Say1");
		}

		static void Say(Func<int, string> s1)
		{
			s1(1);	//调用匿名函数
		}

		static void Add1(int a, int b)
		{
			Console.WriteLine("我是委托方法Add1");
		}

		#region
		static void Add(params int[] arr)   //params 多个参数的时候修饰最后一个参数(数组),没有数据的时候是长度为0的数组而不是空对象
		{
			Console.Write(arr.Length);
		}
		#endregion
	}

	#region 扩展方法(好处就是 无侵入式开发)
	public static class StringExtend
	{
		public static int ToInt32(this string str,string tempStr)  //this 第一个参数表示此方法扩展给哪个类型 
		{
			return int.Parse(str);
		}
	}
	#endregion

}