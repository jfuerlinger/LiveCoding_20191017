using MyStack.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack.Core
{
    public class MyFancyStack<T> : IStack<T>
    {
        private Node<T> _head;

        public void Push(T value)
        {
            _head = new Node<T>(_head, value);
        }

        public T Pop()
        {
            if(_head == null)
            {
                return default(T);
            }

            T value = _head.Value;
            _head = _head.Next;
            
            return value;
        }


        private class Node<T>
        {

            public Node(Node<T> next, T value)
            {
                this.Next = next;
                this.Value = value;
            }

            public T Value { get; set; }
            public Node<T> Next { get; set; }
        }


    }



}
