namespace ConsoleApplications.Blokus
{
    partial class PlayerControl
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
            this.playerName = new System.Windows.Forms.Label();
            this.piecesLeftLabel = new System.Windows.Forms.Label();
            this.numleft = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerName
            // 
            this.playerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(28, 11);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(61, 24);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "Name";
            this.playerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // piecesLeftLabel
            // 
            this.piecesLeftLabel.AutoSize = true;
            this.piecesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piecesLeftLabel.Location = new System.Drawing.Point(3, 44);
            this.piecesLeftLabel.Name = "piecesLeftLabel";
            this.piecesLeftLabel.Size = new System.Drawing.Size(86, 17);
            this.piecesLeftLabel.TabIndex = 1;
            this.piecesLeftLabel.Text = "Pieces Left: ";
            // 
            // numleft
            // 
            this.numleft.AutoSize = true;
            this.numleft.Location = new System.Drawing.Point(95, 46);
            this.numleft.Name = "numleft";
            this.numleft.Size = new System.Drawing.Size(27, 13);
            this.numleft.TabIndex = 2;
            this.numleft.Text = "num";
            this.numleft.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(3, 71);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(53, 17);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score: ";
            // 
            // scoreNum
            // 
            this.scoreNum.AutoSize = true;
            this.scoreNum.Location = new System.Drawing.Point(95, 73);
            this.scoreNum.Name = "scoreNum";
            this.scoreNum.Size = new System.Drawing.Size(27, 13);
            this.scoreNum.TabIndex = 4;
            this.scoreNum.Text = "num";
            this.scoreNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scoreNum);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.numleft);
            this.Controls.Add(this.piecesLeftLabel);
            this.Controls.Add(this.playerName);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(125, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label piecesLeftLabel;
        private System.Windows.Forms.Label numleft;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreNum;
    }
}
