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
            IStack<int> stack = new MyFancyStack<int>();

            // Act
            int value = stack.Pop();

            // Assert
            Assert.AreEqual(value, 0);
        }

        [TestMethod]
        public void MyStack_PopEmptyEmployeeStack_ShouldReturnNull()
        {
            // Arrange
            IStack<Employee> stack = new MyFancyStack<Employee>();

            // Act
            Employee value = stack.Pop();

            // Assert
            Assert.IsNull(value);
        }

        [TestMethod]
        public void MyStack_PushAndPop_ShouldReturnCorrectElement()
        {
            // Arrange
            IStack<int> stack = new MyFancyStack<int>();
            stack.Push(4);

            // Act
            int value = stack.Pop();

            // Assert
            Assert.AreEqual(value, 4);
        }
    }
}
