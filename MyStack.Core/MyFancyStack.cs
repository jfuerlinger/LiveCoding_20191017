using MyStack.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack.Core
{
    public class MyFancyStack : IStack
    {
        private Node _head;

        public void Push(object value)
        {
            _head = new Node(_head, value);
        }

        public object Pop()
        {
            object value = _head?.Value;
            _head = _head?.Next;

            return value;
        }


        private class Node
        {

            public Node(Node next, object value)
            {
                this.Next = next;
                this.Value = value;
            }

            public object Value { get; set; }
            public Node Next { get; set; }
        }


    }



}
