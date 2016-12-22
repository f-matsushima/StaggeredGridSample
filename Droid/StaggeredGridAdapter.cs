using Android.Support.V7.Widget;
using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace StaggeredGridSample.Droid
{
	public class StaggeredGridAdapter : RecyclerView.Adapter
	{
		Context _context;
		StaggeredGridView _gridView;

		ITemplatedItemsView<Cell> TemplatedItemsView => _gridView;

		public StaggeredGridAdapter(Context context, StaggeredGridView gridView)
		{
			_context = context;
			_gridView = gridView;
		}

		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			var cell = _gridView.ItemTemplate.CreateContent() as Cell;
			var view = CellFactory.GetCell(cell, null, parent, _context, _gridView);

			return new StaggeredGridCellHolder(view);
		}

		public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
		{
			if (holder is StaggeredGridCellHolder)
			{
				Cell cell = ((StaggeredGridCellHolder)holder).Cell;
				TemplatedItemsView.TemplatedItems.UpdateContent(cell, position);
			}
		}

		public override int ItemCount
		{
			get
			{
				return TemplatedItemsView.TemplatedItems.Count;
			}
		}
	}
}
