
namespace Library
{
    class Edge<T>
    {
        public Edge(T value)
        {
            Value = value;
        }
        public T Value
        {
            get;
            set;
        }

        public dynamic In
        {
            get;
            set;
        }
        public dynamic Out
        {
            get;
            set;
        }

        public override string ToString()
        {
            return
                string.Format
                (
                    "Edge: {0}, In Vertex: {1}, Out Vertex: {2}",
                    Value.ToString(),
                    In.Value.ToString(),
                    Out.Value.ToString()
                );
        }
    }
}
