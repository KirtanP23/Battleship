/* *****************************
 * Title:   Battleship Assignment Main Class File
 * Author:  Kirtan Patel
 * Date:    Oct. 13, 2024
 * Purpose: To create application for Battleship game to complete Assignment - 2
 * ***************************** */

using Battleship;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class frmBattleShip : Form
    {
        #region Fields
        private int carrierHits    = 0;
        private int battleshipHits = 0;
        private int cruiserHits    = 0;
        private int submarineHits  = 0;
        private int destroyerHits  = 0;
        private int turnCount      = 0;

        private bool gridCreated = false;

        // 2D array of grid buttons — index [row, col] from 1..MAX_BOARD_SIZE
        private Button[,] gridButtons = new Button[BS.MAX_BOARD_SIZE + 1, BS.MAX_BOARD_SIZE + 1];
        #endregion


        public frmBattleShip()
        {
            InitializeComponent();
            panWelcome.Visible = true;
            panGame.Visible = false;
        }


        #region Navigation Handlers

        private void btnStart_Click(object sender, EventArgs e)
        {
            panWelcome.Visible = false;
            panGame.Visible = true;

            if (!gridCreated)
            {
                CreateGrid();
                gridCreated = true;
            }

            BS.RandomizeBoats();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btnShowBoard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to reveal all boat positions?",
                "Show Boats",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                ShowFullBoats();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = true;
            btnStart.Visible = false;
            btnAbout.Visible = false;
        }

        private void btnCloseAbout_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            btnStart.Visible = true;
            btnAbout.Visible = true;
        }

        #endregion


        #region Grid Creation

        /// <summary>
        /// Dynamically creates the 10x10 grid of buttons when the game first starts.
        /// Each button stores its (row, col) coordinates in its Tag property.
        /// </summary>
        private void CreateGrid()
        {
            const int btnSize    = 35;
            const int startX     = 20;
            const int startY     = 40;
            const int headerSize = 22;

            // Column number labels (1 – 10)
            for (int col = 1; col <= BS.MAX_BOARD_SIZE; col++)
            {
                Label colLabel = new Label
                {
                    Text      = col.ToString(),
                    Location  = new Point(startX + headerSize + (col - 1) * btnSize, startY - headerSize),
                    Size      = new Size(btnSize, headerSize),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Font      = new Font("Calibri", 9f, FontStyle.Bold)
                };
                panGrid.Controls.Add(colLabel);
            }

            // Row letter labels (A – J) and their buttons
            for (int row = 1; row <= BS.MAX_BOARD_SIZE; row++)
            {
                Label rowLabel = new Label
                {
                    Text      = ((char)('A' + row - 1)).ToString(),
                    Location  = new Point(startX, startY + (row - 1) * btnSize),
                    Size      = new Size(headerSize, btnSize),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Font      = new Font("Calibri", 9f, FontStyle.Bold)
                };
                panGrid.Controls.Add(rowLabel);

                for (int col = 1; col <= BS.MAX_BOARD_SIZE; col++)
                {
                    Button btn = new Button
                    {
                        Name      = $"btn{(char)('A' + row - 1)}{col}",
                        Size      = new Size(btnSize, btnSize),
                        Location  = new Point(startX + headerSize + (col - 1) * btnSize,
                                              startY + (row - 1) * btnSize),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White,
                        Tag       = new Point(row, col)     // grid coordinates stored here
                    };
                    btn.FlatAppearance.BorderColor = Color.MidnightBlue;
                    btn.FlatAppearance.BorderSize  = 1;
                    btn.Click += btnGrid_Click;
                    toolTip1.SetToolTip(btn, "Click to fire!");

                    gridButtons[row, col] = btn;
                    panGrid.Controls.Add(btn);
                }
            }
        }

        #endregion


        #region Game Logic

        /// <summary>
        /// Handles a grid button click — processes hit or miss and updates state.
        /// </summary>
        private void btnGrid_Click(object sender, EventArgs e)
        {
            Button btn    = (Button)sender;
            Point  coords = (Point)btn.Tag;
            int x = coords.X;   // row
            int y = coords.Y;   // column

            if (BS.boatPositions[x, y] != BS.Boats.NoBoat)
            {
                if (BS.board[x, y] != BS.BoardStatus.Hit)
                {
                    btn.BackColor = Color.Crimson;
                    btn.Text      = "✕";
                    BS.board[x, y] = BS.BoardStatus.Hit;
                    UpdateShipProgress(BS.boatPositions[x, y]);
                }
            }
            else
            {
                if (BS.board[x, y] != BS.BoardStatus.Miss)
                {
                    btn.BackColor = Color.SlateGray;
                    btn.Text      = "•";
                    BS.board[x, y] = BS.BoardStatus.Miss;
                }
            }

            UpdateTurns();
        }

        /// <summary>
        /// Resets all game state and randomizes new boat positions.
        /// </summary>
        private void NewGame()
        {
            carrierHits = battleshipHits = cruiserHits = submarineHits = destroyerHits = 0;
            turnCount = 0;
            lblTurns.Text = "0";

            // Clear boat position array
            for (int x = 1; x <= BS.MAX_BOARD_SIZE; x++)
                for (int y = 1; y <= BS.MAX_BOARD_SIZE; y++)
                    BS.boatPositions[x, y] = BS.Boats.NoBoat;

            prbCarrier.Value    = 0;
            prbBattleShip.Value = 0;
            prbCruiser.Value    = 0;
            prbSubmarine.Value  = 0;
            prbDestroyer.Value  = 0;
            lblTrnTaken.Text    = string.Empty;

            ResetBoard();
            BS.RandomizeBoats();
        }

        /// <summary>
        /// Resets all grid buttons to their default ocean appearance.
        /// </summary>
        private void ResetBoard()
        {
            for (int x = 1; x <= BS.MAX_BOARD_SIZE; x++)
            {
                for (int y = 1; y <= BS.MAX_BOARD_SIZE; y++)
                {
                    Button btn = gridButtons[x, y];
                    if (btn != null)
                    {
                        btn.BackColor = Color.SteelBlue;
                        btn.Text      = string.Empty;
                    }
                }
            }
        }

        /// <summary>
        /// Reveals all un-hit boat cells on the grid.
        /// </summary>
        private void ShowFullBoats()
        {
            HideAllBoats();

            for (int x = 1; x <= BS.MAX_BOARD_SIZE; x++)
                for (int y = 1; y <= BS.MAX_BOARD_SIZE; y++)
                    if (BS.boatPositions[x, y] != BS.Boats.NoBoat && BS.board[x, y] != BS.BoardStatus.Hit)
                        gridButtons[x, y].BackColor = Color.DarkSlateGray;
        }

        /// <summary>
        /// Hides all non-hit boat cells, restoring their default color.
        /// </summary>
        private void HideAllBoats()
        {
            for (int x = 1; x <= BS.MAX_BOARD_SIZE; x++)
                for (int y = 1; y <= BS.MAX_BOARD_SIZE; y++)
                    if (BS.board[x, y] != BS.BoardStatus.Hit)
                        gridButtons[x, y].BackColor = Color.SteelBlue;
        }

        /// <summary>
        /// Increments and displays the turn counter.
        /// </summary>
        private void UpdateTurns()
        {
            turnCount++;
            lblTurns.Text = turnCount.ToString();
        }

        /// <summary>
        /// Updates the progress bar for the given ship and checks if it has been sunk.
        /// </summary>
        private void UpdateShipProgress(BS.Boats shipType)
        {
            switch (shipType)
            {
                case BS.Boats.Carrier:
                    prbCarrier.Value = ++carrierHits;
                    if (carrierHits == BS.GetBoatSize(BS.Boats.Carrier))
                        MessageBox.Show("Carrier sunk!", "Ship Down", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case BS.Boats.Battleship:
                    prbBattleShip.Value = ++battleshipHits;
                    if (battleshipHits == BS.GetBoatSize(BS.Boats.Battleship))
                        MessageBox.Show("Battleship sunk!", "Ship Down", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case BS.Boats.Cruiser:
                    prbCruiser.Value = ++cruiserHits;
                    if (cruiserHits == BS.GetBoatSize(BS.Boats.Cruiser))
                        MessageBox.Show("Cruiser sunk!", "Ship Down", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case BS.Boats.Submarine:
                    prbSubmarine.Value = ++submarineHits;
                    if (submarineHits == BS.GetBoatSize(BS.Boats.Submarine))
                        MessageBox.Show("Submarine sunk!", "Ship Down", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case BS.Boats.Destroyer:
                    prbDestroyer.Value = ++destroyerHits;
                    if (destroyerHits == BS.GetBoatSize(BS.Boats.Destroyer))
                        MessageBox.Show("Destroyer sunk!", "Ship Down", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            CheckAllBoatsSunk();
        }

        /// <summary>
        /// Checks whether all boats have been sunk and triggers the win condition.
        /// </summary>
        private void CheckAllBoatsSunk()
        {
            int totalHits = carrierHits + battleshipHits + cruiserHits + submarineHits + destroyerHits;

            int totalToSink = BS.GetBoatSize(BS.Boats.Carrier)
                            + BS.GetBoatSize(BS.Boats.Battleship)
                            + BS.GetBoatSize(BS.Boats.Cruiser)
                            + BS.GetBoatSize(BS.Boats.Submarine)
                            + BS.GetBoatSize(BS.Boats.Destroyer);

            if (totalHits == totalToSink)
            {
                MessageBox.Show(
                    $"You sank all the boats in {turnCount} turns! Well done!",
                    "Victory!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                NewGame();
            }
        }

        #endregion

        private void panGrid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
