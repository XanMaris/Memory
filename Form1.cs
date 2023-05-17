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
using System.Threading;

namespace Memory
{

    public partial class memory : Form
    {
        // Déclaration des variables globales du jeu
        int nbCartesDansSabot; // Nombre de cartes dans le sabot (en fait nombre
                               // d'images dans le réservoir)
        int nbCartesSurTapis; // Nombre de cartes sur le tapis

        int nbCarteRetourne = 0; //MAX 1

        System.Timers.Timer timerRetry;


        int[] tImagesCartes;
        bool reussi;

        bool attente = false; //SERT A BLOQUER LE CLICK SUR LES AUTRE IMAGE TANT QUE LES DEUX CARTE DIFFERENTES SONT FACE RECTO
        int i_carte2; //2 eme carte tiré
        int i_carte1; //1 er carte tiré
        int carteClique; //Carte courante cliqué

        bool[] ImageTrouvee = { false, false,false,false,false,false,false,false}; //TABLEAU DE BOOLEAN DES CARTE TROUVER
        int indicePremierCarteCLique = 0; // Indice de la premier Carte CLiqué (INDICE DE L IMAGE 1-256)
        int imageTrouveCompteur =0; //Nombre d'image trouvés (Augmente de 2 par 2)
        int[] tImagesCartes1Dim = new int[8]; //Tableau pour générer l'aléatoire

        LotoMachine hasard;

        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        public memory()
        {
            InitializeComponent();
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // Modifier les propriétés de la police
            Font = new Font("Arial", 12, FontStyle.Regular);

            // Modifier le titre du formulaire
            Text = "Memory";

            // Modifier la taille et la position du formulaire
            CenterToScreen();

            // Ajouter un bouton avec une image personnalisée

            jouer.BackColor = Color.Transparent;

         
   
         

        }

        private void Distribution_Sequentielle() //PAS UTILISER DANS LA NOUVELLE VERSION (MAIS IMPLEMENTER COMME DEMANDER)
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

        private void btn_Distribuer_Click(object sender, EventArgs e) //Quand click sur distribuer (afficher 8 cartes a l'utilisateur)
        {
            nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;
            nbCartesSurTapis = tlpTapisDeCartes.Controls.Count;
            Distribution_Aleatoire();
        }

        private void Distribution_Aleatoire() //GENERE 4 NOMBRE ALEAOITRE QUI SERONT LES INDICE DES IMAGE POUR LES CARTE
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

            int[,] tTabTemp = new int[2, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 } }; /// ON DISTRIBUE 2 FOIS LE MEME NUMERO ALEATOIREMENT

            
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

            //Fonction répartition de 4 carte * 2 parmi 8
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


        private void pb_XX_Click(object sender, EventArgs e) //FONCTION Appeléé quand click sur une pictureBox
        {

            PictureBox carte;
            int i_image;
        if(!attente) //ATTENDRE  LES CARTE ACTUELLEMENT RETOURNER FACE VERSO
        {
                if (nbCarteRetourne < 2) //SECURITE (on peut ps avoir 2 carte retourner ---- 1 ere carte : 0 ----- 2 ème carte : 1 
                {
                    reussi = false;
                    carte = (PictureBox)sender; 
                    carteClique = Convert.ToInt32(carte.Tag); //recuperation de la carte courante

                    if (nbCarteRetourne == 0) //Si c'est la 1ere carte
                    {
                        i_carte1 = carteClique;
                        indicePremierCarteCLique = tImagesCartes1Dim[i_carte1];
                        i_image = tImagesCartes1Dim[i_carte1];
                        carte.Image = ilSabotDeCartes.Images[i_image];
                        nbCarteRetourne++;

                    }

                    else //Si c'est la deuxieme carte
                    {
                        i_carte2 = carteClique;
                        i_image = tImagesCartes1Dim[i_carte2];
                        carte.Image = ilSabotDeCartes.Images[i_image];

                        if (i_image == indicePremierCarteCLique) //compraison des images
                        {
                            ImageTrouvee[i_carte1] = true; //MAJ du tableau de boolean
                            ImageTrouvee[i_carte2] = true;
                            imageTrouveCompteur += 2; //Augmentation de 2 car pair 
                            reussi = true;
                        }

                        if (imageTrouveCompteur == 8)
                        {
                            timer.Stop();
                            stopwatch.Stop();
                            MessageBox.Show("Bravo vous avez gagné en : " + chronoLabel.Text + "minutes");

                        }
                        if(!reussi)
                        {
                            timerRetry = new System.Timers.Timer(2500); //Creation d'un timer pour afficher les carte cliqué
                            timerRetry.Elapsed += TimerElapsed;
                            attente = true; //verrou

                            timerRetry.Start(); //lancement du timer

                        }
                        else
                        {
                            retournerCarte();
                            nbCarteRetourne = 0;
                            attente = false;
                        }



                      
                    }
                }
            }
        }


        private void btn_Retourner_Click(object sender, EventArgs e) //FONCTION NON UTILISE DANS CETTE VERSION
        {
            retournerCarte();
        }

        private void jouer_Click(object sender, EventArgs e) 
        {
            //RENITIALISATION DES VARIABLE GLOBALE
            for (int i = 0; i < ImageTrouvee.Length; i++)
            {
                ImageTrouvee[i] = false;
                
            }
            nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;
            nbCartesSurTapis = tlpTapisDeCartes.Controls.Count;

            //INITIALISATION DES SERVICES
            retournerCarte();
            timer.Start();
            stopwatch.Start();
            nbCarteRetourne = 0;
            imageTrouveCompteur = 0;

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


        private void timer_Tick(object sender, EventArgs e) //TIMER VISUEL POUR DETERMINER LA LONGUEUR DE LA PARTIE EN SECONDE
        {
            TimeSpan timespan = stopwatch.Elapsed;
            int minutes = (int)timespan.TotalMinutes;
            int secondes = (int)timespan.Seconds;
            chronoLabel.Text = minutes.ToString() + ":" + secondes.ToString();
            Application.DoEvents();
        }

        private void TimerElapsed(Object sender, ElapsedEventArgs e) //CE TIMER NOUS SERT A METTRE FACE VERSO LES CARTE QUAND CELLE-CI SONT PAS IDENTIQUE
        {
           //2,5 SEC APRES AVOIR RETOURNER 2 CARTE NON IDENTIQUE 

            retournerCarte(); //ON LES RETOURNE
            attente = false;
            timerRetry.Stop();
            nbCarteRetourne = 0;
           
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

        private void memory_Load(object sender, EventArgs e)
        {

        }
    }
}
