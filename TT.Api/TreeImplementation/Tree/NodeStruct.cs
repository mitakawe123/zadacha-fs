namespace TT.Api.TreeImplementation.Tree
{
    public readonly struct NodeStruct
    {
        public int RecursionId { get; }
        public int RecursionLevel { get; }
        public string Name { get; }
        public string ProductName { get; }
        public string ProductCode { get; }
        public string ProductValue { get; }

        public NodeStruct(int recursionId, int recursionLevel, string name, string productName, string productCode, string productValue)
        {
            RecursionId = recursionId;
            RecursionLevel = recursionLevel;
            Name = name;
            ProductName = productName;
            ProductCode = productCode;
            ProductValue = productValue;
        }
    }
}
