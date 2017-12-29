namespace Psythyst.Core.Data
{
    /// <summary>
    /// OutputModel Struct.
    /// </summary>
    public struct OutputModel
    { 
        public string FilePath { get; set; }

        public string FileContent { get; set; }

        public OutputModel(string FilePath, string FileContent)
        {
            this.FilePath = FilePath;
            this.FileContent = FileContent;
        }
    }
}