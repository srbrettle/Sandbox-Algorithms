//-----------------------------------------------------------------------
// <copyright file="VertexAndShortestPathPair.cs" company="srbrettle">
// Copyright (c) srbrettle. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DijkstrasAlgorithm.Models
{
    /// <summary>
    /// Class to store a Vertex and it's Shortest Path (Cost)
    /// </summary>
    public class VertexAndShortestPathPair
    {
        /// <summary>
        /// The particular Vertex.
        /// </summary>
        public readonly Vertex Vertex;

        /// <summary>
        /// The lowest discovered cost to reach the vertex.
        /// </summary>
        private int lowestCostPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAndShortestPathPair" /> class.
        /// </summary>
        /// <param name="vertex">The particular vertex</param>
        public VertexAndShortestPathPair(Vertex vertex)
        {
            this.Vertex = vertex;
            this.lowestCostPath = int.MaxValue;
        }

        /// <summary>
        /// Gets or sets the lowest cost path to the vertex.
        /// </summary>
        public int LowestCostPath { get => this.lowestCostPath; set => this.lowestCostPath = value; }
    }
}
