using System;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// ProjectComponentAttributeModel Struct.
    /// </summary>
    public struct ProjectComponentAttributeModel
    { 
        public string Type { get; }

        public string Name { get; }

        public ProjectEntityIndexType EntityIndex { get; }

        public ProjectComponentAttributeModel(
            string Type, 
            string Name, 
            ProjectEntityIndexType EntityIndex)
        {
            this.Type = Type;
            this.Name = Name;
            this.EntityIndex = EntityIndex;
        }
    }
}