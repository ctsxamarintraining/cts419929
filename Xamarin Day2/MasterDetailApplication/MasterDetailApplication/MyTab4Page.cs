using System;

using Xamarin.Forms;

namespace MasterDetailApplication
{
	public class MyTab4Page : ContentPage
	{
		public MyTab4Page ()
		{
			Content = new StackLayout { 
				BackgroundColor = Color.Blue,
				Children = {
					new Label { Text = "My Tab2 Page" }
				}
			};
		}
	}
}


