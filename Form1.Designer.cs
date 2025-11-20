namespace Tic_Tac_Toe_Game
{
    partial class GameScreen
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
            this.LabelPlayerName = new System.Windows.Forms.Label();
            this.LabelWinner = new System.Windows.Forms.Label();
            this.LabelShowWhoIsWinGame = new System.Windows.Forms.Label();
            this.LabelTurn = new System.Windows.Forms.Label();
            this.labelResetGame = new System.Windows.Forms.Label();
            this.Cell_3_3 = new System.Windows.Forms.Label();
            this.Cell_3_2 = new System.Windows.Forms.Label();
            this.Cell_3_1 = new System.Windows.Forms.Label();
            this.Cell_2_3 = new System.Windows.Forms.Label();
            this.Cell_2_2 = new System.Windows.Forms.Label();
            this.Cell_2_1 = new System.Windows.Forms.Label();
            this.Cell_1_2 = new System.Windows.Forms.Label();
            this.Cell_1_3 = new System.Windows.Forms.Label();
            this.Cell_3 = new System.Windows.Forms.PictureBox();
            this.Cell_1_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cell_3)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPlayerName
            // 
            this.LabelPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayerName.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelPlayerName.Location = new System.Drawing.Point(12, 145);
            this.LabelPlayerName.Name = "LabelPlayerName";
            this.LabelPlayerName.Size = new System.Drawing.Size(288, 54);
            this.LabelPlayerName.TabIndex = 29;
            this.LabelPlayerName.Text = "Players";
            // 
            // LabelWinner
            // 
            this.LabelWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LabelWinner.Location = new System.Drawing.Point(12, 220);
            this.LabelWinner.Name = "LabelWinner";
            this.LabelWinner.Size = new System.Drawing.Size(288, 54);
            this.LabelWinner.TabIndex = 30;
            this.LabelWinner.Text = "Winner";
            // 
            // LabelShowWhoIsWinGame
            // 
            this.LabelShowWhoIsWinGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShowWhoIsWinGame.ForeColor = System.Drawing.Color.Lime;
            this.LabelShowWhoIsWinGame.Location = new System.Drawing.Point(12, 296);
            this.LabelShowWhoIsWinGame.Name = "LabelShowWhoIsWinGame";
            this.LabelShowWhoIsWinGame.Size = new System.Drawing.Size(288, 54);
            this.LabelShowWhoIsWinGame.TabIndex = 31;
            this.LabelShowWhoIsWinGame.Tag = "false";
            this.LabelShowWhoIsWinGame.Text = "In Progress";
            // 
            // LabelTurn
            // 
            this.LabelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LabelTurn.Location = new System.Drawing.Point(12, 79);
            this.LabelTurn.Name = "LabelTurn";
            this.LabelTurn.Size = new System.Drawing.Size(288, 54);
            this.LabelTurn.TabIndex = 32;
            this.LabelTurn.Text = "Turn";
            // 
            // labelResetGame
            // 
            this.labelResetGame.BackColor = System.Drawing.Color.DimGray;
            this.labelResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResetGame.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResetGame.Location = new System.Drawing.Point(12, 382);
            this.labelResetGame.Name = "labelResetGame";
            this.labelResetGame.Size = new System.Drawing.Size(252, 54);
            this.labelResetGame.TabIndex = 33;
            this.labelResetGame.Text = "Restart Game";
            this.labelResetGame.Click += new System.EventHandler(this.labelResetGame_Click);
            // 
            // Cell_3_3
            // 
            this.Cell_3_3.BackColor = System.Drawing.Color.Transparent;
            this.Cell_3_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell_3_3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Cell_3_3.Location = new System.Drawing.Point(640, 403);
            this.Cell_3_3.Name = "Cell_3_3";
            this.Cell_3_3.Size = new System.Drawing.Size(156, 128);
            this.Cell_3_3.TabIndex = 27;
            this.Cell_3_3.Tag = "true";
            this.Cell_3_3.Click += new System.EventHandler(this.Cell_3_3_Click);
            // 
            // Cell_3_2
            // 
            this.Cell_3_2.BackColor = System.Drawing.Color.Transparent;
            this.Cell_3_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell_3_2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Cell_3_2.Location = new System.Drawing.Point(493, 403);
            this.Cell_3_2.Name = "Cell_3_2";
            this.Cell_3_2.Size = new System.Drawing.Size(116, 118);
            this.Cell_3_2.TabIndex = 26;
            this.Cell_3_2.Tag = "true";
            this.Cell_3_2.Click += new System.EventHandler(this.Cell_3_2_Click);
            // 
            // Cell_3_1
            // 
            this.Cell_3_1.BackColor = System.Drawing.Color.Transparent;
            this.Cell_3_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell_3_1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Cell_3_1.Location = new System.Drawing.Point(317, 404);
            this.Cell_3_1.Name = "Cell_3_1";
            this.Cell_3_1.Size = new System.Drawing.Size(129, 117);
            this.Cell_3_1.TabIndex = 25;
            this.Cell_3_1.Tag = "true";
            this.Cell_3_1.Click += new System.EventHandler(this.Cell_3_1_Click);
            // 
            // Cell_2_3
            // 
            this.Cell_2_3.BackColor = System.Drawing.Color.Transparent;
            this.Cell_2_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell_2_3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Cell_2_3.Location = new System.Drawing.Point(640, 252);
            this.Cell_2_3.Name = "Cell_2_3";
            this.Cell_2_3.Size = new System.Drawing.Size(131, 125);
            this.Cell_2_3.TabIndex = 24;
            this.Cell_2_3.Tag = "true";
            this.Cell_2_3.Click += new System.EventHandler(this.Cell_2_3_Click);
            // 
            // Cell_2_2
            // 
            this.Cell_2_2.BackColor = System.Drawing.Color.Transparent;
            this.Cell_2_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell_2_2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Cell_2_2.Location = new System.Drawing.Point(496, 249);
            this.Cell_2_2.Name = "Cell_2_2";
            this.Cell_2_2.Size = new System.Drawing.Size(113, 128);
            this.Cell_2_2.TabIndex = 23;
            this.Cell_2_2.Tag = "true";
            this.Cell_2_2.Click += new System.EventHandler(this.Cell_2_2_Click);
            // 
            // Cell_2_1
            // 
            this.Cell_2_1.BackColor = System.Drawing.Color.Transparent;
            this.Cell_2_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell_2_1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Cell_2_1.Location = new System.Drawing.Point(306, 252);
            this.Cell_2_1.Name = "Cell_2_1";
            this.Cell_2_1.Size = new System.Drawing.Size(140, 125);
            this.Cell_2_1.TabIndex = 22;
            this.Cell_2_1.Tag = "true";
            this.Cell_2_1.Click += new System.EventHandler(this.Cell_2_1_Click);
            // 
            // Cell_1_2
            // 
            this.Cell_1_2.BackColor = System.Drawing.Color.Transparent;
            this.Cell_1_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell_1_2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Cell_1_2.Location = new System.Drawing.Point(493, 100);
            this.Cell_1_2.Name = "Cell_1_2";
            this.Cell_1_2.Size = new System.Drawing.Size(113, 128);
            this.Cell_1_2.TabIndex = 21;
            this.Cell_1_2.Tag = "true";
            this.Cell_1_2.Click += new System.EventHandler(this.Cell_1_2_Click);
            // 
            // Cell_1_3
            // 
            this.Cell_1_3.BackColor = System.Drawing.Color.Transparent;
            this.Cell_1_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell_1_3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Cell_1_3.Location = new System.Drawing.Point(637, 100);
            this.Cell_1_3.Name = "Cell_1_3";
            this.Cell_1_3.Size = new System.Drawing.Size(156, 128);
            this.Cell_1_3.TabIndex = 20;
            this.Cell_1_3.Tag = "true";
            this.Cell_1_3.Click += new System.EventHandler(this.Cell_1_3_Click);
            // 
            // Cell_3
            // 
            this.Cell_3.BackColor = System.Drawing.Color.Transparent;
            this.Cell_3.ErrorImage = global::Tic_Tac_Toe_Game.Properties.Resources.Tic_Tac_Toe;
            this.Cell_3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.Tic_Tac_Toe;
            this.Cell_3.Location = new System.Drawing.Point(165, -114);
            this.Cell_3.Name = "Cell_3";
            this.Cell_3.Size = new System.Drawing.Size(764, 791);
            this.Cell_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cell_3.TabIndex = 34;
            this.Cell_3.TabStop = false;
            // 
            // Cell_1_1
            // 
            this.Cell_1_1.BackColor = System.Drawing.Color.Transparent;
            this.Cell_1_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell_1_1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Cell_1_1.Location = new System.Drawing.Point(306, 103);
            this.Cell_1_1.Name = "Cell_1_1";
            this.Cell_1_1.Size = new System.Drawing.Size(140, 125);
            this.Cell_1_1.TabIndex = 19;
            this.Cell_1_1.Tag = "true";
            this.Cell_1_1.Click += new System.EventHandler(this.Cell_1_1_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(857, 540);
            this.Controls.Add(this.labelResetGame);
            this.Controls.Add(this.LabelTurn);
            this.Controls.Add(this.LabelShowWhoIsWinGame);
            this.Controls.Add(this.LabelWinner);
            this.Controls.Add(this.LabelPlayerName);
            this.Controls.Add(this.Cell_3_3);
            this.Controls.Add(this.Cell_3_2);
            this.Controls.Add(this.Cell_3_1);
            this.Controls.Add(this.Cell_2_3);
            this.Controls.Add(this.Cell_2_2);
            this.Controls.Add(this.Cell_2_1);
            this.Controls.Add(this.Cell_1_2);
            this.Controls.Add(this.Cell_1_3);
            this.Controls.Add(this.Cell_1_1);
            this.Controls.Add(this.Cell_3);
            this.Name = "GameScreen";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cell_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Cell_1_3;
        private System.Windows.Forms.Label Cell_1_2;
        private System.Windows.Forms.Label Cell_2_1;
        private System.Windows.Forms.Label Cell_2_2;
        private System.Windows.Forms.Label Cell_2_3;
        private System.Windows.Forms.Label Cell_3_1;
        private System.Windows.Forms.Label Cell_3_2;
        private System.Windows.Forms.Label Cell_3_3;
        private System.Windows.Forms.Label LabelPlayerName;
        private System.Windows.Forms.Label LabelWinner;
        private System.Windows.Forms.Label LabelShowWhoIsWinGame;
        private System.Windows.Forms.Label LabelTurn;
        private System.Windows.Forms.Label labelResetGame;
        private System.Windows.Forms.PictureBox Cell_3;
        private System.Windows.Forms.Label Cell_1_1;
    }
}

