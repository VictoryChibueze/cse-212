/// <summary>
/// This queue is circular.  When people are added via AddPerson, then they are added to the 
/// back of the queue (per FIFO rules).  When GetNextPerson is called, the next person
/// in the queue is saved to be returned and then they are placed back into the back of the queue.  Thus,
/// each person stays in the queue and is given turns.  When a person is added to the queue, 
/// a turns parameter is provided to identify how many turns they will be given.  If the turns is 0 or
/// less than they will stay in the queue forever.  If a person is out of turns then they will 
/// not be added back into the queue.
/// </summary>

public class TakingTurnsQueue
{
    private readonly Queue<Person> _people = new();

    /// <summary>
    /// Gets the number of people currently in the queue.
    /// </summary>
    public int Length => _people.Count;

    /// <summary>
    /// Add a new person to the queue with a name and number of turns.
    /// </summary>
    /// <param name="name">The name of the person.</param>
    /// <param name="turns">The number of turns the person has (0 or less for infinite turns).</param>
    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    /// <summary>
    /// Get the next person in the queue and return them. If the person has
    /// remaining turns or infinite turns, they are re-added to the back of the queue.
    /// If the queue is empty, an exception is thrown.
    /// </summary>
    /// <returns>The next person in the queue.</returns>
    public Person GetNextPerson()
    {
        if (_people.Count == 0)
        {
            throw new InvalidOperationException("No one in the queue.");
        }

        var person = _people.Dequeue();

        // Re-add to the queue if the person has remaining or infinite turns.
        if (person.Turns <= 0 || person.Turns > 1)
        {
            if (person.Turns > 0)
            {
                person.Turns--; // Decrease finite turns
            }
            _people.Enqueue(person);
        }

        return person;
    }

    public override string ToString()
    {
        return string.Join(", ", _people.Select(p => $"{p.Name} ({(p.Turns <= 0 ? "∞" : p.Turns.ToString())})"));
    }
}
