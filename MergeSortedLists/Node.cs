namespace MergeSortedLists
{
    class Node
    {
        public int data { get; set; }
        public Node next { get; set; }

        public Node() { }

        public Node(int data) {
            this.data = data;
            this.next = null;
        }
    }
}