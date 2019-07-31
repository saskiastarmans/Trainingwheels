using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Types
{
    public static class Rekenen
    {

        public static short w { get; set; }

        public static int x { get; set; }


        public static long z { get; set; }


        public static void Reken1()
        {
            w = 9;
            //x = 2147483637;
            //z = 9_223_372_036_854_775_807;
            //short f = (short)x;
            //w = (short)(w + f);


            

            if ((w > 9 && w < 11))
            {
                Console.WriteLine("Step 1" + w);
            }
            else if (w >= 14 || w <= 16)
            {
                Console.WriteLine("Step 2" + w);
            }

           switch (w)
            {
                case 8:
                case 3:
                    Console.WriteLine("Step 3" + w);

                    break;

                case 9:

                    Console.WriteLine("Step 4" + w);

                    break;

                default:

                    Console.WriteLine("Step 5" + w);

                    break;
            }







        }

       
    }
}
