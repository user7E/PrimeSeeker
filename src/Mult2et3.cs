using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSeeker
{
    public class Mult2et3
    {
        //Values
        int element0;

        //Methods
        public bool CheckPrimeA(int a)
        {
            int b;
            b = a % 2;
            if (b == 0 && b != 2)
            {
                Console.WriteLine("Não é primo!");
                return false;
            }

            int b3;
            b3 = a % 3;
            if (b3 == 0 && b3 != 3)
            {
                Console.WriteLine("Não é primo!");
                return false;
            }
            else
            {
                Console.WriteLine("Pode ser primo!");
                return true;
            }

        }

    }     
}
