using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonenAppV2
{
    public partial class Form1 : Form
    {
        private Person form_preson;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.DialogResult = DialogResult.Abort;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_preson = new Person(true);
            form_preson.m_Name = textBox1.Text;
            form_preson.m_Vorname = textBox2.Text;
            button2.DialogResult = DialogResult.OK;
        }
        public Person getNeuePerson()
        {
            return form_preson;
        }
    }
}
