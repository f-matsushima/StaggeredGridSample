using Android.Support.V7.Widget;
using Android.Graphics;
using Android.Views;

namespace StaggeredGridSample.Droid
{
	public class SpacesItemDecoration : RecyclerView.ItemDecoration
	{
		int _rowSpace;
		int _colSpace;

		public SpacesItemDecoration(int rowSpace, int colSpace)
		{
			_rowSpace = rowSpace;
			_colSpace = colSpace;
		}

		public override void GetItemOffsets(Rect outRect, View view, RecyclerView parent, RecyclerView.State state)
		{
			outRect.Left = _colSpace;
			outRect.Right = _colSpace;
			outRect.Bottom = _rowSpace;
		}
	}
}
