﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibMVC.Biz
{
    public class Class1
    {
        public static int Fib(int n)
        {
            int a = 0;
            int b = 1;
            
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

    }
}
