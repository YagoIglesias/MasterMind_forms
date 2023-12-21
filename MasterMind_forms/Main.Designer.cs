namespace MasterMind_forms
{
    partial class Main
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
            this.panelPlay = new System.Windows.Forms.Panel();
            this.lblCode4 = new System.Windows.Forms.Label();
            this.lblCode3 = new System.Windows.Forms.Label();
            this.lblCode2 = new System.Windows.Forms.Label();
            this.lblCode1 = new System.Windows.Forms.Label();
            this.checkPanel = new System.Windows.Forms.Panel();
            this.choicePanel = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnMagenta = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.lblMasterMind = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.lblNbTries = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.lblDebug = new System.Windows.Forms.Label();
            this.panelPlay.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlay
            // 
            this.panelPlay.BackColor = System.Drawing.Color.DarkGray;
            this.panelPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPlay.Controls.Add(this.checkPanel);
            this.panelPlay.Controls.Add(this.choicePanel);
            this.panelPlay.Location = new System.Drawing.Point(34, 25);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(532, 714);
            this.panelPlay.TabIndex = 0;
            // 
            // lblCode4
            // 
            this.lblCode4.BackColor = System.Drawing.Color.Transparent;
            this.lblCode4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode4.Location = new System.Drawing.Point(746, 768);
            this.lblCode4.Name = "lblCode4";
            this.lblCode4.Size = new System.Drawing.Size(34, 33);
            this.lblCode4.TabIndex = 13;
            // 
            // lblCode3
            // 
            this.lblCode3.BackColor = System.Drawing.Color.Transparent;
            this.lblCode3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode3.Location = new System.Drawing.Point(692, 768);
            this.lblCode3.Name = "lblCode3";
            this.lblCode3.Size = new System.Drawing.Size(34, 33);
            this.lblCode3.TabIndex = 12;
            // 
            // lblCode2
            // 
            this.lblCode2.BackColor = System.Drawing.Color.Transparent;
            this.lblCode2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode2.Location = new System.Drawing.Point(640, 768);
            this.lblCode2.Name = "lblCode2";
            this.lblCode2.Size = new System.Drawing.Size(34, 33);
            this.lblCode2.TabIndex = 11;
            // 
            // lblCode1
            // 
            this.lblCode1.BackColor = System.Drawing.Color.Transparent;
            this.lblCode1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode1.Location = new System.Drawing.Point(590, 768);
            this.lblCode1.Name = "lblCode1";
            this.lblCode1.Size = new System.Drawing.Size(34, 33);
            this.lblCode1.TabIndex = 10;
            // 
            // checkPanel
            // 
            this.checkPanel.Location = new System.Drawing.Point(309, 16);
            this.checkPanel.Name = "checkPanel";
            this.checkPanel.Size = new System.Drawing.Size(184, 650);
            this.checkPanel.TabIndex = 9;
            // 
            // choicePanel
            // 
            this.choicePanel.Location = new System.Drawing.Point(27, 15);
            this.choicePanel.Name = "choicePanel";
            this.choicePanel.Size = new System.Drawing.Size(253, 653);
            this.choicePanel.TabIndex = 8;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.DarkGray;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor.Controls.Add(this.btnMagenta);
            this.panelColor.Controls.Add(this.btnWhite);
            this.panelColor.Controls.Add(this.btnBlack);
            this.panelColor.Controls.Add(this.btnOrange);
            this.panelColor.Controls.Add(this.btnBlue);
            this.panelColor.Controls.Add(this.btnGreen);
            this.panelColor.Controls.Add(this.btnRed);
            this.panelColor.Location = new System.Drawing.Point(50, 757);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(506, 54);
            this.panelColor.TabIndex = 1;
            // 
            // btnMagenta
            // 
            this.btnMagenta.BackColor = System.Drawing.Color.Magenta;
            this.btnMagenta.Location = new System.Drawing.Point(375, 11);
            this.btnMagenta.Name = "btnMagenta";
            this.btnMagenta.Size = new System.Drawing.Size(34, 33);
            this.btnMagenta.TabIndex = 6;
            this.btnMagenta.UseVisualStyleBackColor = false;
            this.btnMagenta.Click += new System.EventHandler(this.Colors_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(325, 11);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(34, 33);
            this.btnWhite.TabIndex = 5;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.Colors_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(276, 11);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(34, 33);
            this.btnBlack.TabIndex = 4;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.Colors_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Location = new System.Drawing.Point(224, 10);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(34, 33);
            this.btnOrange.TabIndex = 3;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.Colors_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(175, 9);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(34, 33);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.Colors_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(123, 9);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(34, 33);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.Colors_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(69, 9);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(34, 33);
            this.btnRed.TabIndex = 0;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.Colors_Click);
            // 
            // lblMasterMind
            // 
            this.lblMasterMind.AutoSize = true;
            this.lblMasterMind.BackColor = System.Drawing.Color.Transparent;
            this.lblMasterMind.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblMasterMind.ForeColor = System.Drawing.Color.White;
            this.lblMasterMind.Location = new System.Drawing.Point(613, 25);
            this.lblMasterMind.Name = "lblMasterMind";
            this.lblMasterMind.Size = new System.Drawing.Size(145, 29);
            this.lblMasterMind.TabIndex = 2;
            this.lblMasterMind.Text = "Master Mind";
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTries.ForeColor = System.Drawing.Color.White;
            this.lblTries.Location = new System.Drawing.Point(625, 78);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(106, 20);
            this.lblTries.TabIndex = 3;
            this.lblTries.Text = "Essai numero";
            // 
            // lblNbTries
            // 
            this.lblNbTries.AutoSize = true;
            this.lblNbTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbTries.ForeColor = System.Drawing.Color.White;
            this.lblNbTries.Location = new System.Drawing.Point(667, 111);
            this.lblNbTries.Name = "lblNbTries";
            this.lblNbTries.Size = new System.Drawing.Size(18, 20);
            this.lblNbTries.TabIndex = 4;
            this.lblNbTries.Text = "1";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(627, 615);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 26);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Valider";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(629, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(627, 566);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 26);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Effacer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.Location = new System.Drawing.Point(629, 350);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(104, 26);
            this.btnReplay.TabIndex = 5;
            this.btnReplay.Text = "Rejouer";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(627, 713);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(104, 26);
            this.btnDebug.TabIndex = 6;
            this.btnDebug.Text = "Code Secret";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.BackColor = System.Drawing.Color.Black;
            this.lblDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebug.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDebug.Location = new System.Drawing.Point(625, 673);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(105, 20);
            this.lblDebug.TabIndex = 14;
            this.lblDebug.Text = "Debeugage : ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(797, 825);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.lblCode4);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.lblCode3);
            this.Controls.Add(this.lblCode2);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.lblCode1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblNbTries);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.lblMasterMind);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelPlay);
            this.Name = "Main";
            this.Text = "Master Mind";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelPlay.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button btnMagenta;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Label lblMasterMind;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Label lblNbTries;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel checkPanel;
        private System.Windows.Forms.Panel choicePanel;
        private System.Windows.Forms.Label lblCode4;
        private System.Windows.Forms.Label lblCode3;
        private System.Windows.Forms.Label lblCode2;
        private System.Windows.Forms.Label lblCode1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Label lblDebug;
    }
}

