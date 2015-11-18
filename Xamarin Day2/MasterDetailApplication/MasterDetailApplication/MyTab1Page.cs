using System;

using Xamarin.Forms;

namespace MasterDetailApplication
{
	public class MyTab1Page : ContentPage
	{
		public MyTab1Page ()
		{
			
			Content = new StackLayout { 
				BackgroundColor = Color.Green,
				VerticalOptions = LayoutOptions.Center,
				Children = {	
					new Label { Text = "Welcome to Mytab1 page" }
				}
			};
		}
	}
}


