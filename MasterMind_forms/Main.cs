using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date   : 12.11.2023      
/// Description : Jeux Master Mind en version graphique avec Windows forms et C#


namespace MasterMind_forms
{
    public partial class Main : Form
    {
     
        // conteur de position de label
        int countLabel = 1;

        //conteur d'essais
        int tries = 1;

        // couleurs possibles
        const int MAX_COLORS = 7;

        // tableau de couleurs avec les couleurs possibles
        Color[] tabColors = new Color[MAX_COLORS];


        // constante choix des couleurs
        const int ROWS = 10 ;
        const int COLUMNS = 4 ;
        // tableau de labels pour le choix de couleurs de l'utilisateur
        Label[,] tabLblChoice = new Label[COLUMNS, ROWS];

        // separation des label et panel 
        int margin = 20;
        int padding = 20;

        // tableau de label pour verifier les couleures correctes ou fauses
        Label[,] tabLblCheck = new Label[COLUMNS, ROWS];

        // crer le code couleur aleatoire
        Random random = new Random();

        // variables index tableau
        // columns
        int rowIndex = 0;
        //lignes
        int columnIndex = 0;

        // constante couleur aleatoire
        const int MAX_RANDOM = 4;

        // tableau couleur utilisateur
        Color[,] tabUserColor = new Color[COLUMNS,ROWS];

        // conteur couleurs bonne possition
        int goodPosition = 0;

        // conteur couleures mauvaise possition
        int badPosition = 0;

        //couleurs possibles returnes de Colors()
        Color[] returnedFromColors;

        // stocker le return du RandomCode()
        Color[] returnedFromRandomCode;

        // tableau pour comparer les couleurs
        Color[] copyFromCode = new Color[MAX_RANDOM];

        // copy des chois de l'utilisateur
        Color[,] userCopyChoice = new Color[COLUMNS, ROWS];

        // variable bool pour activer ou desactiver le code secret
        bool enable = false;

        // var stocker la hauteur des label crées pour le choix des couleurs
        int _heigthLblChoice = 0;


        public Main()
        {
            InitializeComponent();
            
            
        }

        /// <summary>
        /// Creation tableau des couleurs
        /// </summary>
        Color[] Colors()
        {
            // couleurs dans le tableau
            Color[] tabColors = { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Black, Color.White, Color.Magenta };
            //returner le tableau
            return tabColors;
        }

        /// <summary>
        /// Code aleatoire de 4 couleurs
        /// </summary>
        /// <param name="tabColors"></param>
        Color[] RandomCode(Color[] tabColors)
        {
            //code aleatoire entre 7 couleurs
            int color1 = random.Next(tabColors.Length);
            int color2 = random.Next(tabColors.Length);
            int color3 = random.Next(tabColors.Length);
            int color4 = random.Next(tabColors.Length);
            //tableau de random
            Color[] randomCode = { tabColors[color1], tabColors[color2], tabColors[color3], tabColors[color4] };
            // returner random code
            return randomCode;


        }

