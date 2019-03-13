namespace DijkstrasAlgorithm.Models
{
    class Edge
    {        
        readonly int Weight;
        readonly Vertex DirectedFrom;
        readonly Vertex DirectedTo;

        public Edge(int weight, Vertex directedTo, Vertex directedFrom)
        {
            this.Weight = weight;
            this.DirectedFrom = directedFrom;
            this.DirectedTo = directedTo;
        }
    }
}
