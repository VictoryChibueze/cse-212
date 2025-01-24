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
         

        // PLAN
        // Step 1: Create an array of size 'length' to store the results.
        // Step 2: Use a loop to calculate multiples of 'number'.
        // Step 3: Return the array.


        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            // Each element is the number multiplied by (index + 1).
            result[i] = number * (i + 1);
        }

        
        return result;
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

        ///PLAN
        // Step 1: Handle edge cases where no rotation is needed.
        // Step 2: Normalize the amount to ensure it doesn't exceed the list size.
        // Step 3: Use a combination of slicing and concatenation to rotate the list.
            // - Take the last 'rotateBy' elements.
            // - Take the remaining elements from the beginning.
            // - Combine them in the correct order.
        // Step 4: Clear the original list and update it with the new order.

        if (data == null || data.Count <= 1 || amount % data.Count == 0)
            return;

     
        int rotateBy = amount % data.Count;

        List<int> rotatedPart = data.GetRange(data.Count - rotateBy, rotateBy);
        List<int> remainingPart = data.GetRange(0, data.Count - rotateBy);

        data.Clear();
        data.AddRange(rotatedPart);
        data.AddRange(remainingPart);

    }
}
