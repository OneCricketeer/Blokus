using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using System.Drawing;

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
            this.player1PiecesLabel = new System.Windows.Forms.Label();
            this.player2PiecesLabel = new System.Windows.Forms.Label();
            this.player3PiecesLabel = new System.Windows.Forms.Label();
            this.player4PiecesLabel = new System.Windows.Forms.Label();
            this.player1Num = new System.Windows.Forms.Label();
            this.player2Num = new System.Windows.Forms.Label();
            this.player3Num = new System.Windows.Forms.Label();
            this.player4Num = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.board = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rotateCWButton = new System.Windows.Forms.Button();
            this.rotateCCWbutton = new System.Windows.Forms.Button();
            this.flipVbutton = new System.Windows.Forms.Button();
            this.flipHbutton = new System.Windows.Forms.Button();
            this.placeTileButton = new System.Windows.Forms.Button();
            this.pieceSelectControl = new ConsoleApplications.Blokus.PieceSelectControl();
            this.pieceControl = new ConsoleApplications.Blokus.SelectedPieceControl();
            this.playerControl1 = new ConsoleApplications.Blokus.PlayerControl();
            this.playerControl2 = new ConsoleApplications.Blokus.PlayerControl();
            this.playerControl3 = new ConsoleApplications.Blokus.PlayerControl();
            this.playerControl4 = new ConsoleApplications.Blokus.PlayerControl();
            this.SuspendLayout();
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(43, 500);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(72, 24);
            this.player1Name.TabIndex = 0;
            this.player1Name.Text = "Player1";
            this.player1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.player2Name.Location = new System.Drawing.Point(594, 389);
            this.player2Name.Name = "player2Name";
            this.player2Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.player2Name.Size = new System.Drawing.Size(72, 24);
            this.player2Name.TabIndex = 1;
            this.player2Name.Text = "Player2";
            this.player2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player3Name
            // 
            this.player3Name.AutoSize = true;
            this.player3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Name.Location = new System.Drawing.Point(606, 15);
            this.player3Name.Name = "player3Name";
            this.player3Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.player3Name.Size = new System.Drawing.Size(72, 24);
            this.player3Name.TabIndex = 2;
            this.player3Name.Text = "Player3";
            this.player3Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player4Name
            // 
            this.player4Name.AutoSize = true;
            this.player4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4Name.Location = new System.Drawing.Point(43, 15);
            this.player4Name.Name = "player4Name";
            this.player4Name.Size = new System.Drawing.Size(72, 24);
            this.player4Name.TabIndex = 3;
            this.player4Name.Text = "Player4";
            this.player4Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // player2PiecesLabel
            // 
            this.player2PiecesLabel.AutoSize = true;
            this.player2PiecesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2PiecesLabel.Location = new System.Drawing.Point(574, 431);
            this.player2PiecesLabel.Name = "player2PiecesLabel";
            this.player2PiecesLabel.Size = new System.Drawing.Size(86, 17);
            this.player2PiecesLabel.TabIndex = 8;
            this.player2PiecesLabel.Text = "Pieces Left: ";
            // 
            // player3PiecesLabel
            // 
            this.player3PiecesLabel.AutoSize = true;
            this.player3PiecesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3PiecesLabel.Location = new System.Drawing.Point(575, 53);
            this.player3PiecesLabel.Name = "player3PiecesLabel";
            this.player3PiecesLabel.Size = new System.Drawing.Size(86, 17);
            this.player3PiecesLabel.TabIndex = 10;
            this.player3PiecesLabel.Text = "Pieces Left: ";
            // 
            // player4PiecesLabel
            // 
            this.player4PiecesLabel.AutoSize = true;
            this.player4PiecesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4PiecesLabel.Location = new System.Drawing.Point(12, 45);
            this.player4PiecesLabel.Name = "player4PiecesLabel";
            this.player4PiecesLabel.Size = new System.Drawing.Size(86, 17);
            this.player4PiecesLabel.TabIndex = 9;
            this.player4PiecesLabel.Text = "Pieces Left: ";
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
            // player2Num
            // 
            this.player2Num.AutoSize = true;
            this.player2Num.Location = new System.Drawing.Point(666, 433);
            this.player2Num.Name = "player2Num";
            this.player2Num.Size = new System.Drawing.Size(33, 13);
            this.player2Num.TabIndex = 14;
            this.player2Num.Text = "num2";
            // 
            // player3Num
            // 
            this.player3Num.AutoSize = true;
            this.player3Num.Location = new System.Drawing.Point(666, 55);
            this.player3Num.Name = "player3Num";
            this.player3Num.Size = new System.Drawing.Size(33, 13);
            this.player3Num.TabIndex = 16;
            this.player3Num.Text = "num3";
            // 
            // player4Num
            // 
            this.player4Num.AutoSize = true;
            this.player4Num.Location = new System.Drawing.Point(104, 47);
            this.player4Num.Name = "player4Num";
            this.player4Num.Size = new System.Drawing.Size(33, 13);
            this.player4Num.TabIndex = 13;
            this.player4Num.Text = "num4";
            // 
            // frame
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.board});
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
            this.board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.board_MouseMove);
            // 
            // rotateCWButton
            // 
            this.rotateCWButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateCWButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rotateCWButton.Location = new System.Drawing.Point(12, 566);
            this.rotateCWButton.Name = "rotateCWButton";
            this.rotateCWButton.Size = new System.Drawing.Size(142, 23);
            this.rotateCWButton.TabIndex = 5;
            this.rotateCWButton.Text = "RotateCW";
            this.rotateCWButton.UseVisualStyleBackColor = true;
            this.rotateCWButton.Click += new System.EventHandler(this.rotateCWButton_Click);
            // 
            // rotateCCWbutton
            // 
            this.rotateCCWbutton.Location = new System.Drawing.Point(12, 595);
            this.rotateCCWbutton.Name = "rotateCCWbutton";
            this.rotateCCWbutton.Size = new System.Drawing.Size(142, 23);
            this.rotateCCWbutton.TabIndex = 17;
            this.rotateCCWbutton.Text = "RotateCCW";
            this.rotateCCWbutton.UseVisualStyleBackColor = true;
            this.rotateCCWbutton.Click += new System.EventHandler(this.rotateCCWbutton_Click);
            // 
            // flipVbutton
            // 
            this.flipVbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flipVbutton.Location = new System.Drawing.Point(12, 624);
            this.flipVbutton.Name = "flipVbutton";
            this.flipVbutton.Size = new System.Drawing.Size(142, 23);
            this.flipVbutton.TabIndex = 6;
            this.flipVbutton.Text = "Flip Vertical";
            this.flipVbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.flipVbutton.UseVisualStyleBackColor = true;
            this.flipVbutton.Click += new System.EventHandler(this.flipVButton_Click);
            // 
            // flipHbutton
            // 
            this.flipHbutton.Location = new System.Drawing.Point(12, 653);
            this.flipHbutton.Name = "flipHbutton";
            this.flipHbutton.Size = new System.Drawing.Size(142, 23);
            this.flipHbutton.TabIndex = 18;
            this.flipHbutton.Text = "Flip Horizontal";
            this.flipHbutton.UseVisualStyleBackColor = true;
            this.flipHbutton.Click += new System.EventHandler(this.flipHbutton_Click);
            // 
            // placeTileButton
            // 
            this.placeTileButton.Location = new System.Drawing.Point(211, 450);
            this.placeTileButton.Name = "placeTileButton";
            this.placeTileButton.Size = new System.Drawing.Size(99, 23);
            this.placeTileButton.TabIndex = 19;
            this.placeTileButton.Text = "Next Turn Test";
            this.placeTileButton.UseVisualStyleBackColor = true;
            this.placeTileButton.Click += new System.EventHandler(this.placeTileButton_Click);
            // 
            // pieceSelectControl
            // 
            this.pieceSelectControl.Location = new System.Drawing.Point(366, 451);
            this.pieceSelectControl.Name = "pieceSelectControl";
            this.pieceSelectControl.Size = new System.Drawing.Size(400, 250);
            this.pieceSelectControl.TabIndex = 21;
            // 
            // pieceControl
            // 
            this.pieceControl.Location = new System.Drawing.Point(160, 479);
            this.pieceControl.Name = "pieceControl";
            this.pieceControl.Size = new System.Drawing.Size(200, 200);
            this.pieceControl.TabIndex = 20;
            // 
            // playerControl1
            // 
            this.playerControl1.Location = new System.Drawing.Point(12, 412);
            this.playerControl1.Name = "playerControl1";
            this.playerControl1.Size = new System.Drawing.Size(125, 72);
            this.playerControl1.TabIndex = 24;
            // 
            // playerControl2
            // 
            this.playerControl2.Location = new System.Drawing.Point(574, 314);
            this.playerControl2.Name = "playerControl2";
            this.playerControl2.Size = new System.Drawing.Size(125, 72);
            this.playerControl2.TabIndex = 22;
            // 
            // playerControl3
            // 
            this.playerControl3.Location = new System.Drawing.Point(12, 79);
            this.playerControl3.Name = "playerControl3";
            this.playerControl3.Size = new System.Drawing.Size(125, 72);
            this.playerControl3.TabIndex = 23;
            // 
            // playerControl4
            // 
            this.playerControl4.Location = new System.Drawing.Point(574, 88);
            this.playerControl4.Name = "playerControl4";
            this.playerControl4.Size = new System.Drawing.Size(125, 72);
            this.playerControl4.TabIndex = 21;
            // 
            // BlokusGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 700);
            this.Controls.Add(this.pieceSelectControl);
            this.Controls.Add(this.pieceControl);
            this.Controls.Add(this.placeTileButton);
            this.Controls.Add(this.flipVbutton);
            this.Controls.Add(this.flipHbutton);
            this.Controls.Add(this.rotateCCWbutton);
            this.Controls.Add(this.player3Num);
            this.Controls.Add(this.player1Num);
            this.Controls.Add(this.player2Num);
            this.Controls.Add(this.player4Num);
            this.Controls.Add(this.player1PiecesLabel);
            this.Controls.Add(this.player3PiecesLabel);
            this.Controls.Add(this.player4PiecesLabel);
            this.Controls.Add(this.player2PiecesLabel);
            this.Controls.Add(this.rotateCWButton);
            this.Controls.Add(this.player4Name);
            this.Controls.Add(this.player3Name);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BlokusGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blokus";
            this.Load += new System.EventHandler(this.Blokus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Label player3Name;
        private System.Windows.Forms.Label player4Name;
        private System.Windows.Forms.Button rotateCWButton;
        private System.Windows.Forms.Button flipVbutton;
        private System.Windows.Forms.Label player2PiecesLabel;
        private System.Windows.Forms.Label player4PiecesLabel;
        private System.Windows.Forms.Label player3PiecesLabel;
        private System.Windows.Forms.Label player1PiecesLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
//        private Microsoft.VisualBasic.PowerPacks.LineShape gridLine;
        private RectangleShape board;
        private Player player1;
        private Player player2;
        private Player player3;
        private Player player4;
        private Label player1Num;
        private Label player2Num;
        private Label player3Num;
        private Label player4Num;
        private Button rotateCCWbutton;
        private Button flipHbutton;
        private Button placeTileButton;
        private PlayerControl playerControl4;
        private PlayerControl playerControl2;
        private PlayerControl playerControl3;
        private PlayerControl playerControl1;
        private SelectedPieceControl pieceControl;
        private PieceSelectControl pieceSelectControl;
    }
}