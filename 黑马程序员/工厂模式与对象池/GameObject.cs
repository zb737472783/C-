using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式与对象池
{
	public class GameObject
	{
		public Vector3 position;
		public GameObject()
		{
			position = new Vector3();
		}
	}

	public class Bullet : GameObject
	{
		public void Destory()
		{
			GameObjectFactory.Deatory(this);
		}
	}

	public class Enemy : GameObject
	{

	}

	public enum GameObjectEnum
	{
		Bullet,
		Enemy
	}

	public class Vector3
	{
		public float x;
		public float y;
		public float z;
	}
}
