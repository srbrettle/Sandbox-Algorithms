//-----------------------------------------------------------------------
// <copyright file="Vertex.cs" company="srbrettle">
// Copyright (c) srbrettle. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DijkstrasAlgorithm.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An individual vertex.
    /// </summary>
    public class Vertex
    {
        /// <summary>
        /// ID of the vertex.
        /// </summary>
        public readonly Guid ID;

        /// <summary>
        /// Collection of directed edges for the vertex.
        /// </summary>
        public ICollection<Edge> DirectedEdges = new List<Edge>();

        /// <summary>
        /// Boolean for whether the vertex has been visited.
        /// </summary>
        public bool Visited = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vertex" /> class.
        /// </summary>
        /// <param name="id">The ID to set for the vertex.</param>
        public Vertex(Guid id = default(Guid))
        {
            if (id != default(Guid))
            {
                this.ID = id;
            }
            else
            {
                this.ID = Guid.NewGuid();
            }
        }

        /// <summary>
        /// Adds an vertex edge.
        /// </summary>
        /// <param name="edge">The edge to add.</param>
        public void AddEdge(Edge edge)
        {
            this.DirectedEdges.Add(edge);
        }

        /// <summary>
        /// Adds an edge towards an other vertex.
        /// </summary>
        /// <param name="vertex">The other vertex that the edge is directed to.</param>
        /// <param name="weight">Weight of the edge.</param>
        public void AddEdgeTowardsOtherVertex(Vertex vertex, int weight)
        {
            Edge edge = new Edge(weight, this, vertex);
            this.AddEdge(edge);
        }
    }
}