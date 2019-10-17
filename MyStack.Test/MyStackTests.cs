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

        [TestMethod]
        public void MyStack_PushAndPop_ShouldReturnCorrectElement()
        {
            // Arrange
            IStack stack = new MyFancyStack();
            stack.Push(4);

            // Act
            int value = (int)stack.Pop();

            // Assert
            Assert.AreEqual(value, 4);
        }
    }
}
