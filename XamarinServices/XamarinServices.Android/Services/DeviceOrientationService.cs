using Android.Content;
using Android.Runtime;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XamarinServices.Services;

[assembly: Dependency(typeof(XamarinServices.Droid.DeviceOrientationService))]

namespace XamarinServices.Droid
{
    class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = orientation == SurfaceOrientation.Rotation90 || orientation == SurfaceOrientation.Rotation270;
            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}