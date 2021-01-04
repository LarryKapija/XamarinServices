using XamarinServices.Services;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.Threading.Tasks;

namespace XamarinServices.ViewModels
{
    public class DependencyViewModel : BaseViewModel
    {



        public DependencyViewModel(INavigationService navigationService) : base(navigationService)
        {
            OrientationCommand = new DelegateCommand( () =>
            {

                POrientation = OrientationTask();
            });
        }

        public string pOrientation;
        public string POrientation 
        {
            get 
            {
                return pOrientation;
            }
            set 
            {
                pOrientation = value;
                NotifyPropertyChanged(nameof(POrientation));
            }
        }

        public ICommand OrientationCommand { get; }

        public string OrientationTask()
        {
            IDeviceOrientationService service = DependencyService.Get<IDeviceOrientationService>();
            DeviceOrientation orientation = service.GetOrientation();
            return orientation.ToString();
        }
        
    }
}
