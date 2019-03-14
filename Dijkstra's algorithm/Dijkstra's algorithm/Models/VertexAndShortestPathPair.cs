namespace DijkstrasAlgorithm.Models
{
    public class VertexAndShortestPathPair
    {
        public readonly Vertex Vertex;
        public int LowestCostPath;

        public VertexAndShortestPathPair(Vertex vertex)
        {
            this.Vertex = vertex;
            this.LowestCostPath = int.MaxValue;
        }
    }
}
