using System;
using System.Collections.Generic;
using System.Text;

namespace DijkstrasAlgorithm.Models
{
    public class MemoizationTable
    {
        public ICollection<VertexAndShortestPathPair> ShortestPathsTable = new List<VertexAndShortestPathPair>;

        public void AddVertexAndShortestPathPair(VertexAndShortestPathPair vertexAndShortestPathPair)
        {
            this.ShortestPathsTable.Add(vertexAndShortestPathPair);
        }
    }
}
