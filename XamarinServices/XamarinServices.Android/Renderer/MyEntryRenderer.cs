using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinServices.Droid.Renderer;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
namespace XamarinServices.Droid.Renderer
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.AliceBlue);
                Control.SetElevation(40);
                Control.SetShadowLayer(40, 10, 5, Android.Graphics.Color.Black);
            }
        }

    }
}