namespace Battleships
{
    partial class SingleplayerSettingsForm
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
            System.Windows.Forms.GroupBox settingsGroupBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleplayerSettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            settingsGroupBox = new System.Windows.Forms.GroupBox();
            settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.BackColor = System.Drawing.Color.Transparent;
            settingsGroupBox.Controls.Add(this.label1);
            settingsGroupBox.Controls.Add(this.label2);
            settingsGroupBox.Controls.Add(this.okButton);
            settingsGroupBox.Controls.Add(this.nameTextBox);
            settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            settingsGroupBox.ForeColor = System.Drawing.Color.Black;
            settingsGroupBox.Location = new System.Drawing.Point(115, 92);
            settingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            settingsGroupBox.Size = new System.Drawing.Size(364, 237);
            settingsGroupBox.TabIndex = 15;
            settingsGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Single Player Login Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Image = global::Battleships.Properties.Resources.Icons8_Windows_8_Users_Name_24;
            this.label2.Location = new System.Drawing.Point(268, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 50);
            this.label2.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Image = global::Battleships.Properties.Resources.Pictogrammers_Material_Login_variant_24;
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okButton.Location = new System.Drawing.Point(32, 155);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(295, 49);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Login";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(32, 96);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 49);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Username";
            this.nameTextBox.Click += new System.EventHandler(this.clickEvents);
            // 
            // SingleplayerSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Battleships.Properties.Resources.login5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 437);
            this.Controls.Add(settingsGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SingleplayerSettingsForm";
            this.Text = "Battleships: Set Player’s name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingleplayerSettingsFormClosing);
            this.Enter += new System.EventHandler(this.SingleplayerSettingsFormEnter);
            settingsGroupBox.ResumeLayout(false);
            settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}