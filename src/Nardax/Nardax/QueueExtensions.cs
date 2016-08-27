using System.Collections.Generic;

namespace Nardax
{
    public static class QueueExtensions
    {
        // lägg in hel lista med items i befintlig kö

        public static void EnqueueRange<T>(this Queue<T> queue, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                queue.Enqueue(item);
            }
        }
    }
}