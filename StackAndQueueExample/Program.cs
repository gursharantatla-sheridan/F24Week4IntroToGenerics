namespace StackAndQueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack example

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Total: " + stack.Count);
            foreach (int i in stack)
                Console.WriteLine(i);


            //int num = stack[1];

            int num = stack.Pop();
            Console.WriteLine("\nNum = " + num);

            Console.WriteLine("\nTotal: " + stack.Count);
            foreach (int i in stack)
                Console.WriteLine(i);


            num = stack.Peek();
            Console.WriteLine("\nNum = " + num);

            Console.WriteLine("\nTotal: " + stack.Count);
            foreach (int i in stack)
                Console.WriteLine(i);


            Console.WriteLine("\n\n\n\n");



            // Queue example

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Total: " + queue.Count);
            foreach (int i in queue)
                Console.WriteLine(i);

            //num = queue[1];

            num = queue.Dequeue();
            Console.WriteLine("\nNum = " + num);

            Console.WriteLine("\nTotal: " + queue.Count);
            foreach (int i in queue)
                Console.WriteLine(i);

            num = queue.Peek();
            Console.WriteLine("\nNum = " + num);

            Console.WriteLine("\nTotal: " + queue.Count);
            foreach (int i in queue)
                Console.WriteLine(i);
        }
    }
}
