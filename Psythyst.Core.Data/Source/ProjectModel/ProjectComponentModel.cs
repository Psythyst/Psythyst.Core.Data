using System;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// ProjectComponentModel Struct.
    /// </summary>
    public struct ProjectComponentModel
    { 
        public string Name { get; }

        public string[] Context { get; }

        public string UniquePrefix { get; }
        
        public bool Unique { get; }

        public ProjectComponentAttributeModel[] Attribute { get; }

        public ProjectComponentModel(
            string Name, 
            string[] Context, 
            string UniquePrefix, 
            bool Unique, 
            ProjectComponentAttributeModel[] Attribute)
        {
            this.Name = Name;
            this.Context = Context;
            this.UniquePrefix = UniquePrefix;
            this.Unique = Unique;
            this.Attribute = Attribute;
        }
    }
}