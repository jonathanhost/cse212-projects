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
    // Creating a new array with a new size
    double[] multiples = new double[length];

    // run a for to populate the array, multiplying the numbers
    for (int i = 1; i < length + 1; i++)
    {
        multiples[i-1] = number * i;
    }

    return multiples;
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
     
    int n = data.Count;
    amount = amount % n; // verify if the amount is higher the list
    if (amount == 0) return;

    // Take the last elements 
    List<int> tail = data.GetRange(n - amount, amount);

    // Removing elements from the end of the list
    data.RemoveRange(n - amount, amount);

    // add to the beginning
    data.InsertRange(0, tail);
}
}
