using System.Text.Json;

namespace Apteczka_Domowa
{
    public partial class Form1 : Form
    {
        List<Lek> listaLekow = new List<Lek>();
        public Form1()
        {
            InitializeComponent();

            //Test Lek.cs
            //Lek lek1 = new Lek("Ibuprofen", "Lek przeciwbólowy i przeciwzapalny", new DateTime(2025, 12, 31), 10);
            //MessageBox.Show(lek1.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string nazwa = txtNazwa.Text;
                string opis = txtOpis.Text;
                DateTime data = dtpDataWaznosci.Value;
                int ilosc = (int)numIlosc.Value;

                Lek nowy = new Lek(nazwa, opis, data, ilosc);
                listaLekow.Add(nowy);
                listBoxLekow.Items.Add(nowy);


                UstawieniaApteczki ustawienia = UstawieniaApteczki.Pobierz();
                if (ilosc < ustawienia.minIlosc)
                {
                    MessageBox.Show("Uwaga: Ostatnie sztuki leku!!!");
                }

                txtNazwa.Text = "";
                txtOpis.Text = "";
                numIlosc.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d: " + ex.Message);
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(listaLekow);
            File.WriteAllText("listaLekow.json", json);
            MessageBox.Show("Lista leków zosta³a zapisana.");
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            if (File.Exists("listaLekow.json"))
            {
                string json = File.ReadAllText("listaLekow.json");

                listaLekow = JsonSerializer.Deserialize<List<Lek>>(json);

                listBoxLekow.Items.Clear();
                foreach (Lek n in listaLekow)
                {
                    listBoxLekow.Items.Add(n);
                }
            }
            else
            {
                MessageBox.Show("Brak pliku z list¹ leków.");
            }
        }

        private void btnPrzeterminowane_Click(object sender, EventArgs e)
        {
            var przeterminowane = listaLekow
                .Where(l => l.dataWaznosci < DateTime.Now).ToList();

            listBoxLekow.Items.Clear();
            foreach (Lek n in przeterminowane)
            {
                listBoxLekow.Items.Add(n);
            }

            if (przeterminowane.Count == 0)
            {
                MessageBox.Show("Brak przeterminowanych leków.");
            }
        }

        private void btnZmniejszIlosc_Click(object sender, EventArgs e)
        {
            if (listBoxLekow.SelectedIndex == -1)
            {
                MessageBox.Show("Proszê wybraæ lek z listy.");
                return;
            }

            Lek wybranyLek = (Lek)listBoxLekow.SelectedItem;

            if (wybranyLek.ilosc > 0)
            {
                wybranyLek.ilosc--;
                
                if (wybranyLek.ilosc == 0)
                {
                    MessageBox.Show("Uwaga: Lek siê skoñczy³!!!");
                }

                OdswiezListe();

            }
            else
            {
                MessageBox.Show("Nie posiadasz ju¿ tego leku.");
            }
        }

        private void OdswiezListe()
        {
            listBoxLekow.Items.Clear();

            foreach (Lek n in listaLekow)
            {
                listBoxLekow.Items.Add(n);
            }
        }
    }
}
