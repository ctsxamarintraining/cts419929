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



		//	List<ContentPage> pages = new List<ContentPage> (0);
			Color[] colors = { Color.Olive, Color.Purple, Color.Blue,Color.Gray,Color.Green };
//			foreach (Color color in colors) {
//				pages.Add (new ContentPage { Content = new StackLayout {
//						Children = {
//							//BackgroundColor = c,
//							//new Label { Text = "Hi"},
//							//new Label { Text = "coursel"},
//							new BoxView {
//								Color = color,
//								VerticalOptions = LayoutOptions.FillAndExpand,
//								new Label () {
//									Text = string.Format ("Tab page"),
//								}	
//							},
//						
//						}
//					}
//				});
//			}
//				
//			this.Children.Add (pages[0]);
//			this.Children.Add (pages[1]);
//			this.Children.Add (pages[2]);
//			this.Children.Add (pages[3]);
//			this.Children.Add (pages[4]);


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


