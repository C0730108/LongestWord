using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
      
       
        
            static void Main(string[] args)
            {
                Program a = new Program();
                Console.WriteLine("The longest word is :");
                Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm desigined for processing by an Analytical Engine."));

            }
            public string MyFunctionA(string input)
            {
                //write a C# program to find the longrst word in a string.
                string[] words = input.Split(' ');

                int wordArrayLength = words.Length;
                int[] wordsLength = new int[wordArrayLength];
                int x = 0;

                foreach (var word in words)
                {
                    //todo
                }

                //loop post condition: we now have array wordaLength which
                //contains the lengths of each word

                String currentWord = words[0];
                String nextWord;
                String longestWord = currentWord;

                for (int y = 0; y < words.Length - 1; y++)
                {

                    currentWord = words[y];
                    nextWord = words[y + 1];
                    if (nextWord.Length > longestWord.Length)
                    {
                        longestWord = nextWord;
                    }
                    else
                    {
                        longestWord = currentWord;
                    }
                }


                //TODO:Use an IF Statement to make sure that variable longestWord
                //is always set to the Longest Word in the input string

            }

        }
    }


    

