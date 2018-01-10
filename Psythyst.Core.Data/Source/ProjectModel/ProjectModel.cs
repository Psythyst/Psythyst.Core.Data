using System;
using System.Collections.Generic;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// ProjectModel Struct.
    /// </summary>
    public struct ProjectModel
    { 
        public ContextModel[] Context { get; }

        public ComponentModel[] Component { get; }

        public CustomEntityIndexModel[] CustomEntityIndex { get; }

        public ProjectModel (
            ContextModel[] Context, 
            ComponentModel[] Component,
            CustomEntityIndexModel[] CustomEntityIndex) {
                
            this.Context = Context;
            this.Component = Component;
            this.CustomEntityIndex = CustomEntityIndex;
        }
    }
}