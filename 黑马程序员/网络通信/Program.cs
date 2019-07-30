using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 网络通信
{
	class Program
	{
		static void Main(string[] args)
		{
			ClientControl client = new ClientControl();
			client.Connect("127.0.0.1", 12321);

			Console.WriteLine("输入发送内容,quit退出");
			string msg = Console.ReadLine();
			while (msg != "quit")
			{
				client.Send(msg);
				msg = Console.ReadLine();
			}

			Console.ReadKey();
		}
	}
}
