using System;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// ProjectCustomEntityIndexAttributeModel Struct.
    /// </summary>
    public struct ProjectCustomEntityIndexAttributeModel
    { 
        public string Type { get; }

        public string Name { get; }

        public ProjectCustomEntityIndexAttributeModel(
            string Type, 
            string Name)
        {
            this.Type = Type;
            this.Name = Name;
        }
    }
}