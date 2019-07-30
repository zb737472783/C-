using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 黑马程序员
{
	public class Animal
	{
		private string name;
		private static Animal animal;

		public static Animal Create()
		{
			if (animal == null)
			{
				animal = new Animal("Default");
			}
			return animal;
		}

		private Animal()
		{

		}

		public Animal(string name)
		{
			this.name = name;
		}
	}
}
