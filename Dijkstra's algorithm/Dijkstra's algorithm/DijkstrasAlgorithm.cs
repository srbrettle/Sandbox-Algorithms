using DijkstrasAlgorithm.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DijkstrasAlgorithm
{
    public static class DijkstrasAlgorithm
    {       
        public static MemoizationTable CalculateShortestPath(this MemoizationTable memoTable, Vertex vertex)
        {
            memoTable.Update(vertex, 0);
            int costToCurrentVertex = 0;           

            // TODO: swap out infinite loop
            while (true) {
                // initialise edge
                Edge smallestEdgeToUnvisitedVertex = null;

                // Find lowest weighted edge to an unvisited vertex from current vertex
                bool changed = false;
                foreach (var edge in vertex.DirectedEdges.Where(x=>!x.DirectedTo.Visited))
                {
                    memoTable.Update(edge.DirectedTo, costToCurrentVertex + edge.Weight);

                    if ((smallestEdgeToUnvisitedVertex == null) || ((edge.Weight < smallestEdgeToUnvisitedVertex.Weight)))
                    {
                        smallestEdgeToUnvisitedVertex = edge;
                        changed = true;
                    }
                }

                if (changed == false)
                {
                    // All vertices visited
                    break;
                }

                // Visit nearest unvisited vertex with smallest cost
                vertex = smallestEdgeToUnvisitedVertex.DirectedTo;
                costToCurrentVertex += smallestEdgeToUnvisitedVertex.Weight;
            }

            return memoTable;
        }

    }
}
