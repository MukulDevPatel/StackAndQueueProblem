namespace StackAndQueueProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Queue Problem");
            LinkedList queue = new LinkedList();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Display();
        }
    }
}
