using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal static class BuiltInDelegates
    {

       public static void Print (string name)=>Console.WriteLine (name);
        public static int Add(int number1 ,int number2) =>number1+number2;
        public static bool IsEven(int number) => number%2 ==0;


    }
}
