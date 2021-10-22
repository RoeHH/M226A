using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenverwaltungV3
{
    class Person
    {
        public static int s_Anz { get; set; }
        public int m_ID { get; set; }
        public string m_N { get; set; }
        public string m_V { get; set; }

        private short p_J;

        public Person(string n, string v,short j)
        {
            s_Anz++;
            m_ID = s_Anz;
            m_N = n;
            m_V = v;
            m_J = j;
        }

        public short m_J
        {
            get
            {
                return p_J;
            }
            set
            {
                if(value < 100)
                {
                    if(value > DateTime.Now.Year - 2000)
                    {
                        p_J = (short) (value + 1900);
                    }
                    else
                    {
                        p_J = (short)(value + 2000);
                    }
                }
                else if(value > DateTime.Now.Year)
                {
                    p_J = (short) DateTime.Now.Year;
                }
                else
                {
                    p_J = value;
                }
            }
        }
    }
}
