using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace StaggeredGridSample
{
	public class Item
	{
		public string Filename { get; set; }
		public double Ratio { get; set; }

		public Item(string filename, double ratio)
		{
			Filename = filename;
			Ratio = ratio;
		}

		public static List<Item> GetList()
		{
			var list = new List<Item>();

			var random = new Random();
			foreach (var i in Enumerable.Range(1, 30))
			{
				list.Add(new Item("icon.png", 1.0 + random.NextDouble()));
			}

			return list;
		}
	}
}
