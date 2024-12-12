using System;
using System.Collections.Generic;

public class DynamicIsland
{
    static int totalIsland = 0;
    public static void Main(){

        int[,] arr = new int[4,6]{
                            {0,1,1,0,1,1},
                            {0,1,0,0,0,1}, 
                            {0,0,1,1,0,0},
                            {1,0,0,0,0,1}
                       };

        for(int i=0;i<4;i++)
        {
            for(int j=0;j<6;j++)
            {
                    totalIsland += FindIsland(arr, i, j);
            }
        }
        Console.WriteLine("Total Island: "+totalIsland);
    }

    public static int FindIsland(int[,] array, int i, int j){

        if(i < 0 || j < 0 || i >= 4 || j >= 6 || array[i, j] == 0||array[i, j] == -2){
            return 0;
        }

        if(array[i, j] == 1){
            array[i, j] = -2;
        }

        FindIsland(array, i, j + 1);
        FindIsland(array, i + 1, j);
        FindIsland(array, i - 1, j);
        FindIsland(array, i, j - 1);
        return 1;
    }

    public static void print(int[,] array)
    {
        for(int i = 0;i < 4;i++)
        {
            for(int j = 0;j < 6;j++)
            {
                Console.Write(array[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}
