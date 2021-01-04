using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinServices.Constants;
using XamarinServices.ViewModels;
using XamarinServices.Views;

namespace XamarinServices
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
            InitializeComponent( );
        }

        protected override async void OnInitialized()
        {
            await NavigationService.NavigateAsync(Pages.Tabbed);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MyTabbedPage>(Pages.Tabbed);
            containerRegistry.RegisterForNavigation<DependencyPage, DependencyViewModel>(Pages.Dependency);
            containerRegistry.RegisterForNavigation<RendererPage,RendererViewModel>(Pages.Renderer);
            containerRegistry.RegisterForNavigation<EffectPage, EffectViewModel>(Pages.Renderer);
        }
    }
}
