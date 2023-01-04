using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           int[] arr = new int[n];
           int min;

           for(int i = 0; i < n; i++)
           {
            arr[i] = int.Parse(Console.ReadLine());
           }
           min = arr[0]
           for (int i = 0; i < n; i++)
           {
            if (arr[i] < min) min = arr[i];
           }
        Console.WriteLine(min)
        }
    }
}
