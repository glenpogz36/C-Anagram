using System;
using System.Collections.Generic;

class Program
{
    
    public static void Main()
    {

        Console.WriteLine("Enter a word to convert into Anagram");
        string wordEntered = Console.ReadLine();
        char[] arr;
        arr = wordEntered.ToCharArray();
       Array.Sort(arr);
        

         Console.WriteLine("Enter a new word to compare");
         wordEntered = Console.ReadLine();
        char[] arr2;
        arr2 = wordEntered.ToCharArray();
       Array.Sort(arr2);
      

        string firstWord = new string (arr);
        string secondWord = new string (arr2);

        if (firstWord == secondWord)
        {
            Console.WriteLine("The word is Anagram");
        }
        else 
        {
            Console.WriteLine("It's not a Anagram");
        }

    }
}