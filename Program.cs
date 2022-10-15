namespace LinkedListStackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack And Queue Problem");

            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Insert(70);
            linkedListStack.Insert(30);
            linkedListStack.Insert(56);
            linkedListStack.Display();
        }
    }
}
