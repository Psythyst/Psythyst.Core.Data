using System;

namespace Psythyst.Data.Entitas
{
    /// <summary>
    /// ComponentModel Struct.
    /// </summary>
    public struct ComponentModel
    { 
        public string Name;

        public string[] Context;

        public string UniquePrefix;
        
        public bool Unique;

        public ComponentMemberModel[] Member;

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