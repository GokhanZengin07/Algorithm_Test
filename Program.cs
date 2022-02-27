using System;
using System.Linq;
using System.Text;


namespace Algorithm_Test
{
    
    
    
    public class Program

    {   

        static String Reverse2( string input)
        {
            if (string.IsNullOrEmpty(input))
            { return input; }
            char[]arr=input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static String Reverse(string input)
        {
            if(string.IsNullOrEmpty(input))
            { return input; }
            StringBuilder reversed = new StringBuilder(input.Length);
            for (int i = input.Length-1; i >=0;i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();

        }
        static void ParseContents(string s)
        {
            Console.WriteLine("Option 1");
            foreach (var ch in s)
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine("Option 2");
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }
        }
        static Boolean IsAtEvenIndex(string s,char item)
        {
            if (string.IsNullOrEmpty(s))

            {
                return false;
            }
            for (int i = 0; i < s.Length/2+1; i=i+2)
            {
                if(s[i]==item)
                {
                    return true;
                }

            }
            return false;
        }

        static string NormalizeString(String input)
        {
            return input.ToLower().Trim().Replace(",", "");

                
        }
        static void Main(string[] args)

           
        {
            Console.WriteLine("reve");
            Console.WriteLine(Reverse2("asd"));
            Console.WriteLine(Reverse("asd"));
            Console.WriteLine(IsAtEvenIndex("HelLo",'l'));
            Console.WriteLine(IsAtEvenIndex(null, 'l'));
            ParseContents("asdwe");
            Console.WriteLine(maxNumber(5, 6, 8));
            Console.ReadLine();
            Console.WriteLine(maxNumber2(5, 61 ,8));
            Console.ReadLine();
            Console.WriteLine(isUpper("HeLoo"));
            Console.ReadLine();
            Console.WriteLine(isUpper("heloo"));
            Console.ReadLine();
            Console.WriteLine(NormalizeString("heloo   , asd"));
            Console.ReadLine();
            Console.WriteLine("asdasd".Contains("as"));

        }
        static Boolean isPasswordComplex(string s)
        {   
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }
        static Boolean isUpper(string s)
        {
            return s.All(char.IsUpper);
        }
        static Boolean isLower(string s)
        {
            return s.All(char.IsLower);
        }
        static int maxNumber(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c || a == c)
                {
                    return a;
                }
            }
            if (b > c)
            {
                if (b > a || b == a)
                {
                    return b;
                }
            }

            return c;
        }
        static int maxNumber2(int a, int b, int c)
        {
            int max = a;
            if(b>max)
            { max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }
    }
}



