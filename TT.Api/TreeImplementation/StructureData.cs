using System.Collections.Generic;
using System.Linq;
using TT.Api.TreeImplementation.Tree;

namespace TT.Api.TreeImplementation
{
    public class StructureData
    {
        public List<Node> StructureDataMethod(List<Node> tree)
        {
            List<Node> result = new List<Node>();

            for(int i = 0;i < tree.Count;i++)
            {
                for(int j = 0;j < tree.Count;j++)
                {
                    if (tree[i].ProductCode == tree[j].ProductCode)
                    {
                        //tree[i].ProductValue += tree[j].ProductValue;
                    }
                }
            }

            result.AddRange(tree);
            
            return result;
        }
    }
}
