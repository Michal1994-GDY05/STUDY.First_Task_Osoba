using System;

using static TransformacjaDanych;
public class Osoba

{
    private string imięNazwisko;

    public string ImięNazwisko
    {
        get { return imięNazwisko; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Imię nie może być puste.");
            }

            imięNazwisko = value;
            AktualizujImięINazwisko(value);
        }
    }

    public Osoba(string imięNazwisko)
    {
        ImięNazwisko = KapitalizujNazwęWłasną(imięNazwisko); ;
    }

    private string? imię;
    private string? nazwisko;

    public string Imię
    {
        get => imię;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Imię nie może być puste.");
            }
            imię = value;
        }
    }

    public string Nazwisko
    {
        get => nazwisko;
        set { nazwisko = value; }
    }

    public DateTime? DataUrodzenia { get; set; }
    public DateTime? DataŚmierci { get; set; }

    public TimeSpan? Wiek
    {
        get
        {
            if (DataUrodzenia == null)
            {
                return null;
            }

            DateTime śmierc_czyZyjeDoDzisiaj = DataŚmierci ?? DateTime.Now.Date;
            return śmierc_czyZyjeDoDzisiaj - DataUrodzenia.Value;
        }
    }

    private void AktualizujImięINazwisko(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            imię = null;
            nazwisko = null;
        }
        else
        {
            string[] split = value.Split(' ');
            if (split.Length == 1)
            {
                imię = split[0];
                nazwisko = string.Empty;
            }
            else if (split.Length > 1)
            {
                imię = split[0];
                nazwisko = split[split.Length - 1];
            }
        }


    }
    public override string ToString()
    {
        return $"Imię i nazwisko: {ImięNazwisko}\n" +
               $"Imię: {Imię}\n" +
               $"Nazwisko: {Nazwisko}\n" +
               $"Data urodzenia: {DataUrodzenia?.ToShortDateString()}\n" +
               $"Data śmierci: {DataŚmierci?.ToShortDateString()}\n" +
               $"Wiek: {Wiek?.TotalDays} dni\n";
    }
}
