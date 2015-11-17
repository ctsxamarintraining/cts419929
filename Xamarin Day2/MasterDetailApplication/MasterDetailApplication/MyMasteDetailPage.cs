using System;

using Xamarin.Forms;

namespace MasterDetailApplication
{
	public class MyMasteDetailPage : MasterDetailPage
	{
		public MyMasteDetailPage ()
		{


			Label header = new Label
			{
				Text = "MasterDetailPage",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};


			//Array[] menuItemsArray = new Array['content Page','Tabbed Page','Coursol Page'];

			String[] menuItemsArray = {"content Page","Tabbed Page","Coursel Page"};

			ListView listView = new ListView
			{
				ItemsSource = menuItemsArray
			};

			this.Master = new ContentPage
			{
				Title = header.Text,
				Content = new StackLayout
				{
					Children = 
					{
						header, 
						listView
					}
					}
			};



			listView.SelectedItem = menuItemsArray[0];

			this.Detail = new NavigationPage(new MyContentPage());
		
			listView.ItemSelected += (sender, args) =>
			{
				// Set the BindingContext of the detail page.
				this.Detail.BindingContext = args.SelectedItem;

				if(listView.SelectedItem.ToString()=="content Page"){
					this.Detail = new NavigationPage(new MyContentPage());
				}
				if(listView.SelectedItem.ToString()=="Tabbed Page"){
					this.Detail = new NavigationPage(new MyTabbedPage());
				}
				if(listView.SelectedItem.ToString()=="Coursel Page"){
					this.Detail = new NavigationPage(new MyCourselPage());
				}
				// Show the detail page.
				this.IsPresented = false;
			};
//			Content = new StackLayout { 
//				Children = {
//					//new Label { Text = "Hello ContentPage" }
//
//
//				}
//			};
		}
	}
}


