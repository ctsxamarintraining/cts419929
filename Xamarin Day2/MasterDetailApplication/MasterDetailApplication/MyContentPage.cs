using System;

using Xamarin.Forms;

namespace MasterDetailApplication
{
	public class MyContentPage : ContentPage
	{
		public MyContentPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Welcome My Content Page" }
				}
			};
		}
	}
}


