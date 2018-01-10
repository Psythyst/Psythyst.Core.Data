using System;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// CustomEntityIndexMemberModel Struct.
    /// </summary>
    public struct CustomEntityIndexMemberModel
    { 
        public string Type { get; }

        public string Name { get; }

        public CustomEntityIndexMemberModel(
            string Type, 
            string Name)
        {
            this.Type = Type;
            this.Name = Name;
        }
    }
}