using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DijkstrasAlgorithm.Models
{
    public class MemoizationTable
    {
        public ICollection<VertexAndShortestPathPair> ShortestPathsTable = new List<VertexAndShortestPathPair>();        

        public void AddVertex(Vertex vertex)
        {
            var vertexAndShortestPathPair = new VertexAndShortestPathPair(vertex);
            this.ShortestPathsTable.Add(vertexAndShortestPathPair);
        }

        public void AddVertexAndShortestPathPair(VertexAndShortestPathPair vertexAndShortestPathPair)
        {
            this.ShortestPathsTable.Add(vertexAndShortestPathPair);
        }

        public void Update(Vertex vertex, int cost) 
        {
            var vertexAndShortestPathPair = this.ShortestPathsTable.FirstOrDefault(x => x.Vertex == vertex);
            if (cost < vertexAndShortestPathPair.LowestCostPath)
            {
                vertexAndShortestPathPair.LowestCostPath = cost;
            }                       
        }
    }
}
