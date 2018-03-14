using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_to_mixed_Fraction_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "-10/7";
            int num;
            int den;
            int r = 1;

            string[] subs = s.Split('/');

            num = Convert.ToInt32(subs[0]);
            den = Convert.ToInt32(subs[1]);

            if(num < 0 && den < 0)
            {
                num = Math.Abs(num);
                den = Math.Abs(den);
            }

            int gcd = Math.Abs(num);
            int den1 = den;

            if (den == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                while (r > 0)
                {
                    r = gcd % den1;
                    gcd = den1;
                    den1 = r;
                }
                
                num /= gcd;
                den /= gcd;
                     

                int w = num / den;
                num %= den;

                

                if (w == 0)
                {
                    //return num.ToString() + "/" + den.ToString();
                    Console.WriteLine(num.ToString() + "/" + den.ToString());
                }
                else
                {
                    if (num == 0)
                    {
                        //return w.ToString();
                        Console.WriteLine(w.ToString());
                    }
                    else
                    {
                        //return w.ToString() + " " + Math.Abs(num.ToString()) + "/" + den.ToString();
                        Console.WriteLine(w.ToString() + " " + Math.Abs(num).ToString() + "/" + den.ToString());
                    }

                }
            }

        }
    }
}
