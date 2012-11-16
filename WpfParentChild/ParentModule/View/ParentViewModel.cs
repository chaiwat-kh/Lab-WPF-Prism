using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParentModule.Model;
using Microsoft.Practices.Prism.Commands;
using System.Windows;

namespace ParentModule.View
{
    public class ParentViewModel
    {
        private readonly Parent parent;

        public ParentViewModel()
        {
            this.parent = new Parent { Name = "Bon", Age = 27 };

            GetValueCommand = new DelegateCommand<object>(this.GetValue);
        }

        public Parent Parent
        {
            get { return this.parent; }
        }

        public DelegateCommand<object> GetValueCommand { get; private set; }
        private void GetValue(object obj)
        {
            MessageBox.Show(this.BuildResultString());
            // Save the order here.
        }
        private string BuildResultString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Name: ");
            builder.Append(this.parent.Name);
            builder.Append("\nAge: ");
            builder.Append(this.parent.Age);
            return builder.ToString();
        }
    }
}
