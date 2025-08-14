using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Escape_Room;
internal class Room3
{
    /*
          Lösenordet till nästa nivå är fyra siffror som får av
          Kaprekar(1917) Kaprekar(7430)  Kaprekar(8833)  Kaprekar(9998) 
          formaterat som en PIN-kod, alltså fyra siffror utan mellanrum.
    */
    public static void method3()
    {
        int tal1 = 1917; // 9711 - 1179

        int tal2 = 7430; // 7430 - 0347

        int tal3 = 8833; // 8833 - 3388

        int tal4 = 9998; // 9998 - 8999

        int nr1 = 0;
        int nr2 = 0;
        int nr3 = 0;
        int nr4 = 0;

        //tal 1
        for (int i = 0; i < 10; i++)
        {
            if (tal1 == 6174)
            {
                nr1 = i;
                Console.WriteLine(i);
                break;
            }

            tal1 = Sorting(tal1);
            Console.WriteLine(tal1);
        }

        ////tal 2
        //for (int i = 0; i < 10; i++)
        //{
        //    if (tal2 == 6174)
        //    {
        //        nr2 = i;
        //        Console.WriteLine(i);
        //        break;
        //    }

        //    tal2 = Sorting(tal2);
        //    Console.WriteLine(tal2);

        //}

        ////tal 3
        //for (int i = 0; i < 10; i++)
        //{
        //    if (tal3 == 6174)
        //    {
        //        nr3 = i;
        //        Console.WriteLine(i);
        //        break;
        //    }

        //    tal3 = Sorting(tal3);
        //    Console.WriteLine(tal3);

        //}

        //// tal 4
        ////  int tal4 = 9998; // 9998 - 8999
        //for (int i = 0; i < 100; i++)
        //{
        //    if (tal4 == 6174)
        //    {
        //        nr4 = i;
        //        Console.WriteLine(i);
        //        break;
        //    }

        //    tal4 = Sorting(tal4);
        //    Console.WriteLine(tal4);

        //}

        Console.WriteLine($"Kod = {nr1}{nr2}{nr3}{nr4}");
    }

    public static int Sorting(int talet1)
    {
        string talet = Convert.ToString(talet1);


        // Sortera stigande
        char[] digitsAsc = talet.ToCharArray();
        Array.Sort(digitsAsc);
        string ascending = new string(digitsAsc);

        // Sortera fallande
        char[] digitsDesc = talet.ToCharArray();
        Array.Sort(digitsDesc);
        Array.Reverse(digitsDesc);
        string descending = new string(digitsDesc);

        //Console.WriteLine(ascending);
        //Console.WriteLine(descending);

        int asc = Convert.ToInt32(ascending);
        int desc = Convert.ToInt32(descending);

        return desc - asc;
    }
}
