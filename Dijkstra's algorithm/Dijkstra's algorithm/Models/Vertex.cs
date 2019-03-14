using System;
using System.Collections.Generic;

namespace DijkstrasAlgorithm.Models
{
    public class Vertex
    {
        public readonly Guid ID;
        public ICollection<Edge> DirectedEdges = new List<Edge>;        

        public Vertex(Guid id = default(Guid))
        {
            if (id != default(Guid) {
                this.ID = id;
            }
            else
            {
                this.ID = Guid.NewGuid();
            }
        }

        public void AddEdge(Edge edge)
        {
            DirectedEdges.Add(edge);
        }
    }