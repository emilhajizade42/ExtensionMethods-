using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Extensions
{
    public static class ExtensionMethods
    {
        public static bool CustomContains(this string str, char chr)
        {
            foreach (var item in str)
            {
                if (item==chr)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool CustomContains(this string str, string strPart)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==strPart[0])
                {
                    for (int j = 0; j < strPart.Length; j++)
                    {
                        if (str[i+j]==strPart[j])
                        {
                            count++;
                        }
                        else
                        {
                            count = 0;
                            break;
                        }
                    }
                    if (count == strPart.Length)
                    {
                        return true;
                    }
                    else
                    {
                        count = 0;

                    }

                }
            }

            return false;
        }
        public static bool IsPrime(this int num)
        {
            if (num<1)
            {
                return false;
            }
            for (int i = 2; i*i < num; i++)
            {
                if (num%i==0)
                {
                    return false;
                }
                
            }

            return true;
        }
    }
}
