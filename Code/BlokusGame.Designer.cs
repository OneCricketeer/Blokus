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
            this.rotateCWButton = new System.Windows.Forms.Button();
            this.rotateCCWbutton = new System.Windows.Forms.Button();
            this.flipVbutton = new System.Windows.Forms.Button();
            this.flipHbutton = new System.Windows.Forms.Button();
            this.placeTileButton = new System.Windows.Forms.Button();
            this.matrx = new ConsoleApplications.Blokus.BoardControl();
            this.currentPlayerControl = new ConsoleApplications.Blokus.PlayerControl();
            this.player2Control = new ConsoleApplications.Blokus.PlayerControl();
            this.player3Control = new ConsoleApplications.Blokus.PlayerControl();
            this.player4Control = new ConsoleApplications.Blokus.PlayerControl();
            this.pieceControl = new ConsoleApplications.Blokus.SelectedPieceControl();
            this.pieceSelectControl = new ConsoleApplications.Blokus.SelectionControl();
            this.SuspendLayout();
            // 
            // rotateCWButton
            // 
            this.rotateCWButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateCWButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rotateCWButton.Location = new System.Drawing.Point(12, 566);
            this.rotateCWButton.Name = "rotateCWButton";
            this.rotateCWButton.Size = new System.Drawing.Size(141, 23);
            this.rotateCWButton.TabIndex = 5;
            this.rotateCWButton.Text = "RotateCW";
            this.rotateCWButton.UseVisualStyleBackColor = true;
            this.rotateCWButton.Click += new System.EventHandler(this.rotateCWButton_Click);
            // 
            // rotateCCWbutton
            // 
            this.rotateCCWbutton.Location = new System.Drawing.Point(12, 595);
            this.rotateCCWbutton.Name = "rotateCCWbutton";
            this.rotateCCWbutton.Size = new System.Drawing.Size(141, 23);
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
            this.flipVbutton.Size = new System.Drawing.Size(141, 23);
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
            this.flipHbutton.Size = new System.Drawing.Size(141, 23);
            this.flipHbutton.TabIndex = 18;
            this.flipHbutton.Text = "Flip Horizontal";
            this.flipHbutton.UseVisualStyleBackColor = true;
            this.flipHbutton.Click += new System.EventHandler(this.flipHbutton_Click);
            // 
            // placeTileButton
            // 
            this.placeTileButton.Location = new System.Drawing.Point(210, 451);
            this.placeTileButton.Name = "placeTileButton";
            this.placeTileButton.Size = new System.Drawing.Size(99, 23);
            this.placeTileButton.TabIndex = 19;
            this.placeTileButton.Text = "Next Turn Test";
            this.placeTileButton.UseVisualStyleBackColor = true;
            this.placeTileButton.Click += new System.EventHandler(this.nextTurnButton_Click);
            // 
            // matrx
            // 
            this.matrx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrx.BackColor = System.Drawing.Color.LightGray;
            this.matrx.Location = new System.Drawing.Point(147, 45);
            this.matrx.Name = "matrx";
            this.matrx.Size = new System.Drawing.Size(400, 400);
            this.matrx.TabIndex = 26;
            // 
            // player4Control
            // 
            this.player4Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player4Control.Location = new System.Drawing.Point(12, 12);
            this.player4Control.Name = "player4Control";
            this.player4Control.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.player4Control.Size = new System.Drawing.Size(129, 94);
            this.player4Control.TabIndex = 25;
            // 
            // player3Control
            // 
            this.player3Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player3Control.Location = new System.Drawing.Point(553, 12);
            this.player3Control.Name = "player3Control";
            this.player3Control.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.player3Control.Size = new System.Drawing.Size(201, 94);
            this.player3Control.TabIndex = 24;
            // 
            // player2Control
            // 
            this.player2Control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Control.Location = new System.Drawing.Point(553, 351);
            this.player2Control.Name = "player2Control";
            this.player2Control.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.player2Control.Size = new System.Drawing.Size(201, 94);
            this.player2Control.TabIndex = 23;
            // 
            // pieceSelectControl
            // 
            this.pieceSelectControl.Location = new System.Drawing.Point(366, 451);
            this.pieceSelectControl.Name = "pieceSelectControl";
            this.pieceSelectControl.Size = new System.Drawing.Size(400, 248);
            this.pieceSelectControl.TabIndex = 21;
            // 
            // pieceControl
            // 
            this.pieceControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pieceControl.Location = new System.Drawing.Point(159, 476);
            this.pieceControl.Name = "pieceControl";
            this.pieceControl.Size = new System.Drawing.Size(201, 200);
            this.pieceControl.TabIndex = 20;
            // 
            // currentPlayerControl
            // 
            this.currentPlayerControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPlayerControl.Location = new System.Drawing.Point(12, 451);
            this.currentPlayerControl.Name = "currentPlayerControl";
            this.currentPlayerControl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.currentPlayerControl.Size = new System.Drawing.Size(141, 96);
            this.currentPlayerControl.TabIndex = 22;
            // 
            // BlokusGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 700);
            this.Controls.Add(this.matrx);
            this.Controls.AddRange(new PlayerControl[] { this.currentPlayerControl, this.player2Control, 
                this.player3Control, this.player4Control });
            this.Controls.Add(this.pieceControl);
            this.Controls.Add(this.pieceSelectControl);
            this.Controls.Add(this.placeTileButton);
            this.Controls.AddRange(new Button[] {this.rotateCWButton, this.rotateCCWbutton, 
                this.flipVbutton, this.flipHbutton });

            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BlokusGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blokus";
            this.Load += new System.EventHandler(this.Blokus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        //        private Microsoft.VisualBasic.PowerPacks.LineShape gridLine;
        private Player player1;
        private Player player2;
        private Player player3;
        private Player player4;
        private PlayerControl currentPlayerControl;
        private PlayerControl player2Control;
        private PlayerControl player3Control;
        private PlayerControl player4Control;
        private Button rotateCWButton;
        private Button rotateCCWbutton;
        private Button flipVbutton;
        private Button flipHbutton;
        private Button placeTileButton;
        public SelectedPieceControl pieceControl;
        private SelectionControl pieceSelectControl;
        private BoardControl matrx;

    }
}