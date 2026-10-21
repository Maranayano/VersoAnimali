using System.IO;
namespace VersoAnimaliForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CGatto ris = new CGatto();
            CCane ris1 = new CCane();
            CMucca ris2 = new CMucca();
            if (QualeAnimale.Text.Trim() == "Gatto" || QualeAnimale.Text.Trim() == "gatto")
            {
                Risultato.Text = Nometext.Text + " fa: " + ris.Verso() + " età: " + Etatext.Text + " anni" + " energia: " + Energiatext.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\14529929\Downloads\gatto1.png");
            }
            else if (QualeAnimale.Text.Trim() == "Cane" || QualeAnimale.Text.Trim() == "cane")
            {
                Risultato.Text = Nometext.Text + " fa: " + ris1.Verso() + " età: " + Etatext.Text + " anni" + " energia: " + Energiatext.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\14529929\Immagini\cane1.png");
            }
            else if (QualeAnimale.Text.Trim() == "Mucca" || QualeAnimale.Text.Trim() == "mucca")
            {
                Risultato.Text = Nometext.Text + " fa: " + ris2.Verso() + " età: " + Etatext.Text + " anni" + " energia: " + Energiatext.Text;
                pictureBox1.Image = Image.FromFile(@"C:\Users\14529929\Downloads\gatto1.png");
            }
            else
            {
                Risultato.Text = "Errore!";
            }
        }
    }
}
