using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void RateModus()
        { 

        }
        public void EingabeModus()
        {

        }
        public void BuchstabenAufFormDrucken()
        {
        }
        public void ErrorMSG(int ErrorNr)
        {

            MessageBox.Show(this.get_ErrorMSG(ErrorNr), "Fehlermeldung");


        }
        private string get_ErrorMSG(int ErrorNr)
        {
            switch (ErrorNr)
            {
                case 1:
                    return "Es sind lediglich 100 Buchstaben erlaubt !";
                case 2:
                    return "Es sind lediglich Buchstaben erlaubt !";
                case 3:
                    return "Buchstabe wurde bereits geraten !";
                default:
                    return "Nicht definierte Fehlermeldung ErrorNR : "+ ErrorNr.ToString() ;
            }

        }
        
    }
}
