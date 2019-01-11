using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
    /// <summary>
    /// Class for Node in Binary Search Tree
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Value of the node
        /// </summary>
        public int value;

        /// <summary>
        /// Left child node
        /// </summary>
        public Node left;

        /// <summary>
        /// Right child node
        /// </summary>
        public Node right;

        /// <summary>
        /// Constructor for the Node class, creates a Node with a given value
        /// </summary>
        /// <param name="value">Value for the node</param>
        public Node(int value)
        {
            this.value = value;
        }        
    }

    /// <summary>
    /// Class for Binary Search Tree
    /// </summary>
    public class Tree
    {
        /// <summary>
        /// Root Node of the Tree
        /// </summary>
        public Node rootNode;

        /// <summary>
        /// Constructor for the Tree class, sets the value for the root node
        /// </summary>
        /// <param name="rootValue">Value of the Root Node</param>
        public Tree(int rootValue)
        {
            this.rootNode = new Node(rootValue);
        }

        /// <summary>
        /// Constructor for the Tree class, sets the root node
        /// </summary>
        /// <param name="rootNode">Root Node</param>
        public Tree(Node rootNode)
        {
            this.rootNode = rootNode;
        }

        /// <summary>
        /// Inserts a value into a Binary Search Tree
        /// </summary>
        /// <param name="rootNode">Root Node of Tree</param>
        /// <param name="value">Value to add to Tree</param>
        /// <returns></returns>
        public Node Insert(Node rootNode, int value)
        {
            if (rootNode == null)
            {
                rootNode = new Node(value);
            }
            else if (value < rootNode.value)
            {
                rootNode.left = Insert(rootNode.left, value);
            }
            else
            {
                rootNode.right = Insert(rootNode.right, value);
            }

            return rootNode;
        }

        /// <summary>
        /// Constructs a binary search tree
        /// </summary>
        /// <param name="values">Collection of integer values</param>
        /// <returns>Root node of the tree</returns>
        public Node ConstructTree(ICollection<int> values)
        {
            foreach (int value in values)
            {
                this.rootNode = Insert(this.rootNode, value);
            }

            return this.rootNode;
        }
    }
}
