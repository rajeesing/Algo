using System;
using System.Collections.Generic;

public class Fibo{
    public static void Main(){
        var i =0;
        Console.Write("Fibonacci Series maximum go to?: ");
        int max = Convert.ToInt32(Console.ReadLine());

        /******************** RECURSIVE ************************************/
        Console.WriteLine("By Recursive:");
        while(i < max){
           Console.Write(FibonacciRecur(i++)+" ");
        }

        /******************** BRUTE FORCE ************************************/
        Console.WriteLine("\n\nBy Brute Force:");
        FibonacciBF(max);

        /******************** RECURSIVE WITH MEM ************************************/
        Console.WriteLine("\n\nBy Memoisation:");
        List<int> listMem = new List<int>();

        i = 0;
        while(i++ < max){ //initialize with -1 each array element to mark as called already
            listMem.Add(-1);
        }

        i = 0;
         while(i < max){
            listMem[i] = FibonacciMem(i++, listMem);
        }
        PrintList(listMem);
    }

    public static int FibonacciRecur(int upto){
        if(upto <= 1){
            return  upto;
        }
        
        return FibonacciRecur(upto -2) + FibonacciRecur(upto-1);
    }
    public static void FibonacciBF(int upto){
        List<int> list = new List<int>();

        if(upto <= 1){
            return;
        }

        list.Add(0);
        list.Add(1);
        for(int i=2;i<upto;i++)
        { 
           list.Add(list[i-2]+list[i-1]);
        }

        PrintList(list);
    }
    public static  int FibonacciMem(int upto, List<int> list){
        if(upto <= 1){
            return  upto;
        }
       
        if(list[upto] != -1){
            return  list[upto];  
        }
       
        return FibonacciMem(upto - 2, list) + FibonacciMem(upto - 1, list);
    }
    public static void PrintList(List<int> list){
        foreach(int i in list){
            Console.Write(i+" ");
        }
    }
}
