public class PriorityQueue
{
    private List<PriorityItem> _queue = new();
    private int _orderCounter = 0;

    /// <summary>
    /// Adds a new value to the queue with an associated priority.
    /// The node is always added to the back of the queue regardless of the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority, _orderCounter++);
        _queue.Add(newNode);
    }

    public string Dequeue()
    {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the item with the highest priority and the lowest order
        var highestPriorityItem = _queue
            .OrderByDescending(item => item.Priority) // Sort by priority (descending)
            .ThenBy(item => item.Order)              // Sort by order (ascending)
            .First();

        _queue.Remove(highestPriorityItem); // Remove the selected item
        return highestPriorityItem.Value;  // Return the value
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }
    internal int Order { get; set; } // Keeps track of the insertion order

    internal PriorityItem(string value, int priority, int order)
    {
        Value = value;
        Priority = priority;
        Order = order;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority}, Order:{Order})";
    }
}
