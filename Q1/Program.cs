using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items=new List<int> { 2, 4, 6, 8, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
			Func<int, bool> boo = n => n % 2 == 0;
			List<int> nnn= GetEvenItems(items,boo);
		}
		static List<int> GetEvenItems(List<int> lists , Func<int, bool> func)
		{
			var result = new List<int>();
			foreach (var item in lists)
			{
				if (func(item) ==true)
				{
					result.Add(item);
					Console.WriteLine(item);
				}
			}
			return result;
		}


	}
}
