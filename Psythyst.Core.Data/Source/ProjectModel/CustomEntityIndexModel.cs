using System;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// CustomEntityIndexModel Struct.
    /// </summary>
    public struct CustomEntityIndexModel
    { 
        public string EntityIndexMethod { get; }

        public string Context { get; }

        public EntityIndexType EntityIndexParentType { get; }

        public string EntityIndexType { get; }

        public CustomEntityIndexMemberModel[] Member { get; }

        public CustomEntityIndexModel(
            string EntityIndexMethod,
            string Context,
            EntityIndexType EntityIndexParentType,
            string EntityIndexType,
            CustomEntityIndexMemberModel[] Member)
        {
            this.EntityIndexMethod = EntityIndexMethod;
            this.Context = Context;
            this.EntityIndexParentType = EntityIndexParentType;
            this.EntityIndexType = EntityIndexType;
            this.Member = Member;
        }
    }
}