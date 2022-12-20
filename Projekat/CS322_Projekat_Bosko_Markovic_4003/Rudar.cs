namespace CS322_Projekat_Bosko_Markovic_4003
{
    public class Rudar
    {
        private readonly string nalog;

        public Rudar(string _nalog) => this.nalog = _nalog;
     
        public string Nalog
        {
            get { return this.nalog; }
        }
    }
}