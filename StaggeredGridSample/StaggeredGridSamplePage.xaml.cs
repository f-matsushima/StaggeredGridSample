using Xamarin.Forms;

namespace StaggeredGridSample
{
	public partial class StaggeredGridSamplePage : ContentPage
	{
		public StaggeredGridSamplePage()
		{
			InitializeComponent();

			gridView.ItemsSource = Item.GetList();
		}
	}
}
