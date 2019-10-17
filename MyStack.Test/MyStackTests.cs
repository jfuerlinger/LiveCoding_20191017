using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack.Core;
using MyStack.Core.Contracts;

namespace MyStack.Test
{
    [TestClass]
    public class MyStackTests
    {
        [TestMethod]
        public void MyStack_PopEmptyStack_ShouldReturnNull()
        {
            // Arrange
            IStack stack = new MyFancyStack();

            // Act
            object value = stack.Pop();

            // Assert
            Assert.IsNull(value);
        }
    }
}
