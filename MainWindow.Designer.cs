namespace BOMBERMAN
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.pan_Main = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_LoadGame = new System.Windows.Forms.Button();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.pan_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(716, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "By Keita El Kissi";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1;
            // 
            // pan_Main
            // 
            this.pan_Main.BackColor = System.Drawing.Color.Transparent;
            this.pan_Main.Controls.Add(this.btn_exit);
            this.pan_Main.Controls.Add(this.btn_LoadGame);
            this.pan_Main.Controls.Add(this.btn_newGame);
            this.pan_Main.Location = new System.Drawing.Point(270, 300);
            this.pan_Main.Name = "pan_Main";
            this.pan_Main.Size = new System.Drawing.Size(344, 273);
            this.pan_Main.TabIndex = 4;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(23, 178);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(299, 72);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "QUITTER";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_LoadGame
            // 
            this.btn_LoadGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_LoadGame.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_LoadGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LoadGame.FlatAppearance.BorderSize = 0;
            this.btn_LoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadGame.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadGame.Location = new System.Drawing.Point(23, 100);
            this.btn_LoadGame.Name = "btn_LoadGame";
            this.btn_LoadGame.Size = new System.Drawing.Size(299, 72);
            this.btn_LoadGame.TabIndex = 4;
            this.btn_LoadGame.Text = "CHARGER PARTIE";
            this.btn_LoadGame.UseVisualStyleBackColor = false;
            // 
            // btn_newGame
            // 
            this.btn_newGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_newGame.BackgroundImage = global::BOMBERMAN.Properties.Resources.btn_not_hover;
            this.btn_newGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_newGame.FlatAppearance.BorderSize = 0;
            this.btn_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newGame.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newGame.Location = new System.Drawing.Point(23, 22);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(299, 72);
            this.btn_newGame.TabIndex = 3;
            this.btn_newGame.Text = "NOUVELLE PARTIE";
            this.btn_newGame.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BOMBERMAN.Properties.Resources.backImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 635);
            this.Controls.Add(this.pan_Main);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.pan_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Panel pan_Main;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_LoadGame;
        private System.Windows.Forms.Button btn_newGame;
    }
}