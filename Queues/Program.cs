using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(10);
            //queue.Enqueue(2);
            ////queue.Dequeue();
            //Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());
            //queue.Enqueue(3);
            //queue.Enqueue(21);
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine("Removes value {0}", queue.Dequeue());
            //}

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrderFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrderFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }
        }

        static Order[] ReceiveOrderFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }

        static Order[] ReceiveOrderFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }
    }

    class Order
    {
        public int orderId { get; set; }
        public int orderQuantity { get; set; }

        public Order(int orderId, int orderQuantity)
        {
            this.orderId = orderId;
            this.orderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Order {0} processed!", orderId);
        }
    }
}
