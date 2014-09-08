using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Graph<T>: INodeStart<T>, INodeEnd
    {

        Vertex<T> _root;
        dynamic _lastVertex;
        HashSet<dynamic> _lastEdges = new HashSet<dynamic>();
        HashSet<dynamic> _allVertices = new HashSet<dynamic>();
        HashSet<dynamic> _allEdges = new HashSet<dynamic>();

        public Vertex<T> Root
        {
            get
            {
                return _root;
            }
            set
            {
                _root = value;
            }
        }

        public INodeEnd AddRoot(T value)
        {
            Root = new Vertex<T>(value);
            _lastVertex = _root;
            _allVertices.Add(_lastVertex);
            return this;
        }

        public INodeEnd ToVertex<V>(V value)
        {
            var vx = _allVertices.FirstOrDefault<dynamic>(v => v.Value == value);
            dynamic toVertex = null;
            if (vx == null)
                toVertex = new Vertex<V>(value);
            else
                toVertex = vx;

            foreach (var edge in _lastEdges)
            {
                edge.Out = toVertex;
                toVertex.In.Add(edge);
            }

            if (vx == null)
            {
                _allVertices.Add(toVertex);
            }

            _lastEdges = new HashSet<dynamic>();
            _lastVertex = toVertex;

            return this;
        }

        public INodeEnd AddEdge<U>(U value)
        {
            dynamic edge = new Edge<U>(value);
            edge.In = _lastVertex;
            _lastVertex.Out.Add(edge);
            _lastEdges.Add(edge);
            _allEdges.Add(edge);
            return this;
        }

        public INodeEnd AtVertex<X>(X value)
        {
            // find node by Vertex<X>(x) and reset last vertex to it
            var vx = _allVertices.FirstOrDefault<dynamic>(v => v.Value == value);
            if (vx == null)
                throw new Exception("Not found: " + typeof(X) + " of Value: " + value);

            _lastVertex = vx;

            return this;
        }

        public void Print()
        {
            foreach (var vertex in _allVertices)
            {
                Console.WriteLine(vertex.ToString());
            }
            Console.WriteLine();
            foreach (var edge in _allEdges)
            {
                Console.WriteLine(edge.ToString());
            }
        }
    }
}
