namespace DijkstrasAlgorithm.Models
{
    public class Edge
    {        
        readonly int Weight;
        readonly Vertex DirectedFrom;
        readonly Vertex DirectedTo;

        public Edge(int weight, Vertex directedFrom, Vertex directedTo)
        {
            this.Weight = weight;
            this.DirectedFrom = directedFrom;
            this.DirectedTo = directedTo;
        }
    }
}
