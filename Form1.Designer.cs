namespace Assignment_2
{
    partial class frmBattleShip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattleShip));
            this.panWelcome = new System.Windows.Forms.Panel();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCloseAbout = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panGame = new System.Windows.Forms.Panel();
            this.panGrid = new System.Windows.Forms.Panel();
            this.panStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.prbCarrier = new System.Windows.Forms.ProgressBar();
            this.lblBtlShip = new System.Windows.Forms.Label();
            this.prbBattleShip = new System.Windows.Forms.ProgressBar();
            this.lblCruiser = new System.Windows.Forms.Label();
            this.prbCruiser = new System.Windows.Forms.ProgressBar();
            this.lblSubmarine = new System.Windows.Forms.Label();
            this.prbSubmarine = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.prbDestroyer = new System.Windows.Forms.ProgressBar();
            this.lblTrnTaken = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnShowBoats = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panWelcome.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.panGame.SuspendLayout();
            this.panStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panWelcome
            // 
            this.panWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panWelcome.BackgroundImage")));
            this.panWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panWelcome.Controls.Add(this.pnlAbout);
            this.panWelcome.Controls.Add(this.btnAbout);
            this.panWelcome.Controls.Add(this.btnStart);
            this.panWelcome.Controls.Add(this.lblWelcome);
            this.panWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panWelcome.Location = new System.Drawing.Point(2, 12);
            this.panWelcome.Name = "panWelcome";
            this.panWelcome.Size = new System.Drawing.Size(1043, 689);
            this.panWelcome.TabIndex = 0;
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.lblInfo);
            this.pnlAbout.Controls.Add(this.btnCloseAbout);
            this.pnlAbout.Location = new System.Drawing.Point(152, 89);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(726, 477);
            this.pnlAbout.TabIndex = 3;
            this.pnlAbout.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(14, 61);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(662, 312);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnCloseAbout
            // 
            this.btnCloseAbout.Location = new System.Drawing.Point(329, 434);
            this.btnCloseAbout.Name = "btnCloseAbout";
            this.btnCloseAbout.Size = new System.Drawing.Size(75, 23);
            this.btnCloseAbout.TabIndex = 0;
            this.btnCloseAbout.Text = "&Close";
            this.toolTip1.SetToolTip(this.btnCloseAbout, "Press to close About panel");
            this.btnCloseAbout.UseVisualStyleBackColor = true;
            this.btnCloseAbout.Click += new System.EventHandler(this.btnCloseAbout_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(441, 293);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(109, 44);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "&About";
            this.toolTip1.SetToolTip(this.btnAbout, "Press to see About screen");
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(441, 157);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 44);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.toolTip1.SetToolTip(this.btnStart, "Press to Start Game");
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F);
            this.lblWelcome.Location = new System.Drawing.Point(360, 7);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(343, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To BattleShip";
            // 
            // panGame
            // 
            this.panGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panGame.BackColor = System.Drawing.Color.Transparent;
            this.panGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panGame.BackgroundImage")));
            this.panGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panGame.Controls.Add(this.panGrid);
            this.panGame.Controls.Add(this.panStatus);
            this.panGame.Controls.Add(this.btnNewGame);
            this.panGame.Controls.Add(this.btnShowBoats);
            this.panGame.Controls.Add(this.btnExit);
            this.panGame.ForeColor = System.Drawing.Color.Transparent;
            this.panGame.Location = new System.Drawing.Point(5, 12);
            this.panGame.Name = "panGame";
            this.panGame.Size = new System.Drawing.Size(1040, 671);
            this.panGame.TabIndex = 2;
            // 
            // panGrid
            // 
            this.panGrid.BackColor = System.Drawing.Color.Transparent;
            this.panGrid.Location = new System.Drawing.Point(10, 40);
            this.panGrid.Name = "panGrid";
            this.panGrid.Size = new System.Drawing.Size(560, 540);
            this.panGrid.TabIndex = 115;
            this.panGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panGrid_Paint);
            // 
            // panStatus
            // 
            this.panStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panStatus.BackColor = System.Drawing.Color.Transparent;
            this.panStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panStatus.Controls.Add(this.lblStatus);
            this.panStatus.Controls.Add(this.lblCarrier);
            this.panStatus.Controls.Add(this.prbCarrier);
            this.panStatus.Controls.Add(this.lblBtlShip);
            this.panStatus.Controls.Add(this.prbBattleShip);
            this.panStatus.Controls.Add(this.lblCruiser);
            this.panStatus.Controls.Add(this.prbCruiser);
            this.panStatus.Controls.Add(this.lblSubmarine);
            this.panStatus.Controls.Add(this.prbSubmarine);
            this.panStatus.Controls.Add(this.label1);
            this.panStatus.Controls.Add(this.prbDestroyer);
            this.panStatus.Controls.Add(this.lblTrnTaken);
            this.panStatus.Controls.Add(this.lblTurns);
            this.panStatus.Location = new System.Drawing.Point(755, 91);
            this.panStatus.Name = "panStatus";
            this.panStatus.Size = new System.Drawing.Size(257, 344);
            this.panStatus.TabIndex = 114;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(72, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(128, 23);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Boat Statuses";
            // 
            // lblCarrier
            // 
            this.lblCarrier.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lblCarrier.Location = new System.Drawing.Point(4, 45);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(100, 23);
            this.lblCarrier.TabIndex = 1;
            this.lblCarrier.Text = "Carrier (5)";
            // 
            // prbCarrier
            // 
            this.prbCarrier.Location = new System.Drawing.Point(99, 45);
            this.prbCarrier.MarqueeAnimationSpeed = 75;
            this.prbCarrier.Maximum = 5;
            this.prbCarrier.Name = "prbCarrier";
            this.prbCarrier.Size = new System.Drawing.Size(119, 23);
            this.prbCarrier.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbCarrier.TabIndex = 2;
            this.toolTip1.SetToolTip(this.prbCarrier, "Progress for Carrier");
            // 
            // lblBtlShip
            // 
            this.lblBtlShip.Font = new System.Drawing.Font("Calibri", 7.8F);
            this.lblBtlShip.Location = new System.Drawing.Point(4, 97);
            this.lblBtlShip.Name = "lblBtlShip";
            this.lblBtlShip.Size = new System.Drawing.Size(100, 23);
            this.lblBtlShip.TabIndex = 3;
            this.lblBtlShip.Text = "BattleShip (4)";
            // 
            // prbBattleShip
            // 
            this.prbBattleShip.Location = new System.Drawing.Point(99, 97);
            this.prbBattleShip.MarqueeAnimationSpeed = 75;
            this.prbBattleShip.Maximum = 4;
            this.prbBattleShip.Name = "prbBattleShip";
            this.prbBattleShip.Size = new System.Drawing.Size(119, 23);
            this.prbBattleShip.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbBattleShip.TabIndex = 4;
            this.toolTip1.SetToolTip(this.prbBattleShip, "Progress for Battleship");
            // 
            // lblCruiser
            // 
            this.lblCruiser.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.lblCruiser.Location = new System.Drawing.Point(3, 149);
            this.lblCruiser.Name = "lblCruiser";
            this.lblCruiser.Size = new System.Drawing.Size(90, 23);
            this.lblCruiser.TabIndex = 8;
            this.lblCruiser.Text = "Cruiser (3)";
            // 
            // prbCruiser
            // 
            this.prbCruiser.Location = new System.Drawing.Point(99, 149);
            this.prbCruiser.MarqueeAnimationSpeed = 75;
            this.prbCruiser.Maximum = 3;
            this.prbCruiser.Name = "prbCruiser";
            this.prbCruiser.Size = new System.Drawing.Size(119, 23);
            this.prbCruiser.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbCruiser.TabIndex = 5;
            this.toolTip1.SetToolTip(this.prbCruiser, "Progress for Cruiser");
            // 
            // lblSubmarine
            // 
            this.lblSubmarine.Font = new System.Drawing.Font("Calibri", 7.2F);
            this.lblSubmarine.Location = new System.Drawing.Point(3, 201);
            this.lblSubmarine.Name = "lblSubmarine";
            this.lblSubmarine.Size = new System.Drawing.Size(89, 23);
            this.lblSubmarine.TabIndex = 9;
            this.lblSubmarine.Text = "Submarine (3)";
            // 
            // prbSubmarine
            // 
            this.prbSubmarine.Location = new System.Drawing.Point(99, 201);
            this.prbSubmarine.MarqueeAnimationSpeed = 75;
            this.prbSubmarine.Maximum = 3;
            this.prbSubmarine.Name = "prbSubmarine";
            this.prbSubmarine.Size = new System.Drawing.Size(119, 23);
            this.prbSubmarine.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbSubmarine.TabIndex = 6;
            this.toolTip1.SetToolTip(this.prbSubmarine, "Progress of Submarine");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 7.8F);
            this.label1.Location = new System.Drawing.Point(2, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 115;
            this.label1.Text = "Destroyer (2)";
            // 
            // prbDestroyer
            // 
            this.prbDestroyer.Location = new System.Drawing.Point(99, 253);
            this.prbDestroyer.MarqueeAnimationSpeed = 75;
            this.prbDestroyer.Maximum = 2;
            this.prbDestroyer.Name = "prbDestroyer";
            this.prbDestroyer.Size = new System.Drawing.Size(119, 23);
            this.prbDestroyer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbDestroyer.TabIndex = 7;
            this.toolTip1.SetToolTip(this.prbDestroyer, "Progress of Destroyer");
            // 
            // lblTrnTaken
            // 
            this.lblTrnTaken.Location = new System.Drawing.Point(5, 306);
            this.lblTrnTaken.Name = "lblTrnTaken";
            this.lblTrnTaken.Size = new System.Drawing.Size(100, 23);
            this.lblTrnTaken.TabIndex = 116;
            this.lblTrnTaken.Text = "Turns Taken";
            // 
            // lblTurns
            // 
            this.lblTurns.Location = new System.Drawing.Point(132, 309);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(86, 20);
            this.lblTurns.TabIndex = 117;
            this.lblTurns.Text = "0";
            this.toolTip1.SetToolTip(this.lblTurns, "Total turns taken");
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(739, 14);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(126, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "&New Game";
            this.toolTip1.SetToolTip(this.btnNewGame, "Click here to play a new game");
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnShowBoats
            // 
            this.btnShowBoats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowBoats.ForeColor = System.Drawing.Color.Black;
            this.btnShowBoats.Location = new System.Drawing.Point(877, 13);
            this.btnShowBoats.Name = "btnShowBoats";
            this.btnShowBoats.Size = new System.Drawing.Size(140, 23);
            this.btnShowBoats.TabIndex = 1;
            this.btnShowBoats.Text = "&Show Board";
            this.toolTip1.SetToolTip(this.btnShowBoats, "Reveal all boat positions");
            this.btnShowBoats.UseVisualStyleBackColor = true;
            this.btnShowBoats.Click += new System.EventHandler(this.btnShowBoard_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(903, 627);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 23);
            this.btnExit.TabIndex = 113;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Click here to exit game");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBattleShip
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1057, 695);
            this.Controls.Add(this.panGame);
            this.Controls.Add(this.panWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBattleShip";
            this.Text = "BattleShip Game";
            this.panWelcome.ResumeLayout(false);
            this.pnlAbout.ResumeLayout(false);
            this.panGame.ResumeLayout(false);
            this.panStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Non-grid UI controls
        private System.Windows.Forms.Panel      panWelcome;
        private System.Windows.Forms.Label      lblWelcome;
        private System.Windows.Forms.Button     btnStart;
        private System.Windows.Forms.Button     btnAbout;
        private System.Windows.Forms.Panel      pnlAbout;
        private System.Windows.Forms.Label      lblInfo;
        private System.Windows.Forms.Button     btnCloseAbout;
        private System.Windows.Forms.Panel      panGame;
        private System.Windows.Forms.Panel      panGrid;        // grid buttons created at runtime
        private System.Windows.Forms.Panel      panStatus;
        private System.Windows.Forms.Label      lblStatus;
        private System.Windows.Forms.Label      lblCarrier;
        private System.Windows.Forms.ProgressBar prbCarrier;
        private System.Windows.Forms.Label      lblBtlShip;
        private System.Windows.Forms.ProgressBar prbBattleShip;
        private System.Windows.Forms.Label      lblCruiser;
        private System.Windows.Forms.ProgressBar prbCruiser;
        private System.Windows.Forms.Label      lblSubmarine;
        private System.Windows.Forms.ProgressBar prbSubmarine;
        private System.Windows.Forms.Label      label1;
        private System.Windows.Forms.ProgressBar prbDestroyer;
        private System.Windows.Forms.Label      lblTrnTaken;
        private System.Windows.Forms.Label      lblTurns;
        private System.Windows.Forms.Button     btnNewGame;
        private System.Windows.Forms.Button     btnShowBoats;
        private System.Windows.Forms.Button     btnExit;
        private System.Windows.Forms.ToolTip    toolTip1;
    }
}
