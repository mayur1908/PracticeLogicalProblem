﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class VowelConsonant
    {
        public static void checkedAlphabet()
        {

            Console.WriteLine("Enter any Alphabet");
            char ch =Convert.ToChar(Console.Read());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U') 
            {
                Console.WriteLine(ch + " it is vowel");
            }
            else if((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " it is consonant");
            }
            else 
            {
                Console.WriteLine(ch + " it is not valid input");
            }
        }
    }

}  