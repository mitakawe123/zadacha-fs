using System.Collections.Generic;

namespace TT.Api.TreeImplementation.Tree
{
    public class Node
    {
        public string BrandName { get; }
        public string ProductCode { get; }
        public int BrandId { get; }
        public int RecursionId { get; }
        public int ParentId { get; }
        public string PropertyName { get; set; }
        public string ProductName { get; }
        public string ProductValue { get; set; }
        public int RecursionLevel { get; }
        public List<Node> Children { get; }
        public List<KeyValuePair<string, string>> PropsProd { get; }

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

        public Node (string brandName,string productCode,int brandId,string propertyName, string productName)
        {
            BrandName = brandName;
            ProductCode = productCode;
            BrandId = brandId;
            PropertyName = propertyName;
            ProductName = productName;
            Children = new List<Node>();
            PropsProd = new List<KeyValuePair<string, string>>();
        }
    }
}
