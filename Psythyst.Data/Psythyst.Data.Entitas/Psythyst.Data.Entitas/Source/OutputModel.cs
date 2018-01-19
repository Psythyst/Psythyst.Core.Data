namespace Psythyst.Data.Entitas
{
    /// <summary>
    /// OutputModel Struct.
    /// </summary>
    public struct OutputModel
    { 
        public string FilePath;

        public string FileContent;

        public OutputModel(string FilePath, string FileContent)
        {
            this.FilePath = FilePath;
            this.FileContent = FileContent;
        }
    }
}