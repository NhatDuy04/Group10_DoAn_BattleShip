﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Media;
using System.IO;
using System.Net.Sockets;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Media;
namespace battleship
{
    public partial class InGame : Form
    {
        
        Button[,] EnemyArray = new Button[10, 10];
        Button[,] PlayerArray = new Button[10, 10];

        Fleet playerFleet = new Fleet();
        Fleet opponentFleet = new Fleet();

        
        bool[,] PlayerZones = new bool[10, 10];
        bool[,] EnemyZones = new bool[10, 10];

        
        bool PlacingShips = true;
        bool PlacingFirstClick = true;
        bool CarrierPlaced = false;
        bool BattleshipPlaced = false;
        bool CruiserPlaced = false;
        bool BaitPlaced = false;
        POS head = new POS(-1, -1);
        POS tail = new POS(-1, -1);
        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;
        POS lastShot = new POS(0, 0);

        POS[] Carrier = new POS[5];
        POS[] Battleship = new POS[4];
        POS[] Cruiser = new POS[3];
        POS[] Bait = new POS[2];


        string ipAddress = "";
        int port = 357;
        bool server = false;

        IPAddress localAddress;
        TcpListener listener;
        TcpClient client;
        NetworkStream stream;
        StreamWriter writer;
        StreamReader reader;
        StreamReader readData;
        StreamWriter writeData;
        bool listeningForClients = true;
        bool gameover = false;


