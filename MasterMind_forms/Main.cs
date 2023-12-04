using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind_forms
{
    public partial class Main : Form
    {
     
        // conteur de position de label
        int countLabel = 1;

        //conteur d'essais
        int tries = 0;

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
        int margin = 40;
        int padding = 20;

        // tableau de label pour verifier les couleures correctes ou fauses
        Label[,] tabLblCheck = new Label[COLUMNS, ROWS];

        // crer le code couleur aleatoire
        Random random = new Random();

        // variables index tableau
        int rowIndexX = 0;
        int columnIndexY = 0;

        // couleur utilisateur
        int colorUser = -1;

        // constante couleur aleatoire
        const int MAX_RANDOM = 4;

        // tableau couleur utilisateur
        Color[,] tabUserColor = new Color[COLUMNS,ROWS];

        // conteur couleurs correctes
        int goodPosition = 0;

        // conteur faux
        int badPosition = 0;

        
        

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

            //pour les 4 boutons: trouver l'index correspondant a la couleur
            /*Color buttonColor = Color.Red;
            if (randomCode[0] == buttonColor)
            {   
                //premier couleur ok...
            }*/

        }

        /// <summary>
        /// Attribuer une couleur aux labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Colors_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            //remplir la ligne
            if (rowIndexX == COLUMNS)
            {
                MessageBox.Show("La ligne est remplie");
            }
            //incrementer de 1 à chaque clique pour remplir la ligne
            else
            {   
                tabLblChoice[rowIndexX, columnIndexY].BackColor = clickedButton.BackColor;
                //rowIndexX++;
                // stocker la couleur selectione par l'utilisateur
                tabUserColor[rowIndexX, columnIndexY] = clickedButton.BackColor;
                rowIndexX++;
            }
            

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //couleurs possibles
            Color[] returnedFromColors = Colors();
            // code aleatoire
            RandomCode(returnedFromColors);
            // stocker le retun du randomCode
            Color[] retunedFromRandomCode = RandomCode(returnedFromColors);

            // parcourir la ligne 
            for (int i = 0; i < COLUMNS; i++)
            {
                // verifier les couleurs entres par l'utilisateur dans la ligne
                if (retunedFromRandomCode[i] == tabUserColor[i,columnIndexY])
                {  
                    // si c'est correct
                    tabLblCheck[i, columnIndexY].BackColor = Color.White;
                    goodPosition++;

                }
                
            }
          

        }

        /// <summary>
        /// Création des objets et options necesaires des le demarage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            //couleurs possibles
            Color[] returnedFromColors = Colors();
            // code aleatoire
            RandomCode(returnedFromColors);
            // stocker le retun du randomCode
            Color[] retunedFromRandomCode = RandomCode(returnedFromColors);
            // tester si le code fonctione
            label1.BackColor = retunedFromRandomCode[0];
            label2.BackColor = retunedFromRandomCode[1];
            label3.BackColor = retunedFromRandomCode[2];
            label4.BackColor = retunedFromRandomCode[3];


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
                    choice.Size = new Size(29, 27);
                    // position
                    choice.Location = new Point((choice.Width * j) +(j * padding) , (choice.Height * i ) + (i * margin + padding));
                    //associer au panel
                    choicePanel.Controls.Add(choice);
                    // ajouter les btns au tableau
                    tabLblChoice[j, i] = choice;
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
                    check.Size = new Size(29, 27);
                    // position
                    check.Location = new Point((check.Width * l) + (l * padding), (check.Height * k ) + (k * margin + padding));
                    //associer au panel
                    checkPanel.Controls.Add(check);
                    // ajouter les label de check au tableau
                    tabLblCheck[l, k] = check;
                }
            }
        }
    }
}
