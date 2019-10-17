namespace MyStack.Core.Contracts
{
    public interface IStack<T>
    {
        void Push(T value);
        T Pop();
    }
}
