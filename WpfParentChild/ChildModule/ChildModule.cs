using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace ChildModule
{
    public class ChildModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;

        public ChildModule(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;   
        }

        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion("Child", typeof(View.ChildView));
        }
    }
}
