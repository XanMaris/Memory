using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllLoto;
using System.Timers;
using Nest;
using System.Diagnostics;

namespace Memory
{
   
    public partial class memory : Form
    {
        Stopwatch watch = new Stopwatch();
        // Déclaration des variables globales du jeu
        int nbCartesDansSabot; // Nombre de cartes dans le sabot (en fait nombre
                               // d'images dans le réservoir)
        int nbCartesSurTapis; // Nombre de cartes sur le tapis

        int nbCarteRetourne = 0;

        int[] tImagesCartes ;
        int i_hasard;

        LotoMachine hasard;

        public memory()
        {
            InitializeComponent();
           
        }

        private void Distribution_Sequentielle()
        {
            PictureBox carte;
            int i_carte = 1;
            foreach (Control ctrl in tlpTapisDeCartes.Controls)
            {
                // Je sais que le contrôle est une PictureBox
                // donc je "caste" l'objet (le Contrôle) en PictureBox...
                carte = (PictureBox)ctrl;
                // Ensuite je peux accéder à la propriété Image
                // (je ne pourrais pas si je n'avais pas "casté" le contrôle)
                carte.Image = ilSabotDeCartes.Images[i_carte];
                i_carte++;
            }
        }

        private void btn_Distribuer_Click(object sender, EventArgs e)
        {
            nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;
            nbCartesSurTapis = tlpTapisDeCartes.Controls.Count;
            Distribution_Aleatoire();
        }

        private void Distribution_Aleatoire()
        {
            // On utilise la LotoMachine pour générer une série aléatoire
            hasard = new LotoMachine(nbCartesDansSabot);
            // On veut une série de nbCartesSurTapis cartes parmi celles
            // du réservoir
            tImagesCartes = hasard.TirageAleatoire(nbCartesSurTapis, false);
            // La série d'entiers retournée par la LotoMachine correspondra
            // aux indices des cartes dans le "sabot"
            // Affectation des images aux picturebox
            PictureBox carte;
            int i_image;
            for (int i_carte = 0; i_carte < nbCartesSurTapis; i_carte++)
            {

                carte = (PictureBox)tlpTapisDeCartes.Controls[i_carte];
                i_image = tImagesCartes[i_carte + 1]; // i_carte + 1 à cause
                                                      // des pbs d'indices
                carte.Tag = i_carte;
                carte.Image = ilSabotDeCartes.Images[i_image];
            }
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            // On utilise la LotoMachine pour générer une série aléatoire
            // On fixe à 49 le nombre maxi que retourne la machine
            LotoMachine hasard = new LotoMachine(49);
            // On veut une série de 6 numéros distincts parmi 49 (comme quand on joue  loto)
            int[] tirageLoto = hasard.TirageAleatoire(6, false);
            // false veut dire pas de doublon : une fois qu'une boule est sortie,
            // elle ne peut pas sortir à nouveau ;-)
            // La série d'entiers retournée par la LotoMachine correspond au loto
            // affiché sur votre écran TV ce soir...
            string grilleLoto = "* ";
            for (int i = 1; i <= 6; i++)
            {
                grilleLoto = grilleLoto + tirageLoto[i] + " * ";
            }
            MessageBox.Show(grilleLoto, "Tirage du LOTO ce jour !");
        }


        private void pb_XX_Click(object sender, EventArgs e)
        {

            PictureBox carte;
            int i_carte, i_image;
            Image Image_1, Image_2;
            //if (Image_1 == null)
            // MessageBox.Show("L'image 1 n'est pas référencée");
            //if (Image_2 == null)
            // MessageBox.Show("L'image 2 n'est pas référencée");
            if (nbCarteRetourne < 2)
            {
                carte = (PictureBox)sender;
                i_carte = Convert.ToInt32(carte.Tag);
                i_image = tImagesCartes[i_carte+1];
                carte.Image = ilSabotDeCartes.Images[i_image];
               if (i_image == i_hasard)
                {
                    MessageBox.Show("Bravo !");
                }
                else
            {
                    MessageBox.Show("DOMMAGE !");
                }
                if (nbCarteRetourne == 0)
                {
                    Image_1 = carte.Image;
                }
                if (nbCarteRetourne == 1)
                {
                    Image_2 = carte.Image;
                }
                nbCarteRetourne++;
            }
            else
            {
                MessageBox.Show("Deux cartes sont déjà retournées !");
               // RetournerLesCartes();
                nbCarteRetourne = 0;
                Image_1 = null;
                Image_2 = null;
            }
        }

        private void btn_Retourner_Click(object sender, EventArgs e)
        {
            retournerCarte();
        }

        private void jouer_Click(object sender, EventArgs e)
        {

            nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;
            nbCartesSurTapis = tlpTapisDeCartes.Controls.Count;
            retournerCarte();
          
            i_hasard = hasard.NumeroAleatoire();
            PictureBox carte;
            carte = pb_Recherche;
            carte.Image = ilSabotDeCartes.Images[i_hasard];

            //section timer

            timer.Start();
            timer.Enabled = true;

        }

        private void retournerCarte()

        {
            PictureBox carte;
            for (int i_carte = 0; i_carte < nbCartesSurTapis; i_carte++)
            {
                carte = (PictureBox)tlpTapisDeCartes.Controls[i_carte];
                carte.Image = ilSabotDeCartes.Images[0];
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            // timerLabel.Text = time.ToString();
        }




        // MANAGEMENT OF PB CLICK

        private void pb_01_Click(object sender, EventArgs e)
        {
            pb_XX_Click(sender, e);
        }

        private void pb_02_Click(object sender, EventArgs e)
        {
            pb_XX_Click( sender,  e);
        }

        private void pb_03_Click(object sender, EventArgs e)
        {
            pb_XX_Click(sender, e);
        }

        private void pb_04_Click(object sender, EventArgs e)
        {
            pb_XX_Click(sender, e);
        }

        private void pb_05_Click(object sender, EventArgs e)
        {
            pb_XX_Click(sender, e);
        }

        private void pb_07_Click(object sender, EventArgs e)
        {
            pb_XX_Click(sender, e);
        }

        private void pb_06_Click(object sender, EventArgs e)
        {
            pb_XX_Click(sender, e);
        }

        private void pb_08_Click(object sender, EventArgs e)
        {
            pb_XX_Click(sender, e);
        }
    }
}
