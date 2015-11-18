using System;

using Xamarin.Forms;

namespace MasterDetailApplication
{
	public class MyTabbedPage : TabbedPage
	{
		public MyTabbedPage ()
		{
//			Content = new StackLayout { 
//				Children = {
//					new Label { Text = "Hello ContentPage" }
//				}
//			};

//			this.Children.Add (new ContentPage {
//				Title = "Blue and Red",
//				Content = new StackLayout {
//					Children = {
//						new BoxView { Color = Color.Blue },
//						new BoxView { Color = Color.Red}
//					}
//				}
//			});

			Color[] colors = { Color.Blue, Color.Olive, Color.Red,Color.Gray,Color.Pink };
			for (int i = 0; i < 4; i++) {
				this.Children.Add (new ContentPage () {
					BackgroundColor = colors[i],
					Title = string.Format ("Tab{0}", i+1),
					Content = new StackLayout () {
						Orientation = StackOrientation.Vertical,
						VerticalOptions = LayoutOptions.Center,
						HorizontalOptions = LayoutOptions.Center,
						//BackgroundColor = colors[i],
						Children = {
							new Label () {
								Text = string.Format ("Tab page{0}", i+1),
							},
							new Label () {
								Text = string.Format ("Tab page{0}", i+1),
							}
						}
					}
				});

		
			}
//			this.Children.Add (new MyTab1Page ());
//			this.Children.Add (new MyTab2Page ());
//			this.Children.Add (new MyTab3Page ());
//			this.Children.Add (new MyTab4Page ());
		
		}
	}
}


