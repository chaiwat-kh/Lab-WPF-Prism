using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace ParentModule
{
    public class ParentModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;

        public ParentModule(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;   
        }

        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion("Parent", typeof(View.ParentView));
        }
    }
}
