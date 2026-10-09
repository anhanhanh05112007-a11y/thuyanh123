using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuyanh123.Session_8
{
    internal class Bai_tap_nop_7
    {

        static void cau_1()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("The string is: " + s);
        }

        static void cau_2()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            int count = 0;
            foreach (char c in s)
            {
                count++;
            }
            Console.WriteLine("Length of the string is: " + count);
        }

        static void cau_3()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("The characters of the string are:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Character " + i + ": " + s[i]);
            }
        }

        static void cau_4()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("The characters in reverse order:");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }

        static void cau_5()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            int words = 0;
            bool inWord = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || s[i] == '\t')
                {
                    inWord = false;
                }
                else if (!inWord)
                {
                    inWord = true;
                    words++;
                }
            }
            Console.WriteLine("Total number of words in the string is: " + words);
        }

        static void cau_6()
        {
            Console.Write("Input the first string: ");
            string s1 = Console.ReadLine();
            Console.Write("Input the second string: ");
            string s2 = Console.ReadLine();

            int len1 = 0, len2 = 0;
            foreach (char c in s1) len1++;
            foreach (char c in s2) len2++;

            bool same = true;
            if (len1 != len2)
            {
                same = false;
            }
            else
            {
                for (int i = 0; i < len1; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        same = false;
                        break;
                    }
                }
            }

            if (same)
                Console.WriteLine("The two strings are equal.");
            else
                Console.WriteLine("The two strings are not equal.");
        }

        static void cau_7()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            int alphabets = 0, digits = 0, special = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    alphabets++;
                else if (c >= '0' && c <= '9')
                    digits++;
                else
                    special++;
            }
            Console.WriteLine("Number of alphabets: " + alphabets);
            Console.WriteLine("Number of digits: " + digits);
            Console.WriteLine("Number of special characters: " + special);
        }

        static void cau_8()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            int vowels = 0, consonants = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = char.ToLower(s[i]);
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    vowels++;
                else if (c >= 'a' && c <= 'z')
                    consonants++;
            }
            Console.WriteLine("Number of vowels: " + vowels);
            Console.WriteLine("Number of consonants: " + consonants);
        }

        // returns the first position of sub in s starting from index start, or -1 if not found
        static int find(string s, string sub, int start)
        {
            if (sub.Length == 0) return -1;
            for (int i = start; i <= s.Length - sub.Length; i++)
            {
                int j = 0;
                while (j < sub.Length && s[i + j] == sub[j])
                {
                    j++;
                }
                if (j == sub.Length) return i;
            }
            return -1;
        }

        static void cau_9()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            Console.Write("Input the substring to check: ");
            string sub = Console.ReadLine();
            if (find(s, sub, 0) != -1)
                Console.WriteLine("The substring is present in the string.");
            else
                Console.WriteLine("The substring is not present in the string.");
        }

        static void cau_10()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            Console.Write("Input the substring to search: ");
            string sub = Console.ReadLine();
            int pos = find(s, sub, 0);
            if (pos == -1)
                Console.WriteLine("The substring was not found.");
            else
                Console.WriteLine("The substring is found at position: " + pos);
        }

        static void cau_11()
        {
            Console.Write("Input a character: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (c >= 'A' && c <= 'Z')
                Console.WriteLine(c + " is an alphabet and it is in uppercase.");
            else if (c >= 'a' && c <= 'z')
                Console.WriteLine(c + " is an alphabet and it is in lowercase.");
            else
                Console.WriteLine(c + " is not an alphabet.");
        }

        static void cau_12()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            Console.Write("Input the substring to count: ");
            string sub = Console.ReadLine();
            int count = 0;
            int pos = find(s, sub, 0);
            while (pos != -1)
            {
                count++;
                pos = find(s, sub, pos + sub.Length);
            }
            Console.WriteLine("The substring appears " + count + " time(s) in the string.");
        }

        static void cau_13()
        {
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            Console.Write("Input the string to look for: ");
            string target = Console.ReadLine();
            Console.Write("Input the substring to insert: ");
            string insert = Console.ReadLine();
            int pos = find(s, target, 0);
            if (pos == -1)
            {
                Console.WriteLine("The string to look for was not found.");
            }
            else
            {
                string result = s.Substring(0, pos) + insert + s.Substring(pos);
                Console.WriteLine("New string: " + result);
            }
        }

        static void Main(string[] args)
        {
            cau_1();
            //cau_2();
            //cau_3();
            //cau_4();
            //cau_5();
            //cau_6();
            //cau_7();
            //cau_8();
            //cau_9();
            //cau_10();
            //cau_11();
            //cau_12();
            //cau_13();

            Console.ReadKey();
        }
    }
}
