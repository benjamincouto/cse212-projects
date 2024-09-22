public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Define list to store multiples of "number"
        List<double> results = new();

        //FOR loop to multiply "number" with number from 1 to "length" to get multiples, add them to results
        for (double i = 1; i < length; i++)
        {
            results.Add(number * i);
        }

        //convert list to array, return results
        return results.ToArray(); // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        
        //Slice list from index 0 to "amount"
        List<int> firstPart = data.GetRange(0, data.Count - amount);
        //Slice list from "amount" to count
        List<int> lastPart = data.GetRange(data.Count - amount, amount);

        //Combine both to define new list by clearing the original list and adding both parts to data
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
        
    }
}
