using System.Collections.Generic;
using TT.Api.TreeImplementation.Tree;

namespace TT.Api.TreeImplementation
{
    public class BuildProducts
    {
        private Node rootNode;
        private Node newRootNode;

        public BuildProducts(Node root)
        {
            rootNode = root;
            newRootNode = new Node(rootNode.BrandName,rootNode.ProductCode,rootNode.BrandId,rootNode.PropertyName,rootNode.ProductName);
        }

        public Node TraverseAndPush()
        {
            TraverseAndPushNode(rootNode, newRootNode);
            return newRootNode;
        }

        private void TraverseAndPushNode(Node currentNode, Node newCurrentNode)
        {
            var existingNode = newCurrentNode.Children.Find(node => node.ProductCode == currentNode.ProductCode);
            if (existingNode != null)
                existingNode.PropsProd.Add(new KeyValuePair<string, string>(currentNode.PropertyName, currentNode.ProductValue));
            else
            {
                Node newNode = new Node(currentNode.BrandName,currentNode.ProductCode,currentNode.BrandId,currentNode.PropertyName,currentNode.PropertyName);
                newCurrentNode.Children.Add(newNode);
            }

            foreach (var childNode in currentNode.Children)
                TraverseAndPushNode(childNode, newCurrentNode);
        }
    }
}
