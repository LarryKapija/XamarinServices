using Prism.Navigation;
using System;
using System.ComponentModel;

namespace XamarinServices.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
 
        protected INavigationService NavigationService { get; }



        protected BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }



        /// <summary> 
        /// It implement the Invoke method from 
        /// PropertyChanged in the subclasses.
        /// </summary>
        /// <param name="propertyName">
        /// I usually use nameof(ThisProperty)
        /// </param>
        protected void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
