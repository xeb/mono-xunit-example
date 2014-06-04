using System;

namespace MonoXunit
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World! " + new RandString().Gen());
		}
	}
}
