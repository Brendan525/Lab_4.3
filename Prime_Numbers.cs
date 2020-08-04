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

            //example: input = 5    // 2, 3, 5, 7, 11
            //take a number n ()the parameter
            //get the nth prime number
            //send it back

            //there is no input, it is given as number
            //there is no console writing, a number is returned
        }


        //public bool GetPrime(int n)
        //{          

        //    if (n % 2 == 0 && n != 2)
        //    {
        //        return false; // false
        //    }
        //    else
        //    {
        //        return true;
        //    }
            
        //}
    }
}
