﻿using MvvmCross.Plugins.Notifications.Sample.Portable;
using UIKit;

namespace MvvmCross.Plugins.Notifications.Samples.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{
		}

		public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
			: base(applicationDelegate, presenter)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new MvxApp();
		}


	}
}