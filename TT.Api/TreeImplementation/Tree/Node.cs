using System.Collections.Generic;
using TT.Lib.Entities;

namespace TT.Api.TreeImplementation.Tree
{
    public class Node
    {
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
        public List<Node> Children { get; }

        public Node(string brandName, string productCode, int brandId, int recursionId, int parentId, string propertyName, string productName, string productValue, int recursionLevel)
        {
            BrandName = brandName;
            ProductCode = productCode;
            BrandId = brandId;
            RecursionId = recursionId;
            ParentId = parentId;
            PropertyName = propertyName;
            ProductName = productName;
            ProductValue = productValue;
            RecursionLevel = recursionLevel;
            Children = new List<Node>();
        }
    }
}
