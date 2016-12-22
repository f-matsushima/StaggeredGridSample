using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using StaggeredGridSample;
using StaggeredGridSample.Droid;
using AView = Android.Views.View;

[assembly: ExportRenderer(typeof(StaggeredGridCell), typeof(StaggeredGridCellRenderer))]
namespace StaggeredGridSample.Droid
{
	public class StaggeredGridCellRenderer : CellRenderer
	{
		protected override AView GetCellCore(Cell item, AView convertView, ViewGroup parent, Context context)
		{
			var cell = (StaggeredGridCell)item;
			IVisualElementRenderer renderer = Platform.CreateRenderer(cell.View);
			Platform.SetRenderer(cell.View, renderer);
			return new StaggeredGridCellContainer(context, renderer, cell, (StaggeredGridView)ParentView);
		}
	}

	class StaggeredGridCellContainer : ViewGroup, INativeElementView
	{
		StaggeredGridView _parent;
		IVisualElementRenderer _view;
		StaggeredGridCell _cell;

		public StaggeredGridCellContainer(Context context, IVisualElementRenderer view, StaggeredGridCell cell, StaggeredGridView parent) : base(context)
		{
			_view = view;
			_cell = cell;
			_parent = parent;
			AddView(view.ViewGroup);
		}

		public Element Element
		{
			get { return _cell; }
		}

		protected override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			double width = Context.FromPixels(r - l);
			double height = Context.FromPixels(b - t);

			Xamarin.Forms.Layout.LayoutChildIntoBoundingRegion(_view.Element, new Rectangle(0, 0, width, height));

			_view.UpdateLayout();
		}

		protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			int width = MeasureSpec.GetSize(widthMeasureSpec);
			int height = (int)(width * _cell.Ratio);

			SetMeasuredDimension(width, height);
		}
	}
}
