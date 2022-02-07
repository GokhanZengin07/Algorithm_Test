using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Test
{

    public class Challenge1
    {

        public String Reverse2(string input)
        {
            if (string.IsNullOrEmpty(input))
            { return input; }
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public string ReverseEachWord(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();

            string [] arr=input.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(Reverse2(arr[i]));
                if (i!=arr.Length-1)
                {
                    result.Append(' ');
                } 
            }

            return result.ToString();

        }

    }

  


}
