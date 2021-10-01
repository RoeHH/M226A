using System;
using System.Windows.Forms;

namespace PersonenAppV2
{
    [Serializable()]
    public class Person
    {
        static int sAnzahlPersonen = 0;

        private const int kleinstestEintritsJahr = 1975;
        private const double kleinstMöglichesSalaer = 0.00;
        private const double groestMöglichesSalaer = 99999.95;

        public int m_PersNr { get; private set; }
        public string m_Anrede { get; set; }
        public string m_Name { get; set; }
        public string m_Vorname { get; set; }
        public string m_Plz { get; set; }
        public string m_Ort { get; set; }
        private int m_EintrittsJahr;
        public int EintrittsJahr { 
            get
            {
                return m_EintrittsJahr;
            }
            set
            {
                int year = DateTime.Now.Year;
                if (value < kleinstestEintritsJahr || value > year)
                {
                    if (value < kleinstestEintritsJahr)
                    {
                        m_EintrittsJahr = kleinstestEintritsJahr;
                    }
                    else
                    {
                        m_EintrittsJahr = year;
                    }
                    MessageBox.Show($"The Value needs to be between {kleinstestEintritsJahr} and {year}");
                }
                else
                {
                    m_EintrittsJahr = value;
                }
            }
        }
        private double m_Salaer;
        public double Salaer {
            get
            {
                return m_Salaer;
            }
            set
            {
                if (value < kleinstMöglichesSalaer || value > groestMöglichesSalaer)
                {
                    if (value < kleinstMöglichesSalaer)
                    {
                        m_Salaer = kleinstMöglichesSalaer;
                    }
                    else
                    {
                        m_Salaer = groestMöglichesSalaer;
                    }
                    MessageBox.Show($"The Value needs to be between {kleinstMöglichesSalaer} and {groestMöglichesSalaer}");
                }
                else
                {
                    m_Salaer = value;
                }
            }
        }
        public double m_Pensum { get; set; }
        public Person(bool empty)
        {
            if (empty)
            {
                m_PersNr = sAnzahlPersonen + 1;
                sAnzahlPersonen += 1;
                m_Anrede = "";
                m_Name = "";
                m_Vorname = "";
                m_Plz = "";
                m_Ort = "";
                m_EintrittsJahr = DateTime.Now.Year;
                m_Salaer = 0;
                m_Pensum = 0;
            }
            else
            {
                personConst();
            }
        }

        public Person(int PersNr)
        {
            m_PersNr = PersNr;
            sAnzahlPersonen += 1;
        }

        public Person(){
            personConst();
        }
        private void personConst()
        {
            m_PersNr = sAnzahlPersonen + 1;
            m_Anrede = "Elefant";
            m_Name = "Blümchen";
            m_Vorname = "Benjamin";
            m_Plz = "6000";
            m_Ort = "Luzern";
            m_EintrittsJahr = DateTime.Now.Year;
            m_Salaer = 121212121212.12;
            m_Pensum = 100;
            sAnzahlPersonen += 1;
        }

        public Person(string anrede, string name, string vorname, string plz, string ort, int eintrittsJahr, double salaer, double pensum)
        {
            m_PersNr = sAnzahlPersonen + 1;
            m_Anrede = anrede;
            m_Name = name;
            m_Vorname = vorname;
            m_Plz = plz;
            m_Ort = ort;
            EintrittsJahr = eintrittsJahr;
            Salaer = salaer;
            m_Pensum = pensum;
            sAnzahlPersonen += 1;
        }

        public Person(string Name, string Vornamen)
        {
            m_PersNr = sAnzahlPersonen + 1;
            m_Name = Name;
            m_Vorname = Vornamen;
            sAnzahlPersonen += 1;
        }

        public Person(int PersNr, string Anrede, string Vornamen)
        {
            m_PersNr = PersNr;
            m_Anrede = Anrede;
            m_Vorname = Vornamen;
            sAnzahlPersonen += 1;
        }

        public Person(int PersNr, string Name, int Eintritsjahr)
        {
            m_PersNr = PersNr;
            m_Name = Name;
            m_EintrittsJahr = Eintritsjahr;
            sAnzahlPersonen += 1;
        }

        public static double CalculateLohn(double Salaer, double Pensum)
        {
            return (Salaer / 100) * Pensum; 
        }

    }
}
