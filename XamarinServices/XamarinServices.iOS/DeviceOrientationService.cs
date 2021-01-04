using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XamarinServices.Services;

[assembly: Dependency(typeof(XamarinServices.iOS.DeviceOrientationService))]
namespace XamarinServices.iOS
{
    class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}