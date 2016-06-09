﻿//
// Unit tests for GKComponentSystem
//
// Authors:
//	Alex Soto <alex.soto@xamarin.com>
//	
//
// Copyright 2015 Xamarin Inc. All rights reserved.
//

#if !__WATCHOS__
#if XAMCORE_2_0 // The GKComponentSystem framework is Unified only

using System;
using OpenTK;

#if XAMCORE_2_0
using Foundation;
using GameplayKit;
#else
using MonoTouch.Foundation;
using MonoTouch.GameplayKit;
#endif
using NUnit.Framework;

namespace MonoTouchFixtures.GamePlayKit {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class GKComponentSystemTests {

		[SetUp]
		public void Setup ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (9, 0))
				Assert.Ignore ("Ignoring GameplayKit tests: Requires iOS9+");
		}

		[Test]
		public void InitWithComponentClassType ()
		{
			var componentSystem = new GKComponentSystem<MySubcomponent> ();
			Assert.NotNull (componentSystem, "GKComponentSystem type ctor must not be null");
			Assert.AreEqual (typeof(MySubcomponent), componentSystem.ComponentType);
		}

		[Test]
		public void IndexerTest ()
		{
			var componentSystem = new GKComponentSystem<MySubcomponent> ();
			Assert.NotNull (componentSystem, "GKComponentSystem type ctor must not be null");
			Assert.AreEqual (typeof(MySubcomponent), componentSystem.ComponentType);

			componentSystem.AddComponent (new MySubcomponent (0));
			componentSystem.AddComponent (new MySubcomponent (1));
			componentSystem.AddComponent (new MySubcomponent (2));

			Assert.IsTrue (componentSystem.Components.Length == 3, "componentSystem.Components must be 3");
			var secondComponent = componentSystem [1] as MySubcomponent;
			Assert.NotNull (secondComponent, "secondComponent must not be null");
			Assert.IsTrue (secondComponent.Id == 1, "secondComponent.Id must be 1");
		}
	}

	[Preserve (AllMembers = true)]
	class MySubcomponent : GKComponent { 
	
		public int Id { get; private set; }

		public MySubcomponent (int id)
		{
			Id = id;
		}

		public MySubcomponent (IntPtr handle) : base (handle) { }
	}
}

#endif // XAMCORE_2_0
#endif // !__WATCHOS__
