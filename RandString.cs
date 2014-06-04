using System;

namespace MonoXunit
{
	public class RandString
	{
		public string Gen()
		{
			var rand = new Random().Next(0, 100);

			if(rand < 10)
				return "Mark";
			
			if(rand < 20)
				return "Done";
			
			if(rand < 100)
				return "Doll";
			
			return "OHNOES!";
		}
	}
}

