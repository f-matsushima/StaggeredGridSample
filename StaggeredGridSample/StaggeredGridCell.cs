using Xamarin.Forms;

namespace StaggeredGridSample
{
	public class StaggeredGridCell : ViewCell
	{
		public static readonly BindableProperty RatioProperty = BindableProperty.Create("Ratio", typeof(double), typeof(StaggeredGridCell), 1.0);

		public double Ratio
		{
			get
			{
				return (double)GetValue(RatioProperty);
			}
			set
			{
				SetValue(RatioProperty, value);
			}
		}
	}
}
