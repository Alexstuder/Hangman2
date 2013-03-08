using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman2
{
    public  class Text
    {
        public String str_OriginalText;
        public String str_gerateneBuchstaben;
        
        public Text()
        {
            // Die Varbiablen werden initialisiert
            str_gerateneBuchstaben = "";
            str_OriginalText       = "";

        }

        public bool check_Wertebereich(string Text)
        {
            // Definition des gültigen Wertebereiches
            string GueltigerWertebereich = "abcdefghijklmnopqrstuvwxyzöäüÖÜÄABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            
            char[] TextArray = Text.ToArray();

            foreach (char Buchstaben in TextArray)
            {// Hier wird überprüf , ob der eingegebener Text dem Werteberiech entspricht
                if (GueltigerWertebereich.IndexOf(Buchstaben.ToString()) == -1)
                {// Falls ein Buchstabe nicht im Wertebereich enthalten ist, wird die überprüfung abgebrochen und Fehlermeldung ausgegeben
                    //  MessageBox.Show("Es sind lediglich Buchstaben erlaubt: "+ Buchstaben.ToString(), "Fehlermeldung");

                    return false;
                }

            }
            // Falls die überprüfung bis hierein gelangt, ist der Text gültig
            return true;

        }
        public bool check_TextLänge(string Text)
        {// Check ob Länge unt 100 Zeichen ist
            if (Text.Length <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool check_BuchstabenBereitsVorhanden(char RateBuchstaben)
        {
            if (this.str_gerateneBuchstaben.IndexOf(RateBuchstaben.ToString()) == -1)
            {
                // Der überprüfte und gültige Buchstaben wird zu den bisher geratenen Buchstaben zugefügt
                this.str_gerateneBuchstaben = this.str_gerateneBuchstaben + RateBuchstaben.ToString();
                return true;
            }
            else
            {   // Der Buchstabe wurde bereit geraten
                return false;
            }

        }

        public bool check_SpielEnde()
        { int AnzahlRichtig = 0 ;
            for (int i = 1; i <= this.str_gerateneBuchstaben.Length; i++)
            {
                if (this.str_OriginalText.IndexOf(this.str_gerateneBuchstaben.Substring(i)) == -1)
                { AnzahlRichtig++ ;
                }
            }
            return true;
        }
    }
}
