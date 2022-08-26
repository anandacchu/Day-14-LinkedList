namespace LinkedListDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(45);
            linkedList.Add(78);
            linkedList.Add(48);
            linkedList.Add(10);


            LinkedList linkedList2 = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            
            linkedList.Display();
        }
    }
}
