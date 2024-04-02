using ThreadSafeQueue;

namespace BThreadSafeQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImmutableQueue<string> queue = new("abc");
            queue = queue
                .Enqueue("cde")
                .Enqueue("fgh");

            queue = queue
                .Dequeue(out string val);
            Console.WriteLine(val);
            queue = queue
               .Peek(out val);
            Console.WriteLine(val);

            Console.ReadLine();
        }
    }
}
