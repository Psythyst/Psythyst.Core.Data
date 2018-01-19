using System;

namespace Psythyst.Data.Entitas
{
    /// <summary>
    /// CustomEntityIndexMemberModel Struct.
    /// </summary>
    public struct CustomEntityIndexMemberModel
    { 
        public string Type;

        public string Name;

        public CustomEntityIndexMemberModel(
            string Type, 
            string Name)
        {
            this.Type = Type;
            this.Name = Name;
        }
    }
}