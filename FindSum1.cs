using System;

class SlidingWindow{
    public static void Main()
    {
        int[] arr = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
        int k = 4;
        int n = arr.Length;
        Console.WriteLine(FindSum(arr, n, k));
        Console.WriteLine(BruteForce(arr, n, k));
        Console.ReadKey();
    }

    public static int FindSum(int[] arr, int n, int k){
        int sum = 0, tempSum=0;

        for(int i = 0;i < k; i++){
            sum += arr[i];
        }

        for(int i = k;i < n; i++){
            tempSum += arr[i] + arr[i - k];
            sum = Math.Max(sum,tempSum);    
        }

        return sum;
    }

    public static int BruteForce(int[] arr, int n, int k){
        int tempSum = 0;
        int sum = Math.MinValue();
        for(int i = 0;i < n; i++){
            for(j = i; j < k; j++){
                tempSum += arr[j];
            }
        }
    }
}
