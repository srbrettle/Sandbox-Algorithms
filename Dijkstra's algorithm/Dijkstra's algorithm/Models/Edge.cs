//-----------------------------------------------------------------------
// <copyright file="Edge.cs" company="srbrettle">
// Copyright (c) srbrettle. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DijkstrasAlgorithm.Models
{
    /// <summary>
    /// A weighted edge between to vertices.
    /// </summary>
    public class Edge
    {        
        /// <summary>
        /// Weight/cost given to an edge.
        /// </summary>
        public readonly int Weight;

        /// <summary>
        /// Vertex the edge is from.
        /// </summary>
        public readonly Vertex DirectedFrom;

        /// <summary>
        /// Vertex the edge is directed to.
        /// </summary>
        public readonly Vertex DirectedTo;

        /// <summary>
        /// Initializes a new instance of the <see cref="Edge" /> class.
        /// </summary>
        /// <param name="weight">Weight to set for the edge.</param>
        /// <param name="directedFrom">Vertex the edge is to be set from.</param>
        /// <param name="directedTo">Vertex the edge is to be set as directed to.</param>
        public Edge(int weight, Vertex directedFrom, Vertex directedTo)
        {
            this.Weight = weight;
            this.DirectedFrom = directedFrom;
            this.DirectedTo = directedTo;
        }
    }
}
