using Android.Support.V7.Widget;
using Xamarin.Forms;
using AView = Android.Views.View;

namespace StaggeredGridSample.Droid
{
	public class StaggeredGridCellHolder : RecyclerView.ViewHolder
	{
		Cell _cell;

		public StaggeredGridCellHolder(AView view) : base(view)
		{
			_cell = (view as INativeElementView).Element as Cell;
		}

		public Cell Cell
		{
			get
			{
				return _cell;
			}
		}
	}
}
