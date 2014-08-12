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

		[Fact]
		public void String_Is_Not_Null()
		{
			var item = new RandString().Gen();

			Assert.False(String.IsNullOrEmpty(item));
		}
	}
}

