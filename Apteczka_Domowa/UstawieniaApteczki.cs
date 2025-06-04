using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class UstawieniaApteczki
{
    public int minIlosc { get; set; }
    private static UstawieniaApteczki instance;

    public UstawieniaApteczki()
    {
        minIlosc = 2;
    }

    public static UstawieniaApteczki Pobierz()
    {
        if (instance == null)
        {
            if (File.Exists("ustawieniaApteczki.json"))
            {
                string json = File.ReadAllText("ustawieniaApteczki.json");
                instance = JsonSerializer.Deserialize<UstawieniaApteczki>(json);
            }
            else
            {
                instance = new UstawieniaApteczki();
                string json = JsonSerializer.Serialize(instance);
                File.WriteAllText("ustawieniaApteczki.json", json);
            }
        }
        return instance;
    }
}