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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panelPlay.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlay
            // 
            this.panelPlay.BackColor = System.Drawing.Color.DarkGray;
            this.panelPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPlay.Controls.Add(this.label4);
            this.panelPlay.Controls.Add(this.label3);
            this.panelPlay.Controls.Add(this.label2);
            this.panelPlay.Controls.Add(this.label1);
            this.panelPlay.Controls.Add(this.checkPanel);
            this.panelPlay.Controls.Add(this.choicePanel);
            this.panelPlay.Location = new System.Drawing.Point(34, 25);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(532, 714);
            this.panelPlay.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 686);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 686);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
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
            this.btnCheck.Location = new System.Drawing.Point(654, 669);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 26);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Valider";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(797, 838);
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
            this.panelPlay.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

