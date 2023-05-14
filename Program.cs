namespace StackAndQueueProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stack Problem");
            LinkedList stack = new LinkedList();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
        }
    }
}
