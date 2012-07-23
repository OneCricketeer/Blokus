using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace ConsoleApplications.Blokus
{
    partial class BlokusGame
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
            this.player1Name = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.player3Name = new System.Windows.Forms.Label();
            this.player4Name = new System.Windows.Forms.Label();
            this.piecesPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.rotateButton = new System.Windows.Forms.Button();
            this.flipButton = new System.Windows.Forms.Button();
            this.selectedPiecePanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.optionText = new System.Windows.Forms.Label();
            this.player2PiecesLabel = new System.Windows.Forms.Label();
            this.player4PiecesLabel = new System.Windows.Forms.Label();
            this.player3PiecesLabel = new System.Windows.Forms.Label();
            this.player1PiecesLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.board = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.gridLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.player4Num = new System.Windows.Forms.Label();
            this.player2Num = new System.Windows.Forms.Label();
            this.player1Num = new System.Windows.Forms.Label();
            this.player3Num = new System.Windows.Forms.Label();
            this.piecesPanel.SuspendLayout();
            this.selectedPiecePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(26, 500);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(72, 24);
            this.player1Name.TabIndex = 0;
            this.player1Name.Text = "Player1";
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.player2Name.Location = new System.Drawing.Point(637, 216);
            this.player2Name.Name = "player2Name";
            this.player2Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.player2Name.Size = new System.Drawing.Size(72, 24);
            this.player2Name.TabIndex = 1;
            this.player2Name.Text = "Player2";
            // 
            // player3Name
            // 
            this.player3Name.AutoSize = true;
            this.player3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Name.Location = new System.Drawing.Point(43, 213);
            this.player3Name.Name = "player3Name";
            this.player3Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.player3Name.Size = new System.Drawing.Size(72, 24);
            this.player3Name.TabIndex = 2;
            this.player3Name.Text = "Player3";
            // 
            // player4Name
            // 
            this.player4Name.AutoSize = true;
            this.player4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4Name.Location = new System.Drawing.Point(237, 9);
            this.player4Name.Name = "player4Name";
            this.player4Name.Size = new System.Drawing.Size(72, 24);
            this.player4Name.TabIndex = 3;
            this.player4Name.Text = "Player4";
            // 
            // piecesPanel
            // 
            this.piecesPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.piecesPanel.Controls.Add(this.label8);
            this.piecesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piecesPanel.Location = new System.Drawing.Point(360, 461);
            this.piecesPanel.Name = "piecesPanel";
            this.piecesPanel.Size = new System.Drawing.Size(400, 230);
            this.piecesPanel.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(130, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pieces to select from";
            // 
            // rotateButton
            // 
            this.rotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rotateButton.Location = new System.Drawing.Point(159, 668);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(91, 23);
            this.rotateButton.TabIndex = 5;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // flipButton
            // 
            this.flipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flipButton.Location = new System.Drawing.Point(263, 668);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(91, 23);
            this.flipButton.TabIndex = 6;
            this.flipButton.Text = "Flip";
            this.flipButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // selectedPiecePanel
            // 
            this.selectedPiecePanel.Controls.Add(this.label11);
            this.selectedPiecePanel.Controls.Add(this.optionText);
            this.selectedPiecePanel.Location = new System.Drawing.Point(160, 461);
            this.selectedPiecePanel.Name = "selectedPiecePanel";
            this.selectedPiecePanel.Size = new System.Drawing.Size(200, 200);
            this.selectedPiecePanel.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "Selected Piece";
            // 
            // optionText
            // 
            this.optionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.optionText.AutoSize = true;
            this.optionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionText.Location = new System.Drawing.Point(43, 178);
            this.optionText.Name = "optionText";
            this.optionText.Size = new System.Drawing.Size(118, 22);
            this.optionText.TabIndex = 3;
            this.optionText.Text = "Piece options";
            this.optionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2PiecesLabel
            // 
            this.player2PiecesLabel.AutoSize = true;
            this.player2PiecesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2PiecesLabel.Location = new System.Drawing.Point(595, 249);
            this.player2PiecesLabel.Name = "player2PiecesLabel";
            this.player2PiecesLabel.Size = new System.Drawing.Size(86, 17);
            this.player2PiecesLabel.TabIndex = 8;
            this.player2PiecesLabel.Text = "Pieces Left: ";
            // 
            // player4PiecesLabel
            // 
            this.player4PiecesLabel.AutoSize = true;
            this.player4PiecesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4PiecesLabel.Location = new System.Drawing.Point(382, 15);
            this.player4PiecesLabel.Name = "player4PiecesLabel";
            this.player4PiecesLabel.Size = new System.Drawing.Size(86, 17);
            this.player4PiecesLabel.TabIndex = 9;
            this.player4PiecesLabel.Text = "Pieces Left: ";
            // 
            // player3PiecesLabel
            // 
            this.player3PiecesLabel.AutoSize = true;
            this.player3PiecesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3PiecesLabel.Location = new System.Drawing.Point(12, 249);
            this.player3PiecesLabel.Name = "player3PiecesLabel";
            this.player3PiecesLabel.Size = new System.Drawing.Size(86, 17);
            this.player3PiecesLabel.TabIndex = 10;
            this.player3PiecesLabel.Text = "Pieces Left: ";
            // 
            // player1PiecesLabel
            // 
            this.player1PiecesLabel.AutoSize = true;
            this.player1PiecesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1PiecesLabel.Location = new System.Drawing.Point(12, 539);
            this.player1PiecesLabel.Name = "player1PiecesLabel";
            this.player1PiecesLabel.Size = new System.Drawing.Size(86, 17);
            this.player1PiecesLabel.TabIndex = 11;
            this.player1PiecesLabel.Text = "Pieces Left: ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.board,
            this.gridLine});
            this.shapeContainer1.Size = new System.Drawing.Size(766, 700);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // board
            // 
            this.board.BorderWidth = 3;
            this.board.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board.Location = new System.Drawing.Point(159, 47);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(400, 400);
            this.board.Click += new System.EventHandler(this.placeTile);
            this.board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.board_MouseMove);
            // 
            // gridLine
            // 
            this.gridLine.Name = "gridLine";
            this.gridLine.X1 = 0;
            this.gridLine.X2 = 0;
            this.gridLine.Y1 = 0;
            this.gridLine.Y2 = 0;
            // 
            // player4Num
            // 
            this.player4Num.AutoSize = true;
            this.player4Num.Location = new System.Drawing.Point(474, 17);
            this.player4Num.Name = "player4Num";
            this.player4Num.Size = new System.Drawing.Size(33, 13);
            this.player4Num.TabIndex = 13;
            this.player4Num.Text = "num4";
            // 
            // player2Num
            // 
            this.player2Num.AutoSize = true;
            this.player2Num.Location = new System.Drawing.Point(687, 251);
            this.player2Num.Name = "player2Num";
            this.player2Num.Size = new System.Drawing.Size(33, 13);
            this.player2Num.TabIndex = 14;
            this.player2Num.Text = "num2";
            // 
            // player1Num
            // 
            this.player1Num.AutoSize = true;
            this.player1Num.Location = new System.Drawing.Point(104, 541);
            this.player1Num.Name = "player1Num";
            this.player1Num.Size = new System.Drawing.Size(33, 13);
            this.player1Num.TabIndex = 15;
            this.player1Num.Text = "num1";
            // 
            // player3Num
            // 
            this.player3Num.AutoSize = true;
            this.player3Num.Location = new System.Drawing.Point(104, 251);
            this.player3Num.Name = "player3Num";
            this.player3Num.Size = new System.Drawing.Size(33, 13);
            this.player3Num.TabIndex = 16;
            this.player3Num.Text = "num3";
            // 
            // BlokusGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 700);
            this.Controls.Add(this.player3Num);
            this.Controls.Add(this.player1Num);
            this.Controls.Add(this.player2Num);
            this.Controls.Add(this.player4Num);
            this.Controls.Add(this.player1PiecesLabel);
            this.Controls.Add(this.player3PiecesLabel);
            this.Controls.Add(this.player4PiecesLabel);
            this.Controls.Add(this.player2PiecesLabel);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.piecesPanel);
            this.Controls.Add(this.player4Name);
            this.Controls.Add(this.player3Name);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.selectedPiecePanel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "BlokusGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blokus";
            this.Load += new System.EventHandler(this.Blokus_Load);
            this.piecesPanel.ResumeLayout(false);
            this.piecesPanel.PerformLayout();
            this.selectedPiecePanel.ResumeLayout(false);
            this.selectedPiecePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Label player3Name;
        private System.Windows.Forms.Label player4Name;
        private System.Windows.Forms.Panel piecesPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Panel selectedPiecePanel;
        private System.Windows.Forms.Label player2PiecesLabel;
        private System.Windows.Forms.Label player4PiecesLabel;
        private System.Windows.Forms.Label player3PiecesLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label player1PiecesLabel;
        private System.Windows.Forms.Label optionText;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape gridLine;
        private RectangleShape board;
        private Label player4Num;
        private Label player2Num;
        private Label player1Num;
        private Label player3Num;
    }
}