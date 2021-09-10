using System;
using System.Windows.Forms;

namespace PersonenAppV2
{
    public class Person
    {
        private const int kleinstestEintritsJahr = 1975;
        private const double kleinstMöglichesSalaer = 0.00;
        private const double groestMöglichesSalaer = 99999.95;

        public int m_PersNr { get; private set; }
        public string m_Anrede { get; set; }
        public string m_Name { get; set; }
        public string m_Vorname { get; set; }
        public string m_Plz { get; set; }
        public string m_Ort { get; set; }
        public int m_EintrittsJahr { 
            get
            {
                return m_EintrittsJahr;
            }
            set
            {
                int year = DateTime.Now.Year;
                if (value < kleinstestEintritsJahr || value > year)
                {
                    if(value < kleinstestEintritsJahr)
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
        public double m_Salaer {
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
        }

    }
}
