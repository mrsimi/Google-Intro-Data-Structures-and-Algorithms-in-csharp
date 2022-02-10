namespace List_Based_Collection
{
    public class Stack<T>
    {
        private readonly T[] _stack;
        private readonly int _size;
        private int _topMostItemIndex = -1;


        public Stack(int size=16)
        {
            _size = size;
            _stack = new T[size];
        }

        private bool IsFull => _size == _topMostItemIndex+1;
        public bool IsEmpty => _topMostItemIndex == -1;

        public void Push(T value)
        {
            if(IsFull)
            {
                throw new System.Exception("Stack is Full");
            }

            _stack[++_topMostItemIndex] = value;
        }

        public T Pop()
        {
            if(IsEmpty)
            {
                throw new System.Exception("Stack is Full");
            }

            return _stack[_topMostItemIndex--];
        }

        public T Peek()
        {
            if(IsEmpty)
            {
                throw new System.Exception("Stack is Full");
            }

            return _stack[_topMostItemIndex];
        }
    }
}