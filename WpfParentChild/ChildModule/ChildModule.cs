using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using ParentChildService;

namespace ChildModule
{
    public class ChildModule : IModule
    {
        private readonly IRegionViewRegistry _regionViewRegistry;
        private readonly IParentChildService _parentChildService;

        public ChildModule(IRegionViewRegistry registry, IParentChildService parentChildService)
        {
            this._regionViewRegistry = registry;
            this._parentChildService = parentChildService;
            
        }

        public void Initialize()
        {
            _regionViewRegistry.RegisterViewWithRegion("Child", typeof(View.ChildView));
        }
    }
}