        /// <summary>
        /// Création du jeu
        /// </summary>
        public void Game()
        {
            // compteur essaies 
            tries = 1;
            lblNbTries.Text = tries.ToString();
            // masquer le bouton quitter
            btnExit.Visible = false;
            // masquer btn rejouer
            btnReplay.Visible = false;
            //couleurs possibles
            returnedFromColors = Colors();
            // code aleatoire
            RandomCode(returnedFromColors);
            // stocker le return du randomCode
            returnedFromRandomCode = RandomCode(returnedFromColors);
            // copy du tableau
            returnedFromRandomCode.CopyTo(copyFromCode, 0);
            // attribuer la couleur aleatoire aux label afin d'avoir le mode debeugue
            lblCode1.BackColor = returnedFromRandomCode[0];
            lblCode2.BackColor = returnedFromRandomCode[1];
            lblCode3.BackColor = returnedFromRandomCode[2];
            lblCode4.BackColor = returnedFromRandomCode[3];
            // masquer les labels avec le code
            lblCode1.Hide();
            lblCode2.Hide();
            lblCode3.Hide();
            lblCode4.Hide();


            // tableau de labels pour la selection des couleures par l'utilisateur
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    // creation des proprietes du label
                    Label choice = new Label();
                    //nom 
                    choice.Name = "lblChoice" + countLabel++;
                    // style
                    choice.BackColor = Color.Transparent;
                    choice.BorderStyle = BorderStyle.Fixed3D;
                    //taille
                    choice.Size = new Size(30, 30);
                    // position
                    choice.Location = new Point((choice.Width * j) + (j * padding), (choice.Height * i) + (i * margin + padding));
                    //associer au panel
                    choicePanel.Controls.Add(choice);
                    // ajouter les btns au tableau
                    tabLblChoice[j, i] = choice;
                    // stocker la hauteur des label
                    _heigthLblChoice = 30;
                }

            }
            // tableau de labels pour verifier la position correcte
            for (int k = 0; k < ROWS; k++)
            {
                for (int l = 0; l < COLUMNS; l++)
                {
                    // creation des proprietes du label
                    Label check = new Label();
                    //nom 
                    check.Name = "lblCeck" + countLabel++;
                    // style
                    check.BackColor = Color.Transparent;
                    check.BorderStyle = BorderStyle.Fixed3D;
                    //taille
                    check.Size = new Size(25, 25);
                    // position
                    check.Location = new Point((check.Width * l) + (l * (padding - 10)), ((check.Height * k) + (_heigthLblChoice / 2 + 8) + (k * (margin + 5))));
                    //associer au panel
                    checkPanel.Controls.Add(check);
                    // ajouter les label de check au tableau
                    tabLblCheck[l, k] = check;
                }
            }
        }

        /// <summary>
        /// Attribuer une couleur aux labels par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Colors_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            //remplir la ligne
            if (columnIndex == COLUMNS)
            {
                MessageBox.Show("La ligne est remplie");
            }
            else
            {
                tabLblChoice[columnIndex, rowIndex].BackColor = clickedButton.BackColor;
                // stocker la couleur selectione par l'utilisateur
                tabUserColor[columnIndex, rowIndex] = clickedButton.BackColor;
                // copier le code couleur de l'utilisateur
                userCopyChoice[columnIndex,rowIndex] = clickedButton.BackColor;
                columnIndex++;
            }
             


        }

        /// <summary>
        /// Btn pour verifier le code couleur introduit par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // reinitialiser les couleurs du tableau de copie
            for (int i = 0; i < MAX_RANDOM; i++)
            {
                copyFromCode[i] = returnedFromRandomCode[i];

            }
            
            // parcourir la ligne 
            for (int i = 0; i < COLUMNS; i++)
            {
                // verifier les couleurs entres par l'utilisateur dans la ligne
                if (returnedFromRandomCode[i] == tabUserColor[i,rowIndex])
                {
                    // remplacer les couleurs trouves par du gris
                    copyFromCode[i] = Color.Gray;
                    // remplacer les couleur correctes par du beige
                    userCopyChoice[i,rowIndex] = Color.Beige;
                    // si c'est correct afficher une case en blanc
                    tabLblCheck[goodPosition, rowIndex].BackColor = Color.White; 
                    // si couleur correct incrementer 
                    goodPosition++;
                    // si tout est correct alors gagne
                    if (goodPosition == 4)
                    {
                        // message de victoire
                        MessageBox.Show("Félicitation, vous avez gagnés !!", "Victoire");
                        // rendre visible le btn quitter
                        btnExit.Visible = true;
                        // rendre vible le btn rejouer
                        btnReplay.Visible = true;

                        // desactiver les boutons
                        btnBlack.Enabled = false;
                        btnBlue.Enabled = false;
                        btnGreen.Enabled = false;
                        btnMagenta.Enabled = false;
                        btnOrange.Enabled = false;
                        btnRed.Enabled = false;
                        btnWhite.Enabled = false;

                    }
                    
                }
                // assigner la valeur de good possition a bad possition
                badPosition = goodPosition;
                
            }
            for (int i = 0; i < COLUMNS; i++)
            {
                // verifier le code secret sans les couleurs deja trouves
                for (int j = 0; j < copyFromCode.Length; j++)
                {
                    if (userCopyChoice[i, rowIndex] == copyFromCode[j] && i != j)
                    {
                        // changer la couleur si on trouve une couleur mal place afin d'eviter les doublons
                        copyFromCode[j] = Color.Gray;
                        // afficher les case noir pour les couleurs mal places
                        tabLblCheck[badPosition, rowIndex].BackColor = Color.Black;
                        badPosition++;
                        break;
                    } 
                }

            }

            // reinitialiser la colonne
            columnIndex = 0;
            // incrementer la ligne
            rowIndex++;
            // compteur reinitialiser
            goodPosition = 0;
            // compteur reinitialise
            badPosition = 0;
            // incrementer les essais
            tries++;
           // afficher les essais
            lblNbTries.Text = tries.ToString();
            if (tries == 11)
            {
                MessageBox.Show("Vous avez utilise vos 10 essais !", "Perdu");
                // rendre visible le btn quitter
                btnExit.Visible = true;
                // rendre vible le btn rejouer
                btnReplay.Visible = true;
                // desactiver les boutons
                btnBlack.Enabled = false;
                btnBlue.Enabled = false;
                btnGreen.Enabled = false;
                btnMagenta.Enabled = false;
                btnOrange.Enabled = false;
                btnRed.Enabled = false;
                btnWhite.Enabled = false;

            }
        }

        /// <summary>
        /// Création des objets et options necesaires des le demarage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            Game();

        }

        /// <summary>
        /// Effacer la couleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // si les case sont vides on ne peut pas effacer
            if (columnIndex == 0 )
            {

            }
            // si elles sont remplies ont peut effacer
            else
            {
                columnIndex--;
                tabLblChoice[columnIndex, rowIndex].BackColor = Color.Transparent;
            }
            
            
        }

        /// <summary>
        /// Quitter le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // message de remerciment 
            MessageBox.Show("Merci d'avoir participe !");
            // fin du programme
            Application.Exit();
        }

        /// <summary>
        /// Rejouer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplay_Click(object sender, EventArgs e)
        {
            // vider les panel
            choicePanel.Controls.Clear();
            checkPanel.Controls.Clear();
            //compeur lignes et colonnes
            rowIndex = 0;
            columnIndex = 0;
            // rejoue
            Game();
            // Reactivation des boutons
            btnBlack.Enabled = true;
            btnBlue.Enabled = true;
            btnGreen.Enabled = true;
            btnMagenta.Enabled = true;
            btnOrange.Enabled = true;
            btnRed.Enabled = true;
            btnWhite.Enabled = true;
        }

        /// <summary>
        /// Afficher le code secret
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDebug_Click(object sender, EventArgs e)
        {
            // si les labels sont desactivées on les montres
            if (enable == false)
            {
                // activer le code
                lblCode1.Show();
                lblCode2.Show();
                lblCode3.Show();
                lblCode4.Show();
                // code activée
                enable = true;
            }
            // si ils sont actives on les cache
            else
            {
                // cacher le code
                lblCode1.Hide();
                lblCode2.Hide();
                lblCode3.Hide();
                lblCode4.Hide();
                // code désactivée
                enable = false;
            }
           

        }
    }
}
