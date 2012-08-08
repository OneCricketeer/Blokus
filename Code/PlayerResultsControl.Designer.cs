namespace ConsoleApplications.Blokus
{
    partial class PlayerResultsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.piecesLeftLabel = new System.Windows.Forms.Label();
            this.numPieces = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.nameLabel.Size = new System.Drawing.Size(55, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // piecesLeftLabel
            // 
            this.piecesLeftLabel.AutoSize = true;
            this.piecesLeftLabel.Location = new System.Drawing.Point(101, 0);
            this.piecesLeftLabel.Name = "piecesLeftLabel";
            this.piecesLeftLabel.Size = new System.Drawing.Size(66, 13);
            this.piecesLeftLabel.TabIndex = 1;
            this.piecesLeftLabel.Text = "Pieces Left: ";
            // 
            // numPieces
            // 
            this.numPieces.AutoSize = true;
            this.numPieces.Location = new System.Drawing.Point(173, 0);
            this.numPieces.Name = "numPieces";
            this.numPieces.Size = new System.Drawing.Size(27, 13);
            this.numPieces.TabIndex = 2;
            this.numPieces.Text = "num";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(282, 0);
            this.score.Name = "score";
            this.score.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.score.Size = new System.Drawing.Size(47, 13);
            this.score.TabIndex = 3;
            this.score.Text = "num";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(238, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(41, 13);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score: ";
            // 
            // PlayerResultsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.score);
            this.Controls.Add(this.numPieces);
            this.Controls.Add(this.piecesLeftLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "PlayerResultsControl";
            this.Size = new System.Drawing.Size(332, 17);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label piecesLeftLabel;
        private System.Windows.Forms.Label numPieces;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label scoreLabel;
    }
}
