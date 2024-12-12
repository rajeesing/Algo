using System;

class BinarySearch{
    static bool rcurrFound =false;
    public static void Main()
    {
        int[] arr = { 1, 2, 4, 10, 12, 13, 21, 40, 120 };

        Console.Write("Enter Search Item: ");
        var item = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Search(arr, item));
        Console.WriteLine(Recursive(arr,item,0,arr.Length));
    }

    public static int Search(int[] arr, int searchItem)
    {
        int low = 0, high = arr.Length-1;
        
        while(low <= high)
        {
            var mid = (low + high) / 2;

            if(arr[mid] == searchItem)
            {
                return arr[mid];
            }
            if(arr[mid] < searchItem)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return 0;
    }


    public static bool Recursive(int[] arr, int searchVal, int start, int end)
    {
         if(start != end)
        {
            var mid = (start + end) / 2;

            if(arr[mid] == searchVal)
            {
                rcurrFound = true;
            }
            
            if(arr[mid] <= searchVal)
                Recursive(arr, searchVal, mid+1, end);
            else
                Recursive(arr, searchVal, start,  mid-1);
        }
        return rcurrFound;
    } 
}
