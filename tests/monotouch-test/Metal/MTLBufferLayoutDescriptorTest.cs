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
	public class MTLBufferLayoutDescriptorTest {
		[Test]
		public void GetSetStrideTest ()
		{
			uint stride = 8;
			var descriptor = new MTLBufferLayoutDescriptor ();
			descriptor.Stride = stride;
			Assert.AreEqual (stride, descriptor.Stride);
		}
		
		[Test]
		public void GetSetStepFunctionTest ()
		{
			var func = MTLStepFunction.Constant;
			var descriptor = new MTLBufferLayoutDescriptor ();
			descriptor.StepFunction = func;
			Assert.AreEqual (func, descriptor.StepFunction);
		}
		
		[Test]
		public void GetSetStepRate ()
		{
			uint step = 8;
			var descriptor = new MTLBufferLayoutDescriptor ();
			descriptor.StepRate = step;
			Assert.AreEqual (step, descriptor.StepRate);
		}
	}
}

#endif // !__WATCHOS__
