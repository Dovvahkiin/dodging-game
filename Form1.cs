using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypicalYasuo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int xLock;
        int yLock;
        int tornadoY; 
        int tornadoX; 
        int a;
        int b;
        int vreme;

        private void Form1_KeyDown(object sender, KeyEventArgs e) // u zagradi je defenisano "e" koji služi za tastere
        {
            int x = pbTeemo.Location.X; // lokacija slike (picture boxa) teema X osa
            int y = pbTeemo.Location.Y; // lokacija slike (picture boxa) teema Y osa


            if ((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.D)) x += 10; // pomeranje u desno
            else if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.A)) x -= 12; // pomeranje u levo
            pbTeemo.Location = new Point(x, y); // ucitavanje lokacije teema

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xLock = this.Width;
            yLock = this.Height;
            a = r.Next(10, 20);
            b = 0;
            tornadoY = 0;
            vreme = 0;
            label1.Text = "Ukupno preživelih sekundi: 0"; // label sa rezultatom
            pomeranjeSlike();
            pbTornado.Visible = false;
            btnOpet.Visible = false;

        }

        private void pomeranjeSlike() // pomeranje slike yasua
        {
            int x = pbYasuo.Location.X;
            int y = pbYasuo.Location.Y;

            x = r.Next (150, x+= 150 ); // next vraća random broj u range od minimuma i maximuma (150, x+=150)

            pbYasuo.Location = new Point(x, y);
        }
        private void timer1_Tick(object sender, EventArgs e) // Yasuovo kretanje uz funkciju
        {
            pomeranjeSlike(); // pozivanje funkcije za pomeranje slike
        }
        private void timer2_Tick(object sender, EventArgs e) // kretanje tornada
        {
            int x = pbTeemo.Location.X;
            b++; // Svaki put kad timer odradi tick b se poveća za 1, a vrednost a koja je random je određena na otvaranje forme
            vreme++; // tajmer
            if (vreme % 10 == 0)
                label1.Text = " Ukupno preživelih sekundi:" + vreme / 10;
            if(b == a) // ako se vrednost b i random vrednost a poklope pojavljuje se tornado sa x pozicije yasua
            {
                pbTornado.Visible = true;
                tornadoX = pbYasuo.Location.X;
            }
            else if (b > a) // kada se promeni vrednost tornado ide vertikalno
            {
                tornadoY += 35;
                pbTornado.Location = new Point(tornadoX, tornadoY);
                if (tornadoY > Height) // kada tornado nestane sa forma dobija početnu vrednost
                {
                    b = 0; // vrednost b se postavlja na 0 jer sledeći tick na timer dodaje vrednost tako da će biti ponovo 1,2,3...
                    tornadoY = 0;
                    a = r.Next(10, 20); // vrednost a dobije ponovo neku drugu random vrednost 
                }
            }
            if (pbTornado.Bounds.IntersectsWith(pbTeemo.Bounds)) // ako se teemo i tornado poklope poziva se funkcija gameover
            {
                gameover(); 
            }
        }
        private void gameover() // funkcija za kraj igre
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            btnOpet.Visible = true;

        }

        private void btnOpet_Click(object sender, EventArgs e) // dugme za ponovni pokušaj sa svim vrednostima jednakim nuli
        {
            vreme = 0;
            a = 0;
            b = 0;
            tornadoX = 0;
            tornadoY = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            btnOpet.Visible = false;
            label1.Text = "Ukupno preživelih sekundi: 0";
        }






    }
}
