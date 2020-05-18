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
            this.lb_p1 = new System.Windows.Forms.Label();
            this.btn_solo = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_p1
            // 
            this.lb_p1.AutoSize = true;
            this.lb_p1.BackColor = System.Drawing.Color.Transparent;
            this.lb_p1.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_p1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_p1.Location = new System.Drawing.Point(95, 18);
            this.lb_p1.Name = "lb_p1";
            this.lb_p1.Size = new System.Drawing.Size(188, 31);
            this.lb_p1.TabIndex = 20;
            this.lb_p1.Text = "MODE DE JEUX";
            // 
            // btn_solo
            // 
            this.btn_solo.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_solo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_solo.FlatAppearance.BorderSize = 0;
            this.btn_solo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_solo.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_solo.Location = new System.Drawing.Point(12, 96);
            this.btn_solo.Name = "btn_solo";
            this.btn_solo.Size = new System.Drawing.Size(370, 59);
            this.btn_solo.TabIndex = 19;
            this.btn_solo.Text = "SOLO";
            this.btn_solo.UseVisualStyleBackColor = true;
            // 
            // btn_multi
            // 
            this.btn_multi.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_multi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_multi.FlatAppearance.BorderSize = 0;
            this.btn_multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multi.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.Location = new System.Drawing.Point(12, 161);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(370, 59);
            this.btn_multi.TabIndex = 18;
            this.btn_multi.Text = "MULTIPLAYER";
            this.btn_multi.UseVisualStyleBackColor = true;
            // 
            // btn_c
            // 
            this.btn_c.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_c.FlatAppearance.BorderSize = 0;
            this.btn_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.Location = new System.Drawing.Point(12, 264);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(370, 67);
            this.btn_c.TabIndex = 17;
            this.btn_c.Text = "RETOUR";
            this.btn_c.UseVisualStyleBackColor = true;
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lb_p1);
            this.Controls.Add(this.btn_solo);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_c);
            this.Name = "GameMode";
            this.Size = new System.Drawing.Size(392, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_solo;
        private System.Windows.Forms.Label lb_p1;
    }
}
