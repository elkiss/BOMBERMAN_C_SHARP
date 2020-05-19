namespace BOMBERMAN
{
    partial class GameMode
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_titre = new System.Windows.Forms.Label();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pb_winner = new System.Windows.Forms.PictureBox();
            this.lb_winner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_winner)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_titre.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_titre.Location = new System.Drawing.Point(108, 13);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(154, 43);
            this.lb_titre.TabIndex = 20;
            this.lb_titre.Text = "WINNER";
            // 
            // btn_newGame
            // 
            this.btn_newGame.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_newGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_newGame.FlatAppearance.BorderSize = 0;
            this.btn_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newGame.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newGame.Location = new System.Drawing.Point(12, 208);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(370, 59);
            this.btn_newGame.TabIndex = 19;
            this.btn_newGame.Text = "NOUVELLE PARTIE";
            this.btn_newGame.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(12, 275);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(370, 59);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "MENU PRINCIPAL";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // pb_winner
            // 
            this.pb_winner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_winner.Location = new System.Drawing.Point(22, 71);
            this.pb_winner.Name = "pb_winner";
            this.pb_winner.Size = new System.Drawing.Size(138, 123);
            this.pb_winner.TabIndex = 21;
            this.pb_winner.TabStop = false;
            // 
            // lb_winner
            // 
            this.lb_winner.AutoSize = true;
            this.lb_winner.BackColor = System.Drawing.Color.Transparent;
            this.lb_winner.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_winner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_winner.Location = new System.Drawing.Point(190, 120);
            this.lb_winner.Name = "lb_winner";
            this.lb_winner.Size = new System.Drawing.Size(124, 31);
            this.lb_winner.TabIndex = 22;
            this.lb_winner.Text = "PLAYER 1";
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lb_winner);
            this.Controls.Add(this.pb_winner);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.btn_newGame);
            this.Controls.Add(this.btn_exit);
            this.Name = "GameMode";
            this.Size = new System.Drawing.Size(392, 349);
            ((System.ComponentModel.ISupportInitialize)(this.pb_winner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.PictureBox pb_winner;
        private System.Windows.Forms.Label lb_winner;
    }
}
