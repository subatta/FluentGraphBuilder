using System.Collections.Generic;

namespace Library
{
    public class GraphContainer
    {
        HashSet<dynamic> _graphs = new HashSet<dynamic>();
        public Graph<T> AddGraph<T>()
        {
            var graph = new Graph<T>();
            _graphs.Add(graph);
            return graph;
        }
    }
}
