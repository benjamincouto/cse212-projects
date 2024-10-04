using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items and priority: John(500), Mary(600), Mark(400), Hannah(300). Test dequeuing order is correct 
    // Expected Result: John, Mary, Mark, Hannah
    // Defect(s) Found: The highest priority item in the queue was not being removed
    //                  for loop within Dequeue() was not iterating through all items(removed "-1"). 
    //                  Conditional within for loop with >= would prioritize the last element when an equal is found, changed it to >                
    // Test1: Assert.AreEqual error, <John> was expected but it is <Mary>
    // Test2: Index was out of range
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("John", 500);
        priorityQueue.Enqueue("Mary", 600);
        priorityQueue.Enqueue("Mark", 400);
        priorityQueue.Enqueue("Hannah", 300);

        //Expected dequeue order
        string[] expectedResult = { "Mary", "John", "Mark", "Hannah" };

        for (int i = 0; i < expectedResult.Length; i++)
        {
            var dequeuedItem = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], dequeuedItem, $"Dequeued item at position {i} should be {expectedResult[i]}.");
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following items and priority: John(500), Mary(600), Mark(400), Hannah(300). Test dequeuing order is correct when multiple items with same priority are present
    // Expected Result: Carlos should be dequeued before Jannik (FIFO)
    // Defect(s) Found: The highest priority item in the queue was not being removed
    //                  for loop within Dequeue() was not iterating through all items(removed "-1"). 
    //                  Conditional within for loop with >= would prioritize the last element when an equal is found, changed it to >
    // Test1: Assert.AreEqual error, <Carlos> was expected but it is <Jannik>
    // Test2: Index was out of range
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Carlos", 500);
        priorityQueue.Enqueue("Jannik", 500);
        priorityQueue.Enqueue("Novak", 400);

        //Expected dequeue order
        string[] expectedResult = { "Carlos", "Jannik", "Novak" };
        
        for (int i = 0; i < expectedResult.Length; i++)
        {
            var dequeuedItem = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], dequeuedItem, $"Dequeued item at position {i} should be {expectedResult[i]}.");
        }
    }

        [TestMethod]
    // Scenario: Queue is empty
    // Expected Result: Error "The queue is empty."
    // Defect(s) Found: No defects
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "Dequeueing from an empty queue should throw an InvalidOperationException.");
    }

        [TestMethod]
    // Scenario: Add items with different priorities "out of order": Benjamin(700), Camila(300), Eliza(500), Andres(700)
    // Expected Result: Dequeue should be according to priority (Benjamin, Andres, Eliza, Camila)
    // Defect(s) Found: The highest priority item in the queue was not being removed
    //                  for loop within Dequeue() was not iterating through all items(removed "-1"). 
    //                  Conditional within for loop with >= would prioritize the last element when an equal is found, changed it to >
    // Test1: Assert.AreEqual error, <Andres> was expected but it is <Benjamin>
    // Test2: Index was out of range
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Benjamin", 700);
        priorityQueue.Enqueue("Camila", 300);
        priorityQueue.Enqueue("Eliza", 500);
        priorityQueue.Enqueue("Andres", 700);
        
        //Expected dequeue order
        string[] expectedResult = {"Benjamin", "Andres", "Eliza", "Camila" };

        for (int i = 0; i < expectedResult.Length; i++)
        {
            var dequeuedItem = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], dequeuedItem, $"Dequeued item at position {i} should be {expectedResult[i]}.");
        }
    }

}