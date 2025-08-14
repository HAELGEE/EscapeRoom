using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Room;
internal class Room2
{
    /*
            En ”Pythagoreansk trippel” är tre heltal;

            a < b < c

            som uppfyller Pythagoras sats;

            a2 + b2 = c2

            Alltså a ska vara mindre än b som i sin tur ska vara mindre än c. Det finns endast en ”trippel” där a + b + c = 950.
            Hitta värdet på produkten abc. Det är lösenordet till nästa nivå.
        */

    public static void method2()
    {
        for (int a = 1; a < 950; a++)
        {
            for (int b = a + 1; b < 950 - a; b++)
            {
                int c = 950 - a - b;
                if (a * a + b * b == c * c)
                {
                    Console.WriteLine($"a = {a}, b = {b}, c = {c}, abc = {a * b * c}");                   
                }
            }
        }

        // Svaret är a*b*c vilket blir 29417700
    }
}
