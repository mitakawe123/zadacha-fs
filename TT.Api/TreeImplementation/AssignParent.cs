using TT.Api.TreeImplementation.Tree;

namespace TT.Api.TreeImplementation
{
    public class AssignParent
    {
        public void AssignParentToChildren(Node node, string parent)
        {
            node.Parent = parent;
            foreach (var child in node.Children)
            {
                AssignParentToChildren(child, node.PropertyName);
            }
        }
    }
}
