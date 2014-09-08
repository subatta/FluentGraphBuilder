
namespace Library
{
    public interface INodeEnd
    {
        INodeEnd ToVertex<T>(T value); // get or add
        INodeEnd AddEdge<T>(T value);
        INodeEnd AtVertex<T>(T value); // reset last vertext pointer
        void Print();
    }
}
