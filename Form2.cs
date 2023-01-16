using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bibliotekaDavid
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string novikorisnik = comboBox1.Text;

            if (novikorisnik == "NOVI KORISNIK")
            {
                label1.Visible = true;
                textBoxImeKorisnika.Visible = true;
                label2.Visible = true;
                textBoxPrezimeKorisnika.Visible = true;
            }

            if (novikorisnik == "STARI KORISNIK")
            {
                label1.Visible = false;
                textBoxImeKorisnika.Visible = false;
                label2.Visible = false;
                textBoxPrezimeKorisnika.Visible = false;
            }
        }

        private void Podatci()
        {

            string ime = textBoxImeKorisnika.Text;
            string prezime = textBoxPrezimeKorisnika.Text;
            string IDkorisnik = textBoxIDkorisnika.Text;
            string IDknjiga = textBoxIDknjige.Text;
            var x = new XDocument(
            new XElement("Podatci"),
                new XElement("Korisnik"),
                    new XAttribute("Ime", ime),
                    new XAttribute("Prezime", prezime),
                    new XAttribute("ID korisnika", IDkorisnik),
                new XElement("Knjiga"),
                    new XAttribute("ID knjige", IDknjiga)
            );

        }

        private void buttonUnesiPodatke_Click(object sender, EventArgs e)
        {
            x.Save(@"C:\Users\ucenik\source\repos\bibliotekaDavid\bibliotekaDavid\Podatci.xml");
        }
    }
    }

