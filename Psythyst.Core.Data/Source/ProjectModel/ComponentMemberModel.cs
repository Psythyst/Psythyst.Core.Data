using System;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// ComponentMemberModel Struct.
    /// </summary>
    public struct ComponentMemberModel
    { 
        public string Type { get; }

        public string Name { get; }

        public EntityIndexType EntityIndex { get; }

        public ComponentMemberModel(
            string Type, 
            string Name, 
            EntityIndexType EntityIndex)
        {
            this.Type = Type;
            this.Name = Name;
            this.EntityIndex = EntityIndex;
        }
    }
}