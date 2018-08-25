using System;

namespace MergeSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MergeSorted Lists!");
            Console.WriteLine("Enter the number of Lists");
            int noOfLists = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of elements in every list");
            int noOfElements = int.Parse(Console.ReadLine());

            Node[] nodes = new Node[noOfLists];
            for (int i = 0; i < noOfLists; i++) {
                Console.WriteLine("Enter the elements of the List "+i);
                List list = new List();
                for (int j = 0; j < noOfElements; j++) {
                    int element = int.Parse(Console.ReadLine());
                    nodes[i] = list.AddNodeToLinkedList(nodes[i],element);
                }
            }
            MergeSortedLists mergeSortedLists = new MergeSortedLists(nodes);
            nodes = mergeSortedLists.MergeLists(nodes, noOfLists-1);
            mergeSortedLists.printList(nodes[0]);
            Console.ReadKey();
        }
    }
}
