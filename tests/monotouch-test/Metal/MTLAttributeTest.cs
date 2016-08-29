#if !__WATCHOS__

using System;

#if XAMCORE_2_0
using Metal;
#else
using MonoTouch.Metal;
#endif

using NUnit.Framework;

namespace MonoTouchFixtures.Metal {
	
	[TestFixture]
	public class MTLAttributeTest {
		MTLAttribute attr = null;
		
		[SetUp]
		public void SetUp ()
		{
			attr = new MTLAttribute ();
		}
		
		[TearDown]
		public void TearDown ()
		{
			if (attr != null)
				attr.Dispose ();
			attr = null;
		}

		[Test]
		public void GetNameTest ()
		{
			Assert.Null (attr.Name, $"Name default value is {attr.Name}");
		}

		[Test]
		public void GetAttributeIndexTest ()
		{
			Assert.AreEqual (0, attr.AttributeIndex, $"AttributeIndex default value is {attr.AttributeIndex}");
		}

		[Test]
		public void GetAttributeTypeTest ()
		{
			Assert.AreEqual (MTLDataType.None, attr.AttributeType, $"AttributeType default value is {attr.AttributeType}");
		}

		[Test]
		public void GetActiveTest ()
		{
			Assert.False (attr.Active);
		}

		[Test]
		public void GetIsPatchDataTest ()
		{
			Assert.False (attr.IsPatchData);
		}

		[Test]
		public void GetIsPatchControlPointDataTest ()
		{
			Assert.False (attr.IsPatchControlPointData);
		}
	}
}

#endif // !__WATCHOS__
