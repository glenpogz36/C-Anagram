using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    
    public static void Main()
    {
        List<string> wordList = new List<string>();
        List<string> anagramList = new List<string> {};
        string wordEntered;
       
    

        Console.WriteLine("Enter a word to check Anagram");
       string userInput = Console.ReadLine();

       Console.WriteLine("Enter another word to compare");
       wordEntered = Console.ReadLine();
        
        while(!string.IsNullOrEmpty(wordEntered) && wordEntered!="Q")
        {   
        
       wordList.Add(wordEntered);
        

         Console.WriteLine("Enter a new word to compare or 'Q' to Quit");
         wordEntered = Console.ReadLine();
      }



   
   
   CheckAnagram myAnagram = new CheckAnagram();
            foreach (string listString in wordList)
            {
                if (myAnagram.IsAnagram(userInput, listString))
                {
                anagramList.Add(listString);
                Console.WriteLine("We've found an anagram in your list!");
               
                }
               
            }     
    }

   

    public class CheckAnagram
    {
        public bool IsAnagram(string Input, string fromList)
        {
            char[] arrayOne = Input.ToCharArray();
            char[] arrayTwo = fromList.ToCharArray();

            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            return arrayOne.SequenceEqual(arrayTwo);
        }
    }

        // string firstWord = new string (arr);
        // string secondWord = new string (arr2);

        // if (firstWord == secondWord)
        // {
        //     Console.WriteLine("The word is Anagram");
        // }
        // else 
        // {
        //     Console.WriteLine("It's not a Anagram");
        // }

   
      
}