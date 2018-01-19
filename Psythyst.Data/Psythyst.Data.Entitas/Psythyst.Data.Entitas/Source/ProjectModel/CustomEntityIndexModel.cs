using System;

namespace Psythyst.Data.Entitas
{
    /// <summary>
    /// CustomEntityIndexModel Struct.
    /// </summary>
    public struct CustomEntityIndexModel
    { 
        public string EntityIndexMethod;

        public string Context;

        public EntityIndexType EntityIndexParentType;

        public string EntityIndexType;

        public CustomEntityIndexMemberModel[] Member;

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