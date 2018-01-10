using System;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// ComponentModel Struct.
    /// </summary>
    public struct ComponentModel
    { 
        public string Name { get; }

        public string[] Context { get; }

        public string UniquePrefix { get; }
        
        public bool Unique { get; }

        public ComponentMemberModel[] Member { get; }

        public ComponentModel(
            string Name, 
            string[] Context, 
            string UniquePrefix, 
            bool Unique, 
            ComponentMemberModel[] Member)
        {
            this.Name = Name;
            this.Context = Context;
            this.UniquePrefix = UniquePrefix;
            this.Unique = Unique;
            this.Member = Member;
        }
    }
}