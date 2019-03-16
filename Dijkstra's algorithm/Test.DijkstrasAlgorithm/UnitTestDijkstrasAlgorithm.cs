//-----------------------------------------------------------------------
// <copyright file="UnitTestDijkstrasAlgorithm.cs" company="srbrettle">
// Copyright (c) srbrettle. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Test.DijkstrasAlgorithm
{
    using System.Linq;
    using global::DijkstrasAlgorithm;
    using global::DijkstrasAlgorithm.Models;
    using Xunit;

    /// <summary>
    /// Unit test class for algorithm testing.
    /// </summary>
    public class UnitTestDijkstrasAlgorithm
    {
        /// <summary>
        /// Tests the algorithm.
        /// </summary>
        [Fact]
        public void TestAlgorthim()
        {
            MemoizationTable memoTable = new MemoizationTable();

            Vertex initialVertex = new Vertex();
            Vertex secondaryVertex = new Vertex();
            Vertex tertiaryVertex = new Vertex();
            Vertex quaternaryVertex = new Vertex();

            initialVertex.AddEdgeTowardsOtherVertex(secondaryVertex, 3);
            initialVertex.AddEdgeTowardsOtherVertex(tertiaryVertex, 15);

            secondaryVertex.AddEdgeTowardsOtherVertex(tertiaryVertex, 7);
            secondaryVertex.AddEdgeTowardsOtherVertex(quaternaryVertex, 4);

            tertiaryVertex.AddEdgeTowardsOtherVertex(initialVertex, 1);
            tertiaryVertex.AddEdgeTowardsOtherVertex(secondaryVertex, 1);
            tertiaryVertex.AddEdgeTowardsOtherVertex(tertiaryVertex, 1);
            tertiaryVertex.AddEdgeTowardsOtherVertex(quaternaryVertex, 1);            

            memoTable.AddVertex(initialVertex);
            memoTable.AddVertex(secondaryVertex);
            memoTable.AddVertex(tertiaryVertex);
            memoTable.AddVertex(quaternaryVertex);

            memoTable.CalculateShortestPath(initialVertex);

            Assert.Equal(0, memoTable.ShortestPathsTable.FirstOrDefault(x => x.Vertex == initialVertex).LowestCostPath);
            Assert.Equal(3, memoTable.ShortestPathsTable.FirstOrDefault(x => x.Vertex == secondaryVertex).LowestCostPath);
            Assert.Equal(10, memoTable.ShortestPathsTable.FirstOrDefault(x => x.Vertex == tertiaryVertex).LowestCostPath);
            Assert.Equal(7, memoTable.ShortestPathsTable.FirstOrDefault(x => x.Vertex == quaternaryVertex).LowestCostPath);
        }
    }
}
