using System;
using System.Collections.Generic;

namespace DijkstrasAlgorithm.Models
{
    public class Vertex
    {
        readonly Guid ID;
        readonly ICollection<Edge> DirectedEdges = new List<Edge>;        

        public Vertex(Guid id)
        {
            this.ID = id;
        }
    }