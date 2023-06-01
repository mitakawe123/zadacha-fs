using System.Collections.Generic;

namespace TT.Api.TreeImplementation.Tree
{
    public class Node
    {
        public List<Node> Children { get; } = new List<Node>();
        public int RecursionId { get; }
        public string Name { get; }
        public int RecursionLevel { get; }
        public string ProductName { get; }
        public string ProductCode { get; }
        public string ProductValue { get; }
        public string DirectParent { get; set; }

        public Node(int recursionId, string name, int recursionLevel, string productName, string productCode, string productValue)
        {
            RecursionId = recursionId;
            Name = name;
            RecursionLevel = recursionLevel;
            ProductName = productName;
            ProductCode = productCode;
            ProductValue = productValue;
        }
    }
}
