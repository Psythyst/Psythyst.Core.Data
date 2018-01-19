using System;
using System.Collections.Generic;

namespace Psythyst.Data.Entitas
{
    /// <summary>
    /// ProjectModel Struct.
    /// </summary>
    public struct ProjectModel
    { 
        public ContextModel[] Context;

        public ComponentModel[] Component;

        public CustomEntityIndexModel[] CustomEntityIndex;

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