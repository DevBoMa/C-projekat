using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS322_Projekat_Bosko_Markovic_4003
{
    public partial class Form2 : Form
    {
        public Form2() => InitializeComponent();

        private void Zatvori(object s, FormClosedEventArgs e) => Form1.Instanca().Show();

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "")
            {
                MessageBox.Show("Унесите податке");
                return;
            }

            if (this.textBox2.Text != this.textBox3.Text)
            {
                MessageBox.Show("Унете шифре се не подударају!");
                return;
            }

            using (SqlConnection veza = new SqlConnection("Data Source=DESKTOP-3F74CRJ; Initial Catalog=Korisnici; User ID=sa; Password=Siftovanje"))
            {
                veza.Open();

                SqlCommand komanda1 = new SqlCommand("select nalog, sifra from korisnici", veza);
                SqlDataReader citac = komanda1.ExecuteReader();

                // Provera da li baza sadrzi nekog pod tim imenom i sifrom
                while (citac.Read())
                {
                    if (this.textBox1.Text == citac.GetString(0) || this.textBox2.Text == citac.GetString(1))
                    {
                        MessageBox.Show("Корисник под тим налогом или шифром већ постоји!");
                        citac.Close();
                        veza.Close();
                        return;
                    }
                }

                citac.Close();

                SqlCommand komanda = new SqlCommand("insert into korisnici(nalog, sifra, bitkoini) values(@user, @password, 0)", veza);
                komanda.Parameters.AddWithValue("@user", this.textBox1.Text);
                komanda.Parameters.AddWithValue("@password", this.textBox2.Text);
                komanda.ExecuteNonQuery();

                veza.Close();
            }

            this.Close();
            Form1.Instanca().Show();
        }
    }
}