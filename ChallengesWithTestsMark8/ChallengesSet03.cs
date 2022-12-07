using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
                return false;
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
           if(numbers == null || numbers.Count() ==0) 
            {
            return false;
            }

           var sum = numbers.Sum();
            return (sum % 2 !=0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isLower = false;
            bool isNumber = false;
            bool isUpper = false;

            foreach ( var letter in password ) 
            {
                if (char.IsLower(letter) ) 
                {
                    isLower= true;
                }
                if (char.IsNumber(letter))
                {
                    isNumber = true;
                }
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }
              
            }
             return isUpper && isLower && isNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0: dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] myArray= new int[50];
            int index =0;
            for (int i = 0; i < 100; i++)
            { 
            if (i % 2 != 0)
                {
                    myArray[index] = i;
                    index++;
                }
            }
            return myArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
          for (int i = 0; i < words.Length;i++) 
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