        public InGame()
        {
            BuildPlayerBoard();
            BuildEnemyBoard();
            FillArrays();
            DisableMyBoard();
            InitializeComponent();
        }

        
        private void StartGame()
        {
            PlacingShips = true;
            EnableMyBoard(); 
        }
        private void PlaceShips(POS c)
        {
            if (!CarrierPlaced)
            {

                if (PlacingFirstClick)
                {
                    PlacingFirstClick = false;
                    head = c;
                    DisableMyBoard();
                    PathEnable("Carrier", head);
                }
                else
                {
                    tail = c;
                    ShipPOS(5, "Carrier");
                    DrawShip(4);
                    PlacingFirstClick = true;
                    CarrierPlaced = true;
                    EnableMyBoard();
                }
            }
            else if (!BattleshipPlaced)
            {
                if (PlacingFirstClick)
                {
                    PlacingFirstClick = false;
                    head = c;
                    DisableMyBoard();
                    PathEnable("Battleship", head);
                }
                else
                {
                    tail = c;
                    ShipPOS(4, "Battleship");
                    DrawShip(3);
                    PlacingFirstClick = true;
                    BattleshipPlaced = true;
                    EnableMyBoard();                   
                }
            }
            else if (!CruiserPlaced)
            {
                if (PlacingFirstClick)
                {
                    PlacingFirstClick = false;
                    head = c;
                    DisableMyBoard();
                    PathEnable("Cruiser", head);
                }
                else
                {
                    tail = c;
                    ShipPOS(3, "Cruiser");
                    DrawShip(2);
                    PlacingFirstClick = true;
                    CruiserPlaced = true;
                    EnableMyBoard();
                }
            }
            else if (!BaitPlaced)
            {
                if (PlacingFirstClick)
                {
                    PlacingFirstClick = false;
                    head = c;
                    DisableMyBoard();
                    PathEnable("Bait", head);
                }
                else
                {
                    tail = c;
                    ShipPOS(2, "Bait");
                    DrawShip(1);
                    PlacingFirstClick = true;
                    BaitPlaced = true;
                    EnableMyBoard();
                }
            }
            if (CarrierPlaced && BattleshipPlaced && CruiserPlaced && BaitPlaced)
            {
                DisableMyBoard();
                playerFleet.Carrier = Carrier;
                playerFleet.Battleship = Battleship;
                playerFleet.Cruiser = Cruiser;
                playerFleet.Bait = Bait;
                if (server == false)
                    signalReady();
            }
        }
        private void ShipPOS(int n, string name)
        {
            POS[] temp;
            if (n == 5)
                temp = new POS[5];
            else if (n == 4)
                temp = new POS[4];
            else if (n == 3)
                temp = new POS[3];
            else if (n == 2)
                temp = new POS[2];
            else
            {
                temp = new POS[1];
            }


            int k = 0;
            if (tail.X < head.X)
            {
                for (int j = head.X; j >= tail.X; j--)
                {
                    PlayerZones[j, head.Y] = true;
                    PlayerArray[j, head.Y].Enabled = false;
                    PlayerArray[j, head.Y].BackgroundImage = Properties.Resources.transport__1_;
                    PlayerArray[j, head.Y].BackgroundImageLayout = ImageLayout.Stretch;
                    PlayerArray[j, head.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    POS t = new POS(j, head.Y);
                    temp[k] = t;
                    k++;
                }
            }
            else if (tail.X > head.X)
            {
                for (int j = head.X; j <= tail.X; j++)
                {
                    PlayerZones[j, head.Y] = true;
                    PlayerArray[j, head.Y].Enabled = false;
                    PlayerArray[j, head.Y].BackgroundImage = Properties.Resources.transport__1_;
                    PlayerArray[j, head.Y].BackgroundImageLayout = ImageLayout.Stretch;
                    PlayerArray[j, head.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    POS t = new POS(j, head.Y);
                    temp[k] = t;
                    k++;
                }
            }
            else if (tail.Y < head.Y)
            {
                for (int i = head.Y; i >= tail.Y; i--)
                {
                    PlayerZones[head.X, i] = true;
                    PlayerArray[head.X, i].Enabled = false;
                    PlayerArray[head.X, i].BackgroundImage = Properties.Resources.transport__1_;
                    PlayerArray[head.X, i].BackgroundImageLayout = ImageLayout.Stretch;
                    PlayerArray[head.X, i].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    POS t = new POS(head.X, i);
                    temp[k] = t;
                    k++;
                }
            }
            else if (tail.Y > head.Y)
            {
                for (int i = head.Y; i <= tail.Y; i++)
                {
                    PlayerZones[head.X, i] = true;
                    PlayerArray[head.X, i].Enabled = false;
                    PlayerArray[head.X, i].BackgroundImage = Properties.Resources.transport__1_;
                    PlayerArray[head.X, i].BackgroundImageLayout = ImageLayout.Stretch;
                    PlayerArray[head.X, i].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    POS t = new POS(head.X, i);
                    temp[k] = t;
                    k++;
                }

            }

            if (name.Equals("Carrier"))
                Carrier = temp;
            else if (name.Equals("Battleship"))
                Battleship = temp;
            else if (name.Equals("Cruiser"))
                Cruiser = temp;
            else if (name.Equals("Bait"))
                Bait = temp;

            else
            {
                temp = new POS[1];
            }
        }

        private void DrawShip(int size)
        {
            if (up)
            {
                PlayerArray[head.X, head.Y - size].FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
                up = false;
            }
            if (down)
            {
                PlayerArray[head.X, head.Y + size].FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
                down = false;
            }
            if (left)
            {
                PlayerArray[head.X - size, head.Y].FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
                left = false;
            }
            if (right)
            {
                PlayerArray[head.X + size, head.Y].FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
                right = false;
            }



            if (tail.X < head.X)
            {
                for (int j = head.X; j >= tail.X; j--)
                {
                    PlayerZones[j, head.Y] = true;
                    PlayerArray[j, head.Y].Enabled = false;
                    PlayerArray[j, head.Y].BackgroundImage = Properties.Resources.transport__1_;
                    PlayerArray[j, head.Y].BackgroundImageLayout = ImageLayout.Stretch;
                    PlayerArray[j, head.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                }
            }
            else if (tail.X > head.X)
            {
                for (int j = head.X; j <= tail.X; j++)
                {
                    PlayerZones[j, head.Y] = true;
                    PlayerArray[j, head.Y].Enabled = false;
                    PlayerArray[j, head.Y].BackgroundImage = Properties.Resources.transport__1_;
                    PlayerArray[j, head.Y].BackgroundImageLayout = ImageLayout.Stretch;
                    PlayerArray[j, head.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                }
            }
            else if (tail.Y < head.Y)
            {
                for (int i = head.Y; i >= tail.Y; i--)
                {
                    PlayerZones[head.X, i] = true;
                    PlayerArray[head.X, i].Enabled = false;
                    PlayerArray[head.X, i].BackgroundImage = Properties.Resources.transport__1_;
                    PlayerArray[head.X, i].BackgroundImageLayout = ImageLayout.Stretch;
                    PlayerArray[head.X, i].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                }
            }
            else if (tail.Y > head.Y)
            {
                for (int i = head.Y; i <= tail.Y; i++)
                {
                    PlayerZones[head.X, i] = true;
                    PlayerArray[head.X, i].Enabled = false;
                    PlayerArray[head.X, i].BackgroundImage = Properties.Resources.transport__1_;
                    PlayerArray[head.X, i].BackgroundImageLayout = ImageLayout.Stretch;
                    PlayerArray[head.X, i].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                }

            }
        }

        private void PathEnable(string ship, POS c)
        {
            if (ship.Equals("Carrier"))
            {
                if (c.X - 4 >= 0)
                {
                    if (PlayerZones[c.X - 1, c.Y] == false && PlayerZones[c.X - 2, c.Y] == false && PlayerZones[c.X - 3, c.Y] == false && PlayerZones[c.X - 4, c.Y] == false)
                    {
                        left = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X - 4, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X - 4, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }

                // Check Right
                if (c.X + 4 <= 9)
                {
                    // Check left
                    if (PlayerZones[c.X + 1, c.Y] == false && PlayerZones[c.X + 2, c.Y] == false && PlayerZones[c.X + 3, c.Y] == false && PlayerZones[c.X + 4, c.Y] == false)
                    {
                        right = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X + 4, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X + 4, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }

                // Check Up
                if (c.Y - 4 >= 0)
                {
                    if (PlayerZones[c.X, c.Y - 1] == false && PlayerZones[c.X, c.Y - 2] == false && PlayerZones[c.X, c.Y - 3] == false && PlayerZones[c.X, c.Y - 4] == false)
                    {
                        up = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y - 4].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X, c.Y - 4].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }

                // Check Down
                if (c.Y + 4 <= 9)
                {
                    if (PlayerZones[c.X, c.Y + 1] == false && PlayerZones[c.X, c.Y + 2] == false && PlayerZones[c.X, c.Y + 3] == false && PlayerZones[c.X, c.Y + 4] == false)
                    {
                        down = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y + 4].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X, c.Y + 4].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }
            }
            else if (ship.Equals("Battleship"))
            {
                // Size 4
                //Check left
                if (c.X - 3 >= 0)
                {
                    // Check left
                    if (PlayerZones[c.X - 1, c.Y] == false && PlayerZones[c.X - 2, c.Y] == false && PlayerZones[c.X - 3, c.Y] == false)
                    {
                        left = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X - 3, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X - 3, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }

                // Check Right
                if (c.X + 3 <= 9)
                {
                    // Check left
                    if (PlayerZones[c.X + 1, c.Y] == false && PlayerZones[c.X + 2, c.Y] == false && PlayerZones[c.X + 3, c.Y] == false)
                    {
                        right = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X + 3, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X + 3, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }

                // Check Up
                if (c.Y - 3 >= 0)
                {
                    if (PlayerZones[c.X, c.Y - 1] == false && PlayerZones[c.X, c.Y - 2] == false && PlayerZones[c.X, c.Y - 3] == false)
                    {
                        up = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y - 3].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X, c.Y - 3].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }

                // Check Down
                if (c.Y + 3 <= 9)
                {
                    if (PlayerZones[c.X, c.Y + 1] == false && PlayerZones[c.X, c.Y + 2] == false && PlayerZones[c.X, c.Y + 3] == false)
                    {
                        down = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y + 3].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X, c.Y + 3].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }
            }
            else if (ship.Equals("Cruiser"))
            {
                // Size 3
                //Check left
                if (c.X - 2 >= 0)
                {
                    // Check left
                    if (PlayerZones[c.X - 1, c.Y] == false && PlayerZones[c.X - 2, c.Y] == false)
                    {
                        left = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X - 2, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X - 2, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }

                // Check Right
                if (c.X + 2 <= 9)
                {
                    // Check left
                    if (PlayerZones[c.X + 1, c.Y] == false && PlayerZones[c.X + 2, c.Y] == false)
                    {
                        right = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X + 2, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X + 2, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }

                // Check Up
                if (c.Y - 2 >= 0)
                {
                    if (PlayerZones[c.X, c.Y - 1] == false && PlayerZones[c.X, c.Y - 2] == false)
                    {
                        up = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y - 2].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X, c.Y - 2].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }

                // Check Down
                if (c.Y + 2 <= 9)
                {
                    if (PlayerZones[c.X, c.Y + 1] == false && PlayerZones[c.X, c.Y + 2] == false)
                    {
                        down = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y + 2].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                        PlayerArray[c.X, c.Y + 2].FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    }
                }
            }
            else if (ship.Equals("Bait"))
            {
                if (c.X - 1 >= 0)
                {
                    // Check left
                    if (PlayerZones[c.X - 1, c.Y] == false)
                    {
                        left = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X - 1, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                        PlayerArray[c.X - 1, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                    }
                }

                // Check Right
                if (c.X + 1 <= 9)
                {
                    // Check left
                    if (PlayerZones[c.X + 1, c.Y] == false)
                    {
                        right = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X + 1, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                        PlayerArray[c.X + 1, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                    }
                }

                // Check Up
                if (c.Y - 1 >= 0)
                {
                    if (PlayerZones[c.X, c.Y - 1] == false)
                    {
                        up = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y - 1].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                        PlayerArray[c.X, c.Y - 1].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                    }
                }

                // Check Down
                if (c.Y + 1 <= 9)
                {
                    if (PlayerZones[c.X, c.Y + 1] == false)
                    {
                        down = true;
                        PlayerArray[c.X, c.Y].Enabled = true;
                        PlayerArray[c.X, c.Y + 1].Enabled = true;
                        PlayerArray[c.X, c.Y].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                        PlayerArray[c.X, c.Y + 1].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                    }
                }
            }

        }

        // My board disable
        private void DisableMyBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                //columns
                for (int j = 0; j < 10; j++)
                {
                    PlayerArray[i, j].Enabled = false;
                    
                }
            }
        }

        // My board enable
        private void EnableMyBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                //columns
                for (int j = 0; j < 10; j++)
                {
                    if (!PlayerZones[i, j])
                    {
                        PlayerArray[i, j].Enabled = true;
                    }
                }

            }
        }

        
        private void EnemyZoneClick(object sender, EventArgs e)
        {
            // All button names for the enemy are "buttonX(letter)(number)" format, extract the letter and number from the name
            Button b = (Button)sender;
            string buttonName = b.Name;


            int x = (int)Char.GetNumericValue(buttonName[7]);
            int y = (int)Char.GetNumericValue(buttonName[8]);

            EnemyZones[x, y] = true;
            EnemyArray[x, y].Enabled = false;
            EDEnemyButtons(false);
            
            POS newcoord = new POS(x, y);
            Shoot(newcoord);
        }

        // shoot
        private void Shoot(POS c)
        {
            msg m = new msg();
            m.type = "move";
            m.body = "move";
            m.name = txt_username.Text;
            m.move = c;
            lastShot = c;

            string output = JsonConvert.SerializeObject(m);
            writer.WriteLine(output);
            writer.Flush();
        }

        // Handles the button presses on the player's board
        private void MyZoneClick(object sender, EventArgs e)
        {
            // All button names for the player are "button(letter)(number)" format, extract the letter and number from the name
            Button b = (Button)sender;
            string buttonName = b.Name;


            int x = (int)Char.GetNumericValue(buttonName[6]);
            int y = (int)Char.GetNumericValue(buttonName[7]);

            if (PlacingShips)
            {
                POS temp = new POS(x, y);
                PlaceShips(temp);
            }

        }

        // Handle the Chat send
        private void btn_chat_Click(object sender, EventArgs e)
        {
            msg t = new msg();
            t.name = txt_username.Text;
            t.body = txt_chat.Text;
            t.type = "chat";
            t.move = new POS(0, 0);
            txt_chat.Text = "";
            string output = JsonConvert.SerializeObject(t);
            writer.WriteLine(output);
            writer.Flush();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        // Fills the arrays as empty
        private void FillArrays()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PlayerZones[j, i] = false;
                    EnemyZones[j, i] = false;
                }
            }
        }

