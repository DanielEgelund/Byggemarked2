// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace appTest
{
	[Register ("UmbracoViewController")]
	partial class UmbracoViewController
	{
		[Outlet]
		UIKit.UILabel price { get; set; }

		[Action ("AddToCartBtn:")]
		partial void AddToCartBtn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (price != null) {
				price.Dispose ();
				price = null;
			}
		}
	}
}
