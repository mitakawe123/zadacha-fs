using System.Collections.Generic;

namespace TT.Api.TreeImplementation.Tree
{
    public class Node
    {
        public List<Node> Children { get; set; }
        public int RecursionId { get; set; }
        public string Name { get; set; }
        public int RecursionLevel { get; set; }

        //values to show to the user
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductValue { get; set; }

        public Node()
        {
            Children = new List<Node>();
        }

        public Node(int RecursionId, string Name, int RecursionLevel)
        {
            this.RecursionId = RecursionId;
            this.Name = Name;
            this.RecursionLevel = RecursionLevel;
            Children = new List<Node>();
        }
    }
}
