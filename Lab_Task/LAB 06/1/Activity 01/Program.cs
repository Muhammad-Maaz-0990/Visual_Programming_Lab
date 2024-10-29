using System;
using System.Collections.Generic;

namespace ExIList
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
        }
    }
}
