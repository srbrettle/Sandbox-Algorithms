//-----------------------------------------------------------------------
// <copyright file="DijkstrasAlgorithm.cs" company="srbrettle">
// Copyright (c) srbrettle. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DijkstrasAlgorithm
{
    using System.Linq;
    using global::DijkstrasAlgorithm.Models;    

    /// <summary>
    /// Main class for Dijkstra's Algorithm formula
    /// </summary>
    public static class DijkstrasAlgorithm
    {       
        /// <summary>
        /// Extension method to calculate shortest paths using Dijkstra's Algorithm.
        /// </summary>
        /// <param name="memoTable">Memoization Table</param>
        /// <param name="vertex">Vertex To calculate path from</param>
        /// <returns>Updated memoization table</returns>
        public static MemoizationTable CalculateShortestPath(this MemoizationTable memoTable, Vertex vertex)
        {
            memoTable.Update(vertex, 0);
            int costToCurrentVertex = 0;           

            // TODO: swap out infinite loop
            while (true)
            {
                // initialise edge
                Edge smallestEdgeToUnvisitedVertex = null;

                // Find lowest weighted edge to an unvisited vertex from current vertex
                bool changed = false;
                foreach (Edge edge in vertex.GetDirectedEdges().Where(x => !x.DirectedTo.Visited))
                {
                    memoTable.Update(edge.DirectedTo, costToCurrentVertex + edge.Weight);

                    if ((smallestEdgeToUnvisitedVertex == null) || (edge.Weight < smallestEdgeToUnvisitedVertex.Weight))
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
