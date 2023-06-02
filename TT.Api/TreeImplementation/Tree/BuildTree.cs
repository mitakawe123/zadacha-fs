using System.Collections.Generic;

namespace TT.Api.TreeImplementation.Tree
{
    public class BuildTree
    {
        public Node BuildTreeMethod(List<Node> nodes)
        {
            Dictionary<int, List<Node>> nodeDict = new Dictionary<int, List<Node>>();
            Node rootNode = nodes[0];

            foreach (Node node in nodes)
            {
                if (!nodeDict.ContainsKey(node.ParentId))
                    nodeDict[node.ParentId] = new List<Node>();

                nodeDict[node.ParentId].Add(node);
            }

            AssignChildren(rootNode, nodeDict);

            return rootNode;
        }

        private void AssignChildren(Node node, Dictionary<int, List<Node>> nodeDict)
        {
            if (nodeDict.ContainsKey(node.RecursionId))
            {
                List<Node> children = nodeDict[node.RecursionId];
                node.Children.AddRange(children);

                foreach (Node child in children)
                {
                    AssignChildren(child, nodeDict);
                }
            }
        }
    }
}
