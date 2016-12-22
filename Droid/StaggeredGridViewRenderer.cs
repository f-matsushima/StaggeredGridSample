using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Support.V7.Widget;
using StaggeredGridSample;
using StaggeredGridSample.Droid;

[assembly: ExportRenderer(typeof(StaggeredGridView), typeof(StaggeredGridViewRenderer))]
namespace StaggeredGridSample.Droid
{
	public class StaggeredGridViewRenderer : ViewRenderer<StaggeredGridView, RecyclerView>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<StaggeredGridView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
				var contex = Forms.Context;
				var nativeControl = new RecyclerView(contex);

				int padding = (int)Element.ColumnSpacing / 2;
				nativeControl.SetPadding(padding, 0, padding, 0);

				var sglm = new StaggeredGridLayoutManager(Element.SpanCount, StaggeredGridLayoutManager.Vertical);
				var adapter = new StaggeredGridAdapter(contex, Element);
				var decoration = new SpacesItemDecoration((int)Element.RowSpacing, padding);

				nativeControl.SetLayoutManager(sglm);
				nativeControl.SetAdapter(adapter);
				nativeControl.AddItemDecoration(decoration);

				SetNativeControl(nativeControl);
			}
		}
	}
}
