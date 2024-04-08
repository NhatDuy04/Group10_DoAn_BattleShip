namespace Battleships
{
    partial class PasswordCheckForm
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
            System.Windows.Forms.GroupBox passwordGroupBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordCheckForm));
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            passwordGroupBox = new System.Windows.Forms.GroupBox();
            passwordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordGroupBox
            // 
            passwordGroupBox.BackColor = System.Drawing.Color.Transparent;
            passwordGroupBox.Controls.Add(this.label3);
            passwordGroupBox.Controls.Add(this.label1);
            passwordGroupBox.Controls.Add(this.okButton);
            passwordGroupBox.Controls.Add(this.passwordTextBox);
            passwordGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            passwordGroupBox.ForeColor = System.Drawing.Color.Black;
            passwordGroupBox.Location = new System.Drawing.Point(118, 110);
            passwordGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            passwordGroupBox.Name = "passwordGroupBox";
            passwordGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            passwordGroupBox.Size = new System.Drawing.Size(364, 223);
            passwordGroupBox.TabIndex = 17;
            passwordGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Check Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(34, 80);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(240, 49);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Click += new System.EventHandler(this.clickEvents);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBoxTextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Image = global::Battleships.Properties.Resources.Icons8_Windows_8_Security_Password_2_24;
            this.label3.Location = new System.Drawing.Point(270, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 50);
            this.label3.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Image = global::Battleships.Properties.Resources.Pictogrammers_Material_Login_variant_24;
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okButton.Location = new System.Drawing.Point(34, 139);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(295, 49);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Login";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // PasswordCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Battleships.Properties.Resources.login61;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 437);
            this.Controls.Add(passwordGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PasswordCheckForm";
            this.Text = "Battleships: Lock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordCheckFormClosing);
            passwordGroupBox.ResumeLayout(false);
            passwordGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}