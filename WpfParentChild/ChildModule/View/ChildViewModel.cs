using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.ViewModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System.Windows.Forms;
using ParentChildService;

namespace ChildModule.ViewModel
{
    //[Export(typeof(ChildViewModel))]
    public class ChildViewModel : NotificationObject
    {
        private IParentChildService _parentChildService;

        //[ImportingConstructor]
        public ChildViewModel(IParentChildService parentChildService)
        {
            if (parentChildService == null)
            {
                throw new ArgumentNullException("parentChildService");
            }

            Name = "Bon";
            this.SubmitCommand = new DelegateCommand<object>(this.OnSubmit);
            this.AddressViewModel = new AddressViewModel();

            this._parentChildService = parentChildService;
        }

        public AddressViewModel AddressViewModel { get; private set; }
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public ICommand SubmitCommand { get; private set; }
        private void OnSubmit(object obj)
        {
            MessageBox.Show(_parentChildService.Test());
        }
    }
}
