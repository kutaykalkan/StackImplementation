using System;
using NUnit.Framework;

namespace StackImplementation.Tests
{
    [TestFixture]
    public class StackImplementationTests
    {
        private Stack<int> _stack;
        [Test]
        public void TestPushPop()
        {
            _stack = new Stack<int>();
            _stack.Push(1);
            Assert.AreEqual(1, _stack.Pop());
        }

        [Test]
        public void TestEnsureCapacity()
        {
            _stack = new Stack<int>(1);
            _stack.Push(1);
            _stack.Push(2);
            Assert.AreEqual(2, _stack.Capacity);
            Assert.AreEqual(2, _stack.Size);
        }

        [Test]
        public void TestIsEmpty()
        {
            _stack = new Stack<int>(1);
            Assert.AreEqual(true, _stack.IsEmpty);
        }

        [Test]
        public void WhenStackIsEmptyThrowException()
        {
            _stack = new Stack<int>();
            Assert.Throws<Exception>(() => _stack.Pop(), "There are no items in the stack!");
        }

        [Test]
        public void WhenCapacityIsBelowOrEqualToZeroThrowException()
        {
            Assert.Throws<ArgumentException>(() => _stack = new Stack<int>(-1), "Capacity can not be 0");
        }
    }
}
