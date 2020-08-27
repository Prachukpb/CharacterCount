using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCount
{
    class Program
    {

        static void Main(string[] args)
        {

            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();  //Declare an array of alphabets
            List<int> Occ = new List<int>();    //Declare a list object to store all the frequency of alphabets
            int upper = 0;  //Declare a int variable to store the # of letters in the given string 

            // Read the string from Console
            Console.Write("Enter the string : ");
            string str = Console.ReadLine().ToUpper();  //Convert the string to uppercase    

            //for each item in the alpha[], count the number of occurrences in the given string.
            foreach (char i in alpha)
            {
                int freq = str.Count(f => (f == i));    //Using Linq count function, the frequency of each alphabet is counted
                Occ.Add(freq);  //Store the frequencies in a list
            }

            //Calculate the total number of alphabets in the given string
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    upper++;                
            }

            Console.WriteLine("{0}", string.Join(" ", alpha)); //Display the Array of alphabets
            Console.WriteLine("{0}", string.Join(" ", Occ.ToArray())); //Display the respective frequency count array
            Console.WriteLine("The text has been processed."); //Success message
            Console.WriteLine("Total letters counted:" + upper); //Display the total alphabet count in the string            
        }
    }
}
 