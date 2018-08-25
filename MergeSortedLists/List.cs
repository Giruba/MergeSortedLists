using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSortedLists
{
    class List
    {
        public List() { }

        public Node AddNodeToLinkedList(Node head, int data)
        {
            Node newNode = new Node(data);

            Node lastNode = head;

            if (head == null) {
                head = newNode;
                return head;
            }
            while (lastNode.next != null) {
                lastNode = lastNode.next;
            }
            lastNode.next = newNode;

            return head;
        }
    }
}
