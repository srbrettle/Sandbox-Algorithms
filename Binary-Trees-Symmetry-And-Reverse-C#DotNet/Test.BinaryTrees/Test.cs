using System;
using Xunit;
using BinaryTrees;

namespace Test.BinaryTrees
{
    public class Test
    {
        [Fact]
        public void Test_TreeCreation()
        {
            Tree tree = new Tree(10);
            tree.ConstructTree(new int[] { 5, 15, 2, 7, 12, 17 });

            Assert.Equal(10, tree.rootNode.value);
            Assert.Equal(5, tree.rootNode.left.value);
            Assert.Equal(15, tree.rootNode.right.value);
            Assert.Equal(2, tree.rootNode.left.left.value);
            Assert.Equal(7, tree.rootNode.left.right.value);
            Assert.Equal(12, tree.rootNode.right.left.value);
        }

        [Fact]
        public void Test_Symmetry_True()
        {
            Tree tree = new Tree(10);
            tree.ConstructTree(new int[] { 5, 15, 2, 7, 12, 17 });

            Assert.True(tree.IsTreeSymmetric());
        }

        [Fact]
        public void Test_Symmetry_False()
        {
            Tree tree = new Tree(10);
            tree.ConstructTree(new int[] { 5, 15, 2, 7, 12 });

            Assert.False(tree.IsTreeSymmetric());
        }

        [Fact]
        public void Test_Reverse()
        {
            Tree tree = new Tree(10);
            tree.ConstructTree(new int[] { 5, 15, 2, 7, 12, 17 });
            tree.ReverseTree();

            Assert.Equal(10, tree.rootNode.value);
            Assert.Equal(5, tree.rootNode.right.value);
            Assert.Equal(15, tree.rootNode.left.value);
            Assert.Equal(2, tree.rootNode.right.right.value);
            Assert.Equal(7, tree.rootNode.right.left.value);
            Assert.Equal(12, tree.rootNode.left.right.value);

        }
    }
}
