using System.Collections.Generic;

namespace TT.Api.TreeImplementation.Tree
{
    public class Node
    {
        private readonly List<Node> _children = new List<Node>();
        public IReadOnlyList<Node> Children => _children;
        public List<KeyValuePair<string, string>> PropsProd { get; }
        
        public string BrandName { get; }
        public string ProductCode { get; }
        public int BrandId { get; }
        public int RecursionId { get; }
        public int ParentId { get; }
        public string PropertyName { get; }
        public string ProductName { get; }
        public string ProductValue { get; }
        public int RecursionLevel { get; }
        public string Parent { get; set; }

        private Node(string brandName, string productCode, int brandId, string propertyName, string productName)
        {
            BrandName = brandName;
            ProductCode = productCode;
            BrandId = brandId;
            PropertyName = propertyName;
            ProductName = productName;
        }

        public Node(string brandName, string productCode, int brandId, int recursionId, int parentId, string propertyName, string productName, string productValue, int recursionLevel) :
            this(brandName, productCode, brandId, propertyName, productName)
        {
            RecursionId = recursionId;
            ParentId = parentId;
            ProductValue = productValue;
            RecursionLevel = recursionLevel;
        }

        public Node(string brandName, string productCode, int brandId, string propertyName, string productName, string parent) :
            this(brandName, productCode, brandId, propertyName, productName)
        {
            Parent = parent;
            PropsProd = new List<KeyValuePair<string, string>>();
        }

        public void AddChild(Node node) => _children.Add(node);

        public void AddChildren(IEnumerable<Node> nodes) => _children.AddRange(nodes);
    }
}
