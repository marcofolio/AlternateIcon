// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AlternateIcon
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnIconMarcofolio { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnIconMicrosoft { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnIconXamarin { get; set; }

        [Action ("BtnIconMarcofolio_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnIconMarcofolio_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnIconMicrosoft_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnIconMicrosoft_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnIconXamarin_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnIconXamarin_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnIconMarcofolio != null) {
                btnIconMarcofolio.Dispose ();
                btnIconMarcofolio = null;
            }

            if (btnIconMicrosoft != null) {
                btnIconMicrosoft.Dispose ();
                btnIconMicrosoft = null;
            }

            if (btnIconXamarin != null) {
                btnIconXamarin.Dispose ();
                btnIconXamarin = null;
            }
        }
    }
}