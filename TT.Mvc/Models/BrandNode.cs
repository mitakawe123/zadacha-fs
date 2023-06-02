using System.Collections.Generic;

namespace TT.Mvc.Models
{
    public class BrandNode
    {
        public string BrandName { get; }
        public string ProductCode { get; }
        public int BrandId { get; }
        public int RecursionId { get; }
        public string PropertyName { get; }
        public string ProductName { get; }
        public string ProductValue { get; }
        public int RecursionLevel { get; }

        public string Parent { get; }
        public List<BrandNode> Children { get; set; }

        public BrandNode()
        {
            Children = new List<BrandNode>();
        }
    }
}
