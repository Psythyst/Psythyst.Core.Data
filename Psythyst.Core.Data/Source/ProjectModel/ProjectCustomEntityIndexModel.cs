using System;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// ProjectCustomEntityIndexModel Struct.
    /// </summary>
    public struct ProjectCustomEntityIndexModel
    { 
        public string EntityIndexMethod { get; }

        public string Context { get; }

        public ProjectEntityIndexType EntityIndexParentType { get; }

        public string EntityIndexType { get; }

        public ProjectCustomEntityIndexAttributeModel[] Attribute { get; }

        public ProjectCustomEntityIndexModel(
            string EntityIndexMethod,
            string Context,
            ProjectEntityIndexType EntityIndexParentType,
            string EntityIndexType,
            ProjectCustomEntityIndexAttributeModel[] Attribute)
        {
            this.EntityIndexMethod = EntityIndexMethod;
            this.Context = Context;
            this.EntityIndexParentType = EntityIndexParentType;
            this.EntityIndexType = EntityIndexType;
            this.Attribute = Attribute;
        }
    }
}