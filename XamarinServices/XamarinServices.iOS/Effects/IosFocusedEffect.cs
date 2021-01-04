using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinServices.iOS.Effects;

[assembly: ResolutionGroupName("Larry's")]
[assembly: ExportEffect(typeof(IosFocusedEffect), "FocusEffect")]
namespace XamarinServices.iOS.Effects
{
    class IosFocusedEffect : PlatformEffect
    {
        //Atributes:
        UIColor backgroundColor;

        //Methods:
        #region OnAttached
        protected override void OnAttached()
        {
            try
            {
                Control.BackgroundColor = backgroundColor = UIColor.FromRGB(66, 255, 155);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
        #endregion

        #region OnDetached
        protected override void OnDetached()
        {

        }
        #endregion

        #region OnElementPropertyChanged
        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);


            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (Control.BackgroundColor == backgroundColor)
                    {
                        Control.BackgroundColor = UIColor.White;
                    }
                    else
                    {
                        Control.BackgroundColor = backgroundColor;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", error.Message);

            }
        }
        #endregion
    }
}