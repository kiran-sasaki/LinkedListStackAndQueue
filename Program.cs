namespace LinkedListStackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack And Queue Problem");

            //    LinkedListStack linkedListStack = new LinkedListStack();
            //    linkedListStack.Insert(70);
            //    linkedListStack.Insert(30);
            //    linkedListStack.Insert(56);
            //    linkedListStack.Display();
            //    linkedListStack.Peek();
            //    linkedListStack.Pop();
            //    linkedListStack.IsEmpty();
            //    linkedListStack.Display();

            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
        }
    }
}
