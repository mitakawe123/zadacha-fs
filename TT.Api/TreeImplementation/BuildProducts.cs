using System.Collections.Generic;
using System.Linq;
using TT.Api.TreeImplementation.Tree;

namespace TT.Api.TreeImplementation
{
    public class BuildProducts
    {
        private readonly Node rootNode;
        private readonly Node newRootNode;

        public BuildProducts(Node root)
        {
            rootNode = root;
            newRootNode = new Node(rootNode.BrandName,rootNode.ProductCode,rootNode.BrandId,rootNode.PropertyName,rootNode.ProductName,rootNode.Parent);
        }

        public Node TraverseAndPush()
        {
            TraverseAndPushNode(rootNode, newRootNode);
            return newRootNode;
        }

        private void TraverseAndPushNode(Node currentNode, Node newCurrentNode)
        {
            Node existingNode = newCurrentNode.Children.FirstOrDefault(node => node.ProductCode == currentNode.ProductCode);
            if (existingNode == null)
            {
                Node newNode = new Node(currentNode.BrandName, currentNode.ProductCode, currentNode.BrandId, currentNode.PropertyName, currentNode.PropertyName, currentNode.Parent);
                newCurrentNode.AddChild(newNode);
            }
            else
                existingNode.PropsProd.Add(new KeyValuePair<string, string>(currentNode.PropertyName, currentNode.ProductValue));

            foreach (Node childNode in currentNode.Children)
                TraverseAndPushNode(childNode, newCurrentNode);
        }
    }
}
