using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Vertex<T>
    {
        HashSet<dynamic> _inEdges;
        HashSet<dynamic> _outEdges;

        public Vertex(T value)
        {
            Value = value;
            Out = new HashSet<dynamic>();
            In = new HashSet<dynamic>();
        }
        public T Value
        {
            get;
            set;
        }

        public HashSet<dynamic> In
        {
            get
            {
                return _inEdges;
            }
            set
            {
                _inEdges = value;
            }
        }
        public HashSet<dynamic> Out
        {
            get
            {
                return _outEdges;
            }
            set
            {
                _outEdges = value;
            }
        }

        public override string ToString()
        {
            return
                string.Format
                (
                    "Vertex: {0}, In Edges: {1}, Out Edges: {2}",
                    Value.ToString(),
                    EdgesAsString(_inEdges),
                    EdgesAsString(_outEdges)
                );
        }

        StringBuilder s = new StringBuilder();
        string EdgesAsString(HashSet<dynamic> set)
        {
            s.Clear();
            foreach (var edge in set)
            {
                s.Append(edge.Value.ToString() + ",");
            }

            if (s.Length > 0)
                s = s.Remove(s.Length - 1, 1);

            return s.ToString();
        }
    }
}
