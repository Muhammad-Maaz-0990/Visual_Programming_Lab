﻿using System;
using System.Collections.Generic;

namespace ExIList
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int> { 10, 20, 30, 40 };
            Console.WriteLine("Total Elements: {0}", intList.Count);
        }
    }
}

