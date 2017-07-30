using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepairCenter
{
    [TestClass]
    public class RepairCenterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        enum Priority
        {
            Low = 1,
            Medium = 2,
            High = 3
        }

        struct Order
        {
            public int orderNumber;
            public string orderIssue;
            public Priority priority;

            public Order(int orderNumber, string orderIssue, Priority priority)
            {
                this.orderNumber = orderNumber;
                this.orderIssue = orderIssue;
                this.priority = priority;
            }
        }
    }
}
