using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Unity;

namespace wpfmvvm
{
    class Bootstarpper:UnityBootstrapper
    {

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Views.MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType(typeof(object), typeof(Views.Viewa), "Viewa");
            Container.RegisterType(typeof(object), typeof(Views.Viewb), "Viewb");
        }
    }
}
