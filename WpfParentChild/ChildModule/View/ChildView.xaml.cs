using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel.Composition;
using ChildModule.ViewModel;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Practices.ServiceLocation;

namespace ChildModule.View
{
    /// <summary>
    /// Interaction logic for ChildView.xaml
    /// </summary>  
    [PartCreationPolicy(CreationPolicy.Shared)]
    public partial class ChildView : UserControl
    {
        public ChildView()
        {
            InitializeComponent();
            ViewModel = ServiceLocator.Current.GetInstance<ChildViewModel>();
        }

        //[Import]        
        public ChildViewModel ViewModel
        {
            set
            {
                this.DataContext = value;
            }
        }
    }
}
