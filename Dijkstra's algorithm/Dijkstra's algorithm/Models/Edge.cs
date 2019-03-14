namespace DijkstrasAlgorithm.Models
{
    public class Edge
    {        
        public readonly int Weight;
        public readonly Vertex DirectedFrom;
        public readonly Vertex DirectedTo;

        public Edge(int weight, Vertex directedFrom, Vertex directedTo)
        {
            this.Weight = weight;
            this.DirectedFrom = directedFrom;
            this.DirectedTo = directedTo;
        }
    }
}
