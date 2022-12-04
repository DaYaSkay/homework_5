using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static double max(double firstelement, double secondelement)
        {
            if (firstelement > secondelement)
            {
                return firstelement;
            }
            else
            {
                return secondelement;
            }
        }

        static double max(double firstelement, double secondelement, double thirdelement)
        {
            double max;
            double[] arrayelement = new double[3] { firstelement, secondelement, thirdelement };
            max = firstelement;
            for(int i=1;i<3;i++)
            {
                if(max< arrayelement[i])
                {
                    max = arrayelement[i];
                }
            }
            return max;

        }


        static double max(double firstelement, double secondelement, double thirdelement, double fourthelement)
        {
            double max;
            double[] arrayelement = new double[4] { firstelement, secondelement, thirdelement, fourthelement };
            max = firstelement;
            for (int i = 1; i < 4; i++)
            {
                if (max < arrayelement[i])
                {
                    max = arrayelement[i];
                }
            }
            return max;

        }

        static bool TrySumIfOdd(int firstelement, int secondelement)
        {
            int sum;
            sum = firstelement + secondelement;
            if (sum % 2==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool TrySumIfOdd(int firstelement, int secondelement, int thirdelement)
        {
            int sum;
            sum = firstelement + secondelement+ thirdelement;
            if (sum % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool TrySumIfOdd(int firstelement, int secondelement, int thirdelement, int fourthelement)
        {
            int sum;
            sum = firstelement + secondelement + thirdelement+ fourthelement;
            if (sum % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string Repeat(string str,int n)
        {
            string newstr="";
            for (int i=0;i<n;i++)
            {
                newstr= newstr + str;
            }
            return newstr;
        }


        static void Main()
        {
            double a;
            a = max(1,3,5,4.5);
            Console.WriteLine(a);


            bool b;
            b = TrySumIfOdd(1, 2);
            Console.WriteLine(b);

            string str;
            str = "win";
            str = Repeat(str, 3);
            Console.WriteLine(str);
        }
    }
}