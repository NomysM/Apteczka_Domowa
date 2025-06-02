using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lek
{
    public string nazwa;
    public string opis;
    public DateTime dataWaznosci;
    public int ilosc;

    public Lek(string nazwa, string opis, DateTime dataWaznosci, int ilosc)
    {
        this.nazwa = nazwa;
        this.opis = opis;
        this.dataWaznosci = dataWaznosci;
        this.ilosc = ilosc;
    }

    public override string ToString()
    {
        return nazwa + " (" + ilosc + " szt.) - ważne do " + dataWaznosci.ToShortDateString() + " Opis: " + opis;
    }

}