        // Builds the players board
        private void BuildPlayerBoard()
        {
            int width = 35;
            int height = 35;

            int x = 694;
            int y = 14;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j != 0)
                        x += 40;
                    Button b = new Button();
                    b.Size = new Size(height, width);
                    b.Location = new Point(x, y);
                    b.Text = "";
                    b.BackColor = System.Drawing.Color.FromArgb(255, 180, 180, 185);
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 200, 200, 200);
                    b.FlatAppearance.BorderSize = 1;
                    b.UseVisualStyleBackColor = true;
                    b.TabStop = false;
                    b.Name = "button" + j.ToString() + i.ToString();
                    b.Click += MyZoneClick;
                    PlayerArray[j, i] = b;
                    this.Controls.Add(PlayerArray[j, i]);
                }
                y += 40;
                x = 694;
            }
        }

        // Builds the enemy board
        private void BuildEnemyBoard()
        {
            int width = 35;
            int height = 35;
            int x = 1300;
            int y = 394;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j != 0)
                        x += 40;
                    Button b = new Button();
                    b.Size = new Size(height, width);
                    b.Location = new Point(x, y);
                    b.Text = "";
                    b.BackColor = System.Drawing.Color.FromArgb(255, 250, 112, 112);
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 200, 200, 200);
                    b.FlatAppearance.BorderSize = 1;
                    b.UseVisualStyleBackColor = true;
                    b.TabStop = false;
                    b.Name = "buttonX" + j.ToString() + i.ToString();
                    b.Click += EnemyZoneClick;
                    EnemyArray[j, i] = b;
                    this.Controls.Add(EnemyArray[j, i]);
                }
                y += 40;
                x = 1300;
            }
        }

        // Say ready
        private void signalReady()
        {
            EDEnemyButtons(false);
            label_turn.Text = "Lượt của địch";
            msg m = new msg();
            m.type = "ready";
            m.body = "ready";
            m.name = txt_username.Text;
            m.move = new POS(0, 0);
            string output = JsonConvert.SerializeObject(m);
            writer.WriteLine(output);
            writer.Flush();
        }
        string soundHit = @"hit.wav"; //thêm âm thanh khi bắn trúng 
        string soundMiss = @"miss.wav"; //thêm âm thanh khi bắn trượt 
        private void RunClient()
        {
            ipAddress = txt_IP.Text;
            client = new TcpClient(ipAddress, port);
            stream = client.GetStream();
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);

            string clientInput;
            try
            {
                while (!string.IsNullOrEmpty(clientInput = reader.ReadLine()))
                {
                    string output;
                    msg message = JsonConvert.DeserializeObject<msg>(clientInput);
                    msg reply = new msg();
                    reply.name = txt_username.Text;
                    reply.move = new POS(0, 0);

                    if (message.type.Equals("chat"))
                    {
                        string text = message.name + ": " + message.body + Environment.NewLine;
                        txt_chatlog.Text += text;

                    }
                    else if (message.type.Equals("move"))
                    {
                        string text = message.name + " Đã bắn tại X = " + message.move.X + " Y = " + message.move.Y + Environment.NewLine;
                        txt_chatlog.Text += text;

                        bool check = checkHit(message.move);
                        if (check)
                        {
                            reply.type = "hit";
                            reply.body = "hit";
                            PlayerArray[message.move.X, message.move.Y].BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            reply.type = "miss";
                            reply.body = "miss";
                            PlayerArray[message.move.X, message.move.Y].BackColor = System.Drawing.Color.White;
                        }
                        output = JsonConvert.SerializeObject(reply);
                        writer.WriteLine(output);
                        writer.Flush();
                        if (!gameover)
                        {
                            label_turn.Text = "Lượt của bạn";
                            // enable th enemy grid again.
                            EDEnemyButtons(true);
                        }
                    }
                    else if (message.type.Equals("quit"))
                    {
                        string text = message.name + " thoát... " + Environment.NewLine;
                        ServerDisco();
                        break;
                    }
                    else if (message.type.Equals("sunk"))
                    {
                        if (message.body.Equals("carrier"))
                        {
                            txt_chatlog.Text += "Enemy carrier đã bị bắn chìm!" + Environment.NewLine;
                        }
                        else if (message.body.Equals("battleship"))
                        {
                            txt_chatlog.Text += "Enemy battleship đã bị bắn chìm!" + Environment.NewLine;
                        }
                        else if (message.body.Equals("cruiser"))
                        {
                            txt_chatlog.Text += "Enemy cruiser đã bị bắn chìm!" + Environment.NewLine;
                        }
                        

                    }
                    else if (message.type.Equals("miss"))
                    {
                        AudioContext.missSound.Play();
                        EnemyArray[lastShot.X, lastShot.Y].BackColor = System.Drawing.Color.White;
                        txt_chatlog.Text += "Bắn trượt!" + Environment.NewLine;
                        label_turn.Text = "Lượt của địch";
                    }
                    else if (message.type.Equals("hit"))
                    {
                        AudioContext.hitSound.Play();
                        EnemyArray[lastShot.X, lastShot.Y].BackColor = System.Drawing.Color.Red;
                        txt_chatlog.Text += "Bắn trúng!" + Environment.NewLine;
                        label_turn.Text = "Lượt của bạn";
                        txt_chatlog.Text += "Bạn được băn thêm 1 viên!" + Environment.NewLine;
                        EDEnemyButtons(true);
                    }
                    else if (message.type.Equals("won"))
                    {
                        label_turn.Text = "BẠN ĐÃ THẮNG";
                        Win w = new Win();
                        w.ShowDialog();
                        //EDEnemyButtons(false);
                        //MasterLock();
                    }
                    else if (message.type.Equals("ready"))
                    {
                        EDEnemyButtons(true);
                    }
                    if (writer == null)
                        break;
                }
            }
            catch (Exception e)
            {
                txt_chatlog.Text += e.ToString();
            }


        }

        // server
        private void Server()
        {
            server = true;
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            listener.BeginAcceptTcpClient(handleClient, listener);
        }

        private void handleClient(IAsyncResult result)
        {
            if (listeningForClients)
            {
                client = listener.EndAcceptTcpClient(result);
                listeningForClients = false;
                ThreadPool.QueueUserWorkItem(runServer, client);
            }
        }

        private void runServer(object obj)
        {
            stream = client.GetStream();
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);
            string clientInput;

            try
            {
                while (!string.IsNullOrEmpty(clientInput = reader.ReadLine()))
                {
                    string output;
                    msg message = JsonConvert.DeserializeObject<msg>(clientInput);
                    msg reply = new msg();
                    reply.name = txt_username.Text;
                    reply.move = new POS(0, 0);

                    if (message.type.Equals("chat"))
                    {
                        string text = message.name + ": " + message.body + Environment.NewLine;
                        txt_chatlog.Text += text;

                    }
                    else if (message.type.Equals("move"))
                    {
                        string text = message.name + " Đã bắn tại X = " + message.move.X + " Y = " + message.move.Y + Environment.NewLine;
                        txt_chatlog.Text += text;
                        bool check = checkHit(message.move);

                        if (check)
                        {
                            reply.type = "hit";
                            reply.body = "hit";
                            PlayerArray[message.move.X, message.move.Y].BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            reply.type = "miss";
                            reply.body = "miss";
                            PlayerArray[message.move.X, message.move.Y].BackColor = System.Drawing.Color.White;
                        }
                        output = JsonConvert.SerializeObject(reply);
                        writer.WriteLine(output);
                        writer.Flush();
                        if (!gameover)
                        {
                            label_turn.Text = "Lượt của bạn";
                            // enable th enemy grid again.
                            EDEnemyButtons(true);
                        }


                    }
                    else if (message.type.Equals("quit"))
                    {
                        string text = message.name + " thoát... " + Environment.NewLine;
                        ServerDisco();
                        break;
                    }
                    else if (message.type.Equals("sunk"))
                    {
                        if (message.body.Equals("carrier"))
                        {
                            txt_chatlog.Text += "Enemy carrier đã bị bắn chìm!" + Environment.NewLine;
                        }
                        else if (message.body.Equals("battleship"))
                        {
                            txt_chatlog.Text += "Enemy battleship đã bị bắn chìm!" + Environment.NewLine;
                        }
                        else if (message.body.Equals("cruiser"))
                        {
                            txt_chatlog.Text += "Enemy cruiser đã bị bắn chìm!" + Environment.NewLine;
                        }

                    }
                    else if (message.type.Equals("miss"))
                    {
                        AudioContext.missSound.Play();
                        EnemyArray[lastShot.X, lastShot.Y].BackColor = System.Drawing.Color.White;
                        txt_chatlog.Text += "Bắn trượt!" + Environment.NewLine;
                    }
                    else if (message.type.Equals("hit"))
                    {
                        AudioContext.hitSound.Play();
                        EnemyArray[lastShot.X, lastShot.Y].BackColor = System.Drawing.Color.Red;
                        txt_chatlog.Text += "Bắn trúng!" + Environment.NewLine;
                        txt_chatlog.Text += "Bạn được băn thêm 1 viên!" + Environment.NewLine;
                        EDEnemyButtons(true);
                    }
                    else if (message.type.Equals("won"))
                    {
                        label_turn.Text = "BẠN ĐÃ THẮNG";
                        Win w = new Win();
                        w.ShowDialog();
                    }
                    else if (message.type.Equals("ready"))
                    {
                        EDEnemyButtons(true);
                        label_turn.Text = "Lượt của bạn";
                        txt_chatlog.Text += message.name + " đã sẵn sàng." + Environment.NewLine;
                    }
                    if (writer == null)
                        break;
                }

            }
            catch (Exception e)
            {
                txt_chatlog.Text += e.ToString();
            }
        }

        private void ServerDisco()
        {
            try
            {
                if (writer != null)
                    writer = null;
                if (stream != null)
                    stream = null;
                if (reader != null)
                    reader = null;
                if (client != null)
                    client.Close();

            }
            catch
            {

            }
        }

        private void Sunk(string name)
        {
            msg n = new msg();
            n.type = "sunk";
            n.name = txt_username.Text;
            n.move = new POS();
            n.body = name;
            string output = JsonConvert.SerializeObject(n);
            writer.WriteLine(output);
            writer.Flush();

            if (playerFleet.CarrierSunk == true && playerFleet.BattleshipSunk == true
                && playerFleet.CruiserSunk == true)
            {
                msg w = new msg();
                w.type = "won";
                w.name = txt_username.Text;
                w.move = new POS();
                n.body = "Winner Winner!!";
                string outputWin = JsonConvert.SerializeObject(w);
                writer.WriteLine(outputWin);
                writer.Flush();
                
                Lose l = new Lose();
                l.ShowDialog();
                gameover = true;
                MasterLock();
            }
        }

        private void MasterLock()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    EnemyArray[j, i].Enabled = false;
                }
            }
        }

        private bool checkHit(POS c)
        {
            // check carrier
            for (int i = 0; i < 5; i++)
            {
                if (Carrier[i].X == c.X && Carrier[i].Y == c.Y)
                {
                    Carrier[i].Hit = true;

                    bool sunk = true;
                    for (int j = 0; j < 5; j++)
                    {
                        if (Carrier[j].Hit == false)
                            sunk = false;
                    }
                    if (sunk)
                    {
                        playerFleet.CarrierSunk = true;
                        Sunk("carrier");

                    }
                    return true;
                }

            }
            // check battleship
            for (int i = 0; i < 4; i++)
            {
                if (Battleship[i].X == c.X && Battleship[i].Y == c.Y)
                {
                    Battleship[i].Hit = true;
                    bool sunk = true;
                    for (int j = 0; j < 4; j++)
                    {
                        if (Battleship[j].Hit == false)
                            sunk = false;
                    }
                    if (sunk)
                    {
                        playerFleet.BattleshipSunk = true;
                        Sunk("battleship");

                    }
                    return true;
                }
            }
            // check cruiser
            for (int i = 0; i < 3; i++)
            {
                if (Cruiser[i].X == c.X && Cruiser[i].Y == c.Y)
                {
                    Cruiser[i].Hit = true;
                    bool sunk = true;
                    for (int j = 0; j < 3; j++)
                    {
                        if (Cruiser[j].Hit == false)
                            sunk = false;
                    }
                    if (sunk)
                    {
                        playerFleet.CruiserSunk = true;
                        Sunk("cruiser");

                    }
                    return true;
                }
            }
            //check bait
            for (int i = 0; i < 2; i++)
            {
                if (Bait[i].X == c.X && Bait[i].Y == c.Y)
                {
                    Bait[i].Hit = true;
                    bool sunk = true;
                    for (int j = 0; j < 2; j++)
                    {
                        if (Bait[j].Hit == false)
                            sunk = false;
                    }
                    
                    return true;
                }
            }


            return false;
        }


        private void EDEnemyButtons(bool b)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (EnemyZones[j, i] == false)
                        EnemyArray[j, i].Enabled = b;
                }
            }
        }

        private void textBoxChatLog_TextChanged(object sender, EventArgs e)
        {
            txt_chatlog.SelectionStart = txt_chatlog.Text.Length;
            txt_chatlog.ScrollToCaret();
        }
        private void btn_play_Click(object sender, EventArgs e)
        {
            ipAddress = txt_IP.Text;
            port = Int32.Parse(txt_Port.Text);
            label2.Text = "Đang Chơi";
            label2.ForeColor = System.Drawing.Color.Blue;
            btn_play.Enabled = false;
            buttonHost.Enabled = false;
            server = false;
            Thread t = new Thread(RunClient);
            t.Start();
            StartGame();
        }

        private void buttonHost_Click_1(object sender, EventArgs e)
        {
            Server();
            buttonHost.Enabled = false;
            btn_play.Enabled = false;
            StartGame();
            EDEnemyButtons(false);
        }
        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_IP_TextChanged(object sender, EventArgs e)
        {

        }

        


    }
}
