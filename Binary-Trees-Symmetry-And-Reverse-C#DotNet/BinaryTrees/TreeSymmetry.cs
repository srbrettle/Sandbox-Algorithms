using System;

namespace BinaryTrees
{
    public static class TreeSymmetry
    {
        /// <summary>
        /// Checks if a Binary Tree is symmetric
        /// </summary>
        /// <param name="tree">Tree to check</param>
        /// <returns>Boolean specifying whether the tree is symettric</returns>
        public static bool IsTreeSymmetric(this Tree tree)
        {
            return IsTreeSymmetricHelper(tree.rootNode.left, tree.rootNode.right);
        }

        /// <summary>
        /// Helper function checking whether a pair of nodes is symmetric
        /// </summary>
        /// <param name="node1">Node 1</param>
        /// <param name="node2">Node 2</param>
        /// <returns>Boolean specifying whether a pair of nodes were symmetric</returns>
        public static bool IsTreeSymmetricHelper(Node node1, Node node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }
            if (node1 == null || node2 == null)
            {
                return false;
            }

            return IsTreeSymmetricHelper(node1.left, node2.right) && IsTreeSymmetricHelper(node1.right, node2.left);
        }

        
    }
}
