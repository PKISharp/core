namespace ACMESharp.Ext
{
    public struct ExtInfo
    {
        public ExtInfo(string name, string label = null, string description = null)
        {
            Name = name;
            Label = label;
            Description = description;
        }

        public string Name
        { get; private set; }

        public string Label
        { get; private set; }

        public string Description
        { get; private set; }
    }
}