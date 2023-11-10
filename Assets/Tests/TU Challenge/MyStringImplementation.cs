using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UIElements;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        internal static string BazardString(string input)
        {
            string stringBazard = "";
            for (int i = 0; i <= input.Length - 1; i=i+2)
            {
                stringBazard += input[i];
            }
            for (int i = 1; i <= input.Length - 1; i = i + 2)
            {
                stringBazard += input[i];
            }
            return stringBazard;
        }

        internal static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == "" || input == null)
            {
                return true;
            }
            for(int i = 0; i< input.Length-1;i++) 
            {
                string character = "";
                character += input[i];
                if (character != " ")
                {
                    return false;
                }
                character = "";
            }
            return true;
        }

        internal static string MixString(string a, string b)
        {
            string c = "";
            int lenght = 0;
            int end = 0;
            int i = 0;
            if (a == null || b == null || a == "" || b == "")
            {
                throw new ArgumentException();
            }
            if (a.Length < b.Length)
            {
                lenght = a.Length;
                end = b.Length-a.Length;
            }
            else
            {
                lenght = b.Length;
                end =  a.Length - b.Length;
            }
            for(; i< lenght ; i++)
            {
                c += a[i];
                c += b[i];
            }
            for(int y = 0; y < end;y++)
            {
                if (a.Length < b.Length)
                {
                    c += b[i + y];
                }
                else
                {
                    c += a[i + y];
                }
            }
            return c;
        }

        internal static string ToCesarCode(string input, int offset)
        {
            string code = "";
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] += (char)(i + 65);
            }
            for(int y = 0; y < input.Length;y++) 
            {
                if(input[y] == ' ')
                { 
                    code += input[y];
                }
                for (int z = 0 ; z < 26; z++)
                {
                    if (alphabet[z] == input[y])
                    {
                        if (z + offset > 26)
                        {
                            code += alphabet[(z + offset)-26];
                        }
                        code += alphabet[z+offset];
                    }
                }
            }
            return code;
        }

        internal static string ToLowerCase(string a)
        {
            return a.ToLower();
        }

        internal static string UnBazardString(string input)
        {
            int length = input.Length;
            char[] originalOrder = new char[length];

            for (int i = 0; i < length; i++)
            {
                int originalIndex = (i % 2 == 0) ? i / 2 : length / 2 + i / 2;
                originalOrder[originalIndex] = input[i];
            }

            return new string(originalOrder);
        }

        internal static string Voyelles(string a)
        {
            string voyelle="";
            bool notIn = true;
            for (int i=0; i < a.Length; i++)
            {
                if (char.ToLower(a[i]) == 'a' || char.ToLower(a[i]) == 'e' || char.ToLower(a[i]) == 'i' || char.ToLower(a[i]) == 'o' || char.ToLower(a[i]) == 'u' || char.ToLower(a[i]) == 'y')
                {
                    notIn = true;
                    for (int  y = 0;y<voyelle.Length;y++)
                    {
                        if (char.ToLower(a[i]) == voyelle[y])
                        {
                             notIn = false;
                        }
                    }
                    if (notIn == true)
                    {
                        voyelle += char.ToLower(a[i]);
                    }
                }
            }
            return voyelle;
        }
    }
}
