// Write a C# program that takes a string input containing duplicate characters.
//The program must count the occurrences of each character and reconstruct the string by appending the count directly after each character.
//Finally, print the characters in descending order based on their count frequency.If two characters have the same frequency, sort them alphabetically.

//Sample input = "Softsquare Success"
//Sample output = s5u2e2c2o1f1t1q1a1r1

using System;
using System.Collections.Generic;
using System.Linq;

class StrBld {
    
    static void Main() {
        
        Console.Write("Enter something: ");
        string ip = Console.ReadLine().ToLower().Replace(" ", "");
        
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        
        foreach(char ch in ip) {
            
            if(!charCount.ContainsKey(ch)) {
                charCount[ch] = 1;
            }
            else {
                charCount[ch] += 1;
            }
        }
        
        foreach(KeyValuePair<char, int> el in charCount.OrderByDescending(dic => dic.Value)) {
            
            Console.Write(el.Key + "" + el.Value);
        }
    }
}
