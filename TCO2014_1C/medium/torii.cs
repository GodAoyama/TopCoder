using System;
using System.Collections.Generic;
using System.Linq;

public class FizzBuzzTurbo
{
    public long[] counts(long A, long B)
    {
        long fizz = 0, buzz = 0, fizzbuzz = 0;

        fizzbuzz = B / 15 - (A-1) / 15;
        fizz = B / 3 - (A-1) / 3 - fizzbuzz;
        buzz = B / 5 - (A-1) / 5 - fizzbuzz;

        return new long[3] { fizz, buzz, fizzbuzz };
    }
}