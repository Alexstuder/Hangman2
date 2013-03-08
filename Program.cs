using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman2
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {   // Form Starten
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 HangmanForm1 = new Form1();
            Form HangmanForm = HangmanForm1;
            Application.Run(HangmanForm);

            // Das objekt Spielsteuerung wird instanziert
            Spielsteuerung Spiel = new Spielsteuerung(HangmanForm1);
            
            // Spiel wird gestartet
            Spiel.start_Game();
        }
        
    }
}
