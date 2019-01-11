using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
    public static class TreeReversal
    {
        /// <summary>
        /// Reverses a Binary Tree
        /// </summary>
        /// <param name="tree">Tree to reverse</param>
        /// <returns>Reversed Tree</returns>
        public static Tree ReverseTree(this Tree tree)
        {
            Node reversedTreeRoot = ReverseHelper(tree.rootNode);

            Tree reversedTree = new Tree(reversedTreeRoot);

            return reversedTree;
        }

        /// <summary>
        /// Reverses nodes of a tree
        /// </summary>
        /// <param name="node">Node to reverse</param>
        /// <returns>Reversed node</returns>
        public static Node ReverseHelper(this Node node)
        {
            if (node == null)
            {
                return null;
            }

            Node childLeftNode = node.left;
            node.left = ReverseHelper(node.right);
            node.right = ReverseHelper(childLeftNode);
            return node;
        }
    }
}
