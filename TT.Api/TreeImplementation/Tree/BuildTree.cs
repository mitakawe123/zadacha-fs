using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TT.Api.TreeImplementation.Tree
{
    public class BuildTree
    {
        public List<Node> BuildTreeMethod(List<Node> nodes)
        {
            Dictionary<int, List<Node>> nodeDict = new Dictionary<int, List<Node>>();
            foreach (Node node in nodes)
            {
                if (!nodeDict.ContainsKey(node.ParentId))
                    nodeDict[node.ParentId] = new List<Node>();

                nodeDict[node.ParentId].Add(node);
            }

            foreach (Node node in nodes)
            {
                if (nodeDict.ContainsKey(node.RecursionId))
                    node.Children.AddRange(nodeDict[node.RecursionId]);
            }

            return nodes;
        }
    }
}
