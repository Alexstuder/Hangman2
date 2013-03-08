namespace Hangman2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_BitteEingeben = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_BitteEingeben
            // 
            this.lbl_BitteEingeben.AutoSize = true;
            this.lbl_BitteEingeben.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BitteEingeben.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BitteEingeben.ForeColor = System.Drawing.Color.Blue;
            this.lbl_BitteEingeben.Location = new System.Drawing.Point(59, 91);
            this.lbl_BitteEingeben.Name = "lbl_BitteEingeben";
            this.lbl_BitteEingeben.Size = new System.Drawing.Size(311, 39);
            this.lbl_BitteEingeben.TabIndex = 0;
            this.lbl_BitteEingeben.Text = "Gib deinen Text ein :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 487);
            this.Controls.Add(this.lbl_BitteEingeben);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BitteEingeben;
    }
}

