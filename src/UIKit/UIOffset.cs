//
// UIEnums.cs:
//
// Copyright 2009-2011 Novell, Inc.
// Copyright 2011-2012, Xamarin Inc.
//
// Author:
//  Miguel de Icaza
//

using System;
using XamCore.Foundation;
using XamCore.ObjCRuntime;

namespace XamCore.UIKit {

	// UIGeometry.h
	public struct UIOffset {

		// API match for UIOffsetZero field/constant
		[Field ("UIOffsetZero")] // fake (but helps testing and could also help documentation)
		public static readonly UIOffset Zero;

		public UIOffset (nfloat horizontal, nfloat vertical)
		{
			Horizontal = horizontal;
			Vertical = vertical;
		}
		public /* CGFloat */ nfloat Horizontal;
		public /* CGFloat */ nfloat Vertical;

		public override bool Equals (object obj)
		{
			if (!(obj is UIOffset))
				return false;
			var other = (UIOffset) obj;
			return other.Horizontal == Horizontal && other.Vertical == Vertical;
		}

		public override int GetHashCode ()
		{
			return Horizontal.GetHashCode () ^ Vertical.GetHashCode ();
		}

		public static bool operator == (UIOffset left, UIOffset right)
		{
			return (left.Horizontal == right.Horizontal) && (left.Vertical == right.Vertical);
		}

		public static bool operator != (UIOffset left, UIOffset right)
		{
			return (left.Horizontal != right.Horizontal) || (left.Vertical != right.Vertical);
		}
	}
}
