using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class TransformacjaDanych
{
    private const char
        Spacja = ' ',
        Łącznik = '-'
        ;

    public static string KapitalizujNazwęWłasną(string fraza)
    {
        string[] rozbicieGłówne = fraza.Trim().Split(Spacja);
        for (int ig = 0; ig < rozbicieGłówne.Length; ig++)
        {
            string[] rozbiciePoboczne = rozbicieGłówne[ig].Split(Łącznik);
            for (int ip = 0; ip < rozbiciePoboczne.Length; ip++)
                rozbiciePoboczne[ip] = KapitalizujPierwsząLiterę(
                    rozbiciePoboczne[ip]
                    );
            rozbicieGłówne[ig] = string.Join(Łącznik, rozbiciePoboczne);
        }
        return string.Join(Spacja, rozbicieGłówne);
    }

    public static string KapitalizujPierwsząLiterę(string wyraz)
    {
        wyraz = wyraz.Trim();
        if (wyraz == "")
            return "";
        else
        {
            string
                pierwsza = wyraz.Substring(0, 1).ToUpper(),
                reszta = wyraz.Substring(1).ToLower()
                ;
            return pierwsza + reszta;
        }
    }
}

