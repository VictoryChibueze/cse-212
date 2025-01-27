using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    
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
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
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
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        // Arrange
        var priorityQueue = new PriorityQueue();
        
        // Act & Assert
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "Queue is empty, cannot dequeue.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
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
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
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