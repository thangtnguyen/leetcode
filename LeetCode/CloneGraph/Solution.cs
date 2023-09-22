namespace CloneGraph
{
    public class Solution
    {
        public Node CloneGraph(Node node)
        {
            if (node == null) return null;

            Dictionary<Node, Node> cloneMapping = new Dictionary<Node, Node>();
            Queue<Node> handledNodes = new Queue<Node>();
            Node newNode = new Node(node.val);
            cloneMapping.Add(node, newNode);
            handledNodes.Enqueue(node);
            while(handledNodes.Any())
            {
                Node currentNode = handledNodes.Dequeue();
                var newNeighbors = cloneMapping[currentNode].neighbors;
                foreach (var neighbor in currentNode.neighbors)
                {
                    if (!cloneMapping.ContainsKey(neighbor))
                    {
                        Node tempNode = new Node(neighbor.val);
                        cloneMapping.Add(neighbor, tempNode);
                        handledNodes.Enqueue(neighbor);
                    }
                    newNeighbors.Add(cloneMapping.GetValueOrDefault(neighbor));
                }
            }

            return newNode;
        }
    }
}
