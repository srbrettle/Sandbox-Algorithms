using System;
using Xunit;
using DijkstrasAlgorithm.Models;
using DijkstrasAlgorithm;
using System.Linq;

namespace Test.DijkstrasAlgorithm
{
    public class UnitTestDijkstrasAlgorithm
    {
        [Fact]
        public void TestAlgorthim()
        {
            MemoizationTable memoTable = new MemoizationTable();

            Vertex initialVertex = new Vertex();
            Vertex secondaryVertex = new Vertex();
            Vertex tertiaryVertex = new Vertex();
            Vertex quaternaryVertex = new Vertex();

            initialVertex.AddEdgeToVertex(secondaryVertex, 3);
            initialVertex.AddEdgeToVertex(tertiaryVertex, 15);

            secondaryVertex.AddEdgeToVertex(tertiaryVertex, 7);
            secondaryVertex.AddEdgeToVertex(quaternaryVertex, 4);

            tertiaryVertex.AddEdgeToVertex(initialVertex, 1);
            tertiaryVertex.AddEdgeToVertex(secondaryVertex, 1);
            tertiaryVertex.AddEdgeToVertex(tertiaryVertex, 1);
            tertiaryVertex.AddEdgeToVertex(quaternaryVertex, 1);            

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
