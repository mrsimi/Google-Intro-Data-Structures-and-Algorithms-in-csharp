using System;

namespace List_Based_Collection
{
    public class Queue <T>
    {
        private T[] _queue;
        private int _size;
        private int rear;
        private int front;
        public Queue(int size=6)
        {
            _size = size;
            _queue = new T[size];
            front = 0; 
            rear = -1;
        }

        public void Enqueue(T value)
        {
            if(rear == _size -1)
            {
                throw new System.Exception("Queue Overflow");
            }
            else 
            {
                _queue[++rear] = value;
            }
        }

        public T Deque()
        {
            if(front == rear +1)
            {
                throw new System.Exception("Queue is Empty");
            }
            else 
            {
                return _queue[front++];
            }
        }

        public void printQueue()
        {
            if(front == rear+1)
            {
                throw new System.Exception("Queue is Empty");
            }
            else
            {
                for(int i = front; i <= rear; i++)
                {
                    Console.Write(_queue[i] + " ");
                }
            }
        }
    }
}