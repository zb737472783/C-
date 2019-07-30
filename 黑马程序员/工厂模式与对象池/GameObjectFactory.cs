using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式与对象池
{
	public class GameObjectFactory
	{
		public static Bullet CreateBullet()
		{
			Bullet bullet;
			if (bulletStack.Count > 0)
			{
				bullet = bulletStack.Pop();
			}
			else
			{
				bullet = new Bullet();
			}
			return bullet;
		}

		private static Stack<Bullet> bulletStack = new Stack<Bullet>();
		public static GameObject Create(GameObjectEnum gameObjectEnum)
		{
			GameObject go = new GameObject();
			switch (gameObjectEnum)
			{
				case GameObjectEnum.Bullet:
					go = new Bullet();
					break;
				case GameObjectEnum.Enemy:
					go = new Enemy();
					break;
			}
			return go;
		}

		public static void Deatory(Bullet bullet)
		{
			bulletStack.Push(bullet);
		}
	}
}
