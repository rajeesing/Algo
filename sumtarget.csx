public class SumTarget
{
    public int[] FindPairs(int[] numbers, int target)
    {
        var numDict = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int complement = target - numbers[i];
            if (numDict.ContainsKey(complement))
            {
                return new int[] { numDict[complement], i };
            }
            numDict[numbers[i]] = i;
        }
        return new int[0];
    }
}

var result = new SumTarget().FindPairs(new int[] { 1, 2, 4, 5 }, 5);
foreach (var pair in result)
{
    Console.WriteLine($"Pair found: {pair}");
}
