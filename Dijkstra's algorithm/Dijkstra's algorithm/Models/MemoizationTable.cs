//-----------------------------------------------------------------------
// <copyright file="MemoizationTable.cs" company="srbrettle">
// Copyright (c) srbrettle. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DijkstrasAlgorithm.Models
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Memoization Table.
    /// </summary>
    public class MemoizationTable
    {
        /// <summary>
        /// Collection of vertex and shortest path pair, this represents the shortest path table.
        /// </summary>
        public ICollection<VertexAndShortestPathPair> ShortestPathsTable = new List<VertexAndShortestPathPair>();

        /// <summary>
        /// Generate a vertex and shortest path pair and add to the shortest path table.
        /// </summary>
        /// <param name="vertex">Vertex to add.</param>
        public void AddVertex(Vertex vertex)
        {
            var vertexAndShortestPathPair = new VertexAndShortestPathPair(vertex);
            this.ShortestPathsTable.Add(vertexAndShortestPathPair);
        }

        /// <summary>
        /// Add a vertex and shortest path pair to the shortest path table.
        /// </summary>
        /// <param name="vertexAndShortestPathPair">Vertex and shortest path pair to add.</param>
        public void AddVertexAndShortestPathPair(VertexAndShortestPathPair vertexAndShortestPathPair)
        {
            this.ShortestPathsTable.Add(vertexAndShortestPathPair);
        }

        /// <summary>
        /// Update the shortest path table if cost is lower than current.
        /// </summary>
        /// <param name="vertex">Vertex to update on the shortest path table.</param>
        /// <param name="cost">Cost to update if lower than existing.</param>
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
