using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node<T>
    {
        private T data;
        private Node<T> next;
        private Node<T> previous;

        public Node(T data)
        {
            this.data = data;
        }
    }
}
