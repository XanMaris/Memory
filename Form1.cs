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
        
        


        // Déclaration des variables globales du jeu
        int nbCartesDansSabot; // Nombre de cartes dans le sabot (en fait nombre
                               // d'images dans le réservoir)
        int nbCartesSurTapis; // Nombre de cartes sur le tapis

        int nbCarteRetourne = 0;

        int[] tImagesCartes;

        int i_carte2;
        int i_carte1;
        int carteClique;
        bool tromper = false;
        bool[] ImageTrouvee = { false, false,false,false,false,false,false,false};
        int indicePremierCarteCLique =0;
        int imageTrouveCompteur =0;
        int[] tImagesCartes1Dim = new int[8];

        LotoMachine hasard;

        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

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
            tImagesCartes = hasard.TirageAleatoire(nbCartesSurTapis / 2 , false);
            // La série d'entiers retournée par la LotoMachine correspondra
            // aux indices des cartes dans le "sabot"
            // Affectation des images aux picturebox
            PictureBox carte;
            int i_image;

            int[,] tTabTemp = new int[2, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j < tImagesCartes.Length; j++)
                {
                    while (true)
                    {
                        Random rnd = new Random();
                        int k = rnd.Next(0, 4);
                        int l = rnd.Next(0, 2);
                        if (tTabTemp[l, k] == 0)
                        {
                            tTabTemp[l, k] = tImagesCartes[j];
                            break;
                        }
                    }
                }
            }



            int ligne = 0;
            int colonne = 0;
            
            for (int i_carte = 0; i_carte < nbCartesSurTapis; i_carte++)
            { 
                if(i_carte == 4)
                {
                    ligne = 1;
                    colonne = 0;
                }
                
                carte = (PictureBox)tlpTapisDeCartes.Controls[i_carte];
                i_image = tTabTemp[ligne, colonne];
                tImagesCartes1Dim[i_carte] = i_image;
                carte.Tag = i_carte;
                carte.Image = ilSabotDeCartes.Images[i_image];
                colonne++;

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
           
            int i_image;
            Image Image_1, Image_2;
            if (nbCarteRetourne < 2)
            {
                carte = (PictureBox)sender;
                carteClique = Convert.ToInt32(carte.Tag);

                if (indicePremierCarteCLique == 0 )
                {
                    i_carte1 = carteClique;
                    indicePremierCarteCLique = tImagesCartes1Dim[i_carte1];
                    i_image = tImagesCartes1Dim[i_carte1];
                    carte.Image = ilSabotDeCartes.Images[i_image];
                }
                
                else
                {
                    i_carte2 = carteClique;
                    i_image = tImagesCartes1Dim[i_carte2];
                    carte.Image = ilSabotDeCartes.Images[i_image];
                    if (i_image == indicePremierCarteCLique)
                    {
                        ImageTrouvee[i_carte1] = true;
                        ImageTrouvee[i_carte2] = true;
                        imageTrouveCompteur+=2;
                    }
                }
                
             /*   if (nbCarteRetourne == 0)
                {
                    Image_1 = carte.Image;
                }
                if (nbCarteRetourne == 1)
                {
                    Image_2 = carte.Image;
                }
             */
                nbCarteRetourne++;
                if(nbCarteRetourne == 2)
                {
                    timer1.Start();
                    tromper = true;
                    nbCarteRetourne = 0;
                    indicePremierCarteCLique = 0;
                    pb_XX_Click(sender, e);
                    Image_1 = null;
                    Image_2 = null;

                }

                if(imageTrouveCompteur == 8)
                {
                    timer1.Stop();
                    timer.Stop();
                    stopwatch.Stop();

                    MessageBox.Show("Bravo vous avez gagner en : " + chronoLabel.Text +"sec");
                        
                }                
            }
        }

        /*private void btn_Retourner_Click(object sender, EventArgs e)
        {
            retournerCarte();
        }*/

        private void jouer_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < ImageTrouvee.Length; i++)
            {
                ImageTrouvee[i] = false;
                
            }
            nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;
            nbCartesSurTapis = tlpTapisDeCartes.Controls.Count;
            retournerCarte();

            /*  i_hasard = hasard.NumeroAleatoire();
              PictureBox carte;
              carte = pb_Recherche;


              carte.Image = ilSabotDeCartes.Images[i_hasard];
            */

            //section timer

            timer.Start();
            stopwatch.Start();


        }

        private void retournerCarte()
        {
            PictureBox carte;
            for (int i_carte = 0; i_carte < nbCartesSurTapis; i_carte++)
            {  
                if(!ImageTrouvee[i_carte])
                {
                    carte = (PictureBox)tlpTapisDeCartes.Controls[i_carte];
                    carte.Image = ilSabotDeCartes.Images[0];
                }
                
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            chronoLabel.Text = stopwatch.Elapsed.Seconds.ToString();
            Application.DoEvents();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tromper)
            {
                retournerCarte();
                timer1.Stop();
            }
            Application.DoEvents();

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
