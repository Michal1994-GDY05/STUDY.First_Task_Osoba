using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class First_Task_Osoba
{
    public static void Main(string[] args)
    {
        Osoba osoba1 = new Osoba("Jan Kowalski");
        osoba1.DataUrodzenia = new DateTime(1990, 2, 11);
        osoba1.DataŚmierci = new DateTime(2000, 12, 31);

        Osoba osoba2 = new Osoba("Anna Nowak");
        osoba2.DataUrodzenia = new DateTime(1985, 5, 10);

        Console.WriteLine(osoba1.ToString());
        Console.WriteLine(osoba2.ToString());

    }
}
