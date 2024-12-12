using System;
using System.Collections.Generic;

public class TOH
{

    public static void Main()
    {
        int totalDiscs = 3;
        int stackA = 1, stackB = 2, stackC = 3;
        Find(totalDiscs, stackA, stackB, stackC);
    }

    public static void Find(int totalDiscs, int stackA, int stackB,int stackC)
    {
        if (totalDiscs > 0)
        {
            Find(totalDiscs - 1, stackA, stackC, stackB);
            Console.WriteLine(stackA + ", " + stackC);
            Find(totalDiscs - 1, stackB, stackA, stackC);
        }
    }
}
