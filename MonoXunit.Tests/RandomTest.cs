using System;
using Xunit;

namespace MonoXunit.Tests
{
	public class RandomTest
	{
		[Fact]
		public void Length_Is_Ok()
		{
			var item = new RandString().Gen();

			Assert.True(item.Length == 4);
		}
	}
}

