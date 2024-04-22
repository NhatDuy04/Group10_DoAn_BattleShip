namespace Battleships
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.quitButton = new System.Windows.Forms.Button();
            this.multiplayerButton = new System.Windows.Forms.Button();
            this.creditsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.quitButton.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.Black;
            this.quitButton.Image = global::Battleships.Properties.Resources.Iconsmind_Outline_Close_24;
            this.quitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quitButton.Location = new System.Drawing.Point(22, 297);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(216, 46);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButtonClick);
            // 
            // multiplayerButton
            // 
            this.multiplayerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.multiplayerButton.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplayerButton.ForeColor = System.Drawing.Color.Black;
            this.multiplayerButton.Image = global::Battleships.Properties.Resources.Ionic_Ionicons_Play_forward_circle_outline_24;
            this.multiplayerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.multiplayerButton.Location = new System.Drawing.Point(22, 141);
            this.multiplayerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.multiplayerButton.Name = "multiplayerButton";
            this.multiplayerButton.Size = new System.Drawing.Size(216, 46);
            this.multiplayerButton.TabIndex = 9;
            this.multiplayerButton.Text = "MultiplePlayer";
            this.multiplayerButton.UseVisualStyleBackColor = false;
            this.multiplayerButton.Click += new System.EventHandler(this.MultiplayerButtonClick);
            // 
            // creditsButton
            // 
            this.creditsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.creditsButton.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsButton.ForeColor = System.Drawing.Color.Black;
            this.creditsButton.Image = global::Battleships.Properties.Resources.Pictogrammers_Material_Light_Credit_card_24;
            this.creditsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creditsButton.Location = new System.Drawing.Point(22, 216);
            this.creditsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(216, 46);
            this.creditsButton.TabIndex = 10;
            this.creditsButton.Text = "Credits";
            this.creditsButton.UseVisualStyleBackColor = false;
            this.creditsButton.Click += new System.EventHandler(this.CreditsButtonClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 63);
            this.label1.TabIndex = 13;
            this.label1.Text = "BATTLE SHIP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Trip around the world";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Battleships.Properties.Resources.MainGamePic6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.multiplayerButton);
            this.Controls.Add(this.creditsButton);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenuForm";
            this.Text = "Battleships: Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuFormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button creditsButton;
        private System.Windows.Forms.Button multiplayerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

