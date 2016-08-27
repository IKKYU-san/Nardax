using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Nardax.UnitTests
{
    [TestClass]
    public class QueueExtensionsTest
    {
ueExtensionsTest()
        {
            _queue = new Queue<string>();
            _queue.Enqueue("aa");
            _queue.Enqueue("bb");
            _queue.Enqueue("cc");
        }

        [TestMethod]
        public void EnqueueRange()
        {e());
            Assert.AreEqual("cc", _queue.Dequeue());
            Assert.AreEqual("dd", _queue.Dequeue());
            Assert.AreEqual("ee", _queue.Dequeue());
        }
    }
}
