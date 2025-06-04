using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lek
{
    public string nazwa { get; set; }
    public string opis { get; set; }
    public DateTime dataWaznosci { get; set; }
    public int ilosc { get; set; }

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
