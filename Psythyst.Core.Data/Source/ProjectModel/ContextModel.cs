using System;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// ContextModel Struct.
    /// </summary>
    public struct ContextModel
    { 
        public string Name { get; }

        public ContextModel(string Name){
            this.Name = Name;
        }
    }
}