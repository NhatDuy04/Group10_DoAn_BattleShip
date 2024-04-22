using System;
using System.Threading;
using System.Windows.Forms;

namespace Battleships
{
    public partial class MainGameForm : Form
    {
        int mouseCellX;
        int mouseCellY;

        Player yourPlayer;
        Player opponentPlayer;

        public MainGameForm()
        {
            InitializeComponent();
            // Disable maximalization button on the title bar.
            MaximizeBox = true;
            // Set the location of the form to the center of the screen.
            CenterToScreen();

            // Set random deck images, but two different.
            int deck1Number = GlobalContext.RandomNumber(4);
            int deck2Number = GlobalContext.RandomNumber(4);
            while (deck1Number == deck2Number)
            {
                deck2Number = GlobalContext.RandomNumber(4);
            }

            deck1PictureBox.Image = GraphicContext.deckImages[deck1Number];
            deck2PictureBox.Image = GraphicContext.deckImages[deck2Number];

            // Set the title of the form for better player orientation.
            if (Game.playerSwitch)
            {
                Text = "Battleships: " + Game.player1.Name + "’s turn";
                yourPlayer = Game.player1;
                opponentPlayer = Game.player2;
            }
            else
            {
                Text = "Battleships: " + Game.player2.Name + "’s turn";
                yourPlayer = Game.player2;
                opponentPlayer = Game.player1;
            }

            mouseCellX = -1;
            mouseCellY = -1;

            //if (Game.roundCount == 1)
            //{
                //AudioContext.drumSoundPlayer.Play();
            //}

            RedrawStatistics();
        }

        private void RedrawStatistics() 
        {
            roundTextBox.Text = Game.roundCount.ToString();
            roundTextBox.Refresh();

            battleLogRichTextBox.Text = yourPlayer.BattleLog;
            battleLogRichTextBox.Refresh();

            
        }

        private void deckPictureBoxClick(object sender, EventArgs e)
        {
            if (mouseCellX != -1 && mouseCellY != -1 && !opponentPlayer.RevealedCells[mouseCellX, mouseCellY])
            {
                // Is the game over?
                if (Game.PerformAttack(mouseCellX, mouseCellY, yourPlayer, opponentPlayer))
                {
                    // End of game, actual player wins redraw final state.
                    deck1PictureBox.Refresh();

                    // Reset side statistics.
                    RedrawStatistics();

                    // Wait few seconds.
                    Thread.Sleep(40);

                    // Play the winning sound.
                    //AudioContext.vicotrySoundPlayer.Play();

                    // Show the informational message box.
                    MessageBox.Show("Congratulations " + yourPlayer.Name + "! You have won against " + opponentPlayer.Name + " in " + Game.roundCount + " rounds!", "Battleships: Game Over!");

                    // Dispose the form and return to the main menu.
                    Dispose();

                    // Play the menu music in loop.
                    //AudioContext.menuSoundPlayer.PlayLooping();

                    GlobalContext.MainMenuForm.Location = Location;
                    GlobalContext.MainMenuForm.Show();
                }
                else
                {
                    // The game is not over yet.
                    // Redraw the deck.
                    deck1PictureBox.Refresh();

                    // Scroll the battle log to the end.
                    battleLogRichTextBox.ScrollToCaret();

                    // Reset the side statistics.
                    RedrawStatistics();

                    // Wait few seconds.
                    Thread.Sleep(40);

                    // Is the game a singleplayer?
                    
                    
                    
                        // The game is a multiplayer. 
                        if (!Game.playerSwitch)
                        {
                            // It has been the second player's turn. 
                            // Increment the round count.
                            Game.roundCount++;
                        }

                        // Switch the player, show the lock form.
                        Dispose();
                        Game.playerSwitch = !Game.playerSwitch;

                        PasswordCheckForm passwordCheckForm = new PasswordCheckForm();
                        passwordCheckForm.Location = Location;
                        passwordCheckForm.Show();
                    
                }                
            }
            
        }

        private void deck1PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            // Are we on the grid of the first deck?
            if (GraphicContext.GetCoorX(this, deck1PictureBox) != -1 && GraphicContext.GetCoorY(this, deck1PictureBox) != -1)
            {
                // Have the cell selected by mouse changed?
                if (GraphicContext.GetCell(GraphicContext.GetCoorX(this, deck1PictureBox)) != mouseCellX || GraphicContext.GetCell(GraphicContext.GetCoorY(this, deck1PictureBox)) != mouseCellY)
                {
                    // Update the cell selected by mouse.
                    mouseCellX = GraphicContext.GetCell(GraphicContext.GetCoorX(this, deck1PictureBox));
                    mouseCellY = GraphicContext.GetCell(GraphicContext.GetCoorY(this, deck1PictureBox));

                    // Repaint the first deck.
                    deck1PictureBox.Refresh();

                    // Draw the outer frame of the selected cell.
                    GraphicContext.DrawOuterFrameCell(mouseCellX, mouseCellY, 5, this, deck1PictureBox);
                }
            }
            else
            {
                // Unselect the cell in the first deck.
                mouseCellX = -1;
                mouseCellY = -1;

                // Repaint the first deck.
                deck1PictureBox.Refresh();  
            }
        }
        
        private void deck1PictureBoxPaint(object sender, PaintEventArgs e)
        {
            GraphicContext.DrawSunkenShips(opponentPlayer.ShipSet, opponentPlayer.ShipLeftCells, e);
            GraphicContext.DrawDeckStatus(opponentPlayer.RevealedCells, opponentPlayer.ShipSet, e);

            if (opponentPlayer.LastRevieledCells[0] != -1 && opponentPlayer.LastRevieledCells[1] != -1)
            {
                GraphicContext.DrawOuterFrameCell(opponentPlayer.LastRevieledCells[0], opponentPlayer.LastRevieledCells[1], 6, e);
            }
        }

        private void deck2PictureBoxPaint(object sender, PaintEventArgs e)
        {
            GraphicContext.DrawShipSet(yourPlayer.ShipSet, e);
            GraphicContext.DrawDeckStatus(yourPlayer.RevealedCells, yourPlayer.ShipSet, e);

            if (yourPlayer.LastRevieledCells[0] != -1 && yourPlayer.LastRevieledCells[1] != -1)
            {
                GraphicContext.DrawOuterFrameCell(yourPlayer.LastRevieledCells[0], yourPlayer.LastRevieledCells[1], 7, e);
            }
        }

        private void BattleLogRichTextBoxTextChanged(object sender, EventArgs e)
        {
            battleLogRichTextBox.SelectionStart = battleLogRichTextBox.TextLength;
        }

        private void MainMenuFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quitToMainMenu = MessageBox.Show("Do you really want to quit game to Main menu?", "Battleships: Quitting game...", MessageBoxButtons.YesNo);
            if (quitToMainMenu == DialogResult.Yes)
            {
                // Play the menu music in loop.
                //AudioContext.menuSoundPlayer.PlayLooping();

                // In case someone presses close button, show the dialog box.
                GlobalContext.MainMenuForm.Location = Location;
                GlobalContext.MainMenuForm.Show();
            }
            else
            {
                // Prevent form from closing.
                e.Cancel = true;
            }
        }
    }
}
