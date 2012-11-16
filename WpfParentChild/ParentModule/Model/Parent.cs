using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ParentModule.Model
{
    public class Parent : INotifyPropertyChanged
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
