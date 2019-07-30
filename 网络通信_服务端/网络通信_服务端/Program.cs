using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 网络通信_服务端
{
	class Program
	{
		static void Main(string[] args)
		{
			ServerControl serverControl = new ServerControl();
			serverControl.Start();

			Console.ReadKey();
		}
	}
}
