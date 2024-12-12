using System;

public class WordLookup{
    public static void Main(){
        char[,] grid1 = new char[7,6]
        {
            {'c', 'c', 'x', 't', 'i', 'b'},
            {'c', 'c', 'a', 't', 'n', 'i'},
            {'a', 'c', 'n', 'n', 't', 't'},
            {'t', 'c', 's', 'i', 'p', 't'},
            {'a', 'o', 'o', 'o', 'a', 'a'},
            {'o', 'a', 'a', 'a', 'o', 'o'},
            {'k', 'a', 'i', 'c', 'k', 'i'},
        };
        string searchWord="catnip";
         int x=0,p=0;
        for(int i = 0;i < 6;i++){
            for(int j = 0;j < 7;j++){
               
               Find(grid1, i, j,searchWord,p);
            }
        }
    }

    public static void Find(char[,] grid, int i, int j,string searchWord, int charIndex){
         if(i >= 7 || j >= 6||grid[i,j]=='*'){
            return;
        }
        
        if(charIndex == searchWord.Length){
            return;
        }

        if(grid[i, j] == searchWord[charIndex]){
            Console.WriteLine(i+", "+j);
            //grid[i,j]='*';
            Find(grid, i + 1, j, searchWord, charIndex+1);
            Find(grid, i, j + 1, searchWord, charIndex+1);
        }
        else
        {
            charIndex--;
        }
    }
}
