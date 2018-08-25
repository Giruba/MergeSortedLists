using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSortedLists
{
    class MergeSortedLists
    {
        Node[] nodes { set; get; }

        MergeSortedLists() { }

        public MergeSortedLists(Node[] inputNodes) {
            nodes = inputNodes;
        }

        public Node[] MergeLists(Node[] nodes, int noOfLists) {
            int i = 0;
            int j = i+1;

            while (j !=3) {
                nodes[i] = MergeTwoSortedLists(nodes[i], nodes[j]);
                j++;
            }
            return nodes;
        }

        Node MergeTwoSortedLists(Node firstList, Node secondList) {
            Node result = new Node();
            if (firstList == null)
                return secondList;
            if (secondList == null)
                return firstList;

            if (firstList.data < secondList.data)
            {
                result.data = firstList.data;
                result.next = MergeTwoSortedLists(firstList.next, secondList);
            }
            else
            {
                result.data = secondList.data;
                result.next = MergeTwoSortedLists(firstList, secondList.next);
            }
            return result;
        }

        public void printList(Node list) {
            if (list == null)
            {
                Console.WriteLine("List is null!");
            }
            else {
                while (list != null) {
                    Console.Write(list.data + "->");
                    list = list.next;
                }
                Console.WriteLine("null"+"\nEnd of Program! Press any key to exit");
            }
        }

    }
}
