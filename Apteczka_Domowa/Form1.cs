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
    }
}
