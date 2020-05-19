namespace BOMBERMAN
{
    partial class Sc_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sc_game));
            this.pan_arena = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pan_p1 = new System.Windows.Forms.Panel();
            this.lb_speedP1 = new System.Windows.Forms.Label();
            this.lb_nbBp1 = new System.Windows.Forms.Label();
            this.lb_lifeP1 = new System.Windows.Forms.Label();
            this.lb_beffectP1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_icP1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_p1 = new System.Windows.Forms.Label();
            this.lb_p2 = new System.Windows.Forms.Label();
            this.pan_p2 = new System.Windows.Forms.Panel();
            this.lb_SpeedP2 = new System.Windows.Forms.Label();
            this.lb_nbBp2 = new System.Windows.Forms.Label();
            this.lb_lifeP2 = new System.Windows.Forms.Label();
            this.lb_BeffectP2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_icP2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pan_p1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pan_p2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_arena
            // 
            this.pan_arena.AutoSize = true;
            this.pan_arena.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pan_arena.Location = new System.Drawing.Point(226, 67);
            this.pan_arena.Name = "pan_arena";
            this.pan_arena.Size = new System.Drawing.Size(552, 519);
            this.pan_arena.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pan_p1
            // 
            this.pan_p1.BackColor = System.Drawing.Color.Black;
            this.pan_p1.Controls.Add(this.lb_speedP1);
            this.pan_p1.Controls.Add(this.lb_nbBp1);
            this.pan_p1.Controls.Add(this.lb_lifeP1);
            this.pan_p1.Controls.Add(this.lb_beffectP1);
            this.pan_p1.Controls.Add(this.label2);
            this.pan_p1.Controls.Add(this.pb_icP1);
            this.pan_p1.Controls.Add(this.pictureBox3);
            this.pan_p1.Controls.Add(this.pictureBox2);
            this.pan_p1.Controls.Add(this.pictureBox1);
            this.pan_p1.Location = new System.Drawing.Point(12, 129);
            this.pan_p1.Name = "pan_p1";
            this.pan_p1.Size = new System.Drawing.Size(128, 204);
            this.pan_p1.TabIndex = 1;
            this.pan_p1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_speedP1
            // 
            this.lb_speedP1.AutoSize = true;
            this.lb_speedP1.Font = new System.Drawing.Font("Ravie", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_speedP1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_speedP1.Location = new System.Drawing.Point(30, 166);
            this.lb_speedP1.Name = "lb_speedP1";
            this.lb_speedP1.Size = new System.Drawing.Size(32, 31);
            this.lb_speedP1.TabIndex = 13;
            this.lb_speedP1.Text = "3";
            // 
            // lb_nbBp1
            // 
            this.lb_nbBp1.AutoSize = true;
            this.lb_nbBp1.Font = new System.Drawing.Font("Ravie", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nbBp1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_nbBp1.Location = new System.Drawing.Point(30, 128);
            this.lb_nbBp1.Name = "lb_nbBp1";
            this.lb_nbBp1.Size = new System.Drawing.Size(32, 31);
            this.lb_nbBp1.TabIndex = 12;
            this.lb_nbBp1.Text = "3";
            // 
            // lb_lifeP1
            // 
            this.lb_lifeP1.AutoSize = true;
            this.lb_lifeP1.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lifeP1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_lifeP1.Location = new System.Drawing.Point(66, 31);
            this.lb_lifeP1.Name = "lb_lifeP1";
            this.lb_lifeP1.Size = new System.Drawing.Size(48, 45);
            this.lb_lifeP1.TabIndex = 11;
            this.lb_lifeP1.Text = "3";
            // 
            // lb_beffectP1
            // 
            this.lb_beffectP1.AutoSize = true;
            this.lb_beffectP1.Font = new System.Drawing.Font("Ravie", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_beffectP1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_beffectP1.Location = new System.Drawing.Point(30, 92);
            this.lb_beffectP1.Name = "lb_beffectP1";
            this.lb_beffectP1.Size = new System.Drawing.Size(32, 31);
            this.lb_beffectP1.TabIndex = 10;
            this.lb_beffectP1.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(62, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 57);
            this.label2.TabIndex = 8;
            // 
            // pb_icP1
            // 
            this.pb_icP1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_icP1.BackgroundImage = global::BOMBERMAN.Properties.Resources.INT_WB;
            this.pb_icP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_icP1.Location = new System.Drawing.Point(0, 16);
            this.pb_icP1.Name = "pb_icP1";
            this.pb_icP1.Size = new System.Drawing.Size(60, 60);
            this.pb_icP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_icP1.TabIndex = 6;
            this.pb_icP1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.BackgroundImage = global::BOMBERMAN.Properties.Resources.speed;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 164);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BackgroundImage = global::BOMBERMAN.Properties.Resources.bomb_nb;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::BOMBERMAN.Properties.Resources.effet;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lb_p1
            // 
            this.lb_p1.AutoSize = true;
            this.lb_p1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_p1.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_p1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_p1.Location = new System.Drawing.Point(9, 100);
            this.lb_p1.Name = "lb_p1";
            this.lb_p1.Size = new System.Drawing.Size(130, 26);
            this.lb_p1.TabIndex = 14;
            this.lb_p1.Text = "JOUEUR 1";
            // 
            // lb_p2
            // 
            this.lb_p2.AutoSize = true;
            this.lb_p2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_p2.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_p2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_p2.Location = new System.Drawing.Point(871, 93);
            this.lb_p2.Name = "lb_p2";
            this.lb_p2.Size = new System.Drawing.Size(130, 26);
            this.lb_p2.TabIndex = 16;
            this.lb_p2.Text = "JOUEUR 2";
            // 
            // pan_p2
            // 
            this.pan_p2.BackColor = System.Drawing.Color.Black;
            this.pan_p2.Controls.Add(this.lb_SpeedP2);
            this.pan_p2.Controls.Add(this.lb_nbBp2);
            this.pan_p2.Controls.Add(this.lb_lifeP2);
            this.pan_p2.Controls.Add(this.lb_BeffectP2);
            this.pan_p2.Controls.Add(this.label9);
            this.pan_p2.Controls.Add(this.pb_icP2);
            this.pan_p2.Controls.Add(this.pictureBox6);
            this.pan_p2.Controls.Add(this.pictureBox7);
            this.pan_p2.Controls.Add(this.pictureBox8);
            this.pan_p2.Location = new System.Drawing.Point(876, 122);
            this.pan_p2.Name = "pan_p2";
            this.pan_p2.Size = new System.Drawing.Size(128, 204);
            this.pan_p2.TabIndex = 15;
            // 
            // lb_SpeedP2
            // 
            this.lb_SpeedP2.AutoSize = true;
            this.lb_SpeedP2.Font = new System.Drawing.Font("Ravie", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SpeedP2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_SpeedP2.Location = new System.Drawing.Point(30, 166);
            this.lb_SpeedP2.Name = "lb_SpeedP2";
            this.lb_SpeedP2.Size = new System.Drawing.Size(32, 31);
            this.lb_SpeedP2.TabIndex = 13;
            this.lb_SpeedP2.Text = "3";
            // 
            // lb_nbBp2
            // 
            this.lb_nbBp2.AutoSize = true;
            this.lb_nbBp2.Font = new System.Drawing.Font("Ravie", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nbBp2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_nbBp2.Location = new System.Drawing.Point(30, 128);
            this.lb_nbBp2.Name = "lb_nbBp2";
            this.lb_nbBp2.Size = new System.Drawing.Size(32, 31);
            this.lb_nbBp2.TabIndex = 12;
            this.lb_nbBp2.Text = "3";
            // 
            // lb_lifeP2
            // 
            this.lb_lifeP2.AutoSize = true;
            this.lb_lifeP2.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lifeP2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_lifeP2.Location = new System.Drawing.Point(66, 31);
            this.lb_lifeP2.Name = "lb_lifeP2";
            this.lb_lifeP2.Size = new System.Drawing.Size(48, 45);
            this.lb_lifeP2.TabIndex = 11;
            this.lb_lifeP2.Text = "3";
            // 
            // lb_BeffectP2
            // 
            this.lb_BeffectP2.AutoSize = true;
            this.lb_BeffectP2.Font = new System.Drawing.Font("Ravie", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BeffectP2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_BeffectP2.Location = new System.Drawing.Point(30, 92);
            this.lb_BeffectP2.Name = "lb_BeffectP2";
            this.lb_BeffectP2.Size = new System.Drawing.Size(32, 31);
            this.lb_BeffectP2.TabIndex = 10;
            this.lb_BeffectP2.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ravie", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(62, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 57);
            this.label9.TabIndex = 8;
            // 
            // pb_icP2
            // 
            this.pb_icP2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_icP2.BackgroundImage = global::BOMBERMAN.Properties.Resources.INT_WBBLA;
            this.pb_icP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_icP2.Location = new System.Drawing.Point(0, 16);
            this.pb_icP2.Name = "pb_icP2";
            this.pb_icP2.Size = new System.Drawing.Size(60, 60);
            this.pb_icP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_icP2.TabIndex = 6;
            this.pb_icP2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.BackgroundImage = global::BOMBERMAN.Properties.Resources.speed;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(0, 164);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox7.BackgroundImage = global::BOMBERMAN.Properties.Resources.bomb_nb;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(0, 128);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox8.BackgroundImage = global::BOMBERMAN.Properties.Resources.effet;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(2, 92);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            // 
            // Sc_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1017, 649);
            this.Controls.Add(this.lb_p2);
            this.Controls.Add(this.pan_p2);
            this.Controls.Add(this.lb_p1);
            this.Controls.Add(this.pan_p1);
            this.Controls.Add(this.pan_arena);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Sc_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPER BOMBERMAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sc_game_FormClosing);
            this.Load += new System.EventHandler(this.Sc_game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sc_game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Sc_game_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Sc_game_PreviewKeyDown);
            this.pan_p1.ResumeLayout(false);
            this.pan_p1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pan_p2.ResumeLayout(false);
            this.pan_p2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_beffectP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_speedP1;
        private System.Windows.Forms.Label lb_nbBp1;
        private System.Windows.Forms.Label lb_lifeP1;
        private System.Windows.Forms.Label lb_SpeedP2;
        private System.Windows.Forms.Label lb_nbBp2;
        private System.Windows.Forms.Label lb_lifeP2;
        private System.Windows.Forms.Label lb_BeffectP2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.Panel pan_p1;
        public System.Windows.Forms.PictureBox pb_icP1;
        public System.Windows.Forms.Panel pan_p2;
        public System.Windows.Forms.PictureBox pb_icP2;
        public System.Windows.Forms.Label lb_p1;
        public System.Windows.Forms.Label lb_p2;
        public System.Windows.Forms.Panel pan_arena;
        public System.Windows.Forms.Timer timer1;
    }
}

