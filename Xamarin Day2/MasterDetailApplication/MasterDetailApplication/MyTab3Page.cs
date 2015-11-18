using System;

using Xamarin.Forms;

namespace MasterDetailApplication
{
	public class MyTab3Page : ContentPage
	{
		public MyTab3Page ()
		{
			Content = new StackLayout { 
				BackgroundColor = Color.Purple,
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


