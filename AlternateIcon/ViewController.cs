using System;

using UIKit;

namespace AlternateIcon
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		private static string AlternateIconNameMicrosoft = "Microsoft";
		private static string AlternateIconNameMarcofolio = "Marcofolio";

		partial void BtnIconXamarin_TouchUpInside(UIButton sender)
		{
			SupportsAlternateIcons(() =>
			{
				UIApplication.SharedApplication.SetAlternateIconName(null, HandleError); // Default icon
			});
		}

		partial void BtnIconMicrosoft_TouchUpInside(UIButton sender)
		{
			SupportsAlternateIcons(() =>
			{
				UIApplication.SharedApplication.SetAlternateIconName(AlternateIconNameMicrosoft, HandleError);
			});
		}

		partial void BtnIconMarcofolio_TouchUpInside(UIButton sender)
		{
			SupportsAlternateIcons(() =>
			{
				UIApplication.SharedApplication.SetAlternateIconName(AlternateIconNameMarcofolio, HandleError);
			});
		}

		private void SupportsAlternateIcons(Action callback)
		{
			if (UIApplication.SharedApplication.SupportsAlternateIcons)
			{
				callback();
			}
			else
			{
				throw new Exception("iOS version doesn't support AlternateIcons.");
			}
		}

		private void HandleError(Foundation.NSError error)
		{
			if (error != null)
			{
				throw new Exception($"Can't change Icon. Error: {error.Description}.");
			}
		}
	}
}
