using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepairCenter
{
    [TestClass]
    public class RepairCenterTests
    {
        [TestMethod]
        public void SortTest()
        {
            var orders = new Order[] {
                new Order(3, "HardDiskRepair",Priority.High),
                new Order(1, "VentilationSystemCleaning", Priority.Low),
                new Order(2, "DataRecovery", Priority.High),
                new Order(4, "DisplayReplacement", Priority.Medium)};

            var sortedOrders = new Order[] {
                new Order(2, "DataRecovery", Priority.High),
                new Order(3, "HardDiskRepair",Priority.High),
                new Order(4, "DisplayReplacement", Priority.Medium),
                new Order(1, "VentilationSystemCleaning", Priority.Low)};

            CollectionAssert.AreEqual(sortedOrders, SortOrdersByPriority(orders));
        }

        public enum Priority
        {
            Low = 1,
            Medium = 2,
            High = 3
        }

        public struct Order
        {
            public int orderNumber;
            public string orderIssue;
            public Priority priority;

            public Order (int orderNumber, string orderIssue, Priority priority)
            {
                this.orderNumber = orderNumber;
                this.orderIssue = orderIssue;
                this.priority = priority;
            }
        }

        Order[] SortOrdersByPriority(Order[] orders)
        {
            QuickSort(orders, 0, orders.Length - 1);
            return orders;
        }

        void QuickSort(Order[] orders, int left, int right)
        {
            if (right > left)
            {
                var pivot = orders[right];
                int i = left;
                int j = right;
                int index = left;
                while (index <= j)
                {
                    if (FindLowest(pivot, orders[index]))
                    {
                        ChangeElementsBetweenThem(ref orders[i++], ref orders[index++]);
                    }
                    else if (FindLowest(orders[index], pivot))
                    {
                        ChangeElementsBetweenThem(ref orders[index], ref orders[j--]);
                    }
                    else
                    {
                        index++;
                    }
                }
                QuickSort(orders, left, i - 1);
                QuickSort(orders, j + 1, right);
            }   
        }

        private static bool FindLowest(Order first, Order second)
        {
            if (first.priority == second.priority)
                return first.orderNumber > second.orderNumber;
            return first.priority < second.priority;
        }

        private void ChangeElementsBetweenThem(ref Order firstOrder, ref Order secondOrder)
        {
            var temp = firstOrder;
            firstOrder = secondOrder;
            secondOrder = temp;
        }
    }
}
