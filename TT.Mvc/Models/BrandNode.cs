using System.Collections.Generic;

namespace TT.Mvc.Models
{
    public class BrandNode
    {
        public string BrandName { get; }
        public string ProductCode { get; }
        public int BrandId { get; }
        public int RecursionId { get; }
        public int ParentId { get; }
        public string PropertyName { get;  }
        public string ProductName { get; }
        public string ProductValue { get; }
        public int RecursionLevel { get; }
        
        public List<BrandNode> Children { get; }
        public List<KeyValuePair<string, string>> PropsProd { get; }

        public BrandNode(string brandName, string productCode, int brandId, int recursionId, int parentId, string propertyName, string productName, string productValue, int recursionLevel)
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

            Children = new List<BrandNode>();
            PropsProd = new List<KeyValuePair<string, string>>();
        }
    }
}
