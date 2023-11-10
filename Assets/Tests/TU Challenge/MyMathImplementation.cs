using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        internal static int Add(int a, int b)
        {
            return a + b;
        }

        internal static List<int> GenericSort(List<int> toSort, Func<int, int, bool> isInOrder)
        {
            for(int i=0; i < toSort.Count; i++)
            {

            }
            if (isInOrder != IsInOrderDesc)
            {
                Sort(toSort);
            }
            else if (isInOrder == IsInOrderDesc)
            {
                for (int i = 0; i < toSort.Count - 1; i++)
                {
                    for (int j = 0; j < toSort.Count - 1 - i; j++)
                    {
                        if (toSort[j] < toSort[j + 1])
                        {
                            int temp = toSort[j];
                            toSort[j] = toSort[j + 1];
                            toSort[j + 1] = temp;
                        }
                    }
                }
            }
            return toSort;
        }

        internal static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();
            bool[] estPremier = new bool[a + 1];

            for (int i = 2; i <= a; i++)
            {
                estPremier[i] = true;
            }

            for (int p = 2; p * p <= a; p++)
            {
                if (estPremier[p])
                {
                    for (int i = p * p; i <= a; i += p)
                    {
                        estPremier[i] = false;
                    }
                }
            }

            for (int i = 2; i <= a; i++)
            {
                if (estPremier[i])
                {
                    list.Add(i);
                }
            }

            return list;
        }

        internal static bool IsDivisible(int a, int b)
        {
            if (a % b  == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool IsInOrder(int a, int b)
        {
            if (a <= b)
            {
                return true;
            }
            return false;
        }

        internal static bool IsInOrderDesc(int arg1, int arg2)
        {
            if (arg1 > arg2)
            {
                return true;
            }
            return false;
        }

        internal static bool IsListInOrder(List<int> list)
        {
            bool inOrder = true;
            for(int i = 0;i<list.Count-1;i++)
            {
                if (list[i]> list[i + 1])
                {
                    inOrder= false;
                }
            }
            return inOrder;
        }

        internal static bool IsMajeur(int age)
        {
            if(age < 0 || age > 150) 
            {
                throw new ArgumentException();
            }
            else
            {
                if(age >= 18)
                {
                    return true;
                }
                return false;
            }
        }

        internal static bool IsPrimary(int a)
        {
            if(a<0) 
            {
                throw new ArgumentException();
            }
            if (a <= 1)
            {
                return false;
            }
            if (a <= 3)
            {
                return true;
            }
            if (a % 2 == 0 || a % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i * i <= a; i += 6)
            {
                if (a % i == 0 || a % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        internal static int Power(int a, int b)
        {
            return (int) Math.Pow(a,b);
        }

        internal static int Power2(int a)
        {
            return (int)Math.Pow(a, 2);
        }

        internal static List<int> Sort(List<int> toSort)
        {
            for (int i = 0; i < toSort.Count - 1; i++)
            {
                for (int j = 0; j < toSort.Count - 1 - i; j++)
                {
                    if (toSort[j] > toSort[j + 1])
                    {
                        int temp = toSort[j];
                        toSort[j] = toSort[j + 1];
                        toSort[j + 1] = temp;
                    }
                }
            }
            return toSort;
        }
    }
}
