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
 
    public partial class  Main : Form
    {
     
        // conteur de position de label
        int _countLabel = 1;

        //conteur d'essais
        int _tries = 1;

        // couleurs possibles
        const int _MAX_COLORS = 7;

        // tableau de couleurs avec les couleurs possibles
        //Color[] _tabColors = new Color[_MAX_COLORS];


        // constante choix des couleurs
        const int _ROWS = 10 ;
        const int _COLUMNS = 4 ;
        // tableau de labels pour le choix de couleurs de l'utilisateur
        Label[,] _tabLblChoice = new Label[_COLUMNS, _ROWS];

        // separation des label et panel 
        int _margin = 20;
        int _padding = 20;

        // tableau de label pour verifier les couleures correctes ou fauses
        Label[,] _tabLblCheck = new Label[_COLUMNS, _ROWS];

        // crer le code couleur aleatoire
        Random _random = new Random();

        // variables index tableau
        // columns
        int _rowIndex = 0;
        //lignes
        int _columnIndex = 0;

        // constante couleur aleatoire
        const int _MAX_RANDOM = 4;

        // tableau couleur utilisateur
        Color[,] _tabUserColor = new Color[_COLUMNS, _ROWS];

        // conteur couleurs bonne possition
        int _goodPosition = 0;

        // conteur couleures mauvaise possition
        int _badPosition = 0;

        //couleurs possibles returnes de Colors()
        Color[] _returnedFromColors;

        // stocker le return du RandomCode()
        Color[] _returnedFromRandomCode;

        // tableau pour comparer les couleurs
        Color[] _copyFromCode = new Color[_MAX_RANDOM];

        // copy des chois de l'utilisateur
        Color[,] _userCopyChoice = new Color[_COLUMNS, _ROWS];

        // variable bool pour activer ou desactiver le code secret
        bool _enable = false;

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
            int color1 = _random.Next(tabColors.Length);
            int color2 = _random.Next(tabColors.Length);
            int color3 = _random.Next(tabColors.Length);
            int color4 = _random.Next(tabColors.Length);
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
            _tries = 1;
            lblNbTries.Text = _tries.ToString();
            // masquer le bouton quitter
            btnExit.Visible = false;
            // masquer btn rejouer
            btnReplay.Visible = false;
            //couleurs possibles
            _returnedFromColors = Colors();
            // code aleatoire
            RandomCode(_returnedFromColors);
            // stocker le return du randomCode
            _returnedFromRandomCode = RandomCode(_returnedFromColors);
            // copy du tableau
            _returnedFromRandomCode.CopyTo(_copyFromCode, 0);
            // attribuer la couleur aleatoire aux label afin d'avoir le mode debeugue
            lblCode1.BackColor = _returnedFromRandomCode[0];
            lblCode2.BackColor = _returnedFromRandomCode[1];
            lblCode3.BackColor = _returnedFromRandomCode[2];
            lblCode4.BackColor = _returnedFromRandomCode[3];
            // masquer les labels avec le code
            lblCode1.Hide();
            lblCode2.Hide();
            lblCode3.Hide();
            lblCode4.Hide();


            // tableau de labels pour la selection des couleures par l'utilisateur
            for (int i = 0; i < _ROWS; i++)
            {
                for (int j = 0; j < _COLUMNS; j++)
                {
                    // creation des proprietes du label
                    Label choice = new Label();
                    //nom 
                    choice.Name = "lblChoice" + _countLabel++;
                    // style
                    choice.BackColor = Color.Transparent;
                    choice.BorderStyle = BorderStyle.Fixed3D;
                    //taille
                    choice.Size = new Size(30, 30);
                    // position
                    choice.Location = new Point((choice.Width * j) + (j * _padding), (choice.Height * i) + (i * _margin + _padding));
                    //associer au panel
                    choicePanel.Controls.Add(choice);
                    // ajouter les btns au tableau
                    _tabLblChoice[j, i] = choice;
                    // stocker la hauteur des label
                    _heigthLblChoice = 30;
                }

            }
            // tableau de labels pour verifier la position correcte
            for (int k = 0; k < _ROWS; k++)
            {
                for (int l = 0; l < _COLUMNS; l++)
                {
                    // creation des proprietes du label
                    Label check = new Label();
                    //nom 
                    check.Name = "lblCeck" + _countLabel++;
                    // style
                    check.BackColor = Color.Transparent;
                    check.BorderStyle = BorderStyle.Fixed3D;
                    //taille
                    check.Size = new Size(25, 25);
                    // position
                    check.Location = new Point((check.Width * l) + (l * (_padding - 10)), ((check.Height * k) + (_heigthLblChoice / 2 + 8) + (k * (_margin + 5))));
                    //associer au panel
                    checkPanel.Controls.Add(check);
                    // ajouter les label de check au tableau
                    _tabLblCheck[l, k] = check;
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
            // evenements des btns de couleurs 
            Button clickedButton = (Button)sender;
            //remplir la ligne
            if (_columnIndex == _COLUMNS)
            {
                MessageBox.Show("La ligne est remplie");
            }
            else
            {
                _tabLblChoice[_columnIndex, _rowIndex].BackColor = clickedButton.BackColor;
                // stocker la couleur selectione par l'utilisateur
                _tabUserColor[_columnIndex, _rowIndex] = clickedButton.BackColor;
                // copier le code couleur de l'utilisateur
                _userCopyChoice[_columnIndex, _rowIndex] = clickedButton.BackColor;
                _columnIndex++;
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
            for (int i = 0; i < _MAX_RANDOM; i++)
            {
                _copyFromCode[i] = _returnedFromRandomCode[i];

            }
            
            // parcourir la ligne 
            for (int i = 0; i < _COLUMNS; i++)
            {
                // verifier les couleurs entres par l'utilisateur dans la ligne
                if (_returnedFromRandomCode[i] == _tabUserColor[i, _rowIndex])
                {
                    // remplacer les couleurs trouves par du gris
                    _copyFromCode[i] = Color.Gray;
                    // remplacer les couleur correctes par du beige
                    _userCopyChoice[i, _rowIndex] = Color.Beige;
                    // si c'est correct afficher une case en blanc
                    _tabLblCheck[_goodPosition, _rowIndex].BackColor = Color.White; 
                    // si couleur correct incrementer 
                    _goodPosition++;
                    // si tout est correct alors gagne
                    if (_goodPosition == 4 || _goodPosition == 4 && _tries == 11)
                    {
                        // message de victoire
                        MessageBox.Show("Félicitation, vous avez gagné !!", "Victoire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        break;
                    }

                }
                // assigner la valeur de good possition a bad possition
                _badPosition = _goodPosition;
                
            }
            for (int i = 0; i < _COLUMNS; i++)
            {
                // verifier le code secret sans les couleurs deja trouves
                for (int j = 0; j < _copyFromCode.Length; j++)
                {
                    if (_userCopyChoice[i, _rowIndex] == _copyFromCode[j] && i != j)
                    {
                        // changer la couleur si on trouve une couleur mal place afin d'eviter les doublons
                        _copyFromCode[j] = Color.Gray;
                        // afficher les case noir pour les couleurs mal places
                        _tabLblCheck[_badPosition,_rowIndex  ].BackColor = Color.Black;
                        _badPosition++;
                        break;
                    } 
                }
            }
            // reinitialiser la colonne
            _columnIndex = 0;
            // incrementer la ligne
            _rowIndex++;
            // incrementer les essais
            _tries++;
           // afficher les essais
            lblNbTries.Text = _tries.ToString();
            // si le joueur ne trouve pas le code secret avent les 10 essai il a perdu !
            if (_goodPosition != 4 && _tries == 11)
            {        
                MessageBox.Show("Vous avez utilisé vos 10 essais !", "Perdu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // compteur reinitialiser
            _goodPosition = 0;
            // compteur reinitialise
            _badPosition = 0;

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
            if (_columnIndex == 0 )
            {

            }
            // si elles sont remplies ont peut effacer
            else
            {
                _columnIndex--;
                _tabLblChoice[_columnIndex, _rowIndex].BackColor = Color.Transparent;
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
            MessageBox.Show("Merci d'avoir participé !", "Au revoir");
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
            _rowIndex = 0;
            _columnIndex = 0;
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
            if (_enable == false)
            {
                // activer le code
                lblCode1.Show();
                lblCode2.Show();
                lblCode3.Show();
                lblCode4.Show();
                // code activée
                _enable = true;
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
                _enable = false;
            }
           

        }
    }
}
