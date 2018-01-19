using System;

namespace Psythyst.Data.Entitas
{
    /// <summary>
    /// ComponentMemberModel Struct.
    /// </summary>
    public struct ComponentMemberModel
    { 
        public string Type;

        public string Name;

        public EntityIndexType EntityIndex;

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