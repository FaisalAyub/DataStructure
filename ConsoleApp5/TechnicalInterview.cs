using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  public  class TechnicalInterview
    {
        public string ReverseString(string Name)
        {
            string reverseString = "";
            char[] characterArray = Name.ToCharArray();
            
            for(int i = characterArray.Length - 1; i >= 0; i--)
            {
                reverseString += characterArray[i];
            }
            return reverseString;
        }

        public bool IsPalindrome(string Namee)
        {
            string Name= Namee.ToLower();
            for(int x = 0; x <= Name.Length - 1; x++)
            { 
                if (Name[x] != Name[Name.Length - 1 - x])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
