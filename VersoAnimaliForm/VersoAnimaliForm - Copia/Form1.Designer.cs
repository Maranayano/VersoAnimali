namespace VersoAnimaliForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FaiVerso = new Button();
            QualeAnimale = new MaskedTextBox();
            Risultato = new Label();
            Nometext = new TextBox();
            Energiatext = new TextBox();
            Etatext = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FaiVerso
            // 
            FaiVerso.Location = new Point(31, 301);
            FaiVerso.Name = "FaiVerso";
            FaiVerso.Size = new Size(75, 23);
            FaiVerso.TabIndex = 0;
            FaiVerso.Text = "Clicca";
            FaiVerso.UseVisualStyleBackColor = true;
            FaiVerso.Click += button1_Click;
            // 
            // QualeAnimale
            // 
            QualeAnimale.Location = new Point(31, 173);
            QualeAnimale.Name = "QualeAnimale";
            QualeAnimale.Size = new Size(247, 23);
            QualeAnimale.TabIndex = 1;
            QualeAnimale.Text = "Inserisci animale tra: cane, gatto e mucca";
            // 
            // Risultato
            // 
            Risultato.AutoSize = true;
            Risultato.Location = new Point(332, 176);
            Risultato.Name = "Risultato";
            Risultato.Size = new Size(0, 15);
            Risultato.TabIndex = 2;
            // 
            // Nometext
            // 
            Nometext.Location = new Point(31, 202);
            Nometext.Name = "Nometext";
            Nometext.Size = new Size(247, 23);
            Nometext.TabIndex = 3;
            Nometext.Text = "Inserisci nome";
            // 
            // Energiatext
            // 
            Energiatext.Location = new Point(31, 231);
            Energiatext.Name = "Energiatext";
            Energiatext.Size = new Size(247, 23);
            Energiatext.TabIndex = 4;
            Energiatext.Text = "Inserisci energia";
            // 
            // Etatext
            // 
            Etatext.Location = new Point(31, 260);
            Etatext.Name = "Etatext";
            Etatext.Size = new Size(247, 23);
            Etatext.TabIndex = 5;
            Etatext.Text = "Inserisci  età";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(550, 224);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 214);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Etatext);
            Controls.Add(Energiatext);
            Controls.Add(Nometext);
            Controls.Add(Risultato);
            Controls.Add(QualeAnimale);
            Controls.Add(FaiVerso);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FaiVerso;
        private MaskedTextBox QualeAnimale;
        private Label Risultato;
        private TextBox Nometext;
        private TextBox Energiatext;
        private TextBox Etatext;
        private PictureBox pictureBox1;
    }
}
