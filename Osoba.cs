using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class First_Task_Osoba
{
    public static void Main(string[] args)
    {
        Osoba osoba = new Osoba("ada Kolan");
        osoba.DataUrodzenia = new DateTime(1990, 5, 15);
        osoba.DataŚmierci = new DateTime(2000, 12, 31);

        Console.WriteLine(osoba.Imię);
        Console.WriteLine(osoba.Nazwisko);
        Console.WriteLine(osoba.DataUrodzenia?.ToString("yyyy-MM-dd"));
        Console.WriteLine(osoba.DataŚmierci?.ToString("yyyy-MM-dd"));
        Console.WriteLine(osoba.Wiek?.TotalDays);
        Console.WriteLine(osoba.ImięNazwisko);
    }
}
