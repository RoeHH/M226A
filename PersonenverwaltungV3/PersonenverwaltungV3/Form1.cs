using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonenverwaltungV3
{
    public partial class Form1 : Form
    {
        List<Person> p = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p.Add(new Person("A", "A", 12));
            p.ForEach(p =>
            {
                pNr.Text = Convert.ToString(p.m_ID);
                vorname.Text = p.m_V;
                name.Text = p.m_N;
                jahrgang.Text = Convert.ToString(p.m_J);
                numericUpDown1.Value = DateTime.Now.Year - p.m_J;
            });
        }
    }
}
