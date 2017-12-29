using System;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// ProjectContextModel Struct.
    /// </summary>
    public struct ProjectContextModel
    { 
        public string Name { get; }

        public ProjectContextModel(string Name){
            this.Name = Name;
        }
    }
}