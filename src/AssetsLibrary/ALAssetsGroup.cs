//
// This file describes extensions to the ALAssetsGroup class
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2009, Novell, Inc.
// Copyright 2011, Xamarin, Inc.
//
using XamCore.ObjCRuntime;
using XamCore.Foundation;
using XamCore.CoreGraphics;
using XamCore.CoreLocation;
using XamCore.UIKit;
using XamCore.MediaPlayer;

namespace XamCore.AssetsLibrary {

	[Deprecated (PlatformName.iOS, 9, 0, message : "Use the 'Photos' API instead.")]
	public partial class ALAssetsGroup {
		public NSString Name {
			get {
				return (NSString) ValueForProperty (_Name);
			}
		}
		
		public ALAssetsGroupType Type {
			get {
#if XAMCORE_2_0
				return (ALAssetsGroupType) (int) ((NSNumber) ValueForProperty (_Type)).NIntValue;
#else
				return (ALAssetsGroupType) (int) ((NSNumber) ValueForProperty (_Type)).IntValue;
#endif
			}
		}

		public string PersistentID {
			get {
				return (NSString) ValueForProperty (_PersistentID);
			}
		}

		public NSUrl PropertyUrl {
			get {
				return (NSUrl) ValueForProperty (_PropertyUrl);
			}
		}
	}

}

