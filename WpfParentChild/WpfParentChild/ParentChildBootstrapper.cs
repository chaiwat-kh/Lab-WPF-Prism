using System;
using System.Windows;

using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Logging;
using ParentChildService;
using Microsoft.Practices.Unity;
using ChildModule.ViewModel;


namespace WpfParentChild
{
    public class ParentChildBootstrapper : UnityBootstrapper
    {
        private readonly CallbackLogger callbackLogger = new CallbackLogger();

        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindow>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();            
        }

        protected override ILoggerFacade CreateLogger()
        {
            return this.callbackLogger;
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            //this.Container.RegisterType<ChildViewModel, ChildViewModel>(new ContainerControlledLifetimeManager());
            this.Container.RegisterType<IParentChildService, ParentChildService.ParentChildService>(new ContainerControlledLifetimeManager());
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            //moduleCatalog.AddModule(typeof(ChildModule.ChildModule));
            moduleCatalog.AddModule(typeof(ChildModule.ChildModule));

            moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(ParentModule.ParentModule));
        }
 

    }
}
