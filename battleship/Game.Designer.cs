namespace battleship
{
    partial class InGame
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
            this.buttonHost = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.btn_chat = new System.Windows.Forms.Button();
            this.txt_chat = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txt_chatlog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_turn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHost
            // 
            this.buttonHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonHost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonHost.FlatAppearance.BorderSize = 3;
            this.buttonHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHost.ForeColor = System.Drawing.Color.White;
            this.buttonHost.Location = new System.Drawing.Point(310, 123);
            this.buttonHost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHost.Name = "buttonHost";
            this.buttonHost.Size = new System.Drawing.Size(108, 37);
            this.buttonHost.TabIndex = 291;
            this.buttonHost.Text = "HOST";
            this.buttonHost.UseVisualStyleBackColor = false;
            this.buttonHost.Click += new System.EventHandler(this.buttonHost_Click_1);
            // 
            // txt_Port
            // 
            this.txt_Port.BackColor = System.Drawing.Color.White;
            this.txt_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Port.ForeColor = System.Drawing.Color.Black;
            this.txt_Port.Location = new System.Drawing.Point(456, 20);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(192, 22);
            this.txt_Port.TabIndex = 290;
            this.txt_Port.Text = "357";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label54.Location = new System.Drawing.Point(382, 19);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(70, 25);
            this.label54.TabIndex = 289;
            this.label54.Text = "Port : ";
            // 
            // txt_IP
            // 
            this.txt_IP.BackColor = System.Drawing.Color.White;
            this.txt_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP.ForeColor = System.Drawing.Color.Black;
            this.txt_IP.Location = new System.Drawing.Point(156, 22);
            this.txt_IP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(192, 22);
            this.txt_IP.TabIndex = 288;
            this.txt_IP.Text = "127.0.0.1";
            this.txt_IP.TextChanged += new System.EventHandler(this.txt_IP_TextChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(101, 23);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(51, 25);
            this.label53.TabIndex = 287;
            this.label53.Text = "IP : ";
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_play.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_play.FlatAppearance.BorderSize = 3;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Location = new System.Drawing.Point(137, 123);
            this.btn_play.Margin = new System.Windows.Forms.Padding(2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(108, 33);
            this.btn_play.TabIndex = 286;
            this.btn_play.Text = "PLAY";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(158, 48);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(205, 49);
            this.txt_username.TabIndex = 285;
            this.txt_username.Text = "Player 1";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(60, 57);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(92, 25);
            this.label43.TabIndex = 284;
            this.label43.Text = "Player : ";
            // 
            // btn_chat
            // 
            this.btn_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_chat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chat.ForeColor = System.Drawing.Color.White;
            this.btn_chat.Location = new System.Drawing.Point(307, 749);
            this.btn_chat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(111, 53);
            this.btn_chat.TabIndex = 295;
            this.btn_chat.Text = "Send";
            this.btn_chat.UseVisualStyleBackColor = false;
            this.btn_chat.Click += new System.EventHandler(this.btn_chat_Click);
            // 
            // txt_chat
            // 
            this.txt_chat.BackColor = System.Drawing.Color.White;
            this.txt_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chat.ForeColor = System.Drawing.Color.Black;
            this.txt_chat.Location = new System.Drawing.Point(11, 747);
            this.txt_chat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_chat.Multiline = true;
            this.txt_chat.Name = "txt_chat";
            this.txt_chat.Size = new System.Drawing.Size(292, 55);
            this.txt_chat.TabIndex = 294;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.Red;
            this.label42.Location = new System.Drawing.Point(152, 190);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(76, 31);
            this.label42.TabIndex = 293;
            this.label42.Text = "Chat";
            // 
            // txt_chatlog
            // 
            this.txt_chatlog.BackColor = System.Drawing.Color.White;
            this.txt_chatlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chatlog.ForeColor = System.Drawing.Color.Black;
            this.txt_chatlog.Location = new System.Drawing.Point(11, 223);
            this.txt_chatlog.Margin = new System.Windows.Forms.Padding(2);
            this.txt_chatlog.Multiline = true;
            this.txt_chatlog.Name = "txt_chatlog";
            this.txt_chatlog.ReadOnly = true;
            this.txt_chatlog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_chatlog.Size = new System.Drawing.Size(407, 520);
            this.txt_chatlog.TabIndex = 292;
            this.txt_chatlog.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(472, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 94);
            this.label2.TabIndex = 299;
            this.label2.Text = "You";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(980, 616);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 300;
            this.label3.Text = "Opponent";
            // 
            // label_turn
            // 
            this.label_turn.AutoSize = true;
            this.label_turn.BackColor = System.Drawing.Color.Transparent;
            this.label_turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_turn.ForeColor = System.Drawing.Color.White;
            this.label_turn.Location = new System.Drawing.Point(491, 616);
            this.label_turn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_turn.Name = "label_turn";
            this.label_turn.Size = new System.Drawing.Size(93, 32);
            this.label_turn.TabIndex = 301;
            this.label_turn.Text = "Turn: ";
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::battleship.Properties.Resources.MainGamePic61;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1301, 807);
            this.Controls.Add(this.label_turn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_chat);
            this.Controls.Add(this.txt_chat);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.txt_chatlog);
            this.Controls.Add(this.buttonHost);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label43);
            this.Name = "InGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHost;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btn_chat;
        private System.Windows.Forms.TextBox txt_chat;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txt_chatlog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_turn;
    }
}