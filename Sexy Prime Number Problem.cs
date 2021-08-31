using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int m = Int32.Parse(Console.ReadLine());
		int n = Int32.Parse(Console.ReadLine());
		List<int> primes = new List<int>();
		for (int i = m; i <= n; i++)
		{
			bool f = CheckPrime(i);
			if (f == true)
				primes.Add(i);
		}

		//foreach(var v in primes){Console.WriteLine(v);}
		Dictionary<int, int> d = new Dictionary<int, int>();
		int count = 0;
		for (int i = 0; i < primes.Count - 1; i++)
		{
			for (int j = i + 1; j < primes.Count; j++)
			{
				int x = primes[i];
				int y = primes[j];
				//Console.WriteLine("x : {0}, y: {1}, x-y :{2}", x, y, Math.Abs(x - y));
				if (Math.Abs(x - y) == 6)
				{
					//Console.WriteLine("Selected Items, x : {0}, y: {1}, x-y :{2}", x, y, Math.Abs(x - y));
					//Console.WriteLine("key {0} Value {1}", d.ContainsKey(y), d.ContainsValue(x));
					if (d.ContainsKey(y) && d.ContainsValue(x))
					{
						continue;
					}

					Console.WriteLine("Selected Internal Items, x : {0}, y: {1}, x-y :{2}", x, y, x - y);
					d[x] = y;
					count += 1;
				}
			}
		}

		Console.Write("Count : {0}", count);
		foreach (KeyValuePair<int, int> v in d)
		{
			Console.Write("({0},{1})", v.Key, v.Value);
		}

		Console.WriteLine("End");
	}

	static bool CheckPrime(int i)
	{
		if (i == 1)
			return false;
		//Console.WriteLine("Num: {0}",i);
		int c = 0;
		for (int j = 2; j <= i; j++)
		{
			//int v =i%j;
			//Console.WriteLine(" i%j : {0} and i : {1} and j : {2}",v,i,j);
			if (i % j == 0)
			{
				c += 1;
			//Console.WriteLine("Selected : {0} and count : {1}", i,c);
			}
		}

		if (c < 2)
			return true;
		else
			return false;
	}
}
