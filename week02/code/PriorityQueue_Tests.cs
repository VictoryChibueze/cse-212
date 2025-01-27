using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Test the behavior of the PriorityQueue when enqueuing multiple items with different priorities.
    // The test enqueues three items with varying priorities: "item1" with priority 1,"item2" with priority 3,"item3" with priority 2 .
    // It then dequeues one item and checks if the dequeued item is the one with the highest priority.
    // Expected Result: The item with the highest priority (item2 with priority 3) should be dequeued first.
    // The expected result is that "item2" will be returned when calling Dequeue().
    // Defect(s) Found: None (The test passed, so there are no defects in this case).
    
    public void TestPriorityQueue_1()
    {
        // Arrange
        var priorityQueue = new PriorityQueue();

        // Enqueue items
        priorityQueue.Enqueue("item1", 1);  
        priorityQueue.Enqueue("item2", 3);  
        priorityQueue.Enqueue("item3", 2);  
        
        // Act
        var item = priorityQueue.Dequeue();  
        
        // Assert
        Assert.AreEqual("item2", item);
    }


    [TestMethod]
    // Scenario: Testing PriorityQueue when enqueuing multiple items with the same priority.
    // The test enqueues two items (item1 and item2) both with priority 2, and then dequeues them. 
    //It checks if the order of dequeued items respects the FIFO (First In, First Out) rule for equal priorities. 
    // Expected Result: The queue should maintain FIFO order for items with the same priority.
    //The expected dequeued order should be "item1" followed by "item2", as item1 was enqueued first.
    // Defect(s) Found: "item1" was dequeued before "item2", but it was expected that "item2" would be dequeued first.
    public void TestPriorityQueue_2()
    {
        // Arrange
        var priorityQueue = new PriorityQueue();
        
        // Enqueue items with the same priority
        priorityQueue.Enqueue("item1", 2);  
        priorityQueue.Enqueue("item2", 2);  
        
        // Act
        var item1 = priorityQueue.Dequeue();  
        var item2 = priorityQueue.Dequeue();  
        
        // Assert
        Assert.AreEqual("item1", item1);
        Assert.AreEqual("item2", item2);
    }


    [TestMethod]
    // Scenario: Testing the behavior of the PriorityQueue when trying to dequeue from an empty queue.
    // This scenario checks if the queue correctly handles the case where a dequeue operation is attempted 
    // on an empty queue and whether it raises the appropriate exception.
    // Expected Result: Since the queue is empty, calling Dequeue should throw an InvalidOperationException.
    // The exception message would indicate that the queue is empty and cannot perform a dequeue operation.
    // Defect(s) Found: None (The test passed, so there are no defects in this case).
    public void TestPriorityQueue_3()
    {
        // Arrange
        var priorityQueue = new PriorityQueue();
        
        // Act & Assert
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "Queue is empty, cannot dequeue.");
    }

    [TestMethod]
    // Scenario: Testing the behavior of the PriorityQueue when enqueuing multiple items with varying priorities. 
    //The test enqueues four items with different priorities: item1 (priority 1), item2 (priority 3), item3 (priority 2), and item4 (priority 3).
    // It then dequeues all the items and checks the order of dequeued items.
    // Expected Result: The expected dequeued order should be "item2", "item4", "item3", and "item1" based on the priority order.
       //Items with priority 3 (item2 and item4) should be dequeued first, followed by items with priority 2 (item3), and lastly, items with priority 1 (item1).
       //For items with the same priority (item2 and item4), the order of insertion (FIFO) should be respected, so item2 should be dequeued before item4.
    // Defect(s) Found: The test failed because "item2" was dequeued first instead of "item4". The dequeued order was incorrect.
    public void TestPriorityQueue_4()
    {
        // Arrange
        var priorityQueue = new PriorityQueue();
        
        // Enqueue items
        priorityQueue.Enqueue("item1", 1);
        priorityQueue.Enqueue("item2", 3);
        priorityQueue.Enqueue("item3", 2);
        priorityQueue.Enqueue("item4", 3);  
        
        // Act
        var item1 = priorityQueue.Dequeue(); 
        var item2 = priorityQueue.Dequeue();  
        var item3 = priorityQueue.Dequeue();  
        var item4 = priorityQueue.Dequeue(); 
        
        // Assert
        Assert.AreEqual("item2", item1);
        Assert.AreEqual("item4", item2);
        Assert.AreEqual("item3", item3);
        Assert.AreEqual("item1", item4);
    }

    [TestMethod]
    // Scenario: Testing the behavior of the PriorityQueue when enqueuing only a single item into an empty queue and then dequeuing it. 
    //This scenario checks if the queue correctly handles the basic enqueue and dequeue operations with just one item.
    // Expected Result: The queue should correctly handle the enqueueing and dequeuing of a single item.
          //After enqueuing "item1" with priority 1, it should be the only item in the queue.
          //When calling Dequeue, the queue should return "item1", and the queue should become empty.
    // Defect(s) Found: None (The test passed, so there are no defects in this case).
    public void TestPriorityQueue_5()
    {
        // Arrange
        var priorityQueue = new PriorityQueue();
        
        // Enqueue one item
        priorityQueue.Enqueue("item1", 1);
        
        // Act
        var item = priorityQueue.Dequeue();  
        
        // Assert
        Assert.AreEqual("item1", item);
    }

}