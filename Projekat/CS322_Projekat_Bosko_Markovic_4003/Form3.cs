using System;
using System.IO;
using System.Windows.Forms;

namespace CS322_Projekat_Bosko_Markovic_4003
{
    public partial class Form3 : Form
    {
        private string resenje;
        private static bool pogodio = false;
        private Rudar rudar;

        public static bool Pogodio { get; }

        public Rudar Rudar
        {
            set
            {
                if (value == null)
                    return;

                this.rudar = value;
            }

            get { return this.rudar; }
        }

        public Form3() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);
            pogodio = this.textBox3.Text == resenje;
            MessageBox.Show(pogodio ? "Тачан одговор!" : "Нетачан одговор!");
            
            this.Close();
            Form4 forma = new Form4();
            forma.Forma = this;
            forma.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader citac = new StreamReader("Zadaci/Zadatak_" + new Random().Next(1, 5).ToString() + ".txt");
            this.textBox1.Text = citac.ReadLine();
            resenje = citac.ReadLine();
            
            citac.Close();
        }
    }
}