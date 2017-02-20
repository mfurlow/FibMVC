using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FibMVC.Models
{
    public class AddMaxnumber
    {
        public int maxNum { get; set; }

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