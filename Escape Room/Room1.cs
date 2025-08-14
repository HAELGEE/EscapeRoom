using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Room;
public class Room1
{
    /*
        Nivå 1 – Fibonacci
        Du känner säker redan till Fibonacci-talserien. Det är ett mönster av tal som uppstår om du skapar nästa tal som en summa av de två tidigare talen i serien. Om serien börjar på talen 0 och 1 så blir de följande talen:

        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, …

        Men vad blir summan av alla tal i serien om du summerar alla jämna termer under 2 miljoner?

         ger dig tillgång till nästa nivå.
     */


    public static void method1()
    {
        int sum = 2;
        int tempNr1 = 1;
        int tempNr2 = 2;

        Console.WriteLine(tempNr1);
        Console.WriteLine(tempNr2);


        for (int i = 0; i < 14; i++)
        {
            tempNr1 = tempNr2 + tempNr1;
            Console.WriteLine(tempNr1);

            if (tempNr1 % 2 == 0)
            {
                Console.WriteLine($"\n{tempNr1} blev tillagd");
                sum = sum + tempNr1;
                Console.WriteLine($"Summan är nu {sum} \n");
            }

            if (tempNr1 < 1346270 || tempNr2 < 1346270)
            {
                tempNr2 = tempNr1 + tempNr2;
                Console.WriteLine(tempNr2);

                if (tempNr2 % 2 == 0)
                {
                    Console.WriteLine($"\n{tempNr2} blev tillagd");
                    sum = sum + tempNr2;
                    Console.WriteLine($"Summan är nu {sum} \n");
                }
            }
        }
        tempNr1 = tempNr2 + tempNr1;
        Console.WriteLine(tempNr1);

        Console.WriteLine($"Detta är summan = {sum}");

        // Lösenordet för rum 1 = 1089154
    }

}
