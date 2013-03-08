using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman2
{
    public class Spielsteuerung
    {
        // Für das Spiel ist das Objekt Text mit allen Text relevanten Variablen notwendig
        public Text Text;
        public Form1 HangmanForm;
        int AnzahlRateversuche;

        public Spielsteuerung(Form1 Form)
        {   // Damit die Spielsteuerung zugriff auf die Form hat
            HangmanForm = Form;
           
        }
        public void start_Game()
        {// Hier wird das Spiel gestartet

            // Objekte übergeben und initialisiert für neues Spiel
            Text = new Text();
            AnzahlRateversuche = 0;

            // Die Form zeigt den Eingabemodus für die Eingabe des Suchtextes
            //HangmanForm.EingabeModus();
            
        }
        public void TextEingabe(string TextEingabe)
        {
            //Überprüfung ob der Text dem Wertebereich entspricht
            if (Text.check_TextLänge(TextEingabe))
            {
                if (Text.check_Wertebereich(TextEingabe))
                {// Text ist bereit und kann geraten werden
                    HangmanForm.RateModus();
                }
                else
                {   // ErrorMeldung ausgeben <> Wertebereich
                    HangmanForm.ErrorMSG(2);
                }

            }
            else
            {
                // ErrorMeldung ausgeben : Länge > 100
                HangmanForm.ErrorMSG(1);
            }

        }
        public void BuchstabenEingabe(char RateBuchstaben)
        {// check Wertebereich
            if (Text.check_Wertebereich(RateBuchstaben.ToString()))
            {
                // check Buchstaben bereits vorhanden
                if (Text.check_BuchstabenBereitsVorhanden(RateBuchstaben))
                {
                  HangmanForm.BuchstabenAufFormDrucken();
                  if (Text.check_SpielEnde())
                  {
                  }
                }
                else 
                {
                    // ErrorMeldung ausgeben : Buchstabe wurde bereits geraten
                  HangmanForm.ErrorMSG(3);
                }

                

            }
            else
            {
                // ErrorMeldung ausgeben <> Wertebereich
                HangmanForm.ErrorMSG(2);
            }
        }
        public void check_Spielstand()
        {
        }

        public void ende_Game()
        {
            
            
        }
    }
}