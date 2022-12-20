using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace CS322_Projekat_Bosko_Markovic_4003
{
    public partial class Form1 : Form
    {
        private static readonly Form1 forma = new Form1();
        private readonly List<Rudar> rudari;
        private Form3 f;

        public static Form1 Instanca() => forma;

        private Form1()
        {
            InitializeComponent();
            rudari = new List<Rudar>();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void prijava_Click(object sender, EventArgs e)
        {
            bool korisnikUlogovan = false;

            if (this.textBox1.Text == "" || this.textBox2.Text == "")
            {
                MessageBox.Show("Унесите податке!");
                return;
            }

            SqlConnection veza = new SqlConnection("Data Source=DESKTOP-3F74CRJ; Initial Catalog=Korisnici; User ID=sa; Password=Siftovanje");
            veza.Open();

            SqlCommand komanda = new SqlCommand("select nalog, sifra from korisnici", veza);
            SqlDataReader citac = komanda.ExecuteReader();

            while (citac.Read())
            {
                if (this.textBox1.Text == citac.GetString(0) && this.textBox2.Text == citac.GetString(1))
                {
                    korisnikUlogovan = true;
                    citac.Close();
                    break;
                }
            }

            if (!korisnikUlogovan)
            {
                MessageBox.Show("Такав корисник не постоји у бази!");
                citac.Close();
                return;
            }

            this.rudari.Add(new Rudar(this.textBox1.Text));
            veza.Close();
            this.Hide();

            this.f = new Form3();
            this.f.Rudar = this.rudari[^1];
            this.f.Show();
        }

        private void pravljenjeNaloga_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}