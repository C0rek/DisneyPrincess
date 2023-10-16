using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DisneyPrincess.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyListPageDetail : ContentPage
	{
		public MyListPageDetail (string Name, string Personality, string source)
		{
			InitializeComponent ();
			MyItemNameShow.Text = Name;
			MyPersonalityItemShow.Text = Personality;
            MyImageCall.Source = new UriImageSource()
			{
				Uri = new Uri(source)
			};
        }
	}
}