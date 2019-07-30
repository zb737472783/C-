using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 网络通信_服务端
{
	class ServerControl
	{
		Socket serverSocket;

		public ServerControl()
		{
			serverSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
		}

		public void Start()
		{
			serverSocket.Bind(new IPEndPoint(IPAddress.Any, 12321));
			serverSocket.Listen(10);    //最大挂起数
			Console.WriteLine("服务器启动成功");

			Thread threadAccept = new Thread(Accept);
			threadAccept.IsBackground = true;
			threadAccept.Start();
		}

		private void Accept()
		{
			Socket client = serverSocket.Accept();  //接受客户端方法,会阻塞主线程
			IPEndPoint point = client.RemoteEndPoint as IPEndPoint;
			Console.WriteLine(point.Address + "[" + point.Port + "]" + " 连接成功");

			Thread threadReceive = new Thread(Receive);
			threadReceive.IsBackground = true;
			threadReceive.Start(client);

			Accept();	//伪递归
		}

		private void Receive(object obj)
		{
			Socket client = obj as Socket;
			IPEndPoint point = client.RemoteEndPoint as IPEndPoint;
			try
			{
				byte[] msg = new byte[1024];
				int msgLen = client.Receive(msg);
				Console.WriteLine(point.Address + "[" + point.Port + "]:" + Encoding.UTF8.GetString(msg, 0, msgLen));
				client.Send(Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(msg, 0, msgLen) + "楼上说对的"));
				Receive(client);
			}
			catch {
				Console.WriteLine(point.Address + "[" + point.Port + "]:" +"积极断开");
			}
		}
	}
}
