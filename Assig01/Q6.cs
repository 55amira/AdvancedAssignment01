using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig01
{
    internal class Q6
    {
        public static int FindTheFirstNonRepeatedCharacter(string s)
        {
            
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))  
                {
                    charCount[c]++;  
                }
                else
                {
                    charCount[c] = 1; 
                }
            }

            
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)  
                {
                    return i;  
                }
            }

            return -1;  
        }
    }
}
