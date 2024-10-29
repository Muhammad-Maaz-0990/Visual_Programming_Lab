using System;
using System.Collections.Generic;

namespace ExIList
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> strList = new List<string>();
            strList.Add("One");
            strList.Add("Two");
            strList.Add("Three");
            strList.Add("Four");
            strList.Add("Four");  // Duplicate value
            strList.Add("null");  // Adding the string "null"
            strList.Add("null");  // Duplicate string "null"
        }
    }
}

