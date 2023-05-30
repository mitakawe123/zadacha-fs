using System.Collections.Generic;

namespace TT.Mvc.Models
{
    public class BrandNode
    {
        public List<BrandNode> Children { get; set; }
        public int RecursionId { get; set; }
        public string Name { get; set; }
        public int RecursionLevel { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductValue { get; set; }

        public BrandNode()
        {
            Children = new List<BrandNode>();
        }
    }
}
