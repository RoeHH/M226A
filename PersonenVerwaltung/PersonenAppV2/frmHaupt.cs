using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PersonenAppV2
{
    public partial class frmHaupt : Form
    {

        private List<Person> PersonenList = new List<Person>();
        private int pageNr = 0;

        public frmHaupt()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Einlesen();
            pageNr = 0;
            UpdateForm();
        }

        private void FillForm()
        {
            PersonenList.Add(new Person("Banane", "Van Krähnhüsen", "Enea", "6666", "Ort", 2012, 10, 100));
            PersonenList.Add(new Person("Gian", "Fädere", "Gian", "6012", "Notu", 2015, 30, 100));
            PersonenList.Add(new Person("De G", "Hänggi", "Rouven", "6017", "Rusmu", 2000, 42069, 10));
        }

        private void UpdateForm()
        {
            numNavigation.Value = pageNr + 1;
            Person person = PersonenList[pageNr];
            txtPersNr.Text = person.m_PersNr.ToString();
            txtNamen.Text = person.m_Name;
            txtVornamen.Text = person.m_Vorname;
            txtPLZ.Text = person.m_Plz;
            txtOrt.Text = person.m_Ort;
            txtEintrittsjahr.Text = person.EintrittsJahr.ToString();
            txtSalaer.Text = person.Salaer.ToString();
            txtPensum.Text = person.m_Pensum.ToString();
        }

        private void OnFirst(object sender, EventArgs e)
        {
            if (isAbleToChange())
            {
                pageNr = 0;
                UpdateForm();
            }
        }

        private void OnPrevious(object sender, EventArgs e)
        {
            if (isAbleToChange())
            {
                pageNr = pageNr == 0 ? 0 : pageNr - 1;
                UpdateForm();
            }
        }

        private void OnNext(object sender, EventArgs e)
        {
            if (isAbleToChange())
            {
                pageNr = pageNr == PersonenList.Count - 1 ? PersonenList.Count - 1 : pageNr + 1;
                UpdateForm();
            }
        }

        private void OnLast(object sender, EventArgs e)
        {
            if (isAbleToChange())
            {
                pageNr = PersonenList.Count - 1;
                UpdateForm();

            }
        }

        private void OnSave(object sender, EventArgs e)
        {

            Person person = PersonenList[pageNr];
            person.m_Name = txtNamen.Text;
            person.m_Vorname = txtVornamen.Text;
            person.m_Plz = txtPLZ.Text;
            person.m_Ort = txtOrt.Text;
            person.EintrittsJahr = Convert.ToInt32(txtEintrittsjahr.Text);
            person.Salaer = Convert.ToDouble(txtSalaer.Text);
            person.m_Pensum = Convert.ToDouble(txtPensum.Text);
            UpdateForm();
        }

        private void OnAbort(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numNavigation_ValueChanged(object sender, EventArgs e)
        {
            if (isAbleToChange())
            {
                pageNr = (int)numNavigation.Value >= PersonenList.Count ? PersonenList.Count - 1 : (int)numNavigation.Value - 1;
                UpdateForm();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ;
            if (isAbleToChange())
            {
                Form1 myForm = new Form1();
                myForm.Text = "My Form";
                myForm.ShowDialog();
                if (myForm.DialogResult == DialogResult.OK)
                {
                    PersonenList.Add(myForm.getNeuePerson());
                    pageNr = PersonenList.Count - 1;
                }
                UpdateForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PersonenList.RemoveAt(pageNr);
            pageNr = pageNr == PersonenList.Count ? PersonenList.Count - 1 : pageNr + 1;
            UpdateForm();
        }

        private bool isAbleToChange()
        {
            Person person = PersonenList[pageNr];
            try
            {
                if (person.m_Name != "" && person.m_Vorname != "" && person.m_Plz != "" && person.m_Ort != "" && person.EintrittsJahr != 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void Einlesen()
        {
            if (DialogResult.No == MessageBox.Show("Möchten Sie die Daten aus einer Datei laden?", "Laden", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                FillForm();
            }
            else
            {
                //Objekte aus einer Datei laden
                string sPfad = Application.StartupPath + "\\MyObject.pd7";
                if (DialogResult.No == MessageBox.Show("Möchten Sie die Datei im Applikationsverzeichnis lesen?", "Informationen einlesen",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                )
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "pd7 files (*.pd7)|*.pd7|All files (*.*)|*";
                    if (DialogResult.OK == ofd.ShowDialog())
                        sPfad = ofd.FileName;
                    else
                        return;
                }

                try
                {
                    FileStream myStream = new FileStream(sPfad, FileMode.Open);
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    PersonenList = (List<Person>)binFormatter.Deserialize(myStream);
                    myStream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sPfad = Application.StartupPath + "\\MyObject.pd7";
            if (DialogResult.No == MessageBox.Show("Möchten Sie die Daten im Applikationsverzeichnis speichern?", "Speichern",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                )
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "pd7 files (*.pd7)|*.pd7|All files (*.*)|*";
                sfd.DefaultExt = "pd7";
                if (DialogResult.OK == sfd.ShowDialog())
                    sPfad = sfd.FileName;
                else return;
            }
            FileStream myStream = new FileStream(sPfad, FileMode.Create);
            BinaryFormatter binFormatter = new BinaryFormatter();
            binFormatter.Serialize(myStream, PersonenList); 
            myStream.Close();
            
        }
    }
}

