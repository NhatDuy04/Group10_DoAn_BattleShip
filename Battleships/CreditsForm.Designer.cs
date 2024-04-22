namespace Battleships
{
    partial class CreditsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsForm));
            this.creditsButton = new System.Windows.Forms.Button();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creditsButton
            // 
            this.creditsButton.BackColor = System.Drawing.Color.DarkRed;
            this.creditsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.creditsButton.Image = global::Battleships.Properties.Resources.Iconsmind_Outline_Yes_24;
            this.creditsButton.Location = new System.Drawing.Point(427, 286);
            this.creditsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(84, 53);
            this.creditsButton.TabIndex = 16;
            this.creditsButton.UseVisualStyleBackColor = false;
            this.creditsButton.Click += new System.EventHandler(this.CreditsButtonClick);
            // 
            // creditsLabel
            // 
            this.creditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditsLabel.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.creditsLabel.Location = new System.Drawing.Point(88, 25);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(341, 55);
            this.creditsLabel.TabIndex = 17;
            this.creditsLabel.Text = "NT106.O22 - Nhóm 10";
            this.creditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(88, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "22520342 - Phan Nhật Duy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(88, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 55);
            this.label2.TabIndex = 19;
            this.label2.Text = "22521360 - Phạm Trung Thành";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(88, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 55);
            this.label3.TabIndex = 20;
            this.label3.Text = "22521382 - Đào Anh Thiên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Battleships.Properties.Resources.credit2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.creditsButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreditsForm";
            this.Text = "Battleships: Credits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreditsFormFormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button creditsButton;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}