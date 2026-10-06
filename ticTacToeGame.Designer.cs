namespace XO_Game
{
    partial class TicTacToeGame
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
            this.lblTicTacToe = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTicTacToe
            // 
            this.lblTicTacToe.AutoSize = true;
            this.lblTicTacToe.Font = new System.Drawing.Font("ROG Fonts", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacToe.Location = new System.Drawing.Point(347, 24);
            this.lblTicTacToe.Name = "lblTicTacToe";
            this.lblTicTacToe.Size = new System.Drawing.Size(462, 41);
            this.lblTicTacToe.TabIndex = 0;
            this.lblTicTacToe.Text = "Tic-Tac-Toe Game";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(104, 140);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(111, 40);
            this.lblTurn.TabIndex = 1;
            this.lblTurn.Text = "Turn";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(86, 259);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(154, 40);
            this.lblWinner.TabIndex = 2;
            this.lblWinner.Text = "Winner";
            // 
            // TicTacToeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(915, 500);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblTicTacToe);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "TicTacToeGame";
            this.Text = "Tic-Tac-Toe Game";
            this.Load += new System.EventHandler(this.TicTacToeGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TicTacToeGame_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicTacToe;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
    }
}

