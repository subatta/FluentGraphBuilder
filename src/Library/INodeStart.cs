
namespace Library
{
    public interface INodeStart<T>
    {
        INodeEnd AddRoot(T value);
    }
}
