namespace ConsoleApplications.Blokus
{
    partial class ResultForm
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
            this.winnerLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.player1Results = new ConsoleApplications.Blokus.PlayerResultsControl();
            this.player2Results = new ConsoleApplications.Blokus.PlayerResultsControl();
            this.player3Results = new ConsoleApplications.Blokus.PlayerResultsControl();
            this.player4Results = new ConsoleApplications.Blokus.PlayerResultsControl();
            this.SuspendLayout();
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(90, 18);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(145, 24);
            this.winnerLabel.TabIndex = 4;
            this.winnerLabel.Text = "<player> wins!";
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(12, 157);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(148, 23);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play Again";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(169, 157);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(148, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // player1Results
            // 
            this.player1Results.Location = new System.Drawing.Point(-2, 65);
            this.player1Results.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.player1Results.Name = "player1Results";
            this.player1Results.Size = new System.Drawing.Size(332, 17);
            this.player1Results.TabIndex = 7;
            // 
            // player2Results
            // 
            this.player2Results.Location = new System.Drawing.Point(-2, 88);
            this.player2Results.Name = "player2Results";
            this.player2Results.Size = new System.Drawing.Size(332, 17);
            this.player2Results.TabIndex = 8;
            // 
            // player3Results
            // 
            this.player3Results.Location = new System.Drawing.Point(-2, 111);
            this.player3Results.Name = "player3Results";
            this.player3Results.Size = new System.Drawing.Size(332, 17);
            this.player3Results.TabIndex = 9;
            // 
            // player4Results
            // 
            this.player4Results.Location = new System.Drawing.Point(-2, 134);
            this.player4Results.Name = "player4Results";
            this.player4Results.Size = new System.Drawing.Size(332, 17);
            this.player4Results.TabIndex = 10;
            // 
            // ResultForm
            // 
            this.AcceptButton = this.playButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 192);
            this.Controls.Add(this.player4Results);
            this.Controls.Add(this.player3Results);
            this.Controls.Add(this.player2Results);
            this.Controls.Add(this.player1Results);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.winnerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Results";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button cancelButton;
        private PlayerResultsControl player1Results;
        private PlayerResultsControl player2Results;
        private PlayerResultsControl player3Results;
        private PlayerResultsControl player4Results;
    }
}