
namespace Memory
{
    partial class memory
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memory));
            this.btn_Distribuer = new System.Windows.Forms.Button();
            this.jouer = new System.Windows.Forms.Button();
            this.tlpTapisDeCartes = new System.Windows.Forms.TableLayoutPanel();
            this.pb_08 = new System.Windows.Forms.PictureBox();
            this.pb_07 = new System.Windows.Forms.PictureBox();
            this.pb_06 = new System.Windows.Forms.PictureBox();
            this.pb_04 = new System.Windows.Forms.PictureBox();
            this.pb_02 = new System.Windows.Forms.PictureBox();
            this.pb_01 = new System.Windows.Forms.PictureBox();
            this.pb_05 = new System.Windows.Forms.PictureBox();
            this.pb_03 = new System.Windows.Forms.PictureBox();
            this.ilSabotDeCartes = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.chronoLabel = new System.Windows.Forms.Label();
            this.titreChronoLabel = new System.Windows.Forms.Label();
            this.menuGauche = new System.Windows.Forms.GroupBox();
            this.tlpTapisDeCartes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).BeginInit();
            this.menuGauche.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Distribuer
            // 
            this.btn_Distribuer.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Distribuer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Distribuer.BackgroundImage")));
            this.btn_Distribuer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Distribuer.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btn_Distribuer.FlatAppearance.BorderSize = 0;
            this.btn_Distribuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Distribuer.Location = new System.Drawing.Point(6, 81);
            this.btn_Distribuer.Name = "btn_Distribuer";
            this.btn_Distribuer.Size = new System.Drawing.Size(249, 236);
            this.btn_Distribuer.TabIndex = 1;
            this.btn_Distribuer.UseVisualStyleBackColor = false;
            this.btn_Distribuer.Click += new System.EventHandler(this.btn_Distribuer_Click);
            // 
            // jouer
            // 
            this.jouer.BackColor = System.Drawing.Color.SeaShell;
            this.jouer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jouer.BackgroundImage")));
            this.jouer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jouer.Location = new System.Drawing.Point(6, 452);
            this.jouer.Name = "jouer";
            this.jouer.Size = new System.Drawing.Size(255, 76);
            this.jouer.TabIndex = 3;
            this.jouer.UseVisualStyleBackColor = false;
            this.jouer.Click += new System.EventHandler(this.jouer_Click);
            // 
            // tlpTapisDeCartes
            // 
            this.tlpTapisDeCartes.ColumnCount = 4;
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.Controls.Add(this.pb_08, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_07, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_06, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_04, 3, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_02, 1, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_01, 0, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_05, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_03, 2, 0);
            this.tlpTapisDeCartes.Location = new System.Drawing.Point(270, 65);
            this.tlpTapisDeCartes.Name = "tlpTapisDeCartes";
            this.tlpTapisDeCartes.RowCount = 2;
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tlpTapisDeCartes.Size = new System.Drawing.Size(1035, 548);
            this.tlpTapisDeCartes.TabIndex = 13;
            // 
            // pb_08
            // 
            this.pb_08.Location = new System.Drawing.Point(261, 275);
            this.pb_08.Name = "pb_08";
            this.pb_08.Size = new System.Drawing.Size(252, 270);
            this.pb_08.TabIndex = 6;
            this.pb_08.TabStop = false;
            this.pb_08.Click += new System.EventHandler(this.pb_08_Click);
            // 
            // pb_07
            // 
            this.pb_07.Location = new System.Drawing.Point(777, 275);
            this.pb_07.Name = "pb_07";
            this.pb_07.Size = new System.Drawing.Size(255, 270);
            this.pb_07.TabIndex = 4;
            this.pb_07.TabStop = false;
            this.pb_07.Click += new System.EventHandler(this.pb_07_Click);
            // 
            // pb_06
            // 
            this.pb_06.Location = new System.Drawing.Point(519, 275);
            this.pb_06.Name = "pb_06";
            this.pb_06.Size = new System.Drawing.Size(252, 270);
            this.pb_06.TabIndex = 3;
            this.pb_06.TabStop = false;
            this.pb_06.Click += new System.EventHandler(this.pb_06_Click);
            // 
            // pb_04
            // 
            this.pb_04.Location = new System.Drawing.Point(777, 3);
            this.pb_04.Name = "pb_04";
            this.pb_04.Size = new System.Drawing.Size(255, 266);
            this.pb_04.TabIndex = 1;
            this.pb_04.TabStop = false;
            this.pb_04.Click += new System.EventHandler(this.pb_04_Click);
            // 
            // pb_02
            // 
            this.pb_02.Location = new System.Drawing.Point(261, 3);
            this.pb_02.Name = "pb_02";
            this.pb_02.Size = new System.Drawing.Size(252, 266);
            this.pb_02.TabIndex = 0;
            this.pb_02.TabStop = false;
            this.pb_02.Click += new System.EventHandler(this.pb_02_Click);
            // 
            // pb_01
            // 
            this.pb_01.Location = new System.Drawing.Point(3, 3);
            this.pb_01.Name = "pb_01";
            this.pb_01.Size = new System.Drawing.Size(252, 266);
            this.pb_01.TabIndex = 0;
            this.pb_01.TabStop = false;
            this.pb_01.Click += new System.EventHandler(this.pb_01_Click);
            // 
            // pb_05
            // 
            this.pb_05.Location = new System.Drawing.Point(3, 275);
            this.pb_05.Name = "pb_05";
            this.pb_05.Size = new System.Drawing.Size(252, 270);
            this.pb_05.TabIndex = 5;
            this.pb_05.TabStop = false;
            this.pb_05.Click += new System.EventHandler(this.pb_05_Click);
            // 
            // pb_03
            // 
            this.pb_03.Location = new System.Drawing.Point(519, 3);
            this.pb_03.Name = "pb_03";
            this.pb_03.Size = new System.Drawing.Size(252, 266);
            this.pb_03.TabIndex = 0;
            this.pb_03.TabStop = false;
            this.pb_03.Click += new System.EventHandler(this.pb_03_Click);
            // 
            // ilSabotDeCartes
            // 
            this.ilSabotDeCartes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSabotDeCartes.ImageStream")));
            this.ilSabotDeCartes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSabotDeCartes.Images.SetKeyName(0, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(1, "a_vehicule_01.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(2, "a_vehicule_02.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(3, "a_vehicule_03.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(4, "a_vehicule_04.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(5, "a_vehicule_05.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(6, "a_vehicule_06.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(7, "a_vehicule_07.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(8, "a_vehicule_08.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(9, "a_vehicule_09.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(10, "a_vehicule_10.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(11, "a_vehicule_11.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(12, "a_vehicule_12.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(13, "a_vehicule_13.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(14, "a_vehicule_14.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(15, "a_vehicule_15.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(16, "a_vehicule_16.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(17, "a_vehicule_17.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(18, "a_vehicule_18.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(19, "a_vehicule_19.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(20, "a_vehicule_20.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(21, "a_vehicule_21.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(22, "a_vehicule_22.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(23, "a_vehicule_23.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(24, "a_vehicule_24.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(25, "a_vehicule_25.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(26, "a_vehicule_26.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(27, "a_vehicule_27.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(28, "a_vehicule_28.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(29, "a_vehicule_29.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(30, "a_vehicule_30.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(31, "a_vehicule_31.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(32, "a_vehicule_32.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(33, "a_vehicule_33.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(34, "a_vehicule_34.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(35, "a_vehicule_35.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(36, "a_vehicule_36.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(37, "a_vehicule_37.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(38, "a_vehicule_38.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(39, "a_vehicule_39.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(40, "a_vehicule_40.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(41, "CamionMilitaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(42, "Depaneuse.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(43, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(44, "Scooter.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(45, "Dialogue.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(46, "Diplome.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(47, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(48, "FemmeAffaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(49, "FemmeBatiment.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(50, "FemmeBlanche.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(51, "FemmeBleue.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(52, "FemmeCasque.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(53, "FemmeCuisinier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(54, "FemmeInformaticienBrune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(55, "FemmeInformaticienChatain.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(56, "FemmeJournal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(57, "FemmeMedecin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(58, "FemmeMegaphone.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(59, "FemmeOrange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(60, "FemmePhotographe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(61, "FemmePoliciere.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(62, "HommeAffaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(63, "HommeBatiment.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(64, "HommeBleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(65, "HommeCasque.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(66, "HommeCuisinier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(67, "HommeGarde.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(68, "HommeInformaticienBrun.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(69, "HommeInformaticienChatain.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(70, "HommeJournal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(71, "HommeMarron.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(72, "HommeMedecin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(73, "HommeMegaphone.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(74, "HommeOrange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(75, "HommePhotographe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(76, "HommePolicier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(77, "Joker.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(78, "LivreurPizza.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(79, "MarinMousse.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(80, "MarinOfficier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(81, "MarinPompon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(82, "Mecanicien.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(83, "Pilote.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(84, "Pompier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(85, "Serveur.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(86, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(87, "Helico_01p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(88, "Helico_02p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(89, "Helico_04p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(90, "Helico_05p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(91, "Helico_06p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(92, "Helico_07p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(93, "Helico_08p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(94, "Helico_11p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(95, "Helico_13p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(96, "Helico_14p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(97, "Helico_15p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(98, "Helico_16p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(99, "Helico_18p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(100, "Helico_19p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(101, "Helico_20p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(102, "Helico_21p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(103, "Helico_22p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(104, "Helico_23p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(105, "Helico_24p.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(106, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(107, "Helico_01m_bleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(108, "Helico_01m_jaune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(109, "Helico_01m_rouge.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(110, "Helico_02m_bleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(111, "Helico_02m_jaune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(112, "Helico_02m_rouge.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(113, "Helico_04m.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(114, "Helico_05m.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(115, "Helico_06m_bleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(116, "Helico_06m_rouge.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(117, "Helico_06m_vert.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(118, "Helico_07m.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(119, "Helico_08m.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(120, "Helico_11m_bleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(121, "Helico_11m_jaune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(122, "Helico_11m_vert.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(123, "Helico_13m.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(124, "Helico_14m.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(125, "Helico_15m_jaune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(126, "Helico_15m_rouge.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(127, "Helico_15m_vert.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(128, "Helico_16m_bleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(129, "Helico_16m_jaune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(130, "Helico_16m_rouge.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(131, "Helico_18m_bleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(132, "Helico_18m_orange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(133, "Helico_18m_rouge.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(134, "Helico_19m_bleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(135, "Helico_19m_rouge.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(136, "Helico_19m_violet.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(137, "Helico_20m_bleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(138, "Helico_20m_vert.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(139, "Helico_22m_bleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(140, "Helico_22m_jaune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(141, "Helico_22m_vert.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(142, "Helico_23m_blanc.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(143, "Helico_23m_orange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(144, "Helico_24m_bleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(145, "Helico_24m_orange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(146, "Helico_24m_vert.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(147, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(148, "Fleur_01.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(149, "Fleur_02.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(150, "Fleur_03.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(151, "Fleur_04.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(152, "Fleur_05.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(153, "Fleur_06.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(154, "Fleur_07.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(155, "Fleur_08.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(156, "Fleur_09.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(157, "Fleur_10.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(158, "Fleur_11.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(159, "Fleur_12.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(160, "Fleur_13.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(161, "Fleur_14.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(162, "Fleur_15.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(163, "Fleur_16.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(164, "Fleur_17.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(165, "Fleur_18.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(166, "Fleur_19.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(167, "Fleur_20.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(168, "Fleur_21.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(169, "Fleur_22.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(170, "Fleur_23.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(171, "Fleur_24.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(172, "Fleur_25.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(173, "Abeille.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(174, "Autruches.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(175, "Canard.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(176, "Chameau.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(177, "Chien.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(178, "ChienGamelle.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(179, "ChienMechant.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(180, "ChienSavant.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(181, "Chimpanze.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(182, "Coccinelle.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(183, "Crabe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(184, "Crocodile.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(185, "Dauphin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(186, "Ecureuil.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(187, "Hanneton.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(188, "Hibou.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(189, "Hippocampe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(190, "Homard.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(191, "Kangourou.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(192, "Lapin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(193, "LapinChapeau.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(194, "LapinRieur.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(195, "Lion.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(196, "MacareuxMoine.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(197, "Mouette.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(198, "Ocelot.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(199, "OiseauCage.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(200, "OiseauChante.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(201, "OiseauPic.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(202, "Orycterope.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(203, "Papillon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(204, "PoissonBocal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(205, "PoissonBulle.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(206, "PoissonPapillon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(207, "PorcEpic.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(208, "PorcEpic2.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(209, "Renne.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(210, "Renne2.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(211, "Serpent.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(212, "Taureau.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(213, "Vache.jpg");
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(836, 393);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 17);
            this.timerLabel.TabIndex = 15;
            // 
            // chronoLabel
            // 
            this.chronoLabel.AutoSize = true;
            this.chronoLabel.Location = new System.Drawing.Point(1045, 629);
            this.chronoLabel.Name = "chronoLabel";
            this.chronoLabel.Size = new System.Drawing.Size(0, 17);
            this.chronoLabel.TabIndex = 16;
            // 
            // titreChronoLabel
            // 
            this.titreChronoLabel.AutoSize = true;
            this.titreChronoLabel.Location = new System.Drawing.Point(934, 629);
            this.titreChronoLabel.Name = "titreChronoLabel";
            this.titreChronoLabel.Size = new System.Drawing.Size(105, 17);
            this.titreChronoLabel.TabIndex = 17;
            this.titreChronoLabel.Text = "Temps écoulé :";
            // 
            // menuGauche
            // 
            this.menuGauche.BackColor = System.Drawing.Color.SeaShell;
            this.menuGauche.Controls.Add(this.jouer);
            this.menuGauche.Controls.Add(this.btn_Distribuer);
            this.menuGauche.Location = new System.Drawing.Point(0, 0);
            this.menuGauche.Name = "menuGauche";
            this.menuGauche.Size = new System.Drawing.Size(267, 674);
            this.menuGauche.TabIndex = 18;
            this.menuGauche.TabStop = false;
            // 
            // memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1377, 695);
            this.Controls.Add(this.menuGauche);
            this.Controls.Add(this.titreChronoLabel);
            this.Controls.Add(this.chronoLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.tlpTapisDeCartes);
            this.Name = "memory";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.memory_Load);
            this.tlpTapisDeCartes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).EndInit();
            this.menuGauche.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Distribuer;
        private System.Windows.Forms.Button jouer;
        private System.Windows.Forms.TableLayoutPanel tlpTapisDeCartes;
        private System.Windows.Forms.PictureBox pb_04;
        private System.Windows.Forms.PictureBox pb_01;
        private System.Windows.Forms.PictureBox pb_02;
        private System.Windows.Forms.PictureBox pb_03;
        private System.Windows.Forms.ImageList ilSabotDeCartes;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.PictureBox pb_08;
        private System.Windows.Forms.PictureBox pb_07;
        private System.Windows.Forms.PictureBox pb_06;
        private System.Windows.Forms.PictureBox pb_05;
        private System.Windows.Forms.Label chronoLabel;
        private System.Windows.Forms.Label titreChronoLabel;
        private System.Windows.Forms.GroupBox menuGauche;
    }
}

