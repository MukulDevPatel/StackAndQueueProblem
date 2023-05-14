namespace StackAndQueueProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stack Problem");
            LinkedList stack = new LinkedList();
            stack.Add(56);
            stack.Add(30);
            stack.Add(70);
            stack.Display();
        }
    }
}
