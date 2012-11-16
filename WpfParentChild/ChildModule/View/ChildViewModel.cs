using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.ViewModel;


namespace ChildModule.View
{
    [Export]
    public class ChildViewModel : NotificationObject
    {
        public ChildViewModel()
        {
            Name = "Bon";
        }

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
        
    }
}
