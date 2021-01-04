using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinServices.Droid.Effects;

[assembly: ResolutionGroupName("Larry's")]
[assembly: ExportEffect(typeof(AndroidFocusedEffect), "FocusedEffect")]
namespace XamarinServices.Droid.Effects
{
    class AndroidFocusedEffect : PlatformEffect 
    {

        Android.Graphics.Color originalBackgroundColor = new Android.Graphics.Color(66,255,155);
        Android.Graphics.Color backgroundColor;

        protected override void OnAttached()
        {
            try
            {
                backgroundColor = Android.Graphics.Color.AliceBlue;
                Control.SetBackgroundColor(backgroundColor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == backgroundColor)
                    {
                        Control.SetBackgroundColor(originalBackgroundColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(backgroundColor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}
