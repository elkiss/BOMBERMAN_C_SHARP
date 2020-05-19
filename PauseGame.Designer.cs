namespace BOMBERMAN
{
    partial class PauseGame
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
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_titre.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_titre.Location = new System.Drawing.Point(218, 42);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(124, 43);
            this.lb_titre.TabIndex = 23;
            this.lb_titre.Text = "PAUSE";
            // 
            // btn_resume
            // 
            this.btn_resume.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_resume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_resume.FlatAppearance.BorderSize = 0;
            this.btn_resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resume.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resume.Location = new System.Drawing.Point(103, 123);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(370, 59);
            this.btn_resume.TabIndex = 22;
            this.btn_resume.Text = "REPRENDRE";
            this.btn_resume.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(103, 209);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(370, 59);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "SAUVEGARDER";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(103, 291);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(370, 59);
            this.btn_exit.TabIndex = 24;
            this.btn_exit.Text = "QUITTER";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // PauseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.btn_save);
            this.Name = "PauseGame";
            this.Size = new System.Drawing.Size(576, 431);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
    }
}
