namespace Battleships
{
    partial class MultiplayerSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiplayerSettingsForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            settingsGroupBox = new System.Windows.Forms.GroupBox();
            settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.BackColor = System.Drawing.Color.Transparent;
            settingsGroupBox.Controls.Add(this.label3);
            settingsGroupBox.Controls.Add(this.label2);
            settingsGroupBox.Controls.Add(this.label1);
            settingsGroupBox.Controls.Add(this.passwordTextBox);
            settingsGroupBox.Controls.Add(this.okButton);
            settingsGroupBox.Controls.Add(this.nameTextBox);
            settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            settingsGroupBox.ForeColor = System.Drawing.Color.Black;
            settingsGroupBox.Location = new System.Drawing.Point(115, 54);
            settingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            settingsGroupBox.Size = new System.Drawing.Size(364, 304);
            settingsGroupBox.TabIndex = 1;
            settingsGroupBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Image = global::Battleships.Properties.Resources.Icons8_Windows_8_Security_Password_2_24;
            this.label3.Location = new System.Drawing.Point(270, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 49);
            this.label3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Image = global::Battleships.Properties.Resources.Icons8_Windows_8_Users_Name_24;
            this.label2.Location = new System.Drawing.Point(270, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 49);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Multiple Player Login Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(34, 146);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(240, 49);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Click += new System.EventHandler(this.clickEventsPw);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBoxTextChanged);
            // 
            // okButton
            // 
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Image = global::Battleships.Properties.Resources.Pictogrammers_Material_Login_variant_24;
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okButton.Location = new System.Drawing.Point(34, 205);
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
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(34, 87);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 49);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Username";
            this.nameTextBox.Click += new System.EventHandler(this.clickEvents);
            // 
            // MultiplayerSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Battleships.Properties.Resources.ship2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 437);
            this.Controls.Add(settingsGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MultiplayerSettingsForm";
            this.Text = "Battleships:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultiplayerSettingsFormClosing);
            this.Enter += new System.EventHandler(this.MultiplayerSettingsFormEnter);
            settingsGroupBox.ResumeLayout(false);
            settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}