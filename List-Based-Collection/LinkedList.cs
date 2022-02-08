using System;

namespace List_Based_Collection
{
    public class Node<T> where T : class
    {
        public T data;
        public Node<T> next;
    }
    public class LinkedList <T> where T : class
    {
        public Node<T> head; 
        public LinkedList()
        {
            this.head = null;
        }

        public void Append(T value)
        {
            Node<T> current = this.head;
            if(head == null)
            {
                head = new Node<T>{data = value, next = null};
            }
            else
            {
               while(current.next != null)
               {
                   current = current.next;
               }
               current.next = new Node<T>{data = value, next = null};
            }
        }

        public string PrintList()
        {
            string output = string.Empty;
            Node<T> current = this.head;
            if(current != null)
            {
                while (current != null)
                {
                    output= output + current.data +' ';
                    current = current.next;
                }
            }

            return output;
        }

        public int Count()
        {
            int counter = 0;
            Node<T> current = this.head;
            if(current != null)
            {
                while(current != null)
                {
                    counter += 1;
                    current = current.next;
                }
            }

            return counter;
        }

        public T AtIndex(int position)
        {
            int counter = 0;
            Node<T> current = this.head;
            if(current == null)
            {
                throw new NullReferenceException();
            }
            if(position == counter)
            {
                return current.data;
            }
            else 
            {
                while(current != null && counter != position)
                {
                    counter +=1;
                    current = current.next;
                }

                return current.data;
            }
        }


        public void Remove(T value)
        {
            Node<T> current = this.head;
            Node<T> previous = null;
            if(current == null)
            {
                throw new NullReferenceException();
            }
            else if (current.data == value)
            {
                this.head = current.next;
            }
            else 
            {
                while(current.data != value)
                {
                    previous = current; 
                    current = current.next;
                }

                if(previous != null)
                {
                    previous.next = current.next;
                }
            }
        }


        public void InsertAt(T value, int position)
        {
            Node<T> current = this.head;
            int counter = 0;
            if(current == null){
                this.head = new Node<T>{data=value, next = null};
            }
            else if (position == 0)
            {
                this.head = new Node<T>{data = value, next = current};
            }
            else
            {
                while (current != null && position != counter)
                {
                    current = current.next;
                    counter += 1;
                }

                current.next = new Node<T> {data = value , next = current.next};
            }
        }
    }
}