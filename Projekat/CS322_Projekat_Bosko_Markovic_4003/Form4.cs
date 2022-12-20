using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CS322_Projekat_Bosko_Markovic_4003
{
    public partial class Form4 : Form
    {
        private Form3 forma;
        private readonly DataTable tabela = new DataTable();

        public Form4() => InitializeComponent();

        public Form3 Forma
        {
            set { this.forma = value; }
        }

        private void Zatvori(object s, FormClosedEventArgs e) => Form1.Instanca().Show();

        private void Form4_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "Са десне стране можете видети табелу са вашим бројем биткоина које сте досад освојили. " +
                "Taкође можете видети и резултате осталих рудара. Притисните 'X' да би сте се вратили на почетни прозор.";

            SqlConnection veza = new SqlConnection("Data Source=DESKTOP-3F74CRJ; Initial Catalog=Korisnici; User ID=sa; Password=Siftovanje");
            veza.Open();

            SqlCommand komanda = new SqlCommand("update korisnici set bitkoini=bitkoini+1 where nalog=@user", veza);
            komanda.Parameters.AddWithValue("@user", this.forma.Rudar.Nalog);
            komanda.ExecuteNonQuery();

            komanda = new SqlCommand("select ID, nalog, bitkoini from korisnici", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);

            adapter.Fill(this.tabela);
            this.dataGridView1.DataSource = this.tabela;

            veza.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
