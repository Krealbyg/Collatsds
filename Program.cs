using System;
using System.Collections.Generic;
class Collatz
{
    static void Main(string[] args)
    {
        List<int> inputlist = new List<int>();
        for (int i = 0; i < 4; i++)     inputlist.Add(int.Parse(Console.ReadLine())); 
        for (int i = 0; i < 4; i++)     Console.WriteLine(collat(inputlist[i]));
    }
    static long collat(long number)
    {
        if (number <= 1)            return 0;
        else if (number % 2 ==0)    return 1 + collat(number/2);
        else                        return 1 + collat((number * 3) + 1);
    }
}
