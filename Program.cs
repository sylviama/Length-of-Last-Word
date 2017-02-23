using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            string s="";
            
            Solution solu=new Solution();
            int lengthOfLast=solu.LengthOfLastWord(s);
            Console.WriteLine("{0}", lengthOfLast);
        }
    }
    

    public class Solution {
        public int LengthOfLastWord(string s) {
            try
            {
                char[] charArray=s.ToCharArray();
                int LastIndexPosition=charArray.Length;
                int FirstIndexPosition=0;
                
                //find the last word's last letter
                for(var i=charArray.Length-1;i>=0;i--)
                {
                    
                    if(charArray[i]!=' ')
                    {
                        LastIndexPosition=i;
                        break;
                    } 
                }
                
                //find the last word's first letter
                for(var j=LastIndexPosition; j>=0; j--)
                {
                    if(charArray[j]==' ')
                    {
                        FirstIndexPosition=j+1;
                        break;
                    }
                    
                }
                int leng=LastIndexPosition-FirstIndexPosition+1;
                return leng;
            }
            catch(IndexOutOfRangeException)
            {
                return 0;
            }
        }
    }
}
