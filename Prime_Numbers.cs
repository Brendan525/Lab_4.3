using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {

        public int GetNPrime(int number)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);
            primeNumbers.Add(13);
            primeNumbers.Add(17);
            primeNumbers.Add(19);
            primeNumbers.Add(23);
            primeNumbers.Add(29);
            primeNumbers.Add(31);
            primeNumbers.Add(37);
            primeNumbers.Add(41);
            primeNumbers.Add(43);
            primeNumbers.Add(47);
            primeNumbers.Add(53);

            return primeNumbers[number-1];
        }
    }
}
