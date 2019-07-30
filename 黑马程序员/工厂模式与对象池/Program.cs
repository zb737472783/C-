using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式与对象池
{
	class Program
	{
		static void Main(string[] args)
		{
			GameObject bullet = GameObjectFactory.Create(GameObjectEnum.Bullet);

			Bullet bulle1t = GameObjectFactory.CreateBullet();
			bulle1t.Destory();
		}
	}
}
