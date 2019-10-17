using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack.Core.Contracts
{
    public interface IStack
    {
        void Push(object value);
        object Pop();
    }
}
