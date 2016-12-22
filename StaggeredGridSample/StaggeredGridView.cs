using Xamarin.Forms;

namespace StaggeredGridSample
{
	public class StaggeredGridView : ListView
	{
		public static readonly BindableProperty RowSpacingProperty = BindableProperty.Create("RowSpacing", typeof(double), typeof(StaggeredGridView), 0.0);

		public double RowSpacing
		{
			get
			{
				return (double)GetValue(RowSpacingProperty);
			}
			set
			{
				SetValue(RowSpacingProperty, value);
			}
		}

		public static readonly BindableProperty ColumnSpacingProperty = BindableProperty.Create("ColumnSpacing", typeof(double), typeof(StaggeredGridView), 0.0);

		public double ColumnSpacing
		{
			get
			{
				return (double)GetValue(ColumnSpacingProperty);
			}
			set
			{
				SetValue(ColumnSpacingProperty, value);
			}
		}

		public static readonly BindableProperty SpanCountProperty = BindableProperty.Create("SpanCount", typeof(int), typeof(StaggeredGridView), 2);

		public int SpanCount
		{
			get
			{
				return (int)GetValue(SpanCountProperty);
			}
			set
			{
				SetValue(SpanCountProperty, value);
			}
		}
	}
}
