using System;

using Xamarin.Forms;
using System.Collections.Generic;


namespace MasterDetailApplication
{
	public class MyCourselPage : CarouselPage
	{
		public MyCourselPage ()
		{
//			Content = new StackLayout {
//				Orientation = StackOrientation.Horizontal,
//				HorizontalOptions = LayoutOptions.Center,
//				VerticalOptions = LayoutOptions.Center,
//
//				Children = {
//					new Label { Text = "Hello Coursel Page" }
//				}
//			};



			Color[] colors = { Color.Olive, Color.Purple, Color.Blue,Color.Gray,Color.Green };
			foreach (Color color in colors) {
				this.Children.Add(new ContentPage { Content = new StackLayout {
						Children = {
							
							//BackgroundColor = c,
							//new Label { Text = "Hi"},
							//new Label { Text = "coursel"},
							new BoxView {
								Color = color,
								VerticalOptions = LayoutOptions.FillAndExpand,
					
							},

						}
					}
				});
			
			}

		}
	}
}


