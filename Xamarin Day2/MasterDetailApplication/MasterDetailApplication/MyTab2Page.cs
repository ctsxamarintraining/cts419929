﻿using System;

using Xamarin.Forms;

namespace MasterDetailApplication
{
	public class MyTab2Page : ContentPage
	{
		public MyTab2Page ()
		{
			Content = new StackLayout { 
				BackgroundColor = Color.Gray,
				Children = {
					new Label { Text = "Welcome Tab2 Page" }
				}
			};
		}
	}
}


