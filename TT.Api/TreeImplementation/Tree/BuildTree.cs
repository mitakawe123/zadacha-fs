﻿using System.Collections.Generic;

namespace TT.Api.TreeImplementation.Tree
{
    public class BuildTree
    {
        public List<Node> BuildTreeMethod(List<Node> nodes)
        {
            Node rootNode = new Node(0, nodes[0].Name, nodes[0].RecursionLevel);
            Dictionary<int, Node> recursionIdTracker = new Dictionary<int, Node>();

            foreach (Node node in nodes)
                if (!recursionIdTracker.ContainsKey(node.RecursionId))
                    recursionIdTracker.Add(node.RecursionId, node);

            foreach (Node node in nodes)
            {
                if (node.RecursionLevel == 0) 
                    rootNode.Children.Add(node);
                else if (recursionIdTracker.TryGetValue(node.RecursionLevel, out Node parentNode))
                        parentNode.Children.Add(node);
            }

            return rootNode.Children;
        }
    }
}
